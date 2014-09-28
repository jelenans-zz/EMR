namespace ElektronskiZdravstveniKarton
{
    partial class SpisVakcina
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
            this.dgwNeprim = new System.Windows.Forms.DataGridView();
            this.siflek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazlek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orkollek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgwPrim = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.lbPac = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwNeprim)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrim)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwNeprim
            // 
            this.dgwNeprim.AllowUserToAddRows = false;
            this.dgwNeprim.AllowUserToDeleteRows = false;
            this.dgwNeprim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwNeprim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siflek,
            this.nazlek,
            this.orkollek});
            this.dgwNeprim.Location = new System.Drawing.Point(9, 48);
            this.dgwNeprim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgwNeprim.Name = "dgwNeprim";
            this.dgwNeprim.ReadOnly = true;
            this.dgwNeprim.RowHeadersVisible = false;
            this.dgwNeprim.RowTemplate.Height = 28;
            this.dgwNeprim.Size = new System.Drawing.Size(549, 132);
            this.dgwNeprim.TabIndex = 4;
            // 
            // siflek
            // 
            this.siflek.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.siflek.HeaderText = "Vrsta vakcine";
            this.siflek.MinimumWidth = 8;
            this.siflek.Name = "siflek";
            this.siflek.ReadOnly = true;
            // 
            // nazlek
            // 
            this.nazlek.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazlek.HeaderText = "Id vakcine";
            this.nazlek.Name = "nazlek";
            this.nazlek.ReadOnly = true;
            // 
            // orkollek
            // 
            this.orkollek.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orkollek.HeaderText = "Starosna granica";
            this.orkollek.MinimumWidth = 10;
            this.orkollek.Name = "orkollek";
            this.orkollek.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgwNeprim);
            this.groupBox1.Location = new System.Drawing.Point(8, 88);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(570, 206);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vakcine koje nisu primljene ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgwPrim);
            this.groupBox2.Location = new System.Drawing.Point(8, 303);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(570, 206);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Primljene vakcine";
            // 
            // dgwPrim
            // 
            this.dgwPrim.AllowUserToAddRows = false;
            this.dgwPrim.AllowUserToDeleteRows = false;
            this.dgwPrim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPrim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgwPrim.Location = new System.Drawing.Point(9, 48);
            this.dgwPrim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgwPrim.Name = "dgwPrim";
            this.dgwPrim.ReadOnly = true;
            this.dgwPrim.RowHeadersVisible = false;
            this.dgwPrim.RowTemplate.Height = 28;
            this.dgwPrim.Size = new System.Drawing.Size(549, 132);
            this.dgwPrim.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Vrsta vakcine";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Id vakcine";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Starosna granica";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(444, 523);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 42);
            this.button2.TabIndex = 77;
            this.button2.Text = "Zatvori";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbPac
            // 
            this.lbPac.AutoSize = true;
            this.lbPac.Location = new System.Drawing.Point(12, 25);
            this.lbPac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPac.Name = "lbPac";
            this.lbPac.Size = new System.Drawing.Size(81, 20);
            this.lbPac.TabIndex = 78;
            this.lbPac.Text = "Pacijent:   ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbPac);
            this.groupBox3.Location = new System.Drawing.Point(6, 23);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(572, 55);
            this.groupBox3.TabIndex = 79;
            this.groupBox3.TabStop = false;
            // 
            // SpisVakcina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(596, 580);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SpisVakcina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Spisak Vakcina";
            this.Load += new System.EventHandler(this.SpisVakcina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwNeprim)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrim)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwNeprim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgwPrim;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbPac;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn siflek;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazlek;
        private System.Windows.Forms.DataGridViewTextBoxColumn orkollek;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}