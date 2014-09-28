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
    public partial class IzmenaLozinke : Form
    {
        string idz="";
        //string usr;
        private ErrorProvider err = new ErrorProvider();
        private Color colErr = Color.Salmon;
        private Color colOk = Color.White;

        public IzmenaLozinke(string ime, string prz, string idzap)
        {
            InitializeComponent();
            label4.Text = "Korisnik " + ime + " " + prz;
            idz = idzap;
            //usr = ime+" "+prz;
        }

        private void IzmenaLozinke_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = DBConnection.GetConnectionString();
            using (OracleConnection connection = new OracleConnection())
            {
                OracleCommand command; 
                connection.ConnectionString = connectionString;
                connection.Open();
                string sql = "";

                sql = "UPDATE REGISTRACIJA SET SIFRAZAP='"+tbNovaLoz.Text+"'WHERE IDZAP='"+idz+"'";


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



                OKIzmenaLozinke rs = new OKIzmenaLozinke(idz);
                //   rs.ShowDialog();
                this.Opacity = .70;
                DialogResult dr = rs.ShowDialog();
                if (dr == DialogResult.Cancel)
                {
                    //this.Opacity = 1;
                    this.Close();
                }

                // label6.Text = sql;
                connection.Close();
                //this.DialogResult = DialogResult.OK;

            }
        }

        private void tbLoz_Leave(object sender, EventArgs e)
        {
            string connectionString = DBConnection.GetConnectionString();
            using (OracleConnection connection = new OracleConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                string sql = "";

                sql = "SELECT * FROM REGISTRACIJA WHERE SIFRAZAP='" + tbLoz.Text + "'"+"AND IDZAP="+"'"+idz+"'";
                OracleCommand command = new OracleCommand(sql);
                command.Connection = connection;
                OracleDataReader reader = command.ExecuteReader();



                if (!reader.Read() || tbLoz.Text.Equals(""))
                {

                    tbLoz.BackColor = colErr;
                    err.SetError(tbLoz, "Neispravna lozinka");
                    err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
                    button1.Enabled = false;

                }
                else 
                {
                    tbLoz.BackColor = colOk;
                    err.Clear();
                    button1.Enabled = true;

                }

            }
        }

        private void tbPotvrNovaLoz_Leave(object sender, EventArgs e)
        {
            if (tbNovaLoz.Text!=tbPotvrNovaLoz.Text || tbPotvrNovaLoz.Text.Equals(""))
            {
                tbPotvrNovaLoz.BackColor = colErr;
                err.SetError(tbPotvrNovaLoz, "Nova lozinka i njena potvrda se ne poklapaju");
                err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
                button1.Enabled = false;
            }
            else
            {
                tbPotvrNovaLoz.BackColor = colOk;
                err.Clear();
                button1.Enabled = true;
            }
        }

        private void tbUsr_Leave(object sender, EventArgs e)
        {
            string connectionString = DBConnection.GetConnectionString();
            using (OracleConnection connection = new OracleConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                string sql = "";

                sql = "SELECT * FROM REGISTRACIJA WHERE USERZAP='" + tbUsr.Text + "'" + "AND IDZAP=" + "'" + idz + "'";
                OracleCommand command = new OracleCommand(sql);
                command.Connection = connection;
                OracleDataReader reader = command.ExecuteReader();



                if (!reader.Read() || tbUsr.Text.Equals(""))
                {
                    tbUsr.BackColor = colErr;
                    err.SetError(tbUsr, "Neispravno korisničko ime");
                    err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
                    button1.Enabled = false;

                }
                else
                {
                    tbUsr.BackColor = colOk;
                    err.Clear();
                    button1.Enabled = true;

                }

            }
        }

        private void tbNovaLoz_Leave(object sender, EventArgs e)
        {
            if (tbNovaLoz.Text.Equals(""))
            {

                tbNovaLoz.BackColor = colErr;
                err.SetError(tbNovaLoz, "Unesite novu lozinku");
                err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
                button1.Enabled = false;

            }
            else
            {
                tbNovaLoz.BackColor = colOk;
                err.Clear();
                button1.Enabled = true;
            }
        }
    }
}
