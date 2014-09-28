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
    public partial class MeniMedSesTeh : Form
    {
        public MeniMedSesTeh()
        {
            InitializeComponent();
        }

        private void btnRegistrKor_Click(object sender, EventArgs e)
        {
            EvidencijaPacijenta ep = new EvidencijaPacijenta();
            DialogResult dr= ep.ShowDialog();
            this.Opacity = .70;
            if (dr == DialogResult.Cancel)
                this.Opacity = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Protokol ep = new Protokol();
            DialogResult dr = ep.ShowDialog();
            this.Opacity = .70;
            if (dr == DialogResult.Cancel)
                this.Opacity = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IzborLekara ep = new IzborLekara();
            DialogResult dr = ep.ShowDialog();
            if (dr == DialogResult.Cancel)
                this.Opacity = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPretrKor_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
