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
    public partial class Protokol : Form
    {

        public static string jmbg_pac="";

        public Protokol()
        {
            InitializeComponent();


            bindingNavigatorMoveNextItem.Enabled = true;
            bindingNavigatorMovePreviousItem.Enabled = true;
            bindingNavigatorMoveLastItem.Enabled = true;
            bindingNavigatorMoveFirstItem.Enabled = true;
            toolStripButton2.Enabled = true;
            toolStripButton3.Enabled = true;

        }


       
        private void Protokol_Load(object sender, EventArgs e)
        { 
            
            mtbDatProtokol.Text = DateTime.Today.ToString("dd-MMM-yyyy");
            cbKolona.Items.Add(ime.HeaderText);
            cbKolona.Items.Add(prz.HeaderText);
            cbKolona.Items.Add(jmbg.HeaderText);
            cbKolona.Items.Add(izblek.HeaderText);
            cbKolona.SelectedIndex = 0;
            popuniGrid();
            dgwSpisakPrimPac.ClearSelection();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void popuniGrid() {
          
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

                        sql = "SELECT * FROM PRIJEM_PACIJENTA,PACIJENT,LEKAR_OPSTE_MEDICINE,IZBOR_LEKARA WHERE"
                            +" PRIJEM_PACIJENTA.JMBGP=PACIJENT.JMBGP AND PRIJEM_PACIJENTA.JMBGP=IZBOR_LEKARA.JMBGP"
                            +" AND LEKAR_OPSTE_MEDICINE.ID_ZR=IZBOR_LEKARA.ID_ZR";

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
                                         reader["JMBGP"].ToString(),
                                         reader["IME"].ToString()+" "+reader["PRZ"].ToString()+" "+reader["ID_ZR"].ToString()
                                      };

                            dgwSpisakPrimPac.Rows.Add(podaci);
                        }

                    }
                    catch (Exception)
                    {

                        throw;
                    }

                connection.Close();
            }
        }

        private void btnPon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            dgwSpisakPrimPac.ClearSelection();
            dgwSpisakPrimPac.Rows[dgwSpisakPrimPac.RowCount - 1].Selected = true;
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            dgwSpisakPrimPac.ClearSelection();
            dgwSpisakPrimPac.Rows[0].Selected = true;
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            int selIndex = dgwSpisakPrimPac.SelectedRows[0].Index;
            if (selIndex != dgwSpisakPrimPac.RowCount - 1)
            {
                int newSelIndex = selIndex + 1;
                dgwSpisakPrimPac.ClearSelection();
                dgwSpisakPrimPac.Rows[newSelIndex].Selected = true;
            }
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            int selIndex = dgwSpisakPrimPac.SelectedRows[0].Index;
            if (selIndex != 0)
            {
                int newSelIndex = selIndex - 1;
                dgwSpisakPrimPac.ClearSelection();
                dgwSpisakPrimPac.Rows[newSelIndex].Selected = true;
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            PrijemPacReg ep = new PrijemPacReg();
            DialogResult dr = ep.ShowDialog();
            this.Opacity = .70;
            if (dr == DialogResult.Cancel)
                this.Opacity = 1;
            else if (dr == DialogResult.OK)
            {
                dgwSpisakPrimPac.Rows.Clear();
                popuniGrid();
                this.Opacity = 1;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            EvidencijaPacijenta ep = new EvidencijaPacijenta("sa_protokola");
            DialogResult dr = ep.ShowDialog();
            this.Opacity = .70;
            if (dr == DialogResult.Cancel)
                this.Opacity = 1;
            else if (dr == DialogResult.OK)
            {
                PrijemPacReg pp = new PrijemPacReg(jmbg_pac);
                DialogResult drr = pp.ShowDialog();
                this.Opacity = .70;
                if (drr == DialogResult.Cancel)
                    this.Opacity = 1;
                else if (drr == DialogResult.OK)
                {
                    dgwSpisakPrimPac.Rows.Clear();
                    popuniGrid();
                    this.Opacity = 1;
                }
            }
        }

        private void tsPretraga_TextChanged(object sender, EventArgs e)
        {
            string kriterijumZaPretragu = tsPretraga.Text;

            List<string[]> newValues = filtrirajListu(kriterijumZaPretragu);


            dgwSpisakPrimPac.Rows.Clear();

            foreach (string[] data in newValues)
            {
                dgwSpisakPrimPac.Rows.Add(data);
            }
        }


        private List<string[]> filtrirajListu(string kriterijumZaPretragu)
        {
            List<string[]> rez = new List<string[]>();

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
                    sql = "SELECT * FROM PRIJEM_PACIJENTA,PACIJENT,LEKAR_OPSTE_MEDICINE,IZBOR_LEKARA WHERE"
                         + " PRIJEM_PACIJENTA.JMBGP=PACIJENT.JMBGP AND PRIJEM_PACIJENTA.JMBGP=IZBOR_LEKARA.JMBGP"
                         + " AND LEKAR_OPSTE_MEDICINE.ID_ZR=IZBOR_LEKARA.ID_ZR";


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
                        if ((reader["IMEP"].ToString().ToLower()).Contains(kriterijumZaPretragu.ToLower()) ||
                           (reader["PRZP"].ToString().ToLower()).Contains(kriterijumZaPretragu.ToLower()) ||
                           (reader["JMBGP"].ToString().ToLower()).Contains(kriterijumZaPretragu.ToLower()) ||
                           (reader["ID_ZR"].ToString().ToLower()).Contains(kriterijumZaPretragu.ToLower()) ||
                           (reader["IME"].ToString().ToLower()).Contains(kriterijumZaPretragu.ToLower()) ||
                           (reader["PRZ"].ToString().ToLower()).Contains(kriterijumZaPretragu.ToLower()))
                        {
                            String[] podaci = {  reader["IMEP"].ToString(),
                                         reader["PRZP"].ToString(),
                                         reader["JMBGP"].ToString(),
                                         reader["IME"].ToString()+" "+reader["PRZ"].ToString()+" "+reader["ID_ZR"].ToString()
                                      };

                            rez.Add(podaci);
                        }

                    }



                }
                catch (Exception)
                {

                    throw;
                }

                connection.Close();
            }

            return rez;
        }

    
    }
}
