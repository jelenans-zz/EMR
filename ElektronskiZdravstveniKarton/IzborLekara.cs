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
    public partial class IzborLekara : Form
    {
        string jmbg_pacijenta="";
        bool sa_forme_evidencija = false;
        public IzborLekara()
        {
            InitializeComponent();
        }
        public IzborLekara(string jmbgpac,bool sa_evid)
        {
            InitializeComponent();
            jmbg_pacijenta = jmbgpac;
            sa_forme_evidencija = sa_evid;
        }

        private void IzborLekara_Load(object sender, EventArgs e)
        {
            button2.Text = "...";
            button3.Text = "...";
            mtbDatIzbora.Text = DateTime.Today.ToString("dd-MMM-yyyy");
            string connectionString = DBConnection.GetConnectionString();
            using (OracleConnection connection = new OracleConnection())
            {
                try
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    OracleCommand command;
                    OracleDataReader reader;

                    string sqlr = "SELECT * FROM PACIJENT";

                    command = new OracleCommand(sqlr);
                    command.Connection = connection;
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cbPacijent.Items.Add(reader["IMEP"] + " " + reader["PRZP"]+" "+reader["JMBGP"]);
                        cbPacijent.SelectedIndex = 0;
                    }

                    if (sa_forme_evidencija)
                    {
                        string sql = "SELECT * FROM PACIJENT WHERE JMBGP='"+jmbg_pacijenta+"'";

                        command = new OracleCommand(sql);
                        command.Connection = connection;
                        reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                          //  cbPacijent.Items.Add(reader["IMEP"] + " " + reader["PRZP"] + " " + reader["JMBGP"]);
                            cbPacijent.SelectedItem = reader["IMEP"] + " " + reader["PRZP"] + " " + reader["JMBGP"];
                        }
                    }



                    sqlr = "SELECT * FROM LEKAR_OPSTE_MEDICINE";
                    
                    command = new OracleCommand(sqlr);
                    command.Connection = connection;
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cbLekar.Items.Add(reader["IME"] + " " + reader["PRZ"] + " " + reader["ID_ZR"]);
                        cbLekar.SelectedIndex = 0;
                    }

                    sqlr = "SELECT NAZRAZL FROM RAZLOG_IZBORA";

                    command = new OracleCommand(sqlr);
                    command.Connection = connection;
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cbRazlog.Items.Add(reader[0]);
                        cbRazlog.SelectedIndex = 0;
                    }

                    connection.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void btnSac_Click(object sender, EventArgs e)
        {
            OracleCommand command;
            OracleDataReader reader;
            string connectionString = DBConnection.GetConnectionString();
            using (OracleConnection connection = new OracleConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                string sql = "";

                string jmbgpac = "";
                string idlek = "";
                string jmbglek = "";
                string idrazl = "";

                idlek = cbLekar.SelectedItem.ToString().Split(' ').Last();
               // Console.WriteLine("IDLEK "+idlek);

                jmbgpac = cbPacijent.SelectedItem.ToString().Split(' ').Last();
               // Console.WriteLine("JMBGP " + jmbgpac);

                sql = "SELECT JMBGZR FROM LEKAR_OPSTE_MEDICINE WHERE ID_ZR='" + idlek + "'";
                command = new OracleCommand(sql);
                command.Connection = connection;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    jmbglek = (String)reader[0];
                }


                sql = "SELECT IDRAZL FROM RAZLOG_IZBORA WHERE NAZRAZL='" + cbRazlog.SelectedItem.ToString() + "'";
                command = new OracleCommand(sql);
                command.Connection = connection;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    idrazl = (String)reader[0];

                }
             

                sql = "INSERT INTO IZBOR_LEKARA (JMBGZR, ID_ZR, JMBGP, IDRAZL, DATUM_IZBORA) values('"
                                                + jmbglek + "','" + idlek + "','" + jmbgpac+"','" + idrazl + "','"
                                                + mtbDatIzbora.Value.ToString("dd-MMM-yyyy") + "')";
            
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



                ReceptSnim rs = new ReceptSnim("Uspešno snimljeni podaci o pacijentu");
                //   rs.ShowDialog();
                this.Opacity = .70;
                DialogResult dr = rs.ShowDialog();
                if (dr == DialogResult.Cancel)
                {
                    //this.Opacity = 1;
                    this.Close();
                }

                // label6.Text = sql;
                connection.Close();
                //this.DialogResult = DialogResult.OK;
            }
        }

        private void btnPon_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SpisakAnamneza sp = new SpisakAnamneza(DBConnection.Spiskovi.Pacijenti);
            DialogResult dr = sp.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string[] rez = sp.ucitanTekst.Split(',');
                cbPacijent.Text = rez[0]+" "+rez[1]+" "+rez[2];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SpisakAnamneza sp = new SpisakAnamneza(DBConnection.Spiskovi.Lekari);
            DialogResult dr = sp.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string[] rez = sp.ucitanTekst.Split(',');
                cbLekar.Text = rez[0]+" "+rez[1]+" "+rez[2];
            }
        }

        private void btnBrowseDijag_Click(object sender, EventArgs e)
        {
           
        }
    }
}
