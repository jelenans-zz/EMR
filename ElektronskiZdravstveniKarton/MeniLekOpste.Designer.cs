namespace ElektronskiZdravstveniKarton
{
    partial class MeniLekOpste
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
            this.btnPacPrijem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrimPac = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPacPrijem
            // 
            this.btnPacPrijem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPacPrijem.Location = new System.Drawing.Point(56, 48);
            this.btnPacPrijem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPacPrijem.Name = "btnPacPrijem";
            this.btnPacPrijem.Size = new System.Drawing.Size(360, 55);
            this.btnPacPrijem.TabIndex = 49;
            this.btnPacPrijem.Text = "Pacijenti za prijem";
            this.btnPacPrijem.UseVisualStyleBackColor = false;
            this.btnPacPrijem.Click += new System.EventHandler(this.btnPacPrijem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrimPac);
            this.groupBox1.Controls.Add(this.btnPacPrijem);
            this.groupBox1.Location = new System.Drawing.Point(18, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(476, 220);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            // 
            // btnPrimPac
            // 
            this.btnPrimPac.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPrimPac.Location = new System.Drawing.Point(56, 135);
            this.btnPrimPac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrimPac.Name = "btnPrimPac";
            this.btnPrimPac.Size = new System.Drawing.Size(360, 54);
            this.btnPrimPac.TabIndex = 50;
            this.btnPrimPac.Text = "Propisani recepti i uputi";
            this.btnPrimPac.UseVisualStyleBackColor = false;
            this.btnPrimPac.Click += new System.EventHandler(this.btnPrepRecUp_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(360, 288);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 45);
            this.button2.TabIndex = 52;
            this.button2.Text = "Zatvori";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MeniLekOpste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(525, 352);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MeniLekOpste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Meni Lekar Opšte";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPacPrijem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrimPac;
        private System.Windows.Forms.Button button2;
    }
}