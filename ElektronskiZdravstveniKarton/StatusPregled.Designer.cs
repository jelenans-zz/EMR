namespace ElektronskiZdravstveniKarton
{
    partial class StatusPregled
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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.dgwIzabraneStavke = new System.Windows.Forms.DataGridView();
            this.gbPal = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajSve = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgwStav = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIzabraneStavke)).BeginInit();
            this.gbPal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStav)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(335, 403);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(134, 45);
            this.btnOdustani.TabIndex = 45;
            this.btnOdustani.Text = "Odustati";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotvrdi.Location = new System.Drawing.Point(193, 403);
            this.btnPotvrdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(134, 45);
            this.btnPotvrdi.TabIndex = 44;
            this.btnPotvrdi.Text = "Potvrditi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 22);
            this.label2.TabIndex = 49;
            this.label2.Text = "Izabrane stavke:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(4, 47);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbPal);
            this.splitContainer1.Size = new System.Drawing.Size(465, 312);
            this.splitContainer1.SplitterDistance = 170;
            this.splitContainer1.TabIndex = 50;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUkloni);
            this.panel1.Controls.Add(this.dgwIzabraneStavke);
            this.panel1.Location = new System.Drawing.Point(3, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 276);
            this.panel1.TabIndex = 51;
            // 
            // btnUkloni
            // 
            this.btnUkloni.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUkloni.Location = new System.Drawing.Point(4, 233);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(152, 37);
            this.btnUkloni.TabIndex = 52;
            this.btnUkloni.Text = "Ukloni";
            this.btnUkloni.UseVisualStyleBackColor = false;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // dgwIzabraneStavke
            // 
            this.dgwIzabraneStavke.AllowUserToAddRows = false;
            this.dgwIzabraneStavke.AllowUserToDeleteRows = false;
            this.dgwIzabraneStavke.AllowUserToResizeColumns = false;
            this.dgwIzabraneStavke.AllowUserToResizeRows = false;
            this.dgwIzabraneStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwIzabraneStavke.Location = new System.Drawing.Point(0, 0);
            this.dgwIzabraneStavke.MultiSelect = false;
            this.dgwIzabraneStavke.Name = "dgwIzabraneStavke";
            this.dgwIzabraneStavke.ReadOnly = true;
            this.dgwIzabraneStavke.RowTemplate.Height = 28;
            this.dgwIzabraneStavke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwIzabraneStavke.Size = new System.Drawing.Size(156, 227);
            this.dgwIzabraneStavke.TabIndex = 0;
            // 
            // gbPal
            // 
            this.gbPal.Controls.Add(this.textBox1);
            this.gbPal.Controls.Add(this.label1);
            this.gbPal.Controls.Add(this.btnDodajSve);
            this.gbPal.Controls.Add(this.btnDodaj);
            this.gbPal.Controls.Add(this.dgwStav);
            this.gbPal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPal.Location = new System.Drawing.Point(14, 10);
            this.gbPal.Name = "gbPal";
            this.gbPal.Size = new System.Drawing.Size(240, 258);
            this.gbPal.TabIndex = 50;
            this.gbPal.TabStop = false;
            this.gbPal.Text = "Glava";
            this.gbPal.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 28);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pretraga:";
            // 
            // btnDodajSve
            // 
            this.btnDodajSve.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDodajSve.Location = new System.Drawing.Point(118, 213);
            this.btnDodajSve.Name = "btnDodajSve";
            this.btnDodajSve.Size = new System.Drawing.Size(118, 37);
            this.btnDodajSve.TabIndex = 50;
            this.btnDodajSve.Text = "Dodaj sve";
            this.btnDodajSve.UseVisualStyleBackColor = false;
            this.btnDodajSve.Click += new System.EventHandler(this.btnDodajSve_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDodaj.Location = new System.Drawing.Point(6, 213);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(106, 37);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgwStav
            // 
            this.dgwStav.AllowUserToAddRows = false;
            this.dgwStav.AllowUserToDeleteRows = false;
            this.dgwStav.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStav.Location = new System.Drawing.Point(2, 77);
            this.dgwStav.Name = "dgwStav";
            this.dgwStav.ReadOnly = true;
            this.dgwStav.RowHeadersVisible = false;
            this.dgwStav.RowTemplate.Height = 28;
            this.dgwStav.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwStav.Size = new System.Drawing.Size(236, 130);
            this.dgwStav.TabIndex = 1;
            // 
            // StatusPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(480, 462);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPotvrdi);
            this.HelpButton = true;
            this.Name = "StatusPregled";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Status-Pregled";
            this.Load += new System.EventHandler(this.StatusPregled_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwIzabraneStavke)).EndInit();
            this.gbPal.ResumeLayout(false);
            this.gbPal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStav)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgwIzabraneStavke;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.GroupBox gbPal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDodajSve;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgwStav;
    }
}