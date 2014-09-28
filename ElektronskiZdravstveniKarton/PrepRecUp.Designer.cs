namespace ElektronskiZdravstveniKarton
{
    partial class PrepRecUp
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
            this.lbLekar = new System.Windows.Forms.Label();
            this.lbBrRec = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbBrUp = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mtbDatDo = new System.Windows.Forms.DateTimePicker();
            this.mtbDatOd = new System.Windows.Forms.DateTimePicker();
            this.btnPrikaz = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(414, 307);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 42);
            this.button2.TabIndex = 78;
            this.button2.Text = "Zatvori";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbLekar
            // 
            this.lbLekar.AutoSize = true;
            this.lbLekar.Location = new System.Drawing.Point(142, 24);
            this.lbLekar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLekar.Name = "lbLekar";
            this.lbLekar.Size = new System.Drawing.Size(73, 20);
            this.lbLekar.TabIndex = 79;
            this.lbLekar.Text = "Lekar:     ";
            // 
            // lbBrRec
            // 
            this.lbBrRec.AutoSize = true;
            this.lbBrRec.Location = new System.Drawing.Point(10, 56);
            this.lbBrRec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBrRec.Name = "lbBrRec";
            this.lbBrRec.Size = new System.Drawing.Size(94, 20);
            this.lbBrRec.TabIndex = 80;
            this.lbBrRec.Text = "Recepata:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbLekar);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(530, 62);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbBrUp);
            this.groupBox2.Controls.Add(this.lbBrRec);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(293, 103);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(255, 175);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Propisano";
            // 
            // lbBrUp
            // 
            this.lbBrUp.AutoSize = true;
            this.lbBrUp.Location = new System.Drawing.Point(10, 114);
            this.lbBrUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBrUp.Name = "lbBrUp";
            this.lbBrUp.Size = new System.Drawing.Size(64, 20);
            this.lbBrUp.TabIndex = 81;
            this.lbBrUp.Text = "Uputa:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mtbDatDo);
            this.groupBox3.Controls.Add(this.mtbDatOd);
            this.groupBox3.Controls.Add(this.btnPrikaz);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(21, 103);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(255, 175);
            this.groupBox3.TabIndex = 83;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Period";
            // 
            // mtbDatDo
            // 
            this.mtbDatDo.CustomFormat = "dd-MM-yyyy";
            this.mtbDatDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mtbDatDo.Location = new System.Drawing.Point(47, 76);
            this.mtbDatDo.Name = "mtbDatDo";
            this.mtbDatDo.Size = new System.Drawing.Size(165, 26);
            this.mtbDatDo.TabIndex = 89;
            // 
            // mtbDatOd
            // 
            this.mtbDatOd.CustomFormat = "dd-MM-yyyy";
            this.mtbDatOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mtbDatOd.Location = new System.Drawing.Point(47, 27);
            this.mtbDatOd.Name = "mtbDatOd";
            this.mtbDatOd.Size = new System.Drawing.Size(165, 26);
            this.mtbDatOd.TabIndex = 87;
            // 
            // btnPrikaz
            // 
            this.btnPrikaz.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPrikaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaz.Location = new System.Drawing.Point(13, 126);
            this.btnPrikaz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrikaz.Name = "btnPrikaz";
            this.btnPrikaz.Size = new System.Drawing.Size(134, 39);
            this.btnPrikaz.TabIndex = 84;
            this.btnPrikaz.Text = "Prikaži";
            this.btnPrikaz.UseVisualStyleBackColor = false;
            this.btnPrikaz.Click += new System.EventHandler(this.btnPrikaz_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "do:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "od:";
            // 
            // PrepRecUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(570, 366);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PrepRecUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Propisani recepti i uputi";
            this.Load += new System.EventHandler(this.PrepRecUp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbLekar;
        private System.Windows.Forms.Label lbBrRec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbBrUp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPrikaz;
        private System.Windows.Forms.DateTimePicker mtbDatOd;
        private System.Windows.Forms.DateTimePicker mtbDatDo;
    }
}