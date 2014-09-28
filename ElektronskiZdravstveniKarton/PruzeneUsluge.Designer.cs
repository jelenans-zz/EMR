namespace ElektronskiZdravstveniKarton
{
    partial class PruzeneUsluge
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mtbDatDo = new System.Windows.Forms.DateTimePicker();
            this.mtbDatOd = new System.Windows.Forms.DateTimePicker();
            this.btnPrikaz = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbUkUput = new System.Windows.Forms.Label();
            this.lbUkRec = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgwPrimPac = new System.Windows.Forms.DataGridView();
            this.lbUkupno = new System.Windows.Forms.Label();
            this.lekar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brPac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojPrepRecep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojPrepUp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrimPac)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mtbDatDo);
            this.groupBox3.Controls.Add(this.mtbDatOd);
            this.groupBox3.Controls.Add(this.btnPrikaz);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(2, 31);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(729, 77);
            this.groupBox3.TabIndex = 84;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Period";
            // 
            // mtbDatDo
            // 
            this.mtbDatDo.CustomFormat = "dd-MM-yyyy";
            this.mtbDatDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mtbDatDo.Location = new System.Drawing.Point(322, 30);
            this.mtbDatDo.Name = "mtbDatDo";
            this.mtbDatDo.Size = new System.Drawing.Size(165, 26);
            this.mtbDatDo.TabIndex = 88;
            // 
            // mtbDatOd
            // 
            this.mtbDatOd.CustomFormat = "dd-MM-yyyy";
            this.mtbDatOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mtbDatOd.Location = new System.Drawing.Point(57, 30);
            this.mtbDatOd.Name = "mtbDatOd";
            this.mtbDatOd.Size = new System.Drawing.Size(165, 26);
            this.mtbDatOd.TabIndex = 86;
            // 
            // btnPrikaz
            // 
            this.btnPrikaz.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPrikaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaz.Location = new System.Drawing.Point(569, 27);
            this.btnPrikaz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrikaz.Name = "btnPrikaz";
            this.btnPrikaz.Size = new System.Drawing.Size(138, 36);
            this.btnPrikaz.TabIndex = 85;
            this.btnPrikaz.Text = "Prikaži";
            this.btnPrikaz.UseVisualStyleBackColor = false;
            this.btnPrikaz.Click += new System.EventHandler(this.btnPrikaz_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "do:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "od:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(575, 490);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 42);
            this.button2.TabIndex = 85;
            this.button2.Text = "Zatvori";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbUkUput);
            this.groupBox1.Controls.Add(this.lbUkRec);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lbUkupno);
            this.groupBox1.Location = new System.Drawing.Point(2, 128);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(729, 340);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ukupno:";
            // 
            // lbUkUput
            // 
            this.lbUkUput.AutoSize = true;
            this.lbUkUput.Location = new System.Drawing.Point(494, 48);
            this.lbUkUput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUkUput.Name = "lbUkUput";
            this.lbUkUput.Size = new System.Drawing.Size(132, 20);
            this.lbUkUput.TabIndex = 92;
            this.lbUkUput.Text = "Propisanih uputa:";
            // 
            // lbUkRec
            // 
            this.lbUkRec.AutoSize = true;
            this.lbUkRec.Location = new System.Drawing.Point(243, 48);
            this.lbUkRec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUkRec.Name = "lbUkRec";
            this.lbUkRec.Size = new System.Drawing.Size(154, 20);
            this.lbUkRec.TabIndex = 91;
            this.lbUkRec.Text = "Propisanih recepata:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgwPrimPac);
            this.groupBox2.Location = new System.Drawing.Point(0, 95);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(724, 243);
            this.groupBox2.TabIndex = 90;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Po lekarima";
            // 
            // dgwPrimPac
            // 
            this.dgwPrimPac.AllowUserToAddRows = false;
            this.dgwPrimPac.AllowUserToDeleteRows = false;
            this.dgwPrimPac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPrimPac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lekar,
            this.brPac,
            this.BrojPrepRecep,
            this.BrojPrepUp});
            this.dgwPrimPac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwPrimPac.Location = new System.Drawing.Point(4, 24);
            this.dgwPrimPac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgwPrimPac.Name = "dgwPrimPac";
            this.dgwPrimPac.ReadOnly = true;
            this.dgwPrimPac.RowHeadersVisible = false;
            this.dgwPrimPac.RowTemplate.Height = 28;
            this.dgwPrimPac.Size = new System.Drawing.Size(716, 214);
            this.dgwPrimPac.TabIndex = 0;
            // 
            // lbUkupno
            // 
            this.lbUkupno.AutoSize = true;
            this.lbUkupno.Location = new System.Drawing.Point(9, 48);
            this.lbUkupno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUkupno.Name = "lbUkupno";
            this.lbUkupno.Size = new System.Drawing.Size(157, 20);
            this.lbUkupno.TabIndex = 89;
            this.lbUkupno.Text = "Primljenih pacijenata:";
            // 
            // lekar
            // 
            this.lekar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lekar.HeaderText = "Lekar";
            this.lekar.Name = "lekar";
            this.lekar.ReadOnly = true;
            // 
            // brPac
            // 
            this.brPac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.brPac.HeaderText = "Pacijenata";
            this.brPac.Name = "brPac";
            this.brPac.ReadOnly = true;
            // 
            // BrojPrepRecep
            // 
            this.BrojPrepRecep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojPrepRecep.HeaderText = "Prop.recepata";
            this.BrojPrepRecep.Name = "BrojPrepRecep";
            this.BrojPrepRecep.ReadOnly = true;
            // 
            // BrojPrepUp
            // 
            this.BrojPrepUp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojPrepUp.HeaderText = "Prop.uputa";
            this.BrojPrepUp.Name = "BrojPrepUp";
            this.BrojPrepUp.ReadOnly = true;
            // 
            // PruzeneUsluge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(732, 558);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PruzeneUsluge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pružene usluge";
            this.Load += new System.EventHandler(this.PrimljeniPac_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrimPac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPrikaz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgwPrimPac;
        private System.Windows.Forms.Label lbUkupno;
        private System.Windows.Forms.DateTimePicker mtbDatOd;
        private System.Windows.Forms.DateTimePicker mtbDatDo;
        private System.Windows.Forms.Label lbUkUput;
        private System.Windows.Forms.Label lbUkRec;
        private System.Windows.Forms.DataGridViewTextBoxColumn lekar;
        private System.Windows.Forms.DataGridViewTextBoxColumn brPac;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojPrepRecep;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojPrepUp;
    }
}