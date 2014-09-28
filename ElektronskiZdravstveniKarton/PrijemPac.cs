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
    public partial class PrijemPacReg : Form
    {

        string jmbg_pacijenta = "";
        Object SelItem = new Object();

        public PrijemPacReg()
        {
            InitializeComponent();
        }

        public PrijemPacReg(string jmbgp)
        {
            InitializeComponent();
            jmbg_pacijenta = jmbgp;
        }

        private void PrijemPacReg_Load(object sender, EventArgs e)
        {
            mtbDatPrijema.Text = DateTime.Today.ToString("dd-MMM-yyyy");
            string connectionString = DBConnection.GetConnectionString();
            using (OracleConnection connection = new OracleConnection())
            {
                try
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    OracleCommand command;
                    OracleDataReader reader;

                      string sqlr = "SELECT * FROM PACIJENT WHERE JMBGP='"+jmbg_pacijenta+"'";

                    command = new OracleCommand(sqlr);
                    command.Connection = connection;
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        SelItem= reader["IMEP"] + " " + reader["PRZP"] + " " + reader["JMBGP"];
                    }
                    
                    
                    sqlr = "SELECT * FROM PACIJENT";

                    command = new OracleCommand(sqlr);
                    command.Connection = connection;
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cbPrimPacijent.Items.Add(reader["IMEP"] + " " + reader["PRZP"] + " " + reader["JMBGP"]);
                        cbPrimPacijent.SelectedIndex = 0;
                        if (!jmbg_pacijenta.Equals(""))
                        {
                            cbPrimPacijent.SelectedItem = SelItem;
                        }
                    }
          
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

            string jmbg_pacijenta = cbPrimPacijent.SelectedItem.ToString().Split(' ').Last();
            EvidencijaPacijenta ep = new EvidencijaPacijenta(jmbg_pacijenta,true);
            DialogResult dr = ep.ShowDialog();
            this.Opacity = .70;
            if (dr == DialogResult.Cancel)
                this.Opacity = 1;
        }

        private void btnSac_Click(object sender, EventArgs e)
        {
            string idlek = "";
            string jmbglek = "";
            OracleCommand command;
            OracleDataReader reader;
            string connectionString = DBConnection.GetConnectionString();
            using (OracleConnection connection = new OracleConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                string sql = "";

                string jmbgpac = cbPrimPacijent.SelectedItem.ToString().Split(' ').Last();

                sql = "SELECT ID_ZR,JMBGZR FROM IZBOR_LEKARA WHERE JMBGP='" + jmbgpac+"'";

                command = new OracleCommand(sql);
                command.Connection = connection;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    idlek = reader["ID_ZR"].ToString();
                    jmbglek = reader["JMBGZR"].ToString();
                }

                sql = "insert into PRIJEM_PACIJENTA (JMBGP,DATUM_PRIJEMA,ID_PRIJEMA,JMBGZR, ID_ZR) values('"
                    + jmbgpac + "','" + mtbDatPrijema.Value.ToString("dd-MMM-yyyy") +"','" 
                    + DBConnection.RandomString(5) + "','"+jmbglek+"','"+idlek+ "')";
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



              //  ReceptSnim rs = new ReceptSnim("Uspešno snimljeni podaci o prijemu pacijenta");
                //   rs.ShowDialog();
              //  this.Opacity = .70;
                //DialogResult dr = rs.ShowDialog();
                //if (dr == DialogResult.Cancel)
                //{
                    this.Close();
               // }

                this.DialogResult = DialogResult.OK;
                connection.Close();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SpisakAnamneza sp = new SpisakAnamneza(DBConnection.Spiskovi.Pacijenti);
            DialogResult dr = sp.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string[] rez = sp.ucitanTekst.Split(',');
                cbPrimPacijent.Text = rez[0] + " " + rez[1] + " " + rez[2];
            }
        }

        private void btnPon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
