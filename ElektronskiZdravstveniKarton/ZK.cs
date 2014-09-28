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
    public partial class ZK : Form
    {
        string id_pacijenta = "";
        string id_lekara = "";
        string jmbg_lekara = "";
        public static string ucitanTekst = "";

        public ZK(string idpac,string idlek)
        {
            InitializeComponent();
            id_pacijenta = idpac;
            id_lekara = idlek;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            mtbDatPos.Text = DateTime.Today.ToString("dd-MMM-yyyy");
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

                    sql = "SELECT * FROM PACIJENT WHERE PACIJENT.JMBGP='" + id_pacijenta + "'";

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
                        tbPacZk.Text = reader["IMEP"].ToString() + " " + reader["PRZP"].ToString();
                    }

                }
                catch (Exception)
                {

                    throw;
                }

                try
                {

                    sql = "SELECT JMBGZR FROM LEKAR_OPSTE_MEDICINE WHERE ID_ZR='" + id_lekara + "'";

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
                        jmbg_lekara = reader["JMBGZR"].ToString();
                    }

                }
                catch (Exception)
                {

                    throw;
                }

                connection.Close();
            }
        }


        private void btnDetalji_Click(object sender, EventArgs e)
        {

            EvidencijaPacijenta ep = new EvidencijaPacijenta(id_pacijenta, true);
            DialogResult dr = ep.ShowDialog();
            this.Opacity = .70;
            if (dr == DialogResult.Cancel)
                this.Opacity = 1;
            //PodaciPacijent pp = new PodaciPacijent();
            //this.Opacity = .70;
            //DialogResult dr = pp.ShowDialog();
            //if (dr == DialogResult.Cancel)
            //    this.Opacity = 1;

        }

        private void miRecept_Click(object sender, EventArgs e)
        {
            Recept rp = new Recept(id_lekara,jmbg_lekara,id_pacijenta);
            this.Opacity = .70;
            DialogResult dr = rp.ShowDialog();
            if (dr == DialogResult.Cancel)
                this.Opacity = 1;
        }

        private void miPomagalo_Click(object sender, EventArgs e)
        {

        }

        private void miUputa_Click(object sender, EventArgs e)
        {
            Uput up = new Uput(id_lekara, jmbg_lekara, id_pacijenta);
            this.Opacity = .70;
            DialogResult dr = up.ShowDialog();
            if (dr == DialogResult.Cancel)
                this.Opacity = 1;
        }

        private void bolovanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bolovanje up = new Bolovanje(id_pacijenta);
            this.Opacity = .70;
            DialogResult dr = up.ShowDialog();
            if (dr == DialogResult.Cancel)
                this.Opacity = 1;
        }

        private void recepataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PregledZK rp = new PregledZK();
            this.Opacity = .70;
            DialogResult dr = rp.ShowDialog();
            if (dr == DialogResult.Cancel)
                this.Opacity = 1;
        }

        private void mipUput_Click(object sender, EventArgs e)
        {
            PregledZK rp = new PregledZK();
            this.Opacity = .70;
            DialogResult dr = rp.ShowDialog();
            if (dr == DialogResult.Cancel)
                this.Opacity = 1;
        }

        private void bolovanjaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PregledZK rp = new PregledZK();
            this.Opacity = .70;
            DialogResult dr = rp.ShowDialog();
            if (dr == DialogResult.Cancel)
                this.Opacity = 1;
        }

        private void miHDijagnoza_Click(object sender, EventArgs e)
        {
            PruzeneUsluge rp = new PruzeneUsluge();
            this.Opacity = .70;
            DialogResult dr = rp.ShowDialog();
            if (dr == DialogResult.Cancel)
                this.Opacity = 1;
        }

        private void miUpozorenje_Click(object sender, EventArgs e)
        {
            PruzeneUsluge rp = new PruzeneUsluge();
            this.Opacity = .70;
            DialogResult dr = rp.ShowDialog();
            if (dr == DialogResult.Cancel)
                this.Opacity = 1;
        }

        private void miParticipacija_Click(object sender, EventArgs e)
        {
            PruzeneUsluge rp = new PruzeneUsluge();
            this.Opacity = .70;
            DialogResult dr = rp.ShowDialog();
            if (dr == DialogResult.Cancel)
                this.Opacity = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = DBConnection.GetConnectionString();
            using (OracleConnection connection = new OracleConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                string sql = "";

                OracleCommand command = new OracleCommand(sql);
                command.Connection = connection;

                sql = "insert into ZDRAVSTVENI_KARTON (BR_ZK, IDREC, ID_NALAZA, ID_POMAGALA, ID_UPUTA, JMBGZR, ID_ZR, JMBGP, ANAMNEZA, STATUS_PREGLEDA,"
                       + " TERAPIJA,DIJAGNOZA, HRONICNA_DIJAG_, DAT_KONTROLE, NAPOMENA, DAT_POSETE,ZNAK_UPOZ) values ("
                       + "'" + DBConnection.RandomString(6) + "','','','','','" 
                       + jmbg_lekara + "','" +id_lekara+"','"+id_pacijenta+"','"+rtbAnamneza.Text+"','"+rtbStatPreg.Text+"','"
                       + rtbTerapija.Text + "','" + mtbSifDij.Text + " " + tbDijag.Text + "','" + rtbHronDijag.Text + "','" + mtbDatKon.Value.ToString("dd-MMM-yyyy") + "','"
                       + rtbNapomena.Text + "','" + mtbDatPos.Value.ToString("dd-MMM-yyyy") + "','" + rtbZnakUpoz.Text + "')";

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

                ReceptSnim rss = new ReceptSnim("Uspešno snimljeni podaci");
                //   rs.ShowDialog();
                //this.Opacity = .70;
                rss.ShowDialog();
                //if (drrr == DialogResult.OK)
                //{
                //    this.Opacity = 1;
                //}

                //this.DialogResult = DialogResult.OK;
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void vakcinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
               SpisVakcina spisvak = new SpisVakcina(id_pacijenta);
               spisvak.ShowDialog();

               //   connection.ConnectionString = connectionString;
               //   connection.Open();
               //   OracleCommand cmd = new OracleCommand();
               //   cmd.Connection = connection;

               //   cmd.CommandText = "pckg_zu.f_vakcine";
               //   cmd.CommandType = CommandType.StoredProcedure;

               //   OracleParameter p_jmbgp = new OracleParameter("p_idpac", OracleDbType.Char);
               //   p_jmbgp.Value = id_pacijenta.ToCharArray(0,id_pacijenta.Count());
               //   cmd.Parameters.Add(p_jmbgp).Direction = ParameterDirection.Input;

               //   //OracleParameter p_jmbgp = new OracleParameter();
               //   //p_jmbgp.OracleDbType = OracleDbType.Char;
               //   //p_jmbgp.Value = id_pacijenta;

               //   OracleParameter p_vakc = new OracleParameter();
               //   p_vakc.OracleDbType = OracleDbType.Char;
               //   p_vakc.CollectionType = OracleCollectionType.PLSQLAssociativeArray;
               //   p_vakc.Size = 100;
               //   //p_vakc.ArrayBindSize = binds
               //   p_vakc.ArrayBindSize = new int[100];
 
               //   // set the bind size value for each element
               //   for (int i = 0; i < 100; i++)
               //   {
               //       p_vakc.ArrayBindSize[i] = 32000;
               //   }

               //   p_vakc.Direction = ParameterDirection.ReturnValue;

               //   //cmd.Parameters.Add(p_jmbgp);
               //   cmd.Parameters.Add(p_vakc);

               // //  DataSet ds = new DataSet();
               ////   OracleDataAdapter adapter = new OracleDataAdapter(cmd);
               ////   adapter.Fill(ds);
               //   cmd.ExecuteNonQuery();
               //   connection.Close();

            }

        private void btnUcitAnam_Click(object sender, EventArgs e)
         {
            SpisakAnamneza sp= new SpisakAnamneza();
            DialogResult dr= sp.ShowDialog();
            if (dr == DialogResult.OK)
            { 
                rtbAnamneza.Text=sp.ucitanTekst;
            }
        }

        private void btnSnimAnam_Click(object sender, EventArgs e)
        {

            SnimiAnam sa = new SnimiAnam(rtbAnamneza.Text);
            DialogResult dr = sa.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string rez = sa.rezNazivAnam;

                string connectionString = DBConnection.GetConnectionString();
                using (OracleConnection connection = new OracleConnection())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    string sql = "";

                    OracleCommand command = new OracleCommand(sql);
                    command.Connection = connection;


                    sql = "insert into ANAM (NAZAN, OPISAN) values ('"
                           + rez + "','" + rtbAnamneza.Text + "')";

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

                    ReceptSnim rss = new ReceptSnim("Uspešno snimljeni podaci",true);
                    //   rs.ShowDialog();
                    //this.Opacity = .70;
                    rss.ShowDialog();
                    //if (drrr == DialogResult.OK)
                    //{
                    //    this.Opacity = 1;
                    //}

                    //this.DialogResult = DialogResult.OK;
                    connection.Close();
                }
            } 
        }

        private void btnUcitStat_Click(object sender, EventArgs e)
        {
            StatusPregled sp = new StatusPregled();
            DialogResult dr= sp.ShowDialog();

            if (dr == DialogResult.OK)
            {
                string[] rez = sp.ucitanTekst.Split(',');
                for(int i=0;i<rez.Count()-1;i++)
                   rtbStatPreg.Text += rez[i]+'\n';
            }
        }

        private void btnSnimStat_Click(object sender, EventArgs e)
        {

            SnimiStat sa = new SnimiStat();
            DialogResult dr = sa.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (!sa.stara)
                {
                    string rez = sa.rezNazivStat;

                    string connectionString = DBConnection.GetConnectionString();
                    using (OracleConnection connection = new OracleConnection())
                    {
                        connection.ConnectionString = connectionString;
                        connection.Open();
                        string sql = "";

                        OracleCommand command = new OracleCommand(sql);
                        command.Connection = connection;


                        sql = "insert into STATUS_PREGLED (OBLAST, STAVKE) values ('"
                               + rez + "','" + rtbStatPreg.Text + "')";

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

                        ReceptSnim rss = new ReceptSnim("Uspešno snimljeni podaci");
                        //   rs.ShowDialog();
                        //this.Opacity = .70;
                        rss.ShowDialog();
                        //if (drrr == DialogResult.OK)
                        //{
                        //    this.Opacity = 1;
                        //}

                        //this.DialogResult = DialogResult.OK;
                        connection.Close();
                    }
                } else {

                    string rez = sa.rezNazivStat;

                    string connectionString = DBConnection.GetConnectionString();
                    using (OracleConnection connection = new OracleConnection())
                    {
                        connection.ConnectionString = connectionString;
                        connection.Open();
                        string sql = "";

                        OracleCommand command = new OracleCommand(sql);
                        command.Connection = connection;

                        OracleDataReader reader;
                        string oldValRow = "";
                        try
                        {

                            sql = "SELECT STAVKE FROM STATUS_PREGLED WHERE OBLAST='" + rez + "'";

                            command = new OracleCommand(sql);
                            command.Connection = connection;
                            reader = command.ExecuteReader();

                            if (reader.Read())
                            {
                                oldValRow = reader[0].ToString();
                            }
                        }
                        catch (Exception)
                        {

                            throw;
                        }


                        sql = "UPDATE STATUS_PREGLED SET stavke='"
                               +oldValRow+"\n"+ rtbStatPreg.Text +"'"+"WHERE oblast='"+rez+ "'";
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

                        ReceptSnim rss = new ReceptSnim("Uspešno snimljeni podaci");
                        //   rs.ShowDialog();
                        //this.Opacity = .70;
                        rss.ShowDialog();
                        //if (drrr == DialogResult.OK)
                        //{
                        //    this.Opacity = 1;
                        //}

                        //this.DialogResult = DialogResult.OK;
                        connection.Close();
                    }
                }
            }
        }

        private void btnBrowseDijag_Click(object sender, EventArgs e)
        {
            SpisakAnamneza sp = new SpisakAnamneza(DBConnection.Spiskovi.Dijagnoze);
            DialogResult dr = sp.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string[] rez = sp.ucitanTekst.Split(',');
                mtbSifDij.Text = rez[0];
                tbDijag.Text = rez[1];
            }
        }

        private void btnBrowseHronDijag_Click(object sender, EventArgs e)
        {
            SpisakAnamneza sp = new SpisakAnamneza(DBConnection.Spiskovi.Dijagnoze);
            DialogResult dr = sp.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string[] rez = sp.ucitanTekst.Split(',');
                tbSifHronDij.Text = rez[0];
                rtbHronDijag.Text = rez[1];
            }
        }

     

        }
    }

