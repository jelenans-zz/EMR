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
    public partial class Registracija : Form
    {
        string sql1="";
        string sql2 = "";
        string sql3 = "";

        public Registracija()
        {
            InitializeComponent();
        }

        private void Registracija_Load(object sender, EventArgs e)
        {
            dtpDatRodj.Text = DateTime.Today.ToString("dd-MMM-yyyy");
            cbVrstaKor.SelectedIndex = 0;
           // cbVrstaOdel.SelectedItem = cbVrstaOdel.Items[0];
            //cbDan.SelectedItem = cbDan.Items[0];
            //cbMes.SelectedItem = cbMes.Items[0];
            //cbGod.SelectedItem = cbGod.Items[0];
            cbGrad.SelectedItem = cbGrad.Items[0];
            string connectionString =  DBConnection.GetConnectionString();
            // label1.Text = connectionString;
            using (OracleConnection connection = new OracleConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                string sql = "SELECT NAZODEL FROM VRSTA_ODELJENJA";

                OracleCommand command = new OracleCommand(sql);
                command.Connection = connection;
                OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cbVrstaOdel.Items.Add(reader[0]);
                    cbVrstaOdel.SelectedIndex = 0;
                }
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = DBConnection.GetConnectionString();
            using (OracleConnection connection = new OracleConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                string sql = "";
                string idodel = "";

                sql = "SELECT IDODEL FROM VRSTA_ODELJENJA WHERE NAZODEL='" + cbVrstaOdel.SelectedItem.ToString() + "'";
                OracleCommand command = new OracleCommand(sql);
                command.Connection = connection;
                OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    idodel = (String)reader[0];
                }

                sql = "INSERT INTO REGISTRACIJA(VRSTAKOR,IDODEL,IDZAP,IMEZAP,PRZZAP,JMBGZAP,TELZAP,ADRZAP,GRADZAP,DRZZAP,USERZAP,SIFRAZAP) VALUES"
                    + "('" + cbVrstaKor.SelectedItem.ToString() + "','" + idodel+ "','" + tbIdZap.Text + "','" + tbIme.Text + "','" + tbPrez.Text
                    +"','"+mtbJmbg.Text+"','"+tbTel.Text+"','"+tbAdr.Text+"','"+cbGrad.SelectedItem.ToString()+"','Srbija','"+tbUsr.Text+"','"+tbPass.Text+"')";
                    //('Lekar specijalista','UGN','AAABBBCC','Filip','Filipovic','1210980502010','0038121543365','Kosovska 1a','Novi Sad', 'Srbija','user','user')";

 

                sql1 = "INSERT INTO ZDRAVSTVENI_RADNIK (IME, PRZ, JMBGZR, TEL_ZR, ADR_ZR, ZANIMANJE_ZR,ID_ZR, IDZU,DAT_RODJ) VALUES"
                         + "('" + tbIme.Text + "','" + tbPrez.Text + "','" +mtbJmbg.Text
                         + "','" + tbTel.Text + "','" + tbAdr.Text + ", " + cbGrad.SelectedItem.ToString() +"','"
                         + cbVrstaKor.SelectedItem.ToString() + "','" + tbIdZap.Text + "','"
                         + DBConnection.idzu + "','" + dtpDatRodj.Value.ToString("dd-MMM-yyyy") + "')";
              


                if (cbVrstaKor.SelectedItem.ToString().Equals("Lekar opšte medicine"))
                {
                    sql2 = "INSERT INTO SOBNI_LEKAR (IME, PRZ, JMBGZR, TEL_ZR, ADR_ZR, ZANIMANJE_ZR,ID_ZR, IDZU,ZDR_IDZU,DAT_RODJ) VALUES"
                         + "('" + tbIme.Text + "','" + tbPrez.Text + "','" +mtbJmbg.Text
                         + "','" + tbTel.Text + "','" + tbAdr.Text + ", " + cbGrad.SelectedItem.ToString() + "','"
                         + cbVrstaKor.SelectedItem.ToString() + "','" + tbIdZap.Text + "','" + DBConnection.idzu + "','" + idodel+"','"
                         + dtpDatRodj.Value.ToString("dd-MMM-yyyy") + "')";

                    sql3 = "INSERT INTO LEKAR_OPSTE_MEDICINE(JMBGZR, ID_ZR, IDZU, IME, PRZ, TEL_ZR, ADR_ZR, ZANIMANJE_ZR,DAT_RODJ) VALUES"
                         + "('" + mtbJmbg.Text + "','" + tbIdZap.Text + "','" +DBConnection.idzu+ "','" + tbIme.Text + "','" + tbPrez.Text
                         + "','" + tbTel.Text + "','" + tbAdr.Text + ", " + cbGrad.SelectedItem.ToString() + "','"
                         + cbVrstaKor.SelectedItem.ToString() + "','"
                         + dtpDatRodj.Value.ToString("dd-MMM-yyyy") + "')";
                }
                else if (cbVrstaKor.SelectedItem.ToString().Equals("Lekar specijalista"))
                {
                    sql2 = "INSERT INTO SOBNI_LEKAR (IME, PRZ, JMBGZR, TEL_ZR, ADR_ZR, ZANIMANJE_ZR,ID_ZR, IDZU,ZDR_IDZU,DAT_RODJ) VALUES"
                         + "('" + tbIme.Text + "','" + tbPrez.Text + "','" + mtbJmbg.Text
                         + "','" + tbTel.Text + "','" + tbAdr.Text + ", " + cbGrad.SelectedItem.ToString() + "','"
                         + cbVrstaKor.SelectedItem.ToString() + "','" + tbIdZap.Text + "','" + DBConnection.idzu + "','" + idodel + "','"
                         + dtpDatRodj.Value.ToString("dd-MMM-yyyy") + "')";

                    sql3 = "INSERT INTO LEKAR_SPECIJALISTA (JMBGZR, ID_ZR, IDZU, IME, PRZ, TEL_ZR, ADR_ZR,ZANIMANJE_ZR,DAT_RODJ) VALUES "
                         + "('" + mtbJmbg.Text + "','" + tbIdZap.Text + "','" + DBConnection.idzu + "','" + tbIme.Text + "','" + tbPrez.Text
                         + "','" + tbTel.Text + "','" + tbAdr.Text + ", " + cbGrad.SelectedItem.ToString() + "','"
                         + cbVrstaKor.SelectedItem.ToString() + "','"
                         + dtpDatRodj.Value.ToString("dd-MMM-yyyy") + "')";


                }
                else if (cbVrstaKor.SelectedItem.ToString().Equals("Medicinska sestra/tehničar"))
                {// (JMBGZR, ID_ZR, IME, PRZ, TEL_ZR, ADR_ZR, ZANIMANJE_ZR, IDZU, TIP_SR_KADRA)
                    sql2 = "INSERT INTO SREDNJI_MEDICINSKI_KADAR (JMBGZR, ID_ZR, IDZU, IME, PRZ, TEL_ZR, ADR_ZR,ZANIMANJE_ZR,TIP_SR_KADRA,DAT_RODJ) VALUES "
                           + "('" + mtbJmbg.Text + "','" + tbIdZap.Text + "','" + DBConnection.idzu + "','" + tbIme.Text + "','" + tbPrez.Text
                           + "','" + tbTel.Text + "','" + tbAdr.Text + ", " + cbGrad.SelectedItem.ToString() + "','" + "Srednji med.kadar" + "','"
                           + cbVrstaKor.SelectedItem.ToString() + "','"
                           + dtpDatRodj.Value.ToString("dd-MMM-yyyy") + "')";
                }
                else if (cbVrstaKor.SelectedItem.ToString().Equals("Laborant"))
                {
                   
                }

                try
                {
                    command = new OracleCommand(sql1);
                    command.Connection = connection;
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    throw;
                }

                    try
                {
                    command = new OracleCommand(sql2);
                    command.Connection = connection;
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    throw;
                }

                    try
                {
                    if (!sql3.Equals(""))
                    {
                        command = new OracleCommand(sql3);
                        command.Connection = connection;
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {

                    throw;
                }

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

                ReceptSnim rs = new ReceptSnim("Uspešno registrovan korisnik");
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
