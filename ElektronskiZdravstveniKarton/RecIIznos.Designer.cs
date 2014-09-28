namespace ElektronskiZdravstveniKarton
{
    partial class UtrosenaSredstva
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPrikaz = new System.Windows.Forms.Button();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbUkIznos = new System.Windows.Forms.Label();
            this.lbUkRec = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgwPrimPac = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.lekar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojPrepRecep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prekoraceno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sugestije = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrimPac)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPrikaz);
            this.groupBox3.Controls.Add(this.cbMes);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(2, 28);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(729, 77);
            this.groupBox3.TabIndex = 85;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Period";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnPrikaz
            // 
            this.btnPrikaz.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPrikaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaz.Location = new System.Drawing.Point(372, 29);
            this.btnPrikaz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrikaz.Name = "btnPrikaz";
            this.btnPrikaz.Size = new System.Drawing.Size(138, 35);
            this.btnPrikaz.TabIndex = 85;
            this.btnPrikaz.Text = "Prikaži";
            this.btnPrikaz.UseVisualStyleBackColor = false;
            this.btnPrikaz.Click += new System.EventHandler(this.btnPrikaz_Click);
            // 
            // cbMes
            // 
            this.cbMes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "jan",
            "feb",
            "mar",
            "apr",
            "may",
            "jun",
            "jul",
            "aug",
            "sep",
            "oct",
            "nov",
            "dec"});
            this.cbMes.Location = new System.Drawing.Point(219, 33);
            this.cbMes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(134, 28);
            this.cbMes.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mesec:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbUkIznos);
            this.groupBox1.Controls.Add(this.lbUkRec);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(2, 114);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(729, 340);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ukupno:";
            // 
            // lbUkIznos
            // 
            this.lbUkIznos.AutoSize = true;
            this.lbUkIznos.Location = new System.Drawing.Point(321, 48);
            this.lbUkIznos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUkIznos.Name = "lbUkIznos";
            this.lbUkIznos.Size = new System.Drawing.Size(129, 20);
            this.lbUkIznos.TabIndex = 92;
            this.lbUkIznos.Text = "Iznos u dinarima:";
            // 
            // lbUkRec
            // 
            this.lbUkRec.AutoSize = true;
            this.lbUkRec.Location = new System.Drawing.Point(20, 48);
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
            this.BrojPrepRecep,
            this.Iznos,
            this.Prekoraceno,
            this.Sugestije});
            this.dgwPrimPac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwPrimPac.Location = new System.Drawing.Point(4, 24);
            this.dgwPrimPac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgwPrimPac.Name = "dgwPrimPac";
            this.dgwPrimPac.ReadOnly = true;
            this.dgwPrimPac.RowHeadersVisible = false;
            this.dgwPrimPac.RowTemplate.Height = 28;
            this.dgwPrimPac.Size = new System.Drawing.Size(716, 214);
            this.dgwPrimPac.TabIndex = 0;
            this.dgwPrimPac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPrimPac_CellClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(574, 472);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 42);
            this.button2.TabIndex = 91;
            this.button2.Text = "Zatvori";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lekar
            // 
            this.lekar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.lekar.HeaderText = "Lekar";
            this.lekar.Name = "lekar";
            this.lekar.ReadOnly = true;
            this.lekar.Width = 125;
            // 
            // BrojPrepRecep
            // 
            this.BrojPrepRecep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojPrepRecep.HeaderText = "Prop.recepata";
            this.BrojPrepRecep.Name = "BrojPrepRecep";
            this.BrojPrepRecep.ReadOnly = true;
            // 
            // Iznos
            // 
            this.Iznos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Iznos.HeaderText = "Iznos (din)";
            this.Iznos.Name = "Iznos";
            this.Iznos.ReadOnly = true;
            // 
            // Prekoraceno
            // 
            this.Prekoraceno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prekoraceno.HeaderText = "Prekoraceno (din)";
            this.Prekoraceno.Name = "Prekoraceno";
            this.Prekoraceno.ReadOnly = true;
            // 
            // Sugestije
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sugestije.DefaultCellStyle = dataGridViewCellStyle1;
            this.Sugestije.HeaderText = "Sugestije";
            this.Sugestije.Name = "Sugestije";
            this.Sugestije.ReadOnly = true;
            this.Sugestije.Text = "Prikaži...";
            this.Sugestije.UseColumnTextForButtonValue = true;
            this.Sugestije.Width = 90;
            // 
            // UtrosenaSredstva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(734, 528);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.HelpButton = true;
            this.Name = "UtrosenaSredstva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Utrošena sredstva";
            this.Load += new System.EventHandler(this.RecIIznos_Load);
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
        private System.Windows.Forms.Button btnPrikaz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbUkIznos;
        private System.Windows.Forms.Label lbUkRec;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgwPrimPac;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn lekar;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojPrepRecep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iznos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prekoraceno;
        private System.Windows.Forms.DataGridViewButtonColumn Sugestije;
    }
}