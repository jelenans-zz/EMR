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

    public partial class Recept : Form
    {
       

        string idlek = "";
        string jmbglek = "";
        string jmbgpac = "";

        string idRecepta="";

        public Recept(string id_lekara, string jmbg_lekara, string id_pacijenta)
        {
            InitializeComponent();
            idlek = id_lekara;
            jmbglek = jmbg_lekara;
            jmbgpac = id_pacijenta;
        }

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
        static public string GetConnectionString()
        {
            // To avoid storing the connection string in your code, 
            // you can retrieve it from a configuration file. 
            return "Data Source=(DESCRIPTION=" + "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" + "(CONNECT_DATA=(SERVICE_NAME=XE)));"
                    + "User Id=E13080;Password=ftn;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            using (OracleConnection connection = new OracleConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                string sql="";

                OracleCommand command = new OracleCommand(sql);
                command.Connection = connection;

                String sss = RandomString(12);
                Console.WriteLine(sss);

                idRecepta = RandomString(12);
                

                sql = "insert into RECEPT(SIFDIJ, DATIZD, IDREC, JMBGZR, ID_ZR, JMBGP, SIFL, PROP__KOLICINA_LEKA,IZNOS) VALUES ("
                  + "'" + tbSifDij.Text + "','" + mtbDatRec.Value.ToString("dd-MMM-yyyy") + "','" + idRecepta + "','" 
                  + jmbglek+"', '"+idlek+"','"+jmbgpac+ "','" +textBox4.Text + "','"
                  + cbPropKut.SelectedItem.ToString() +"','"+tbPropCena.Text+ "')";

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

               ReceptSnim rs = new ReceptSnim("Uspešno kreiran recept");
            //   rs.ShowDialog();
               this.Opacity = .70;
               DialogResult dr = rs.ShowDialog();
               if (dr == DialogResult.OK)
               {
                   PrintRecept stampa = new PrintRecept(idRecepta, tbNazDij.Text, textBox2.Text, jmbgpac);
                   stampa.ShowDialog();
                   //this.Opacity = 1;
                   //this.Close();
               }

               // label6.Text = sql;
                connection.Close();
                //this.DialogResult = DialogResult.OK;
            }
        }

        private void Recept_Load(object sender, EventArgs e)
        {
            //dateTimePicker1.Value = DateTime.Today;
            mtbDatRec.Text = DateTime.Today.ToString("dd-MMM-yyyy");
            cbPropKut.SelectedIndex = 0;

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   

        private void button3_Click(object sender, EventArgs e)
        {

        }

    

        private void button7_Click(object sender, EventArgs e)
        {
            SpisakAnamneza sp = new SpisakAnamneza(DBConnection.Spiskovi.Dijagnoze);
            DialogResult dr = sp.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string[] rez = sp.ucitanTekst.Split(',');
                tbSifDij.Text=rez[0];
                tbNazDij.Text = rez[1];
            }
        }

        private void tbNaziv_TextChanged(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            using (OracleConnection connection = new OracleConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                string sql = "SELECT SIFL FROM LEK WHERE NAZLEK='" + textBox2.Text + "'";

                OracleCommand command = new OracleCommand(sql);
                command.Connection = connection;
                OracleDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBox4.Text = Convert.ToString(reader[0]);
                }

                sql = "SELECT OR_KOLICINA_LEKA FROM LEK WHERE SIFL='" + textBox2.Text + "'";
                command = new OracleCommand(sql);
                command.Connection = connection;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    tbOrTab.Text = Convert.ToString(reader[0]);
                }

                sql = "SELECT CENA_LEKA FROM LEK WHERE SIFL='" + textBox2.Text + "'";
                command = new OracleCommand(sql);
                command.Connection = connection;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    tbOrCena.Text=Convert.ToString(reader[0]);
                    tbPropCena.Text = Convert.ToString(reader[0]);
                }

                connection.Close();
            }
        }

        private void tbSifra_TextChanged(object sender, EventArgs e)
        {
            string connectionString = GetConnectionString();
            using (OracleConnection connection = new OracleConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                string sql = "SELECT NAZLEK FROM LEK WHERE SIFL='" + textBox4.Text + "'";

                OracleCommand command = new OracleCommand(sql);
                command.Connection = connection;
                OracleDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBox2.Text = Convert.ToString(reader[0]);
                }

                sql = "SELECT OR_KOLICINA_LEKA FROM LEK WHERE SIFL='" + textBox4.Text + "'";
                command = new OracleCommand(sql);
                command.Connection = connection;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    tbOrTab.Text = Convert.ToString(reader[0]);
                }

                sql = "SELECT CENA_LEKA FROM LEK WHERE SIFL='" + textBox4.Text + "'";
                command = new OracleCommand(sql);
                command.Connection = connection;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    tbOrCena.Text=  Convert.ToString(reader[0]);
                    tbPropCena.Text=Convert.ToString(reader[0]);
                }
                connection.Close();
                //this.DialogResult = DialogResult.OK;
            }
        }

        private void tbPropKut_TextChanged(object sender, EventArgs e)
        {

        }


        private void cbPropKut_TextChanged(object sender, EventArgs e)
        {
            int kol = Int32.Parse(cbPropKut.SelectedItem.ToString());
            double orCena = Int32.Parse(tbOrCena.Text);
            tbPropCena.Text = (orCena*kol).ToString();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            SpisakAnamneza sp = new SpisakAnamneza(DBConnection.Spiskovi.Lekovi);
            DialogResult dr = sp.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string[] rez = sp.ucitanTekst.Split(',');
                textBox2.Text = rez[0];
                tbOrTab.Text = rez[1];
                textBox4.Text = rez[2];
                tbOrCena.Text = rez[3];
                tbPropCena.Text = rez[3];
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            Sugestije sug = new Sugestije(textBox4.Text);
            sug.ShowDialog();
        }

  
    }
}
