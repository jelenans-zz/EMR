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
    public partial class ReceptSnim : Form
    {
        String recup = "";
        private string p;
        private bool p_2;
        public ReceptSnim(String rec_up)
        {
            InitializeComponent();
            recup = rec_up;
        }

        public ReceptSnim(string p, bool p_2)
        {
            InitializeComponent();
            lbSnimRecept.Visible = true;
            lbSnimRecept.Text = p;
            recup = p;
            this.p = p;
            this.p_2 = p_2;
        }

        private void ReceptSnim_Load(object sender, EventArgs e)
        {
            if (p_2)
            {
                button1.Visible = false;
                button2.Text = "Zatvori";
            }

            lbSnimRecept.Text = recup;
            if (recup.Equals("Nemate administratorsko pravo"))
            {
                button1.Visible = false;
                button2.Text="OK";

            }
            else if (recup.Equals("Uspešno izmenjena lozinka"))
            {
                button1.Visible = false;
                button2.Text = "OK";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
