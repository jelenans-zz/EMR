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
    public partial class Bolovanje : Form
    {
        string id_pacijenta = "";

        public Bolovanje(string id_pacijenta)
        {
            InitializeComponent();
            this.id_pacijenta = id_pacijenta;
        }

        private string ids_vrsta_bol;
        private string ids_statusa_bol;

  
        static private string GetConnectionString()
        {
            // To avoid storing the connection string in your code, 
            // you can retrieve it from a configuration file. 
            return "Data Source=(DESCRIPTION=" + "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" + "(CONNECT_DATA=(SERVICE_NAME=XE)));"
                    + "User Id=E13080;Password=ftn;";
        }

        private void Bolovanje_Load(object sender, EventArgs e)
        {
            //cbStatBol.Items.Clear();
            //cbVrstaBol.Items.Clear();

            mtbDatIzd.Text = DateTime.Today.ToString("dd-MMM-yyyy");
            string connectionString = GetConnectionString();
            using (OracleConnection connection = new OracleConnection())
            {
                try
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    OracleCommand command;
                    OracleDataReader reader;

                    string sqlr = "SELECT NAZIV_VRSTE_BOL FROM VRSTA_BOLOVANJA";

                    command = new OracleCommand(sqlr);
                    command.Connection = connection;
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cbVrstaBol.Items.Add(reader[0]);
                        cbVrstaBol.SelectedIndex = 0;
                    }

                    sqlr = "SELECT NAZIV_STATUSA FROM STATUS_BOLOVANJA";

                    command = new OracleCommand(sqlr);
                    command.Connection = connection;
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cbStatBol.Items.Add(reader[0]);
                        cbStatBol.SelectedIndex = 0;
                    }
                    connection.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }

            
            string sql = "";
            connectionString = DBConnection.GetConnectionString();
            using (OracleConnection connection = new OracleConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                OracleCommand command;
                OracleDataReader reader;

                try
                {

                    sql = "SELECT * FROM PACIJENT WHERE PACIJENT.JMBGP='" + id_pacijenta + "'";

                    command = new OracleCommand(sql);
                    command.Connection = connection;
                    reader = command.ExecuteReader();
                }
                catch (Exception)
                {

                    throw;
                }

                try
                {
                    if (reader.Read())
                    {
                        tbPac.Text = reader["IMEP"].ToString() + " " + reader["PRZP"].ToString();
                        mtbDatRodj.Text = reader["DATRP"].ToString();
                    }

                }
                catch (Exception)
                {

                    throw;
                }

               

                connection.Close();
            }
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString =  DBConnection.GetConnectionString();
            using (OracleConnection connection = new OracleConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                string sql = "";

                sql = "SELECT ID_VRSTE_BOL FROM VRSTA_BOLOVANJA WHERE NAZIV_VRSTE_BOL='" + cbVrstaBol.SelectedItem.ToString() + "'";
                OracleCommand command = new OracleCommand(sql);
                command.Connection = connection;
                OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ids_vrsta_bol = (String)reader[0];
                    //Console.WriteLine(ids_vrsta_uputa);
                }

                sql = "SELECT ID_STATUSA_BOL FROM STATUS_BOLOVANJA WHERE NAZIV_STATUSA='" + cbStatBol.SelectedItem.ToString() + "'";
                command = new OracleCommand(sql);
                command.Connection = connection;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ids_statusa_bol = (String)reader[0];
                    //Console.WriteLine(ids_vrsta_uputa);

                }

                int recidiv;
                if (chbRecidiv.Checked)
                    recidiv = 1;
                else
                    recidiv = 0;

                int trecel;
                if (chbTreceLice.Checked)
                    trecel = 1;
                else
                    trecel = 0;

                /*insert into BOLOVANJE (JMBGZR, ID_ZR, JMBGP, ID_OBRASCA, ID_STATUSA_BOL, ID_VRSTE_BOL, POC_DATUM_BOL, KRAJ_DATUM_BOL, SPOLJ_UZROK, DIJAGNOZA, NALAZ, RECIDIV, TRECE_LICE, DAT_IZD_BOL)*/
               
                sql = "insert into BOLOVANJE(JMBGZR, ID_ZR, JMBGP, ID_OBRASCA, ID_STATUSA_BOL, ID_VRSTE_BOL, POC_DATUM_BOL, KRAJ_DATUM_BOL, SPOLJ_UZROK, DIJAGNOZA, NALAZ, RECIDIV, TRECE_LICE, DAT_IZD_BOL) VALUES ("
                 + "'" + "0307956152401', 'DFHKLPR9','1107954152487'" + ",'" + DBConnection.RandomString(6) + "','" + ids_statusa_bol + "','" + ids_vrsta_bol + "','" + mtbPocDat.Value.ToString("dd-MMM-yyyy") + "','" + mtbKrajDat.Value.ToString("dd-MMM-yyyy") + "','"
                 + tbSpoljUzrok.Text + "','" + tbDijag.Text + "','" + rtNalaz.Text + "','" + recidiv + "','" + trecel + "','" + mtbDatIzd.Value.ToString("dd-MMM-yyyy") + "')";

               //('0307956152401', 'DFHKLPR9','1107954152487','623327','1','00','02-jun-2012','21-jun-2012','d','dd','ddd','0','1','01-jun-2012')";
            
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



                ReceptSnim rs = new ReceptSnim("Uspešno kreirano bolovanje");
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

   
    }
}
