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
    public partial class PacZaPrijem : Form
    {
        public static string[] ListaPacZaPrij;
        private string idlekara="";

        public PacZaPrijem()
        {
            InitializeComponent();
          
        }

        public PacZaPrijem(string idlek)
        {
            InitializeComponent();
            idlekara = idlek;
        }



        private void MeniLekOpste_Load(object sender, EventArgs e)
        {
            mtbDatOpsta.Text = DateTime.Today.ToString("dd-MMM-yyyy");
            popuniGrid();
            bindingNavigatorMoveNextItem.Enabled = true;
            bindingNavigatorMovePreviousItem.Enabled = true;
            bindingNavigatorMoveLastItem.Enabled = true;
            bindingNavigatorMoveFirstItem.Enabled = true;
            dgwSpisPacZaPrij.ClearSelection();
        }

        private void popuniGrid()
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

                    sql = "SELECT * FROM PRIJEM_PACIJENTA,PACIJENT,LEKAR_OPSTE_MEDICINE,IZBOR_LEKARA WHERE PRIJEM_PACIJENTA.JMBGP=PACIJENT.JMBGP AND PRIJEM_PACIJENTA.JMBGP=IZBOR_LEKARA.JMBGP AND IZBOR_LEKARA.ID_ZR=LEKAR_OPSTE_MEDICINE.ID_ZR AND LEKAR_OPSTE_MEDICINE.ID_ZR='" + idlekara + "'"; // AND DATUM_PRIJEMA='"+mtbDatOpsta.Text+"'"

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
                        lbLekar.Text = reader["IME"].ToString() + " " + reader["PRZ"].ToString() + " " + reader["ID_ZR"].ToString();

                        String[] podaci = {  reader["IMEP"].ToString(),
                                         reader["PRZP"].ToString(),
                                         reader["JMBGP"].ToString(),
                                         reader["BRZK"].ToString()
                                      };

                        dgwSpisPacZaPrij.Rows.Add(podaci);
                    }

                }
                catch (Exception)
                {

                    throw;
                }

                connection.Close();
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
                    +" PRIJEM_PACIJENTA.JMBGP=PACIJENT.JMBGP AND PRIJEM_PACIJENTA.JMBGP=IZBOR_LEKARA.JMBGP"
                    +" AND IZBOR_LEKARA.ID_ZR=LEKAR_OPSTE_MEDICINE.ID_ZR AND LEKAR_OPSTE_MEDICINE.ID_ZR='"
                    + idlekara + "'"; // AND DATUM_PRIJEMA='"+mtbDatOpsta.Text+"'"


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
                           (reader["BRZK"].ToString().ToLower()).Contains(kriterijumZaPretragu.ToLower()))
                        {
                            String[] podaci = {  reader["IMEP"].ToString(),
                                         reader["PRZP"].ToString(),
                                         reader["JMBGP"].ToString(),
                                         reader["BRZK"].ToString()
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



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgwSpisPacZaPrij_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ZK zdravKarton = new ZK(dgwSpisPacZaPrij.SelectedRows[0].Cells[2].Value.ToString(), idlekara);
            zdravKarton.ShowDialog();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            int selIndex = dgwSpisPacZaPrij.SelectedRows[0].Index;
            if (selIndex != dgwSpisPacZaPrij.RowCount - 1)
            {
                int newSelIndex = selIndex + 1;
                dgwSpisPacZaPrij.ClearSelection();
                dgwSpisPacZaPrij.Rows[newSelIndex].Selected = true;
            }
        }




        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {

            dgwSpisPacZaPrij.ClearSelection();
            dgwSpisPacZaPrij.Rows[0].Selected = true;
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            dgwSpisPacZaPrij.ClearSelection();
            dgwSpisPacZaPrij.Rows[dgwSpisPacZaPrij.RowCount-1].Selected = true;
        }

        private void bindingNavigatorMovePreviousItem_Click_1(object sender, EventArgs e)
        {
            int selIndex = dgwSpisPacZaPrij.SelectedRows[0].Index;
            if (selIndex != 0)
            {
                int newSelIndex = selIndex - 1;
                dgwSpisPacZaPrij.ClearSelection();
                dgwSpisPacZaPrij.Rows[newSelIndex].Selected = true;
            }
        }

        private void tsSearchPac_TextChanged(object sender, EventArgs e)
        {
            string kriterijumZaPretragu = tsSearchPac.Text;

            List<string[]> newValues = filtrirajListu(kriterijumZaPretragu);


            dgwSpisPacZaPrij.Rows.Clear();

            foreach (string[] data in newValues)
            {
                dgwSpisPacZaPrij.Rows.Add(data);
            }
        }

 

  
    }
}
