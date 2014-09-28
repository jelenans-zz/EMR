namespace ElektronskiZdravstveniKarton
{
    partial class Registracija
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mtbJmbg = new System.Windows.Forms.MaskedTextBox();
            this.tbPrez = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbVrstaKor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbGrad = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbAdr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTel = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbIdZap = new System.Windows.Forms.MaskedTextBox();
            this.cbVrstaOdel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbUsr = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpDatRodj = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtbJmbg
            // 
            this.mtbJmbg.Location = new System.Drawing.Point(180, 148);
            this.mtbJmbg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtbJmbg.Mask = "0000000000000";
            this.mtbJmbg.Name = "mtbJmbg";
            this.mtbJmbg.Size = new System.Drawing.Size(232, 26);
            this.mtbJmbg.TabIndex = 4;
            // 
            // tbPrez
            // 
            this.tbPrez.Location = new System.Drawing.Point(180, 89);
            this.tbPrez.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPrez.Name = "tbPrez";
            this.tbPrez.Size = new System.Drawing.Size(232, 26);
            this.tbPrez.TabIndex = 3;
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(180, 29);
            this.tbIme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(232, 26);
            this.tbIme.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "JMBG:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ime: ";
            // 
            // cbVrstaKor
            // 
            this.cbVrstaKor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVrstaKor.FormattingEnabled = true;
            this.cbVrstaKor.Items.AddRange(new object[] {
            "Lekar opšte medicine",
            "Lekar specijalista",
            "Medicinska sestra/tehničar",
            "Laborant"});
            this.cbVrstaKor.Location = new System.Drawing.Point(180, 26);
            this.cbVrstaKor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbVrstaKor.Name = "cbVrstaKor";
            this.cbVrstaKor.Size = new System.Drawing.Size(232, 28);
            this.cbVrstaKor.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Vrsta korisnika:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDatRodj);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbTel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbIme);
            this.groupBox1.Controls.Add(this.tbPrez);
            this.groupBox1.Controls.Add(this.mtbJmbg);
            this.groupBox1.Location = new System.Drawing.Point(24, 100);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(438, 418);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbGrad);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.tbAdr);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(0, 306);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(436, 111);
            this.groupBox5.TabIndex = 39;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Prebivalište";
            // 
            // cbGrad
            // 
            this.cbGrad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbGrad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbGrad.FormattingEnabled = true;
            this.cbGrad.Items.AddRange(new object[] {
            "Beograd",
            "Valjevo",
            "Vranje",
            "Zaječar",
            "Zrenjanin",
            "Jagodina",
            "Kragujevac",
            "Kraljevo",
            "Kruševac",
            "Leskovac",
            "Loznica",
            "Niš",
            "Novi Pazar",
            "Novi Sad",
            "Pančevo",
            "Požarevac",
            "Priština",
            "Smederevo",
            "Sombor",
            "Sremska Mitrovica",
            "Subotica",
            "Užice",
            "Čačak",
            "Šabac"});
            this.cbGrad.Location = new System.Drawing.Point(180, 68);
            this.cbGrad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbGrad.Name = "cbGrad";
            this.cbGrad.Size = new System.Drawing.Size(232, 28);
            this.cbGrad.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 80);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 39;
            this.label10.Text = "Grad:";
            // 
            // tbAdr
            // 
            this.tbAdr.Location = new System.Drawing.Point(180, 29);
            this.tbAdr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAdr.Name = "tbAdr";
            this.tbAdr.Size = new System.Drawing.Size(232, 26);
            this.tbAdr.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Ulica:";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(18, 214);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Datum rođenja:";
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(180, 257);
            this.tbTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTel.Mask = "(999) 000-0000";
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(232, 26);
            this.tbTel.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbIdZap);
            this.groupBox3.Controls.Add(this.cbVrstaOdel);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(24, 508);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(438, 120);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            // 
            // tbIdZap
            // 
            this.tbIdZap.Location = new System.Drawing.Point(180, 76);
            this.tbIdZap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbIdZap.Mask = "00000000";
            this.tbIdZap.Name = "tbIdZap";
            this.tbIdZap.Size = new System.Drawing.Size(232, 26);
            this.tbIdZap.TabIndex = 12;
            // 
            // cbVrstaOdel
            // 
            this.cbVrstaOdel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbVrstaOdel.FormattingEnabled = true;
            this.cbVrstaOdel.Location = new System.Drawing.Point(180, 20);
            this.cbVrstaOdel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbVrstaOdel.Name = "cbVrstaOdel";
            this.cbVrstaOdel.Size = new System.Drawing.Size(232, 28);
            this.cbVrstaOdel.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "Odeljenje rada:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 69);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "ID zaposlenog:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 92);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 20);
            this.label13.TabIndex = 41;
            this.label13.Text = " (8 karaktera)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbVrstaKor);
            this.groupBox2.Location = new System.Drawing.Point(24, 32);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(438, 77);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(328, 695);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 45);
            this.button2.TabIndex = 16;
            this.button2.Text = "Poništiti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(186, 695);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 45);
            this.button1.TabIndex = 15;
            this.button1.Text = "Sačuvati";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbUsr);
            this.groupBox4.Controls.Add(this.tbPass);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(24, 620);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(438, 57);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            // 
            // tbUsr
            // 
            this.tbUsr.Location = new System.Drawing.Point(100, 17);
            this.tbUsr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUsr.Name = "tbUsr";
            this.tbUsr.Size = new System.Drawing.Size(107, 26);
            this.tbUsr.TabIndex = 13;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(291, 17);
            this.tbPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(121, 26);
            this.tbPass.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(215, 22);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Lozinka:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 22);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Korisn.ime:";
            // 
            // dtpDatRodj
            // 
            this.dtpDatRodj.CustomFormat = "dd-MM-yyyy";
            this.dtpDatRodj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatRodj.Location = new System.Drawing.Point(180, 207);
            this.dtpDatRodj.Name = "dtpDatRodj";
            this.dtpDatRodj.Size = new System.Drawing.Size(232, 26);
            this.dtpDatRodj.TabIndex = 40;
            // 
            // Registracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(508, 758);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Registracija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registracija korisnika";
            this.Load += new System.EventHandler(this.Registracija_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbJmbg;
        private System.Windows.Forms.TextBox tbPrez;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbVrstaKor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbUsr;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox tbTel;
        private System.Windows.Forms.ComboBox cbVrstaOdel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbGrad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbAdr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox tbIdZap;
        private System.Windows.Forms.DateTimePicker dtpDatRodj;
    }
}