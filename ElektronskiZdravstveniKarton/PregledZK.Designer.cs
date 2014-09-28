namespace ElektronskiZdravstveniKarton
{
    partial class PregledZK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PregledZK));
            this.pRecepti = new System.Windows.Forms.Panel();
            this.dgwRecepti = new System.Windows.Forms.DataGridView();
            this.siflek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazlek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orkollek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prepkollek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dijagrec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datrec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pUputi = new System.Windows.Forms.Panel();
            this.dgwUputi = new System.Windows.Forms.DataGridView();
            this.nazinst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrsuputa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrsan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dijaguput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.pPomagala = new System.Windows.Forms.Panel();
            this.dgwPomagala = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.pNalazi = new System.Windows.Forms.Panel();
            this.dgwNalazi = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.pBolovanja = new System.Windows.Forms.Panel();
            this.dgwBolovanja = new System.Windows.Forms.DataGridView();
            this.vrsta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pocat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.krajdat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dijag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spoljuzr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uzrtrece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datizd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pRecepti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRecepti)).BeginInit();
            this.pUputi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUputi)).BeginInit();
            this.pPomagala.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPomagala)).BeginInit();
            this.pNalazi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwNalazi)).BeginInit();
            this.pBolovanja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBolovanja)).BeginInit();
            this.SuspendLayout();
            // 
            // pRecepti
            // 
            this.pRecepti.Controls.Add(this.dgwRecepti);
            this.pRecepti.Controls.Add(this.label1);
            this.pRecepti.Controls.Add(this.panel2);
            this.pRecepti.Location = new System.Drawing.Point(6, 22);
            this.pRecepti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pRecepti.Name = "pRecepti";
            this.pRecepti.Size = new System.Drawing.Size(1120, 188);
            this.pRecepti.TabIndex = 0;
            // 
            // dgwRecepti
            // 
            this.dgwRecepti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRecepti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siflek,
            this.nazlek,
            this.orkollek,
            this.prepkollek,
            this.dijagrec,
            this.datrec});
            this.dgwRecepti.Location = new System.Drawing.Point(15, 29);
            this.dgwRecepti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgwRecepti.Name = "dgwRecepti";
            this.dgwRecepti.RowTemplate.Height = 28;
            this.dgwRecepti.Size = new System.Drawing.Size(1090, 142);
            this.dgwRecepti.TabIndex = 3;
            // 
            // siflek
            // 
            this.siflek.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.siflek.HeaderText = "Šifra leka";
            this.siflek.MinimumWidth = 8;
            this.siflek.Name = "siflek";
            this.siflek.Width = 96;
            // 
            // nazlek
            // 
            this.nazlek.HeaderText = "Naziv leka";
            this.nazlek.Name = "nazlek";
            this.nazlek.Width = 110;
            // 
            // orkollek
            // 
            this.orkollek.HeaderText = "Or.količina leka";
            this.orkollek.MinimumWidth = 10;
            this.orkollek.Name = "orkollek";
            this.orkollek.Width = 120;
            // 
            // prepkollek
            // 
            this.prepkollek.HeaderText = "Prep.količina leka";
            this.prepkollek.MinimumWidth = 10;
            this.prepkollek.Name = "prepkollek";
            this.prepkollek.Width = 120;
            // 
            // dijagrec
            // 
            this.dijagrec.HeaderText = "Dijagnoza";
            this.dijagrec.Name = "dijagrec";
            this.dijagrec.Width = 110;
            // 
            // datrec
            // 
            this.datrec.HeaderText = "Datum";
            this.datrec.MinimumWidth = 7;
            this.datrec.Name = "datrec";
            this.datrec.Width = 127;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Recepti";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 197);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1120, 188);
            this.panel2.TabIndex = 1;
            // 
            // pUputi
            // 
            this.pUputi.Controls.Add(this.dgwUputi);
            this.pUputi.Controls.Add(this.label2);
            this.pUputi.Location = new System.Drawing.Point(6, 214);
            this.pUputi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pUputi.Name = "pUputi";
            this.pUputi.Size = new System.Drawing.Size(1120, 188);
            this.pUputi.TabIndex = 2;
            // 
            // dgwUputi
            // 
            this.dgwUputi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUputi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazinst,
            this.vrsuputa,
            this.spec,
            this.vrsan,
            this.dijaguput,
            this.razl,
            this.dat});
            this.dgwUputi.Location = new System.Drawing.Point(12, 25);
            this.dgwUputi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgwUputi.Name = "dgwUputi";
            this.dgwUputi.RowTemplate.Height = 28;
            this.dgwUputi.Size = new System.Drawing.Size(1089, 142);
            this.dgwUputi.TabIndex = 4;
            this.dgwUputi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // nazinst
            // 
            this.nazinst.HeaderText = "Naziv institucije";
            this.nazinst.Name = "nazinst";
            this.nazinst.Width = 110;
            // 
            // vrsuputa
            // 
            this.vrsuputa.HeaderText = "Vrsta uputa";
            this.vrsuputa.Name = "vrsuputa";
            this.vrsuputa.Width = 110;
            // 
            // spec
            // 
            this.spec.HeaderText = "Specijalnost";
            this.spec.Name = "spec";
            this.spec.Width = 110;
            // 
            // vrsan
            // 
            this.vrsan.HeaderText = "Vrsta analize";
            this.vrsan.Name = "vrsan";
            this.vrsan.Width = 90;
            // 
            // dijaguput
            // 
            this.dijaguput.HeaderText = "Dijagnoza";
            this.dijaguput.Name = "dijaguput";
            // 
            // razl
            // 
            this.razl.HeaderText = "Razlog";
            this.razl.Name = "razl";
            this.razl.Width = 110;
            // 
            // dat
            // 
            this.dat.HeaderText = "Datum";
            this.dat.Name = "dat";
            this.dat.Width = 112;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Uputi";
            // 
            // pPomagala
            // 
            this.pPomagala.Controls.Add(this.dgwPomagala);
            this.pPomagala.Controls.Add(this.label3);
            this.pPomagala.Location = new System.Drawing.Point(6, 411);
            this.pPomagala.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pPomagala.Name = "pPomagala";
            this.pPomagala.Size = new System.Drawing.Size(1120, 188);
            this.pPomagala.TabIndex = 3;
            // 
            // dgwPomagala
            // 
            this.dgwPomagala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPomagala.Location = new System.Drawing.Point(16, 25);
            this.dgwPomagala.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgwPomagala.Name = "dgwPomagala";
            this.dgwPomagala.Size = new System.Drawing.Size(1089, 142);
            this.dgwPomagala.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pomagala";
            // 
            // pNalazi
            // 
            this.pNalazi.Controls.Add(this.dgwNalazi);
            this.pNalazi.Controls.Add(this.label4);
            this.pNalazi.Location = new System.Drawing.Point(6, 608);
            this.pNalazi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pNalazi.Name = "pNalazi";
            this.pNalazi.Size = new System.Drawing.Size(1120, 188);
            this.pNalazi.TabIndex = 4;
            // 
            // dgwNalazi
            // 
            this.dgwNalazi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwNalazi.Location = new System.Drawing.Point(16, 25);
            this.dgwNalazi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgwNalazi.Name = "dgwNalazi";
            this.dgwNalazi.Size = new System.Drawing.Size(1089, 142);
            this.dgwNalazi.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nalazi";
            // 
            // pBolovanja
            // 
            this.pBolovanja.Controls.Add(this.dgwBolovanja);
            this.pBolovanja.Controls.Add(this.label5);
            this.pBolovanja.Location = new System.Drawing.Point(6, 805);
            this.pBolovanja.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pBolovanja.Name = "pBolovanja";
            this.pBolovanja.Size = new System.Drawing.Size(1120, 186);
            this.pBolovanja.TabIndex = 5;
            // 
            // dgwBolovanja
            // 
            this.dgwBolovanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBolovanja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vrsta,
            this.pocat,
            this.krajdat,
            this.statbol,
            this.dijag,
            this.nal,
            this.spoljuzr,
            this.uzrtrece,
            this.rec,
            this.datizd});
            this.dgwBolovanja.Location = new System.Drawing.Point(15, 25);
            this.dgwBolovanja.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgwBolovanja.Name = "dgwBolovanja";
            this.dgwBolovanja.RowTemplate.Height = 28;
            this.dgwBolovanja.Size = new System.Drawing.Size(1089, 142);
            this.dgwBolovanja.TabIndex = 7;
            // 
            // vrsta
            // 
            this.vrsta.HeaderText = "Vrsta";
            this.vrsta.Name = "vrsta";
            // 
            // pocat
            // 
            this.pocat.HeaderText = "Početni dat.";
            this.pocat.Name = "pocat";
            this.pocat.Width = 60;
            // 
            // krajdat
            // 
            this.krajdat.HeaderText = "Krajnji dat.";
            this.krajdat.Name = "krajdat";
            this.krajdat.Width = 60;
            // 
            // statbol
            // 
            this.statbol.HeaderText = "Status";
            this.statbol.Name = "statbol";
            // 
            // dijag
            // 
            this.dijag.HeaderText = "Dijagnoza";
            this.dijag.Name = "dijag";
            this.dijag.Width = 70;
            // 
            // nal
            // 
            this.nal.HeaderText = "Nalaz";
            this.nal.Name = "nal";
            this.nal.Width = 70;
            // 
            // spoljuzr
            // 
            this.spoljuzr.HeaderText = "Spoljni uzrok";
            this.spoljuzr.Name = "spoljuzr";
            this.spoljuzr.Width = 70;
            // 
            // uzrtrece
            // 
            this.uzrtrece.HeaderText = "Trece lice";
            this.uzrtrece.Name = "uzrtrece";
            this.uzrtrece.Width = 40;
            // 
            // rec
            // 
            this.rec.HeaderText = "Recidiv";
            this.rec.Name = "rec";
            this.rec.Width = 45;
            // 
            // datizd
            // 
            this.datizd.HeaderText = "Dat.izdavanja";
            this.datizd.Name = "datizd";
            this.datizd.Width = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Bolovanja";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(987, 1000);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 42);
            this.button2.TabIndex = 76;
            this.button2.Text = "Zatvori";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PregledZK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1138, 1049);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pBolovanja);
            this.Controls.Add(this.pPomagala);
            this.Controls.Add(this.pNalazi);
            this.Controls.Add(this.pUputi);
            this.Controls.Add(this.pRecepti);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PregledZK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pregled prepisanih recepata, uputa, nalaza, pomagala i bolovanja";
            this.Load += new System.EventHandler(this.PregledZK_Load);
            this.pRecepti.ResumeLayout(false);
            this.pRecepti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRecepti)).EndInit();
            this.pUputi.ResumeLayout(false);
            this.pUputi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUputi)).EndInit();
            this.pPomagala.ResumeLayout(false);
            this.pPomagala.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPomagala)).EndInit();
            this.pNalazi.ResumeLayout(false);
            this.pNalazi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwNalazi)).EndInit();
            this.pBolovanja.ResumeLayout(false);
            this.pBolovanja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBolovanja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pRecepti;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pUputi;
        private System.Windows.Forms.Panel pPomagala;
        private System.Windows.Forms.Panel pNalazi;
        private System.Windows.Forms.Panel pBolovanja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgwRecepti;
        private System.Windows.Forms.DataGridView dgwUputi;
        private System.Windows.Forms.DataGridView dgwPomagala;
        private System.Windows.Forms.DataGridView dgwNalazi;
        private System.Windows.Forms.DataGridView dgwBolovanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn siflek;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazlek;
        private System.Windows.Forms.DataGridViewTextBoxColumn orkollek;
        private System.Windows.Forms.DataGridViewTextBoxColumn prepkollek;
        private System.Windows.Forms.DataGridViewTextBoxColumn dijagrec;
        private System.Windows.Forms.DataGridViewTextBoxColumn datrec;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazinst;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrsuputa;
        private System.Windows.Forms.DataGridViewTextBoxColumn spec;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrsan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dijaguput;
        private System.Windows.Forms.DataGridViewTextBoxColumn razl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dat;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrsta;
        private System.Windows.Forms.DataGridViewTextBoxColumn pocat;
        private System.Windows.Forms.DataGridViewTextBoxColumn krajdat;
        private System.Windows.Forms.DataGridViewTextBoxColumn statbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dijag;
        private System.Windows.Forms.DataGridViewTextBoxColumn nal;
        private System.Windows.Forms.DataGridViewTextBoxColumn spoljuzr;
        private System.Windows.Forms.DataGridViewTextBoxColumn uzrtrece;
        private System.Windows.Forms.DataGridViewTextBoxColumn rec;
        private System.Windows.Forms.DataGridViewTextBoxColumn datizd;
        private System.Windows.Forms.Button button2;


    }
}