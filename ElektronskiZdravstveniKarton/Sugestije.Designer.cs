namespace ElektronskiZdravstveniKarton
{
    partial class Sugestije
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgwSpisak = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.preplek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predllek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSpisak)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwSpisak
            // 
            this.dgwSpisak.AllowUserToAddRows = false;
            this.dgwSpisak.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgwSpisak.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwSpisak.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwSpisak.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwSpisak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSpisak.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.preplek,
            this.predllek});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwSpisak.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwSpisak.Location = new System.Drawing.Point(1, 35);
            this.dgwSpisak.Name = "dgwSpisak";
            this.dgwSpisak.ReadOnly = true;
            this.dgwSpisak.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgwSpisak.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwSpisak.RowTemplate.Height = 28;
            this.dgwSpisak.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwSpisak.Size = new System.Drawing.Size(530, 287);
            this.dgwSpisak.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(385, 345);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 42);
            this.button2.TabIndex = 92;
            this.button2.Text = "Zatvori";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // preplek
            // 
            this.preplek.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.preplek.FillWeight = 89.0863F;
            this.preplek.HeaderText = "Propisan lek";
            this.preplek.Name = "preplek";
            this.preplek.ReadOnly = true;
            // 
            // predllek
            // 
            this.predllek.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.predllek.FillWeight = 89.0863F;
            this.predllek.HeaderText = "Jeftiniji lek iz grupe";
            this.predllek.Name = "predllek";
            this.predllek.ReadOnly = true;
            // 
            // Sugestije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(532, 401);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgwSpisak);
            this.HelpButton = true;
            this.Name = "Sugestije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sugestije";
            this.Load += new System.EventHandler(this.Sugestije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSpisak)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwSpisak;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn preplek;
        private System.Windows.Forms.DataGridViewTextBoxColumn predllek;
    }
}