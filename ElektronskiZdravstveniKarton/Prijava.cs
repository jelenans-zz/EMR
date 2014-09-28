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
    public partial class Prijava : Form
    {
        private int vrsta_kor;
        public static string vrsta="";
        
        public Prijava(int kor)
        {
            InitializeComponent();
            vrsta_kor = kor;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (vrsta_kor==0)
            {
 //               Console.WriteLine("admiiiiiiiiin");
                string connectionString = DBConnection.GetConnectionString();
                using (OracleConnection connection = new OracleConnection())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    string sql = "";
                   // string idodel = "";

                    sql = "SELECT * FROM ADMINZK WHERE USERA='" + tbUser.Text+ "' AND PASSA='"+tbPass.Text+"'";
                    OracleCommand command = new OracleCommand(sql);
                    command.Connection = connection;
                    OracleDataReader reader = command.ExecuteReader();

                   
                    
                    if (reader.Read())
                    {
                            MeniAdmin rp = new MeniAdmin();
                            this.Opacity = .70;
                            DialogResult dr = rp.ShowDialog();
                            if (dr == DialogResult.Cancel)
                                this.Close();
                   }
                   else
                   {
                            MessageBox.Show("Neispravni podaci");
 
                   }
                    this.Opacity = 1;

                    // label6.Text = sql;
                    connection.Close();
                    //this.DialogResult = DialogResult.OK;
                }
            }
            else if (vrsta_kor == 1)
            {
                string connectionString = DBConnection.GetConnectionString();
                using (OracleConnection connection = new OracleConnection())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    string sql = "";

                    sql = "SELECT * FROM REGISTRACIJA WHERE VRSTAKOR='" + vrsta + "' AND USERZAP='" + tbUser.Text + "' AND SIFRAZAP='" + tbPass.Text + "'";
                    OracleCommand command = new OracleCommand(sql);
                    command.Connection = connection;
                    OracleDataReader reader = command.ExecuteReader();



                    if (reader.Read())
                    {
                        if (reader["SIFRAZAP"].Equals("DZNS"))
                        {
                            IzmenaLozinke rp = new IzmenaLozinke(reader["IMEZAP"].ToString(), reader["PRZZAP"].ToString(), reader["IDZAP"].ToString());
                            this.Opacity = .70;
                            DialogResult dr = rp.ShowDialog();
                            if (dr == DialogResult.Cancel)
                                this.Opacity = 1;
                        }
                        else
                        {
                            MeniLekOpste meni = new MeniLekOpste(reader["IDZAP"].ToString());
                            meni.ShowDialog();
                            this.Close();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Neispravni podaci");

                    }
                    this.Opacity = 1;

                    // label6.Text = sql;
                    connection.Close();
                    //this.DialogResult = DialogResult.OK;
                }  
            }
            else if (vrsta_kor == 2)
            {
             
            }
            else if (vrsta_kor == 3)
            {
                string connectionString = DBConnection.GetConnectionString();
                using (OracleConnection connection = new OracleConnection())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    string sql = "";

                    sql = "SELECT * FROM REGISTRACIJA WHERE VRSTAKOR='" + vrsta + "' AND USERZAP='" + tbUser.Text + "' AND SIFRAZAP='" + tbPass.Text + "'";
                    OracleCommand command = new OracleCommand(sql);
                    command.Connection = connection;
                    OracleDataReader reader = command.ExecuteReader();



                    if (reader.Read())
                    {
                        if (reader["SIFRAZAP"].Equals("DZNS"))
                        {
                            IzmenaLozinke rp = new IzmenaLozinke(reader["IMEZAP"].ToString(), reader["PRZZAP"].ToString(), reader["IDZAP"].ToString());
                            this.Opacity = .70;
                            DialogResult dr = rp.ShowDialog();
                            if (dr == DialogResult.Cancel)
                                this.Opacity = 1;
                        }
                        else 
                        {
                            MeniMedSesTeh meni = new MeniMedSesTeh();
                            meni.ShowDialog();
                            this.Close();
 
                        }
                    }
                    else
                    {
                        MessageBox.Show("Neispravni podaci");

                    }
                    this.Opacity = 1;

                    // label6.Text = sql;
                    connection.Close();
                    //this.DialogResult = DialogResult.OK;
                }
            }
            else if (vrsta_kor == 4)
            {
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
