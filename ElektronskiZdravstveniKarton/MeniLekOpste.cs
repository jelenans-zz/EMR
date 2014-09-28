using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ElektronskiZdravstveniKarton
{
    public partial class MeniLekOpste : Form
    {
        string idlek = "";
        public MeniLekOpste(string idl)
        {
            InitializeComponent();
            idlek = idl;
        }

        private void btnPacPrijem_Click(object sender, EventArgs e)
        {
            PacZaPrijem meni = new PacZaPrijem(idlek);
            meni.ShowDialog();
           // this.Close();
        }

        private void btnPrepRecUp_Click(object sender, EventArgs e)
        {
            PrepRecUp meni = new PrepRecUp(idlek);
            meni.ShowDialog();
            //this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
