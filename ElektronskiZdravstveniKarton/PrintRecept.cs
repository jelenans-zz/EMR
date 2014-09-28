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
    public partial class PrintRecept : Form
    {
        private string idRecepta;
        private string nazDij;
        private string nazLeka;
        private string p;
        private string p_2;
        private string jmbgpac;

        public PrintRecept()
        {
            InitializeComponent();
        }


        public PrintRecept(string idRecepta, string p, string p_2, string jmbgpac)
        {
            InitializeComponent();
            this.idRecepta = idRecepta;
            this.p = p;
            this.p_2 = p_2;
            this.jmbgpac = jmbgpac;
            nazLeka = p_2;
            nazDij = p;
        }

        private void PrintRecept_Load(object sender, EventArgs e)
        {
            string connectionString = DBConnection.GetConnectionString();
            // label1.Text = connectionString;
            using (OracleConnection connection = new OracleConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                string sql = "SELECT * FROM RECEPT WHERE IDREC='"+idRecepta+"'";

                OracleCommand command = new OracleCommand(sql);
                command.Connection = connection;
                OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    tbSifra.Text = reader["SIFL"].ToString();
                    tbNaziv.Text = nazLeka;
                    tbKolicina.Text = reader["PROP__KOLICINA_LEKA"].ToString();
                    tbCena.Text = reader["IZNOS"].ToString();
                    tbDijagnoza.Text = reader["SIFDIJ"].ToString()+Environment.NewLine+nazDij;
                    tbDatum.Text = DateTime.Parse(reader["DATIZD"].ToString()).ToString("dd-MMM-yyyy");
                }

                sql = "SELECT * FROM PACIJENT WHERE JMBGP='" + jmbgpac + "'";
                command = new OracleCommand(sql);
                command.Connection = connection;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    lbImePac.Text += "  " + reader["IMEP"].ToString() + " " + reader["PRZP"].ToString();
                    lbBrzk.Text += "  " + reader["BRZK"].ToString();
                }
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
