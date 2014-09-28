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
    public partial class UtrosenaSredstva : Form
    {
        public UtrosenaSredstva()
        {
            InitializeComponent();
        }

        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            dgwPrimPac.ClearSelection();
            string sql = "";
            String[] lekibrpac = new String[4];
            int i = 0;
            string connectionString = DBConnection.GetConnectionString();
            using (OracleConnection connection = new OracleConnection())
            {

                connection.ConnectionString = connectionString;
                connection.Open();
                OracleCommand command;
                OracleDataReader reader;
                OracleDataReader reader1;
                OracleDataReader reader2;


                try
                {

                   

                    sql = "SELECT count(*) FROM RECEPT WHERE extract(month from DATIZD) =  '"
                        + DateTime.ParseExact(cbMes.SelectedItem.ToString(), "MMM", System.Globalization.CultureInfo.InvariantCulture).Month + "'";

                    command = new OracleCommand(sql);
                    command.Connection = connection;
                    reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        lbUkRec.Text += "  " + reader[0].ToString();
                    }

                    sql = "SELECT SUM(IZNOS) FROM RECEPT WHERE extract(month from DATIZD) =  '"
                        + DateTime.ParseExact(cbMes.SelectedItem.ToString(), "MMM", System.Globalization.CultureInfo.InvariantCulture).Month + "'";

                    command = new OracleCommand(sql);
                    command.Connection = connection;
                    reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        lbUkIznos.Text += "  " + reader[0].ToString();
                    }
                }
                catch (Exception)
                {

                    throw;
                }

 #region po_lekarima
                try
                {
                    sql = "SELECT DISTINCT ID_ZR FROM LEKAR_OPSTE_MEDICINE";

                    command = new OracleCommand(sql);
                    command.Connection = connection;
                    reader1 = command.ExecuteReader();



                    while (reader1.Read())
                    {

                        sql = "SELECT * FROM LEKAR_OPSTE_MEDICINE WHERE ID_ZR='" + reader1["ID_ZR"].ToString() + "'";

                        command = new OracleCommand(sql);
                        command.Connection = connection;
                        reader2 = command.ExecuteReader();

                        if (reader2.Read())
                        {
                            lekibrpac[i] = reader2["IME"].ToString() + " " + reader2["PRZ"].ToString() + " " + reader2["ID_ZR"].ToString();
                            i++;
                        }


                        sql = "SELECT count(*) FROM RECEPT WHERE extract(month from DATIZD) =  '"
                             + DateTime.ParseExact(cbMes.SelectedItem.ToString(), "MMM", System.Globalization.CultureInfo.InvariantCulture).Month + "'"
                              + "AND ID_ZR='" + reader1["ID_ZR"].ToString() + "'";


                        command = new OracleCommand(sql);
                        command.Connection = connection;
                        reader2 = command.ExecuteReader();

                        if (reader2.Read())
                        {
                            lekibrpac[i] = reader2[0].ToString();
                            i++;
                        }


                        sql = "SELECT SUM(IZNOS) FROM RECEPT WHERE extract(month from DATIZD) =  '"
                             + DateTime.ParseExact(cbMes.SelectedItem.ToString(), "MMM", System.Globalization.CultureInfo.InvariantCulture).Month + "'"
                              + "AND ID_ZR='" + reader1["ID_ZR"].ToString() + "'";

                        command = new OracleCommand(sql);
                        command.Connection = connection;
                        reader2 = command.ExecuteReader();

                        if (reader2.Read())
                        {
                            lekibrpac[i] = reader2[0].ToString();
                            i++;
                            string izn = reader2[0].ToString();
                            double prekoraceno = 0;
                            if (!izn.Equals(""))
                            {
                                double iznos = Double.Parse(izn);
                                if (DBConnection.dozvoljeno-iznos <= 0)
                                {
                                    prekoraceno = iznos - DBConnection.dozvoljeno;
                                }
                            }
                            lekibrpac[i] = prekoraceno.ToString();
                            i = 0;
                        }

                        dgwPrimPac.Rows.Add(lekibrpac);

                        foreach (DataGridViewRow dgvr in dgwPrimPac.Rows)
                        {
                            if (dgvr.Cells[1].Value.ToString() == ("0"))
                            {
                                dgwPrimPac.Rows.Remove(dgvr);
                            }
                            else if (dgvr.Cells[3].Value.ToString() != ("0"))
                            {
                                dgvr.DefaultCellStyle.BackColor = Color.LightCoral;
                            }


                        }

                        dgwPrimPac.ClearSelection();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
 #endregion
                this.Refresh();
                connection.Close();
            }
        }

        private void RecIIznos_Load(object sender, EventArgs e)
        {

        }

        private void dgwPrimPac_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 4)
            {
                DataGridViewRow selectedRow = dgwPrimPac.Rows[e.RowIndex];
                string[] lekar = selectedRow.Cells[0].Value.ToString().Split(' ');
                string id_lekara = lekar[2];
                Sugestije sug = new Sugestije(id_lekara,cbMes.SelectedItem.ToString());
                sug.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }


    }
}
