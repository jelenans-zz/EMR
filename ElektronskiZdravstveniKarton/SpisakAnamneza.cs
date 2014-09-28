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
using System.Collections;

namespace ElektronskiZdravstveniKarton
{
    public partial class SpisakAnamneza : Form
    {
        //DataColumn col;
        //DataColumn col2;

        public string ucitanTekst="";

        DataGridViewTextBoxColumn colTmp1;
        DataGridViewTextBoxColumn colTmp2;

        private bool lekovi = false;
        private bool dijagnoze=false;
        private bool ustanove = false;
        private bool pacijenti=false;
        private bool lekari=false;

        public SpisakAnamneza()
        {
            InitializeComponent();

            bindingNavigatorMoveNextItem.Enabled = true;
            bindingNavigatorMovePreviousItem.Enabled = true;
            bindingNavigatorMoveLastItem.Enabled = true;
            bindingNavigatorMoveFirstItem.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;

        
        }

        public SpisakAnamneza(DBConnection.Spiskovi spisak)
        {
            InitializeComponent();


            bindingNavigatorMoveNextItem.Enabled = true;
            bindingNavigatorMovePreviousItem.Enabled = true;
            bindingNavigatorMoveLastItem.Enabled = true;
            bindingNavigatorMoveFirstItem.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;


            if (spisak.Equals(DBConnection.Spiskovi.Lekovi))
                lekovi = true;
            else if (spisak.Equals(DBConnection.Spiskovi.Dijagnoze))
                dijagnoze = true;
            else  if (spisak.Equals(DBConnection.Spiskovi.Ustanove))
                ustanove = true;
            else  if (spisak.Equals(DBConnection.Spiskovi.Pacijenti))
                pacijenti = true;
            else  if (spisak.Equals(DBConnection.Spiskovi.Lekari))
                lekari = true;
           
        }

    

        private void SpisakAnamneza_Load(object sender, EventArgs e)
        {

            if (lekovi)
            {
                dgwSpisak.ClearSelection();
                this.Text = "Spisak lekova";
                colTmp1 = new DataGridViewTextBoxColumn();
                colTmp1.HeaderText = "Naziv";
                dgwSpisak.Columns.Add(colTmp1);
                cbKolona.Items.Add(colTmp1.HeaderText);
                colTmp2 = new DataGridViewTextBoxColumn();
                colTmp2.HeaderText = "Originalna količina";
                dgwSpisak.Columns.Add(colTmp2);

                DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
                col3.HeaderText = "Šifra";
                dgwSpisak.Columns.Add(col3);
                cbKolona.Items.Add(col3.HeaderText);


                DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
                col4.HeaderText = "Cena";
                dgwSpisak.Columns.Add(col4);
                cbKolona.Items.Add(col4.HeaderText);

                popuniGrid();
            }
            else if (dijagnoze)
            {
                dgwSpisak.ClearSelection();

                this.Text = "Spisak dijagnoza";

                colTmp1 = new DataGridViewTextBoxColumn();
                colTmp1.HeaderText = "Šifra";
                dgwSpisak.Columns.Add(colTmp1);
                cbKolona.Items.Add(colTmp1.HeaderText);

                DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
                col3.HeaderText = "Naziv";
                dgwSpisak.Columns.Add(col3);
                cbKolona.Items.Add(col3.HeaderText);

                popuniGrid();

            }
            else if (ustanove)
            {
                dgwSpisak.ClearSelection();

                this.Text = "Spisak zdravstvenih ustanova";

                colTmp1 = new DataGridViewTextBoxColumn();
                colTmp1.HeaderText = "Naziv";
                dgwSpisak.Columns.Add(colTmp1);
                cbKolona.Items.Add(colTmp1.HeaderText);

                popuniGrid();

            }
            else if (pacijenti)
            {
                dgwSpisak.ClearSelection();

                this.Text = "Spisak pacijenata";

                colTmp1 = new DataGridViewTextBoxColumn();
                colTmp1.HeaderText = "Ime";
                dgwSpisak.Columns.Add(colTmp1);
                cbKolona.Items.Add(colTmp1.HeaderText);

                DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
                col3.HeaderText = "Prezime";
                dgwSpisak.Columns.Add(col3);
                cbKolona.Items.Add(col3.HeaderText);

                DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
                col4.HeaderText = "JMBG";
                dgwSpisak.Columns.Add(col4);
                cbKolona.Items.Add(col4.HeaderText);

                popuniGrid();

            }
            else if (lekari)
            {
                dgwSpisak.ClearSelection();

                this.Text = "Spisak lekara";

                colTmp1 = new DataGridViewTextBoxColumn();
                colTmp1.HeaderText = "Ime";
                dgwSpisak.Columns.Add(colTmp1);
                cbKolona.Items.Add(colTmp1.HeaderText);

                DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
                col3.HeaderText = "Prezime";
                dgwSpisak.Columns.Add(col3);
                cbKolona.Items.Add(col3.HeaderText);

                DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
                col4.HeaderText = "ID";
                dgwSpisak.Columns.Add(col4);
                cbKolona.Items.Add(col4.HeaderText);

                popuniGrid();

            }
            else 
            {
                dgwSpisak.ClearSelection();
                colTmp1 = new DataGridViewTextBoxColumn();
                colTmp1.HeaderText = "Naziv anamneze";
                dgwSpisak.Columns.Add(colTmp1);
                cbKolona.Items.Add(colTmp1.HeaderText);

                colTmp2 = new DataGridViewTextBoxColumn();
                colTmp2.HeaderText = "Opis anamneze";
                dgwSpisak.Columns.Add(colTmp2);
                cbKolona.Items.Add(colTmp2.HeaderText);

                popuniGrid();
            }

            cbKolona.SelectedIndex = 0;
        }

        private void popuniGrid()
        {
            dgwSpisak.Rows.Clear();

            if (lekovi)
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

                        sql = "SELECT * FROM LEK";

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
                        while (reader.Read())
                        {

                            String[] podaci = {  reader["NAZLEK"].ToString(),
                                                 reader["OR_KOLICINA_LEKA"].ToString(),
                                                 reader["SIFL"].ToString(),
                                                 reader["CENA_LEKA"].ToString()
                                          };

                            dgwSpisak.Rows.Add(podaci);
                        }

                    }
                    catch (Exception)
                    {

                        throw;
                    }

                    connection.Close();
                }
            }
            else if (dijagnoze)
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

                        sql = "SELECT * FROM DIJAGNOZA";

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
                        while (reader.Read())
                        {

                            String[] podaci = {  reader["SIFDIJAG"].ToString(),
                                                 reader["NAZDIJAG"].ToString()
                                          };

                            dgwSpisak.Rows.Add(podaci);
                        }

                    }
                    catch (Exception)
                    {

                        throw;
                    }

                    connection.Close();
                }
            }
            else if (pacijenti)
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

                        sql = "SELECT * FROM PACIJENT";

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
                        while (reader.Read())
                        {

                            String[] podaci = {  reader["IMEP"].ToString(),
                                                 reader["PRZP"].ToString(),
                                                 reader["JMBGP"].ToString()
                                          };

                            dgwSpisak.Rows.Add(podaci);
                        }

                    }
                    catch (Exception)
                    {

                        throw;
                    }

                    connection.Close();
                }
            }
            else if (lekari)
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

                        sql = "SELECT * FROM LEKAR_OPSTE_MEDICINE";

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
                        while (reader.Read())
                        {

                            String[] podaci = {  reader["IME"].ToString(),
                                                 reader["PRZ"].ToString(),
                                                 reader["ID_ZR"].ToString()
                                          };

                            dgwSpisak.Rows.Add(podaci);
                        }

                    }
                    catch (Exception)
                    {

                        throw;
                    }

                    dgwSpisak.ClearSelection();
                    connection.Close();
                }
            }
            else if (ustanove)
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

                        sql = "SELECT * FROM USTANOVE";

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
                        while (reader.Read())
                        {

                            String[] podaci = {  reader["NAZUST"].ToString()
                                          };

                            dgwSpisak.Rows.Add(podaci);
                        }

                    }
                    catch (Exception)
                    {

                        throw;
                    }

                    connection.Close();
                }

            } 
            else
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

                        sql = "SELECT * FROM ANAM";

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
                        while (reader.Read())
                        {

                            String[] podaci = {  reader["NAZAN"].ToString(),
                                             reader["OPISAN"].ToString()
                                          };

                            dgwSpisak.Rows.Add(podaci);
                        }

                    }
                    catch (Exception)
                    {

                        throw;
                    }

                    connection.Close();
                }
            }

            dgwSpisak.ClearSelection();
        }



     
 
        private void button1_Click(object sender, EventArgs e)
        {
            if (lekovi)
            {
                ucitanTekst = dgwSpisak.SelectedRows[0].Cells[0].Value.ToString() + ","
                            + dgwSpisak.SelectedRows[0].Cells[1].Value.ToString() + ","
                            + dgwSpisak.SelectedRows[0].Cells[2].Value.ToString() + ","
                            + dgwSpisak.SelectedRows[0].Cells[3].Value.ToString() + ",";
            }
            else if (dijagnoze)
            {
                ucitanTekst = dgwSpisak.SelectedRows[0].Cells[0].Value.ToString() + ","
                            + dgwSpisak.SelectedRows[0].Cells[1].Value.ToString() + ",";
            }
            else if (pacijenti || lekari)
            {
                ucitanTekst = dgwSpisak.SelectedRows[0].Cells[0].Value.ToString() + ","
                            + dgwSpisak.SelectedRows[0].Cells[1].Value.ToString() + ","
                            + dgwSpisak.SelectedRows[0].Cells[2].Value.ToString();
            }
            else if (ustanove)
            {
                ucitanTekst = dgwSpisak.SelectedRows[0].Cells[0].Value.ToString();
            }
            else
            {
                ucitanTekst = dgwSpisak.SelectedRows[0].Cells[1].Value.ToString();
            }
           this.DialogResult = DialogResult.OK;
           this.Close();
        }

   
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<string[]> filtrirajListu(string kriterijumZaPretragu)
        {
            List<string[]> rez = new List<string[]>();
            if (lekovi)
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

                        if (cbKolona.SelectedItem.ToString().Equals("Naziv"))
                        {
                            sql = "SELECT * FROM LEK WHERE LOWER(NAZLEK) LIKE '%" + kriterijumZaPretragu.ToLower() + "%'";
                        }
                        else if (cbKolona.SelectedItem.ToString().Equals("Originalna količina leka"))
                        {
                            sql = "SELECT * FROM LEK WHERE LOWER(OR_KOLICINA_LEKA) LIKE '%" + kriterijumZaPretragu.ToLower() + "%'";
                        }
                        else if (cbKolona.SelectedItem.ToString().Equals("Šifra"))
                        {
                            sql = "SELECT * FROM LEK WHERE LOWER(SIFL) LIKE '%" + kriterijumZaPretragu.ToLower() + "%'";
                        }
                        else if (cbKolona.SelectedItem.ToString().Equals("Cena leka"))
                        {
                            sql = "SELECT * FROM LEK WHERE LOWER(CENA_LEKA) LIKE '%" + kriterijumZaPretragu.ToLower() + "%'";
                        }

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
                        while (reader.Read())
                        {

                            String[] podaci = {  reader["NAZLEK"].ToString(),
                                                 reader["OR_KOLICINA_LEKA"].ToString(),
                                                 reader["SIFL"].ToString(),
                                                 reader["CENA_LEKA"].ToString()
                                      };
                            rez.Add(podaci);
                        }



                    }
                    catch (Exception)
                    {

                        throw;
                    }

                    connection.Close();
                }
            }
            else if (dijagnoze)
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
                        if (cbKolona.SelectedItem.ToString().Equals("Šifra"))
                        {
                            sql = "SELECT * FROM DIJAGNOZA WHERE LOWER(SIFDIJAG) LIKE '%" + kriterijumZaPretragu.ToLower() + "%'";
                        }
                        else if (cbKolona.SelectedItem.ToString().Equals("Naziv"))
                        {
                            sql = "SELECT * FROM DIJAGNOZA WHERE LOWER(NAZDIJAG) LIKE '%" + kriterijumZaPretragu.ToLower() + "%'";
                        }


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
                        while (reader.Read())
                        {

                            String[] podaci = {  reader["SIFDIJAG"].ToString(),
                                                 reader["NAZDIJAG"].ToString()
                                          };
                            rez.Add(podaci);
                        }



                    }
                    catch (Exception)
                    {

                        throw;
                    }

                    connection.Close();
                }
            }
            else if (pacijenti)
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
                        if (cbKolona.SelectedItem.ToString().Equals("Ime"))
                        {
                            sql = "SELECT * FROM PACIJENT WHERE LOWER(IMEP) LIKE '%" + kriterijumZaPretragu.ToLower() + "%'";
                        }
                        else if (cbKolona.SelectedItem.ToString().Equals("Prezime"))
                        {
                            sql = "SELECT * FROM PACIJENT WHERE LOWER(PRZP) LIKE '%" + kriterijumZaPretragu.ToLower() + "%'";
                        }
                        else if (cbKolona.SelectedItem.ToString().Equals("JMBG"))
                        {
                            sql = "SELECT * FROM PACIJENT WHERE LOWER(JMBGP) LIKE '%" + kriterijumZaPretragu.ToLower() + "%'";
                        }


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
                        while (reader.Read())
                        {

                            String[] podaci = {  reader["IMEP"].ToString(),
                                                    reader["PRZP"].ToString(),
                                                    reader["JMBGP"].ToString()
                                            };
                            rez.Add(podaci);
                        }



                    }
                    catch (Exception)
                    {

                        throw;
                    }

                    connection.Close();
                }
            }
            else if (lekari)
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
                        if (cbKolona.SelectedItem.ToString().Equals("Ime"))
                        {
                            sql = "SELECT * FROM LEKAR_OPSTE_MEDICINE WHERE LOWER(IME) LIKE '%" + kriterijumZaPretragu.ToLower() + "%'";
                        }
                        else if (cbKolona.SelectedItem.ToString().Equals("Prezime"))
                        {
                            sql = "SELECT * FROM LEKAR_OPSTE_MEDICINE WHERE LOWER(PRZ) LIKE '%" + kriterijumZaPretragu.ToLower() + "%'";
                        }


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
                        while (reader.Read())
                        {

                            String[] podaci = {  reader["IME"].ToString(),
                                                 reader["PRZ"].ToString(),
                                                 reader["ID_ZR"].ToString()
                                          };
                            rez.Add(podaci);
                        }



                    }
                    catch (Exception)
                    {

                        throw;
                    }

                    connection.Close();
                }
            }
            else if (ustanove)
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

                        sql = "SELECT * FROM USTANOVE WHERE LOWER(NAZUST) LIKE '%" + kriterijumZaPretragu.ToLower() + "%'";

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
                        while (reader.Read())
                        {

                            String[] podaci = {  reader["NAZUST"].ToString()
                                          };
                            rez.Add(podaci);
                        }



                    }
                    catch (Exception)
                    {

                        throw;
                    }

                    connection.Close();
                }
            }
            else
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
                        if (cbKolona.SelectedItem.ToString().Equals("Naziv anamneze"))
                        {
                            sql = "SELECT * FROM ANAM WHERE LOWER(NAZAN) LIKE '%" + kriterijumZaPretragu.ToLower() + "%'";
                        }
                        else if (cbKolona.SelectedItem.ToString().Equals("Opis anamneze"))
                        {
                            sql = "SELECT * FROM ANAM WHERE LOWER(OPISAN) LIKE '%" + kriterijumZaPretragu.ToLower() + "%'";
                        }


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
                        while (reader.Read())
                        {

                            String[] podaci = {  reader["NAZAN"].ToString(),
                                             reader["OPISAN"].ToString()
                                      };
                            rez.Add(podaci);
                        }



                    }
                    catch (Exception)
                    {

                        throw;
                    }

                    connection.Close();
                }
            }

            return rez;
        }



        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            SnimiAnam sa = new SnimiAnam();
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
                           + rez + "','" + sa.rezSadrzAnam + "')";

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

                 //   ReceptSnim rss = new ReceptSnim("Uspešno snimljeni podaci");
                    //   rs.ShowDialog();
                    //this.Opacity = .70;
                   // rss.ShowDialog();
                    popuniGrid();
                    //if (drrr == DialogResult.OK)
                    //{
                    //    this.Opacity = 1;
                    //}

                    //this.DialogResult = DialogResult.OK;
                    connection.Close();
                }
            } 
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            dgwSpisak.ClearSelection();
            dgwSpisak.Rows[dgwSpisak.RowCount - 1].Selected = true;
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            dgwSpisak.ClearSelection();
            dgwSpisak.Rows[0].Selected = true;
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            int selIndex = dgwSpisak.SelectedRows[0].Index;
             if (selIndex != 0)
             {
                 int newSelIndex = selIndex - 1;
                 dgwSpisak.ClearSelection();
                 dgwSpisak.Rows[newSelIndex].Selected = true;
             }
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            int selIndex = dgwSpisak.SelectedRows[0].Index;
             if (selIndex != dgwSpisak.RowCount - 1)
             {
                 int newSelIndex = selIndex + 1;
                 dgwSpisak.ClearSelection();
                 dgwSpisak.Rows[newSelIndex].Selected = true;
             }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            string connectionString = DBConnection.GetConnectionString();
            using (OracleConnection connection = new OracleConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                string sql = "";

                OracleCommand command = new OracleCommand(sql);
                command.Connection = connection;

                sql = "DELETE FROM ANAM WHERE NAZAN='" + dgwSpisak.SelectedRows[0].Cells[0].Value.ToString()+"'";

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

                popuniGrid();

                connection.Close();
            }
        }

        //private void tsPretraga_TextChanged(object sender, EventArgs e)
        //{
          
        //}

        private void tsPretraga_TextChanged_1(object sender, EventArgs e)
        {
            string kriterijumZaPretragu = tsPretraga.Text;

            List<string[]> newValues = filtrirajListu(kriterijumZaPretragu);


            dgwSpisak.Rows.Clear();

            foreach (string[] data in newValues)
            {
                dgwSpisak.Rows.Add(data);
            }
        }

   

    }
}
