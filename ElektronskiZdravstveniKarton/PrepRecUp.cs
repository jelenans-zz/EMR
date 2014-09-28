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
    public partial class PrepRecUp : Form
    {
        string idlekara = "";
        public PrepRecUp(string idlek)
        {
            InitializeComponent();
            idlekara = idlek;
        }

        private void PrepRecUp_Load(object sender, EventArgs e)
        {
                       string sql = "";
            string connectionString = DBConnection.GetConnectionString();
            using (OracleConnection connection = new OracleConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                OracleCommand command;
                OracleDataReader reader;

                try
                {

                    sql = "SELECT * FROM LEKAR_OPSTE_MEDICINE WHERE ID_ZR='" + idlekara + "'"; 

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
                        lbLekar.Text += reader["IME"] + " " + reader["PRZ"] + " " + reader["ID_ZR"];
                    }

                }
                catch (Exception)
                {

                    throw;
                }

                connection.Close();
            }
           
        }

        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            string sql = "";
            string connectionString = DBConnection.GetConnectionString();
            using (OracleConnection connection = new OracleConnection())
            {

                connection.ConnectionString = connectionString;
                connection.Open();
                OracleCommand command;
                OracleDataReader reader;




                try
                {

                    sql = "SELECT count(*) FROM Recept WHERE ID_ZR ='" + idlekara + "' AND datizd BETWEEN '" + mtbDatOd.Value.ToString("dd-MMM-yyyy") + "' AND '" + mtbDatDo.Value.ToString("dd-MMM-yyyy") + "'";

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
                    lbBrRec.Text +="  "+ reader[0].ToString();
                }

             
                try
                {

                    sql = " SELECT count(*) FROM Uput WHERE ID_ZR ='" + idlekara + "' AND DAT_IZD_UPUT BETWEEN '" + mtbDatOd.Value.ToString("dd-MMM-yyyy") + "' AND '" + mtbDatDo.Value.ToString("dd-MMM-yyyy") + "'";

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
                    lbBrUp.Text +=" "+ reader[0].ToString();
                }

               

                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
