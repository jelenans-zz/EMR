using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client; // ODP.NET Oracle managed provider
using Oracle.DataAccess.Types;

namespace ElektronskiZdravstveniKarton
{
    public partial class Uput : Form
    {
        string idlek = "";
        string jmbglek = "";
        string jmbgpac = "";

        public Uput(string id_lekara, string jmbg_lekara, string id_pacijenta)
        {
            InitializeComponent();
            idlek = id_lekara;
            jmbglek = jmbg_lekara;
            jmbgpac = id_pacijenta;
        }

        private String ids_vrsta_uputa = "";
        private String ids_vrsta_spec_an = "";
        private String ids_vrsta_spec_an1 = "";
        bool spec_an = false;

        private static Random random = new Random((int)DateTime.Now.Ticks);
        private string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }

        static private string GetConnectionString()
        {
            // To avoid storing the connection string in your code, 
            // you can retrieve it from a configuration file. 
            return "Data Source=(DESCRIPTION=" + "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" + "(CONNECT_DATA=(SERVICE_NAME=XE)));"
                    + "User Id=E13080;Password=ftn;";
        }

        private void Uput_Load(object sender, EventArgs e)
        {
            lbSpecAn.Text = "";
            cbSpecAn.Items.Clear();
            cbSpecAn.Visible = false;
            mtbDat.Text = DateTime.Today.ToString("dd-MMM-yyyy");
            string connectionString = GetConnectionString();
            // label1.Text = connectionString;
            using (OracleConnection connection = new OracleConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                string sql = "SELECT NAZIV_VRSTE_UPUTA FROM VRSTA_UPUTA";

                OracleCommand command = new OracleCommand(sql);
                command.Connection = connection;
                OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cbVrstaUputa.Items.Add(reader[0]);
                    cbVrstaUputa.SelectedIndex = 0;
                }


                sql = "SELECT * FROM USTANOVE";

                command = new OracleCommand(sql);
                command.Connection = connection;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    tbNazInstit.Items.Add(reader[0]);
                    tbNazInstit.SelectedIndex = 0;
                }

                connection.Close();
            }

          
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            using (OracleConnection connection = new OracleConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                string sql = "";//= "SELECT IME FROM SOBNI_LEKAR WHERE ID_ZR='" + textBox4.Text + "'";




                sql = "SELECT ID_VRSTE_UPUTA FROM VRSTA_UPUTA WHERE NAZIV_VRSTE_UPUTA='" + cbVrstaUputa.Text + "'";
                OracleCommand command = new OracleCommand(sql);
                command.Connection = connection;
                OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ids_vrsta_uputa = (String)reader[0];
                    Console.WriteLine(ids_vrsta_uputa);
                }

                if (spec_an)
                {
                    if (cbVrstaUputa.SelectedItem.ToString().Equals("Uput lekaru specijalisti"))
                    {
                        sql = "SELECT IDSPEC FROM SPECIJALNOST WHERE NAZSPEC='" + cbSpecAn.Text + "'";
                    }
                    else if (cbVrstaUputa.SelectedItem.ToString().Equals("Uput za laboratoriju"))
                    {
                        sql = "SELECT ID_VRSTE_ANALIZE FROM VRSTA_ANALIZE WHERE NAZIV_VRSTE_ANALIZE='" + cbSpecAn.Text + "'";

                    }

                    command = new OracleCommand(sql);
                    command.Connection = connection;
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        if (cbVrstaUputa.Text.Equals("Uput lekaru specijalisti"))
                        {
                            ids_vrsta_spec_an = "";
                            ids_vrsta_spec_an1 = (String)reader[0];
                        }
                        else if (cbVrstaUputa.Text.Equals("Uput za laboratoriju"))
                        {
                            ids_vrsta_spec_an = (String)reader[0];
                            ids_vrsta_spec_an1 = "";

                        }
                    }
                }

                sql = "insert into UPUT (ID_UPUTA, ID_VRSTE_ANALIZE, IDSPEC, id_vrste_uputa,JMBGZR, ID_ZR, JMBGP, DIJAGNOZA,RAZLOG_UPUT, DAT_IZD_UPUT,NAZIV_INSTITUCIJE) VALUES ("
                 + "'" + RandomString(6) + "','" + ids_vrsta_spec_an + "','" + ids_vrsta_spec_an1 + "','" + ids_vrsta_uputa + "','"
                 + jmbglek+"', '"+idlek+"','"+jmbgpac+"','" + tbSifDijag.Text + "','" + rtbRazlog.Text + "','" + mtbDat.Value.ToString("dd-MMM-yyyy") + "','" + tbNazInstit.Text + "')";

                try
                {
                    command = new OracleCommand(sql);
                    command.Connection = connection;
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    throw;
                }

                ReceptSnim rs = new ReceptSnim("Uspešno kreiran uput");
                //   rs.ShowDialog();
                this.Opacity = .70;
                DialogResult dr = rs.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    //this.Opacity = 1;
                    this.Close();
                }

                // label6.Text = sql;
                connection.Close();
                //this.DialogResult = DialogResult.OK;
            }
        }

        private void cbSpecAn_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbVrstaUputa_TextChanged(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            using (OracleConnection connection = new OracleConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                string sql = "";

                if (cbVrstaUputa.SelectedItem != null)
                    if (cbVrstaUputa.SelectedItem.ToString().Equals("Uput lekaru specijalisti"))
                    {
                        cbSpecAn.Visible = true;
                        lbSpecAn.Text = "Specijalnost: ";
                        sql = "SELECT NAZSPEC FROM SPECIJALNOST";
                        spec_an = true;
                        DBConnection.spec = true;
                    }
                    else if (cbVrstaUputa.SelectedItem.ToString().Equals("Uput za laboratoriju"))
                    {
                        cbSpecAn.Visible = true;
                        lbSpecAn.Text = "Vrsta analize: ";
                        sql = "SELECT NAZIV_VRSTE_ANALIZE FROM VRSTA_ANALIZE";
                        spec_an = true;
                        DBConnection.analiza = true;
                    }
                    else
                    {
                        lbSpecAn.Text = "";
                        cbSpecAn.Items.Clear();
                        cbSpecAn.Visible = false;
                        spec_an = false;
                    }

                if (spec_an)
                {

                    OracleCommand command = new OracleCommand(sql);
                    command.Connection = connection;
                    OracleDataReader reader = command.ExecuteReader();

                    cbSpecAn.Items.Clear();
                    while (reader.Read())
                    {
                        cbSpecAn.Items.Add(reader[0]);
                        cbSpecAn.SelectedIndex = 0;
                    }
                }
                connection.Close();
                //this.DialogResult = DialogResult.OK;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowseDijag_Click(object sender, EventArgs e)
        {
            SpisakAnamneza sp = new SpisakAnamneza(DBConnection.Spiskovi.Dijagnoze);
            DialogResult dr = sp.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string[] rez = sp.ucitanTekst.Split(',');
                tbSifDijag.Text = rez[0];
                tbDijag.Text = rez[1];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SpisakAnamneza sp = new SpisakAnamneza(DBConnection.Spiskovi.Ustanove);
            DialogResult dr = sp.ShowDialog();
            if (dr == DialogResult.OK)
            {
                tbNazInstit.Text = sp.ucitanTekst;
            }
        }

        private void tbSifDijag_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDijag_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
