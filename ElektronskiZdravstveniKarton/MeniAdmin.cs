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
    public partial class MeniAdmin : Form
    {
        public MeniAdmin()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnRegistrKor_Click(object sender, EventArgs e)
        {

            Registracija rp = new Registracija();
            this.Opacity = .70;
            DialogResult dr = rp.ShowDialog();
            if (dr == DialogResult.Cancel)
                this.Opacity = 1;
        }

        private void btnPrimljeniPac_Click(object sender, EventArgs e)
        {
            PruzeneUsluge rp = new PruzeneUsluge();
            this.Opacity = .70;
            DialogResult dr = rp.ShowDialog();
            if (dr == DialogResult.Cancel)
                this.Opacity = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UtrosenaSredstva rp = new UtrosenaSredstva();
            this.Opacity = .70;
            DialogResult dr = rp.ShowDialog();
            if (dr == DialogResult.Cancel)
                this.Opacity = 1;
        }

     
     
     

     
    }
}
