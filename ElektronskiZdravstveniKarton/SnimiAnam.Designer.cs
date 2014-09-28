namespace ElektronskiZdravstveniKarton
{
    partial class SnimiAnam
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNazSablona = new System.Windows.Forms.TextBox();
            this.lbInvAnam = new System.Windows.Forms.Label();
            this.rtbSnimAnam = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(267, 193);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 42);
            this.button2.TabIndex = 67;
            this.button2.Text = "Poništiti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(124, 193);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 42);
            this.button1.TabIndex = 66;
            this.button1.Text = "Sačuvati";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "Naziv šablona:";
            // 
            // tbNazSablona
            // 
            this.tbNazSablona.Location = new System.Drawing.Point(142, 31);
            this.tbNazSablona.Name = "tbNazSablona";
            this.tbNazSablona.Size = new System.Drawing.Size(259, 26);
            this.tbNazSablona.TabIndex = 69;
            // 
            // lbInvAnam
            // 
            this.lbInvAnam.AutoSize = true;
            this.lbInvAnam.Location = new System.Drawing.Point(19, 110);
            this.lbInvAnam.Name = "lbInvAnam";
            this.lbInvAnam.Size = new System.Drawing.Size(90, 20);
            this.lbInvAnam.TabIndex = 70;
            this.lbInvAnam.Text = "Anamneza:";
            // 
            // rtbSnimAnam
            // 
            this.rtbSnimAnam.Location = new System.Drawing.Point(142, 81);
            this.rtbSnimAnam.Name = "rtbSnimAnam";
            this.rtbSnimAnam.Size = new System.Drawing.Size(259, 82);
            this.rtbSnimAnam.TabIndex = 71;
            this.rtbSnimAnam.Text = "";
            // 
            // SnimiAnam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(427, 249);
            this.Controls.Add(this.rtbSnimAnam);
            this.Controls.Add(this.lbInvAnam);
            this.Controls.Add(this.tbNazSablona);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.HelpButton = true;
            this.Name = "SnimiAnam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Snimanje Anamneze";
            this.Load += new System.EventHandler(this.SnimiAnam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNazSablona;
        private System.Windows.Forms.Label lbInvAnam;
        private System.Windows.Forms.RichTextBox rtbSnimAnam;
    }
}