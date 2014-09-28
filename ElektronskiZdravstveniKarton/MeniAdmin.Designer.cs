namespace ElektronskiZdravstveniKarton
{
    partial class MeniAdmin
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
            this.btnRegistrKor = new System.Windows.Forms.Button();
            this.btnPrimljeniPac = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(370, 318);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 45);
            this.button2.TabIndex = 48;
            this.button2.Text = "Zatvori";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRegistrKor
            // 
            this.btnRegistrKor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRegistrKor.Location = new System.Drawing.Point(58, 33);
            this.btnRegistrKor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrKor.Name = "btnRegistrKor";
            this.btnRegistrKor.Size = new System.Drawing.Size(360, 55);
            this.btnRegistrKor.TabIndex = 49;
            this.btnRegistrKor.Text = "Registrovanje korisnika";
            this.btnRegistrKor.UseVisualStyleBackColor = false;
            this.btnRegistrKor.Click += new System.EventHandler(this.btnRegistrKor_Click);
            // 
            // btnPrimljeniPac
            // 
            this.btnPrimljeniPac.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPrimljeniPac.Location = new System.Drawing.Point(58, 108);
            this.btnPrimljeniPac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrimljeniPac.Name = "btnPrimljeniPac";
            this.btnPrimljeniPac.Size = new System.Drawing.Size(360, 54);
            this.btnPrimljeniPac.TabIndex = 50;
            this.btnPrimljeniPac.Text = "Pružene usluge";
            this.btnPrimljeniPac.UseVisualStyleBackColor = false;
            this.btnPrimljeniPac.Click += new System.EventHandler(this.btnPrimljeniPac_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnPrimljeniPac);
            this.groupBox1.Controls.Add(this.btnRegistrKor);
            this.groupBox1.Location = new System.Drawing.Point(28, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(476, 263);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(58, 184);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(360, 54);
            this.button1.TabIndex = 51;
            this.button1.Text = "Utrošena sredstva";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MeniAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(534, 377);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MeniAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Meni Administrator";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRegistrKor;
        private System.Windows.Forms.Button btnPrimljeniPac;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}