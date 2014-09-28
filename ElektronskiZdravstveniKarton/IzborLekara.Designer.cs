namespace ElektronskiZdravstveniKarton
{
    partial class IzborLekara
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPon = new System.Windows.Forms.Button();
            this.btnSac = new System.Windows.Forms.Button();
            this.cbPacijent = new System.Windows.Forms.ComboBox();
            this.cbLekar = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtbDatIzbora = new System.Windows.Forms.DateTimePicker();
            this.cbRazlog = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbIdLek = new System.Windows.Forms.Label();
            this.lbJmbgp = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pacijent:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lekar:";
            // 
            // btnPon
            // 
            this.btnPon.Location = new System.Drawing.Point(246, 304);
            this.btnPon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPon.Name = "btnPon";
            this.btnPon.Size = new System.Drawing.Size(129, 43);
            this.btnPon.TabIndex = 70;
            this.btnPon.Text = "Poništiti";
            this.btnPon.UseVisualStyleBackColor = true;
            this.btnPon.Click += new System.EventHandler(this.btnPon_Click);
            // 
            // btnSac
            // 
            this.btnSac.Location = new System.Drawing.Point(97, 304);
            this.btnSac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSac.Name = "btnSac";
            this.btnSac.Size = new System.Drawing.Size(126, 43);
            this.btnSac.TabIndex = 69;
            this.btnSac.Text = "Sačuvati";
            this.btnSac.UseVisualStyleBackColor = true;
            this.btnSac.Click += new System.EventHandler(this.btnSac_Click);
            // 
            // cbPacijent
            // 
            this.cbPacijent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPacijent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPacijent.FormattingEnabled = true;
            this.cbPacijent.Location = new System.Drawing.Point(126, 29);
            this.cbPacijent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPacijent.Name = "cbPacijent";
            this.cbPacijent.Size = new System.Drawing.Size(231, 28);
            this.cbPacijent.TabIndex = 71;
            // 
            // cbLekar
            // 
            this.cbLekar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbLekar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbLekar.FormattingEnabled = true;
            this.cbLekar.Location = new System.Drawing.Point(126, 91);
            this.cbLekar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbLekar.Name = "cbLekar";
            this.cbLekar.Size = new System.Drawing.Size(231, 28);
            this.cbLekar.TabIndex = 72;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.lbIdLek);
            this.groupBox1.Controls.Add(this.cbLekar);
            this.groupBox1.Controls.Add(this.cbPacijent);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(429, 267);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mtbDatIzbora);
            this.groupBox2.Controls.Add(this.cbRazlog);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(0, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 132);
            this.groupBox2.TabIndex = 78;
            this.groupBox2.TabStop = false;
            // 
            // mtbDatIzbora
            // 
            this.mtbDatIzbora.CustomFormat = "dd-MM-yyyy";
            this.mtbDatIzbora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbDatIzbora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mtbDatIzbora.Location = new System.Drawing.Point(126, 86);
            this.mtbDatIzbora.Name = "mtbDatIzbora";
            this.mtbDatIzbora.Size = new System.Drawing.Size(295, 26);
            this.mtbDatIzbora.TabIndex = 98;
            // 
            // cbRazlog
            // 
            this.cbRazlog.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbRazlog.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbRazlog.FormattingEnabled = true;
            this.cbRazlog.Location = new System.Drawing.Point(126, 27);
            this.cbRazlog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbRazlog.Name = "cbRazlog";
            this.cbRazlog.Size = new System.Drawing.Size(295, 28);
            this.cbRazlog.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 96;
            this.label4.Text = "Razlog:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 95;
            this.label3.Text = "Datum izbora:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(365, 90);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 36);
            this.button3.TabIndex = 93;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(365, 28);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 37);
            this.button2.TabIndex = 92;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbIdLek
            // 
            this.lbIdLek.AutoSize = true;
            this.lbIdLek.Location = new System.Drawing.Point(429, 118);
            this.lbIdLek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIdLek.Name = "lbIdLek";
            this.lbIdLek.Size = new System.Drawing.Size(0, 20);
            this.lbIdLek.TabIndex = 78;
            // 
            // lbJmbgp
            // 
            this.lbJmbgp.AutoSize = true;
            this.lbJmbgp.Location = new System.Drawing.Point(447, 89);
            this.lbJmbgp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbJmbgp.Name = "lbJmbgp";
            this.lbJmbgp.Size = new System.Drawing.Size(0, 20);
            this.lbJmbgp.TabIndex = 77;
            // 
            // IzborLekara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(474, 361);
            this.Controls.Add(this.lbJmbgp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPon);
            this.Controls.Add(this.btnSac);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "IzborLekara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Izbor Lekara";
            this.Load += new System.EventHandler(this.IzborLekara_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPon;
        private System.Windows.Forms.Button btnSac;
        private System.Windows.Forms.ComboBox cbPacijent;
        private System.Windows.Forms.ComboBox cbLekar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbIdLek;
        private System.Windows.Forms.Label lbJmbgp;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker mtbDatIzbora;
        private System.Windows.Forms.ComboBox cbRazlog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}