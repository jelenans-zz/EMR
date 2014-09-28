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
    public partial class PregledZK : Form
    {
        public PregledZK()
        {
            InitializeComponent();
        }


        private void PregledZK_Load(object sender, EventArgs e)
        {
            spisakRecepata();
            dgwRecepti.ClearSelection();

            spisakUputa();
            dgwUputi.ClearSelection();

            spisakBolovanja();
            dgwBolovanja.ClearSelection();
        }

        private void spisakRecepata()
        {
            string connectionString = DBConnection.GetConnectionString();
            using (OracleConnection connection = new OracleConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                OracleCommand command;
                OracleDataReader reader;
                try
                {

                    string sql = "SELECT DISTINCT RECEPT.SIFL,NAZLEK,OR_KOLICINA_LEKA,PROP__KOLICINA_LEKA,SIFDIJ,DATIZD FROM RECEPT,LEK WHERE LEK.SIFL=RECEPT.SIFL";

                command = new OracleCommand(sql);
                command.Connection = connection;
                reader = command.ExecuteReader();
                }
                catch (Exception)
                {

                    throw;
                }

                while (reader.Read())
                {
                    String[] podaci = {  reader["SIFL"].ToString(),
                                         reader["NAZLEK"].ToString(),
                                         reader["OR_KOLICINA_LEKA"].ToString(),
                                         reader["PROP__KOLICINA_LEKA"].ToString(),
                                         reader["SIFDIJ"].ToString(),
                                         reader["DATIZD"].ToString().TrimEnd('0',':')
                                      };

                   dgwRecepti.Rows.Add(podaci);
                }

               // this.pRecepti.Height += 200;
               // this.dgwRecepti.Height += 100;
               // this.pUputi.Visible = false;
               // this.pNalazi.Visible = false;
               // this.pBolovanja.Visible = false;
               // this.pPomagala.Visible = false;
               // this.dgwUputi.Visible = false;
               // this.dgwNalazi.Visible = false;
               // this.dgwBolovanja.Visible = false;
               // this.dgwPomagala.Visible = false;
               // this.Height -= pUputi.Height;
               // this.Height -= pNalazi.Height;
               // this.Height -= pBolovanja.Height;
               // this.Height -= pPomagala.Height/3;
               //// Console.WriteLine("PAREEEEEENT"+ this.Parent.ToString());
               // this.Location = new Point(270, 200);// new Point(this.Parent.Location.X + this.Parent.Width / 3, this.Parent.Location.Y - this.Parent.Height*10);  //Position= FormStartPosition.CenterParent;
               
               connection.Close();
            }
}

        private void spisakUputa(){

            string connectionString = DBConnection.GetConnectionString();
            using (OracleConnection connection = new OracleConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                OracleCommand command;
                OracleDataReader reader;
                string sql = "";
                string sql1 = "";
                string sql2 = "";
                try
                {
                   
                        sql = "SELECT DISTINCT NAZIV_INSTITUCIJE,NAZIV_VRSTE_UPUTA,NAZSPEC,DIJAGNOZA,RAZLOG_UPUT,DAT_IZD_UPUT FROM UPUT,VRSTA_UPUTA,SPECIJALNOST WHERE SPECIJALNOST.IDSPEC=UPUT.IDSPEC AND VRSTA_UPUTA.ID_VRSTE_UPUTA=UPUT.ID_VRSTE_UPUTA";
                        sql1 = "SELECT DISTINCT NAZIV_INSTITUCIJE,NAZIV_VRSTE_UPUTA,NAZIV_VRSTE_ANALIZE,DIJAGNOZA,RAZLOG_UPUT,DAT_IZD_UPUT FROM UPUT,VRSTA_UPUTA,VRSTA_ANALIZE WHERE VRSTA_ANALIZE.ID_VRSTE_ANALIZE=UPUT.ID_VRSTE_ANALIZE AND VRSTA_UPUTA.ID_VRSTE_UPUTA=UPUT.ID_VRSTE_UPUTA";
                        sql2 = "SELECT DISTINCT NAZIV_INSTITUCIJE,NAZIV_VRSTE_UPUTA,DIJAGNOZA,RAZLOG_UPUT,DAT_IZD_UPUT FROM UPUT,VRSTA_UPUTA WHERE VRSTA_UPUTA.ID_VRSTE_UPUTA=UPUT.ID_VRSTE_UPUTA";

                    command = new OracleCommand(sql);
                    command.Connection = connection;
                    reader = command.ExecuteReader();


                    String[] podaci;
                  //  label6.Text = "";
                    while (reader.Read())
                    {
                        //label6.Text += reader[0].ToString();

                        podaci = new String[] {           reader["NAZIV_INSTITUCIJE"].ToString(),
                                                          reader["NAZIV_VRSTE_UPUTA"].ToString(),
                                                          reader["NAZSPEC"].ToString(),
                                                          "-",//reader["NAZIV_VRSTE_ANALIZE"].ToString(),
                                                          reader["DIJAGNOZA"].ToString(),
                                                          reader["RAZLOG_UPUT"].ToString(),
                                                          reader["DAT_IZD_UPUT"].ToString().TrimEnd('0',':')
                                                  };

                        dgwUputi.Rows.Add(podaci);
                    }

                    command = new OracleCommand(sql1);
                    command.Connection = connection;
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {


                        podaci = new String[] {           reader["NAZIV_INSTITUCIJE"].ToString(),
                                                      reader["NAZIV_VRSTE_UPUTA"].ToString(),
                                                      "-",
                                                      reader["NAZIV_VRSTE_ANALIZE"].ToString(),
                                                      reader["DIJAGNOZA"].ToString(),
                                                      reader["RAZLOG_UPUT"].ToString(),
                                                      reader["DAT_IZD_UPUT"].ToString().TrimEnd('0',':')
                                              };

                        dgwUputi.Rows.Add(podaci);
                    }

                    command = new OracleCommand(sql2);
                    command.Connection = connection;
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {


                        podaci = new String[] {           reader["NAZIV_INSTITUCIJE"].ToString(),
                                                      reader["NAZIV_VRSTE_UPUTA"].ToString(),
                                                      "-",
                                                      "-",
                                                      reader["DIJAGNOZA"].ToString(),
                                                      reader["RAZLOG_UPUT"].ToString(),
                                                      reader["DAT_IZD_UPUT"].ToString().TrimEnd('0',':')
                                              };

                        dgwUputi.Rows.Add(podaci);
                    }
                connection.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
           
        }

        private void spisakBolovanja()
        {

            string connectionString = DBConnection.GetConnectionString();
            using (OracleConnection connection = new OracleConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                OracleCommand command;
                OracleDataReader reader;
                string sql = "";
 
                try
                {

                    sql = "SELECT * FROM BOLOVANJE,VRSTA_BOLOVANJA,STATUS_BOLOVANJA WHERE BOLOVANJE.ID_VRSTE_BOL=VRSTA_BOLOVANJA.ID_VRSTE_BOL AND BOLOVANJE.ID_STATUSA_BOL=STATUS_BOLOVANJA.ID_STATUSA_BOL";

                    command = new OracleCommand(sql);
                    command.Connection = connection;
                    reader = command.ExecuteReader();

                    string recidiv;
                    string trecel;

                    String[] podaci;

                    while (reader.Read())
                    {

                        if (reader["RECIDIV"].ToString().Equals("1"))
                            recidiv = "da";
                        else
                            recidiv = "ne";

                        if (reader["TRECE_LICE"].ToString().Equals("1"))
                            trecel = "da";
                        else
                            trecel = "ne";

                        podaci = new String[] {       reader["NAZIV_VRSTE_BOL"].ToString(),
                                                      reader["POC_DATUM_BOL"].ToString(),
                                                      reader["KRAJ_DATUM_BOL"].ToString(),
                                                      reader["NAZIV_STATUSA"].ToString(),
                                                      reader["DIJAGNOZA"].ToString(),
                                                      reader["NALAZ"].ToString(),
                                                      reader["SPOLJ_UZROK"].ToString(),
                                                      trecel,
                                                      recidiv,
                                                      reader["DAT_IZD_BOL"].ToString(),
                                              };

                        dgwBolovanja.Rows.Add(podaci);
                    }

       
                    connection.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
