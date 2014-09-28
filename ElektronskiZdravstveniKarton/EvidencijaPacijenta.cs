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
    public partial class EvidencijaPacijenta : Form
    {
        bool prijem_pacijenta;
        string jmbg_pacijenta = "";
        string saForme = "";

        public EvidencijaPacijenta()
        {
            InitializeComponent();
        }

        public EvidencijaPacijenta(string jmbgp,bool sa_prijem_pac)
        {
            InitializeComponent();
            prijem_pacijenta = sa_prijem_pac;
            jmbg_pacijenta = jmbgp;
        }

       

        public EvidencijaPacijenta(string sa_forme)
        {
            InitializeComponent();
           
            saForme = sa_forme;
        }


        private void EvidencijaPacijenta_Load(object sender, EventArgs e)
        {
            if (prijem_pacijenta)
            {

                string connectionString = DBConnection.GetConnectionString();
                using (OracleConnection connection = new OracleConnection())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    OracleCommand command;
                    OracleDataReader reader;

                    string sql = "SELECT * FROM PACIJENT WHERE JMBGP='" + jmbg_pacijenta + "'";

                    command = new OracleCommand(sql);
                    command.Connection = connection;
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        tbIme.Text = reader["IMEP"].ToString();
                        tbIme.ReadOnly = true;
                        tbPrz.Text = reader["PRZP"].ToString();
                        tbPrz.ReadOnly = true;
                        mtbJmbg.Text = jmbg_pacijenta;
                        mtbJmbg.ReadOnly = true;
                        tbAdr.Text = reader["ADRP"].ToString().Split(',').First();
                        tbAdr.ReadOnly = true;
                        tbGrad.Text = reader["ADRP"].ToString().Split(',').Last();
                        tbGrad.ReadOnly = true;
                        tbDrz.Text = reader["DRZP"].ToString();
                        tbDrz.ReadOnly = true;
                        tbZanimanje.Text = reader["ZANIMANJEP"].ToString();
                        tbZanimanje.ReadOnly = true;
                        tbPosao.Text = reader["POSAOP"].ToString();
                        tbPosao.ReadOnly = true;
                        tbTel.Text = reader["BRTELP"].ToString();
                        tbTel.ReadOnly = true;
                        mtbZK.Text = reader["BRZK"].ToString();
                        mtbZK.ReadOnly = true;
                        tbNosOsig.Text = reader["NOSOSIG"].ToString();
                        tbNosOsig.ReadOnly = true;
                        tbFakt.Text = reader["FAKTURA"].ToString();
                        tbFakt.ReadOnly = true;
                        mtbLbo.Text = reader["LBO"].ToString();
                        mtbLbo.ReadOnly = true;
                        mtbDatRodj.Text = reader["DATRP"].ToString().TrimEnd('0', ':');
                        mtbDatRodj.Enabled = false;

                        if (reader["POLP"].ToString().Equals("m"))
                            rbM.Checked = true;
                        else
                            rbZ.Checked = true;

                        rbM.Enabled = false;
                        rbZ.Enabled = false;

                        if (reader["PARTICIP"].ToString().Equals("1"))
                            chbParticip.Checked = true;
                        else
                            chbParticip.Checked = false;

                        chbParticip.Enabled = false;
                        btnSac.Visible = false;
                        btnPon.Text = "Zatvori";
                        

                    }

                    sql = "SELECT * FROM IZBOR_LEKARA,LEKAR_OPSTE_MEDICINE WHERE JMBGP='" + jmbg_pacijenta + "'" + " AND IZBOR_LEKARA.ID_ZR=LEKAR_OPSTE_MEDICINE.ID_ZR AND IZBOR_LEKARA.JMBGZR=LEKAR_OPSTE_MEDICINE.JMBGZR";

                    command = new OracleCommand(sql);
                    command.Connection = connection;
                    reader = command.ExecuteReader();

                    if (reader.Read())
                    {

                        btnIzbLek.Visible = false;
                        lbIzLekar.Text = reader["IME"].ToString()+" "+reader["PRZ"].ToString()+" "+reader["ID_ZR"].ToString();
                      
                    }

                    connection.Close();
                }
            }
            
        }

        private void btnSac_Click(object sender, EventArgs e)
        {
            OracleCommand command;
            string connectionString = DBConnection.GetConnectionString();
            using (OracleConnection connection = new OracleConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                string sql = "";
                string pol="";

                if (rbM.Checked)
                   pol = "m";
                else
                   pol = "z";

                int particip;
                if (chbParticip.Checked)
                    particip = 1;
                else
                    particip = 0;
       
                sql = "INSERT INTO PACIJENT(IMEP, PRZP, JMBGP, ADRP, DATRP, POLP, DRZP, ZANIMANJEP, POSAOP, BRTELP,BRZK, NOSOSIG, LBO, PARTICIP, FAKTURA) VALUES ('"
                     + tbIme.Text + "','" + tbPrz.Text + "','" + mtbJmbg.Text + "','" + tbAdr.Text + " " + tbGrad.Text + "','" 
                     + mtbDatRodj.Value.ToString("dd-MMM-yyyy")+ "','" + pol
                     + "','" + tbDrz.Text + "','" + tbZanimanje.Text + "','" + tbPosao.Text + "','" + tbTel.Text + "','"
                     + mtbZK.Text + "','" + tbNosOsig.Text + "','" + mtbLbo.Text + "','" + particip + "','" + tbFakt.Text + "')";

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



                ReceptSnim rs = new ReceptSnim("Uspešno snimljeni podaci o pacijentu");
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


                if (saForme.Equals("sa_protokola"))
                    Protokol.jmbg_pac = mtbJmbg.Text;

                this.DialogResult = DialogResult.OK;

            }
        }

        private void btnPon_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand command;
            string connectionString = DBConnection.GetConnectionString();
            using (OracleConnection connection = new OracleConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                string sql = "";
                string pol = "";

                if (rbM.Checked)
                    pol = "m";
                else
                    pol = "z";

                int particip;
                if (chbParticip.Checked)
                    particip = 1;
                else
                    particip = 0;

                sql = "INSERT INTO PACIJENT(IMEP, PRZP, JMBGP, ADRP, DATRP, POLP, DRZP, ZANIMANJEP, POSAOP, BRTELP,BRZK, NOSOSIG, LBO, PARTICIP, FAKTURA) VALUES ('"
                     + tbIme.Text + "','" + tbPrz.Text + "','" + mtbJmbg.Text + "','" + tbAdr.Text + " " + tbGrad.Text + "','"
                     + mtbDatRodj.Value.ToString("dd-MMM-yyyy")+"','" + pol
                     + "','" + tbDrz.Text + "','" + tbZanimanje.Text + "','" + tbPosao.Text + "','" + tbTel.Text + "','"
                     + mtbZK.Text + "','" + tbNosOsig.Text + "','" + mtbLbo.Text + "','" + particip + "','" + tbFakt.Text + "')";

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

                // label6.Text = sql;
                connection.Close();


            }

            IzborLekara ep = new IzborLekara(mtbJmbg.Text,true);
            DialogResult dr = ep.ShowDialog();
            this.Opacity = .70;
            this.Close();
            this.DialogResult = DialogResult.OK;
        }
    }
}
