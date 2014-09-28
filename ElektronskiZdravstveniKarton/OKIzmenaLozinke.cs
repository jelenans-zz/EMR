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
    public partial class OKIzmenaLozinke : Form
    {
        private string id="";
        public OKIzmenaLozinke(string idzap)
        {
            InitializeComponent();
            id = idzap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MeniMedSesTeh meni = new MeniMedSesTeh();
            meni.ShowDialog();
            this.Close();
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void OKIzmenaLozinke_Load(object sender, EventArgs e)
        {

            string connectionString = DBConnection.GetConnectionString();
            using (OracleConnection connection = new OracleConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                string sql = "";

                sql = "SELECT IMEZAP,PRZZAP FROM REGISTRACIJA WHERE IDZAP='" + id + "'";
                OracleCommand command = new OracleCommand(sql);
                command.Connection = connection;
                OracleDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    lbIzm.Text += "za korisnika  " + reader["IMEZAP"].ToString() +" "+ reader["PRZZAP"].ToString();

                }

            }
        }
    }
}
