using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client; // ODP.NET Oracle managed provider
using Oracle.DataAccess.Types;

namespace ElektronskiZdravstveniKarton
{
    public partial class StatusPregled : Form
    {


        public string ucitanTekst = "";

        public StatusPregled()
        {
            InitializeComponent();
        }

        private void StatusPregled_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgwIzabraneStavke.Columns.Add(column);
            dgwIzabraneStavke.RowHeadersVisible = false;
            dgwIzabraneStavke.ColumnHeadersVisible = false;
            dgwIzabraneStavke.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgwIzabraneStavke.AllowUserToAddRows = false;
            dgwIzabraneStavke.AllowUserToDeleteRows = false;
            popuniGrid();
            dgwIzabraneStavke.ClearSelection();
            dgwStav.ClearSelection();

            this.StartPosition = FormStartPosition.CenterScreen;
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

                    sql = "SELECT * FROM STATUS_PREGLED";

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
                    int dx = 0;
                    int dy = 0;
                   
                    int triUredu = 0;
                    bool prva = true;
                    int brBtn = 0;
                    DataGridView dgwTmp = new DataGridView();
                    Button btnDod = new Button();
                    Button btnDodSve = new Button();
                    foreach (Control ctrl2 in gbPal.Controls.Find("dgwStav", true))
                    {
                        if (ctrl2 is DataGridView)
                        {
                            dgwTmp = (DataGridView)ctrl2;
                            break;
                        }
                    }


                    while (reader.Read())
                    {
                        if (triUredu == 3)
                        {
                            dy+=gbPal.Height;
                            dx = 0;
                        }

                        splitContainer1.Panel2.SuspendLayout();
                        GroupBox gbOblasT = new GroupBox();
                        gbOblasT.Size = gbPal.Size;
                        gbOblasT.Text = reader["OBLAST"].ToString();
                        gbOblasT.Location = new Point(gbPal.Location.X+dx, gbPal.Location.Y+dy);
                        if (!prva)
                        {
                            this.Width += gbOblasT.Width + 3;
                            splitContainer1.Width += gbOblasT.Width + 3;
                            btnPotvrdi.Location = new Point(this.Width - 212,btnPotvrdi.Location.Y);
                            btnOdustani.Location = new Point(this.Width - 122, btnOdustani.Location.Y);
                        }

                        dx += gbOblasT.Width + 3;
                        splitContainer1.SplitterDistance = splitContainer1.Width - (splitContainer1.Width-splitContainer1.Panel1.Width);
                        DataGridView dgw = null;

                        Control ctrlTmp= new Control();

                        foreach (Control ctrl in gbPal.Controls)
                        {
                            if (!(ctrl is DataGridView))
                            {
                                if (ctrl is Label)
                                {
                                    ctrlTmp = (Label)ctrl;

                                    Label lab = new Label();
                                    lab.Location = ctrlTmp.Location;
                                    lab.Size = ctrlTmp.Size;
                                    lab.Text = ctrlTmp.Text;
                                    gbOblasT.Controls.Add(lab);
                                }
                                else if (ctrl is TextBox)
                                {
                                    ctrlTmp = (TextBox)ctrl;

                                    TextBox tb = new TextBox();
                                    tb.Location = ctrlTmp.Location;
                                    tb.Size = ctrlTmp.Size;
                                    tb.Name = "tbPret" + brBtn;
                                    tb.TextChanged += new System.EventHandler(textBox1_TextChanged);
                                    brBtn++;
                                    gbOblasT.Controls.Add(tb);
                                }
                                else if (ctrl is Button)
                                {
                                    foreach (Control ctrl2 in gbPal.Controls.Find("btnDodaj", true))
                                    {
                                        if (ctrl2 is Button)
                                        {
                                            btnDod = (Button)ctrl2;
                                            Button btn = new Button();
                                            btn.Location = btnDod.Location;
                                            btn.Size = btnDod.Size;
                                            btn.Text = btnDod.Text;
                                            btn.Name = "btnDod"+brBtn;
                                            brBtn++;
                                            btn.MouseClick += new MouseEventHandler(btnDodaj_Click);
                                            gbOblasT.Controls.Add(btn);
                                            break;
                                        }
                                    }

                                    foreach (Control ctrl2 in gbPal.Controls.Find("btnDodajSve", true))
                                    {
                                        if (ctrl2 is Button)
                                        {
                                            btnDodSve = (Button)ctrl2;
                                            Button btn = new Button();
                                            btn.Location = btnDodSve.Location;
                                            btn.Size = btnDodSve.Size;
                                            btn.Text = btnDodSve.Text;
                                            btn.Name = "btnDodSve" + brBtn;
                                            brBtn++;
                                            btn.MouseClick += new MouseEventHandler(btnDodajSve_Click);
                                            gbOblasT.Controls.Add(btn);
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                        dgw = new DataGridView();                                       
                                        dgw.Size = dgwTmp.Size;
                                        dgw.Location = dgwTmp.Location;
                                        DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                        dgw.Columns.Add(column);
                                        dgw.RowHeadersVisible = false;
                                        dgw.ColumnHeadersVisible = false;
                                        dgw.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                                        dgw.AllowUserToAddRows = false;
                                        dgw.AllowUserToDeleteRows = false;
                                        dgw.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                                        dgw.MultiSelect = false;
                                        dgw.ReadOnly = true;
                                        dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                                        dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                                        dgw.TabIndex = 0;
                                        dgw.Name = "dgwStavke" + brBtn;
                                        brBtn++;
                                        gbOblasT.Visible = true;
                                        string[] podaci = reader["STAVKE"].ToString().Split('\n');
                                        dgw.Rows.Clear();
                                        foreach (string podatak in podaci)
                                        {
                                            dgw.Rows.Add(podatak);
                                        }
                                        dgw.CellClick += new DataGridViewCellEventHandler(dgwStavke_CellClick);
                                        gbOblasT.Controls.Add(dgw);
                                        dgw.ClearSelection();
                                    }
                        }

                        triUredu++;
                        prva = false;
                        splitContainer1.Panel2.Controls.Add(gbOblasT);
                        splitContainer1.Panel2.ResumeLayout(false);
                        splitContainer1.Panel2.Refresh();

                    }
             

                }
                catch (Exception)
                {

                    throw;
                }

                connection.Close();
            }
        }


        public static object Clone_Control(object o)
        {

            Type type = o.GetType();
            PropertyInfo[] properties = type.GetProperties();
            Object retObject = type.InvokeMember("", System.Reflection.BindingFlags.CreateInstance, null, o, null);
            foreach (PropertyInfo propertyInfo in properties)
            {
                if (propertyInfo.CanWrite)
                {
                    propertyInfo.SetValue(retObject, propertyInfo.GetValue(o, null), null);
                }
            }
            return retObject;
        }



        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string selekRed="";

        private void dgwStavke_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            selekRed =  ((DataGridView)sender).SelectedRows[0].Cells[0].Value.ToString();
            //((DataGridView)sender).ClearSelection();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            dgwIzabraneStavke.Rows.Add(selekRed);
            dgwIzabraneStavke.ClearSelection();
        }

        private void btnDodajSve_Click(object sender, EventArgs e)
        {
            Control par = (Control)((Button)sender).Parent;
            GroupBox gbParent= new GroupBox();

            if (par is GroupBox)
                gbParent = (GroupBox)par;

            foreach (Control ctrl in gbParent.Controls)
            {
                if (ctrl is DataGridView)
                {
                    DataGridView dgwTheOne = (DataGridView)ctrl;

                    foreach (DataGridViewRow dr in dgwTheOne.Rows)
                    {
                        dgwIzabraneStavke.Rows.Add(dr.Cells[0].Value.ToString());
                    }

                    dgwIzabraneStavke.ClearSelection();
                    dgwTheOne.ClearSelection();
                    break;
                }
            }


        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            dgwIzabraneStavke.Rows.Remove(dgwIzabraneStavke.SelectedRows[0]);
            dgwIzabraneStavke.ClearSelection();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow dr in dgwIzabraneStavke.Rows)
            {
                ucitanTekst += dr.Cells[0].Value.ToString() + ",";
            }
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string kriterijumZaPretragu = ((TextBox)sender).Text;

          
            
            Control par = (Control)((TextBox)sender).Parent;
            GroupBox gbParent = new GroupBox();

            if (par is GroupBox)
                gbParent = (GroupBox)par;
            List<string> newValues = filtrirajListu(kriterijumZaPretragu, gbParent.Text);
    
            foreach (Control ctrl in gbParent.Controls)
            {
                if (ctrl is DataGridView)
                {
                    DataGridView dgwTheOne = (DataGridView)ctrl;
                    dgwTheOne.Rows.Clear();

                    foreach (string data in newValues)
                    {
                        dgwTheOne.Rows.Add(data);
                    }
                  
                    dgwTheOne.ClearSelection();
                    break;
                }
            }

           
        }

        public static List<string> filtrirajListu(string kriterijumZaPretragu,string oblast)
        {
            List<string> rez = new List<string>();

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

                    sql = "SELECT * FROM STATUS_PREGLED WHERE OBLAST='" + oblast+"'";

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
                        string[] podaci =  reader["STAVKE"].ToString().Split('\n') ;
                        foreach(string podatak in podaci)
                            if(podatak.ToLower().Contains(kriterijumZaPretragu.ToLower()))
                                 rez.Add(podatak);
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
