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
    public partial class SnimiStat : Form
    {

        public string rezNazivStat = "";
        public bool stara = false;

        public SnimiStat()
        {
            InitializeComponent();
        }

        private void SnimiStat_Load(object sender, EventArgs e)
        {
            string connectionString = DBConnection.GetConnectionString();
            using (OracleConnection connection = new OracleConnection())
            {
                try
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    OracleCommand command;
                    OracleDataReader reader;

                    string sqlr = "SELECT * FROM STATUS_PREGLED";

                    command = new OracleCommand(sqlr);
                    command.Connection = connection;
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cbObl.Items.Add(reader["OBLAST"]);             
                    }
                    cbObl.SelectedIndex = 0;
  
                    connection.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbObl.SelectedItem!=null && !cbObl.SelectedItem.ToString().Equals(""))
            {
                stara = true;
                rezNazivStat = cbObl.SelectedItem.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (!tbNovaObl.Text.Equals(""))
            {
                rezNazivStat = tbNovaObl.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
