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
    public partial class PruzeneUsluge : Form
    {
        private List<string> lekari = new List<string>();
        // private List<string> brpacijenti = new List<string>();
        public PruzeneUsluge()
        {
            InitializeComponent();
        }

        private void PrimljeniPac_Load(object sender, EventArgs e)
        {

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

                    sql = "SELECT count(*) FROM PRIJEM_PACIJENTA WHERE DATUM_PRIJEMA BETWEEN '" + mtbDatOd.Value.ToString("dd-MMM-yyyy") + "' AND '" + mtbDatDo.Value.ToString("dd-MMM-yyyy") + "'";

                    command = new OracleCommand(sql);
                    command.Connection = connection;
                    reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        lbUkupno.Text += "  " + reader[0].ToString();
                    }

                    sql = "SELECT count(*) FROM RECEPT WHERE DATIZD BETWEEN '" + mtbDatOd.Value.ToString("dd-MMM-yyyy") + "' AND '" + mtbDatDo.Value.ToString("dd-MMM-yyyy") + "'";

                    command = new OracleCommand(sql);
                    command.Connection = connection;
                    reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        lbUkRec.Text += "  " + reader[0].ToString();
                    }

                    sql = "SELECT count(*) FROM UPUT WHERE DAT_IZD_UPUT BETWEEN '" + mtbDatOd.Value.ToString("dd-MMM-yyyy") + "' AND '" + mtbDatDo.Value.ToString("dd-MMM-yyyy") + "'";

                    command = new OracleCommand(sql);
                    command.Connection = connection;
                    reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        lbUkUput.Text += "  " + reader[0].ToString();
                    }
                }
                catch (Exception)
                {

                    throw;
                }



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
                            lekibrpac[i] = reader2["IME"].ToString() + " " + reader2["PRZ"].ToString();
                            i++;
                        }

                        sql = "SELECT count(*) FROM PRIJEM_PACIJENTA WHERE DATUM_PRIJEMA BETWEEN '" + mtbDatOd.Value.ToString("dd-MMM-yyyy") + "' AND '" + mtbDatDo.Value.ToString("dd-MMM-yyyy") + "'"
                              + "AND ID_ZR='" + reader1["ID_ZR"].ToString() + "'";

                        command = new OracleCommand(sql);
                        command.Connection = connection;
                        reader2 = command.ExecuteReader();

                        if (reader2.Read())
                        {
                            lekibrpac[i] = reader2[0].ToString();
                            i++;
                        }

                        sql = "SELECT count(*) FROM RECEPT WHERE DATIZD BETWEEN '" + mtbDatOd.Value.ToString("dd-MMM-yyyy") + "' AND '" + mtbDatDo.Value.ToString("dd-MMM-yyyy") + "'"
                              + "AND ID_ZR='" + reader1["ID_ZR"].ToString() + "'";


                        command = new OracleCommand(sql);
                        command.Connection = connection;
                        reader2 = command.ExecuteReader();

                        if (reader2.Read())
                        {
                            lekibrpac[i] = reader2[0].ToString();
                            i++;
                        }


                        sql = "SELECT count(*) FROM UPUT WHERE DAT_IZD_UPUT BETWEEN '" + mtbDatOd.Value.ToString("dd-MMM-yyyy") + "' AND '" + mtbDatDo.Value.ToString("dd-MMM-yyyy") + "'"
                              + "AND ID_ZR='" + reader1["ID_ZR"].ToString() + "'";

                        command = new OracleCommand(sql);
                        command.Connection = connection;
                        reader2 = command.ExecuteReader();

                        if (reader2.Read())
                        {
                            lekibrpac[i] = reader2[0].ToString();
                            i = 0;
                        }

                        dgwPrimPac.Rows.Add(lekibrpac);

                        foreach (DataGridViewRow dgvr in dgwPrimPac.Rows)
                        {
                            if (dgvr.Cells[1].Value.ToString() == ("0") && dgvr.Cells[2].Value.ToString() == ("0")  && dgvr.Cells[3].Value.ToString() == ("0"))
                            {
                                 dgwPrimPac.Rows.Remove(dgvr);
                                //dgvr.DefaultCellStyle.ForeColor = Color.Red;
                            }
                        }

                        dgwPrimPac.ClearSelection();
                    }
                }
                catch (Exception)
                {
                    throw;
                }

                this.Refresh();
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);

        //    Graphics gr = e.Graphics;
        //  //  gr.FillRectangle(Brushes.White, this.ClientRectangle);


        //        int x = 140;
        //        int y = 0;
        //        Rectangle rec = this.ClientRectangle;
        //        int width = rec.Width;
        //        int height = rec.Height;

        //     //   Font f1 = new Font(FontFamily.GenericSerif, 12);
        //     //   gr.DrawString("AAAAAAAA", f1, Brushes.Black, 20, 185);


        //        gr.DrawLine(Pens.White, 12, 180, width-12, 180);
        //       // gr.DrawLine(Pens.Gray, width - 142, 0, width - 142, height);
        //        Font f = new Font(FontFamily.GenericSansSerif, 8.25f);
        //        gr.DrawString("Lekar        Br.Pacijenata", f, Brushes.Gray, 20, 185 + y);
        //        gr.DrawLine(Pens.White, 12, 200, width - 12, 200);
        //        foreach (string lek in lekari)
        //        {
        //            gr.DrawString(lek, f, Brushes.Black, 20, 205 + y);                 
        //            y += 20;

        //        }


        //}

    }
}
