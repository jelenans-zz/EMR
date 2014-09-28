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
    public partial class Sugestije : Form
    {


        private string id_lekara;
        private string mesec;
        String[] red = new String[2];
        int i = 0;
        private string sifLeka="";

        public Sugestije()
        {
            InitializeComponent();
        }

        public Sugestije(string id_lekara, string p)
        {
            InitializeComponent();
            this.id_lekara = id_lekara;
            this.mesec = p;
        }

        public Sugestije(string p)
        {
            InitializeComponent();

            this.sifLeka = p;
        }

     
        private void Sugestije_Load(object sender, EventArgs e)
        {
            popuniGrid();
        }

        private void popuniGrid()
        {
            if (!sifLeka.Equals(""))
            {
                string sql = "";
                string connectionString = DBConnection.GetConnectionString();
                using (OracleConnection connection = new OracleConnection())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    OracleCommand command;
                    OracleDataReader reader;
                    OracleDataReader reader2;

                    try
                    {


                    sql = "SELECT * FROM LEK WHERE SIFL='" + sifLeka + "'";
                    command = new OracleCommand(sql);
                    command.Connection = connection;
                    reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                       

                        red[i] = reader["NAZLEK"].ToString() + " " 
                               + reader["SIFL"].ToString() + ", CENA: " 
                               + reader["CENA_LEKA"].ToString();
                        i++;
                   


                    sql = "SELECT * FROM LEK WHERE GRUPA IS NOT NULL AND SIFL!='" + sifLeka
                        + "' AND CENA_LEKA<'" + reader["CENA_LEKA"].ToString()
                        + "' AND GRUPA='" + reader["GRUPA"].ToString() + "' ORDER BY CENA_LEKA ASC";

                    command = new OracleCommand(sql);
                    command.Connection = connection;
                    reader2 = command.ExecuteReader();
                    red[i] = "";
                    while (reader2.Read())
                    {
                        red[i] += reader2["NAZLEK"].ToString() + " " 
                               + reader2["SIFL"].ToString() + ", CENA: " 
                               + reader2["CENA_LEKA"].ToString() + Environment.NewLine;
                    }
                    i = 0;
                            
                    dgwSpisak.Rows.Add(red);

                    }


                    }
                    catch (Exception)
                    {

                        throw;
                    }

                    dgwSpisak.ClearSelection();
                    connection.Close();
                }
            }
            else
            {
                string sql = "";
                string connectionString = DBConnection.GetConnectionString();
                using (OracleConnection connection = new OracleConnection())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    OracleCommand command;
                    OracleDataReader reader;
                    OracleDataReader reader1;
                    OracleDataReader reader2;

                    try
                    {

                        sql = "SELECT SIFL FROM RECEPT WHERE IZNOS IS NOT NULL AND extract(month from DATIZD) =  '"
                              + DateTime.ParseExact(mesec, "MMM", System.Globalization.CultureInfo.InvariantCulture).Month + "'"
                              + "AND ID_ZR='" + id_lekara + "' ORDER BY IZNOS DESC";

                        command = new OracleCommand(sql);
                        command.Connection = connection;
                        reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            sql = "SELECT * FROM LEK WHERE SIFL='" + reader["SIFL"].ToString() + "'";
                            command = new OracleCommand(sql);
                            command.Connection = connection;
                            reader1 = command.ExecuteReader();

                            if (reader1.Read())
                            {
                                red[i] = reader1["NAZLEK"].ToString() + " " + reader1["SIFL"].ToString() + ", CENA: " + reader1["CENA_LEKA"].ToString();
                                i++;

                                sql = "SELECT * FROM LEK WHERE GRUPA IS NOT NULL AND SIFL!='" + reader1["SIFL"].ToString()
                                    + "' AND CENA_LEKA<'" + reader1["CENA_LEKA"].ToString() + "' AND GRUPA='" + reader1["GRUPA"].ToString() + "' ORDER BY CENA_LEKA ASC";
                                command = new OracleCommand(sql);
                                command.Connection = connection;
                                reader2 = command.ExecuteReader();
                                red[i] = "";
                                while (reader2.Read())
                                {
                                    red[i] += reader2["NAZLEK"].ToString() + " " + reader2["SIFL"].ToString() + ", CENA: " + reader2["CENA_LEKA"].ToString() + Environment.NewLine;
                                }
                                i = 0;
                            }
                            dgwSpisak.Rows.Add(red);

                        }


                    }
                    catch (Exception)
                    {

                        throw;
                    }

                    dgwSpisak.ClearSelection();
                    connection.Close();
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
