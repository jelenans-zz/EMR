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
    public partial class Pocetna : Form
    {
        int kor;
        public Pocetna()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {
            cbUlogujSeKao.Text = "Administrator";
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (cbUlogujSeKao.Text.Equals("Administrator"))
            {
                kor = 0;
                Prijava.vrsta = "Administrator";
            }
            else if (cbUlogujSeKao.Text.Equals("Lekar opšte medicine"))
            {
                kor = 1;
                Prijava.vrsta = "Lekar opšte medicine";
            }
            else if (cbUlogujSeKao.Text.Equals("Lekar specijalista"))
            {
                kor = 2;
                Prijava.vrsta = "Lekar specijalista";
            }
            else if (cbUlogujSeKao.Text.Equals("Medicinska sestra/tehničar"))
            {
                kor = 3;
                Prijava.vrsta = "Medicinska sestra/tehničar";
            }
            else if (cbUlogujSeKao.Text.Equals("Laborant"))
            {
                kor = 4;
                Prijava.vrsta = "Laborant";
            }

            Prijava rp = new Prijava(kor);
            this.Opacity = .70;
            DialogResult dr = rp.ShowDialog();
            if (dr == DialogResult.Cancel)
                this.Opacity = 1;
        }
    }
}
