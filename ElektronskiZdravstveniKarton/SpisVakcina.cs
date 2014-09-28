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
    public partial class SpisVakcina : Form
    {
        string jmbgpac = "";

        public SpisVakcina(string idpac)
        {
            InitializeComponent();
            jmbgpac = idpac;
        }

        private void SpisVakcina_Load(object sender, EventArgs e)
        {
            dgwNeprim.ClearSelection();
            dgwPrim.ClearSelection();
            int god_pac = 0;
            string sql = "";
            string sql1 = "";
            // int i=0;
            // int j=0;
            string id_vakcine = "";
            List<String> spisak_prim_vakcina = new List<String>();
            List<String> spisak_neprim_vakcina = new List<String>();
            //String[] spisak_prim_vakcina = new String[] { };
            //string[] spisak_neprim_vakcina = new string[100] { };
            string connectionString = DBConnection.GetConnectionString();
            using (OracleConnection connection = new OracleConnection())
            {

                connection.ConnectionString = connectionString;
                connection.Open();
                OracleCommand command;
                OracleDataReader reader;
                OracleDataReader reader1;

                try
                {

                    sql = " SELECT IMEP,PRZP,JMBGP FROM PACIJENT WHERE PACIJENT.JMBGP='" + jmbgpac + "'";

                    command = new OracleCommand(sql);
                    command.Connection = connection;
                    reader = command.ExecuteReader();
                }
                catch (Exception)
                {

                    throw;
                }


                if (reader.Read())
                {
                    lbPac.Text += "  " + reader["IMEP"] + "  " + reader["PRZP"] + ", jmbg:  " + reader["JMBGP"];
                }


                try
                {

                    sql = " SELECT trunc((SYSDATE-pacijent.datrp)/365, 0) FROM PACIJENT WHERE PACIJENT.JMBGP='" + jmbgpac + "'";

                    command = new OracleCommand(sql);
                    command.Connection = connection;
                    reader = command.ExecuteReader();
                }
                catch (Exception)
                {

                    throw;
                }


                if (reader.Read())
                {
                    god_pac = Int32.Parse(reader[0].ToString());
                }

                lbPac.Text += ", godina: " + god_pac;

                try
                {

                    sql = "SELECT * FROM vakcina WHERE starost_pac<='" + god_pac + "'";

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
                    while (reader.Read())
                    {
                        id_vakcine = reader["ID_VAKCINE"].ToString();
                        sql1 = "SELECT COUNT(*) FROM prima_vakcinu WHERE prima_vakcinu.id_vakcine ='" + id_vakcine + "' and prima_vakcinu.jmbgp='" + jmbgpac + "'";
                        command = new OracleCommand(sql1);
                        command.Connection = connection;
                        reader1 = command.ExecuteReader();
                        while (reader1.Read())
                        {
                            if (Int32.Parse(reader1[0].ToString()) == 0)
                            {
                                dgwNeprim.Rows.Add(reader["VRSTA_VAKCINE"].ToString(),
                                                        reader["ID_VAKCINE"].ToString(),
                                                        reader["STAROST_PAC"].ToString());
                            }
                            else
                            {
                                dgwPrim.Rows.Add(reader["VRSTA_VAKCINE"].ToString(),
                                                        reader["ID_VAKCINE"].ToString(),
                                                        reader["STAROST_PAC"].ToString());
                            }
                        }
                    }

                }
                catch (Exception)
                {

                    throw;
                }

                connection.Close();
            }


            dgwNeprim.ClearSelection();
            dgwPrim.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


  
    }
}
