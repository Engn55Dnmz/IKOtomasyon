namespace WinUI.PersonelAlti
{
    partial class PrimVer
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
            this.grpPrimVer = new System.Windows.Forms.GroupBox();
            this.lblPersonel = new System.Windows.Forms.Label();
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.lblPrimCesidi = new System.Windows.Forms.Label();
            this.cmbPrimCesidi = new System.Windows.Forms.ComboBox();
            this.lblPrimMiktari = new System.Windows.Forms.Label();
            this.txtPrimMiktari = new System.Windows.Forms.TextBox();
            this.lblPrimTarihi = new System.Windows.Forms.Label();
            this.dtpPrimTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnPrimVer = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.grpPrimVer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPrimVer
            // 
            this.grpPrimVer.Controls.Add(this.btnCikis);
            this.grpPrimVer.Controls.Add(this.btnPrimVer);
            this.grpPrimVer.Controls.Add(this.dtpPrimTarihi);
            this.grpPrimVer.Controls.Add(this.txtPrimMiktari);
            this.grpPrimVer.Controls.Add(this.cmbPrimCesidi);
            this.grpPrimVer.Controls.Add(this.cmbPersonel);
            this.grpPrimVer.Controls.Add(this.lblPrimTarihi);
            this.grpPrimVer.Controls.Add(this.lblPrimMiktari);
            this.grpPrimVer.Controls.Add(this.lblPrimCesidi);
            this.grpPrimVer.Controls.Add(this.lblPersonel);
            this.grpPrimVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpPrimVer.Location = new System.Drawing.Point(12, 12);
            this.grpPrimVer.Name = "grpPrimVer";
            this.grpPrimVer.Size = new System.Drawing.Size(356, 261);
            this.grpPrimVer.TabIndex = 0;
            this.grpPrimVer.TabStop = false;
            this.grpPrimVer.Text = "Prim Ver";
            // 
            // lblPersonel
            // 
            this.lblPersonel.AutoSize = true;
            this.lblPersonel.Location = new System.Drawing.Point(17, 34);
            this.lblPersonel.Name = "lblPersonel";
            this.lblPersonel.Size = new System.Drawing.Size(72, 15);
            this.lblPersonel.TabIndex = 0;
            this.lblPersonel.Text = "Personel :";
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(130, 31);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(204, 23);
            this.cmbPersonel.TabIndex = 1;
            this.cmbPersonel.Click += new System.EventHandler(this.cmbPersonel_Click);
            // 
            // lblPrimCesidi
            // 
            this.lblPrimCesidi.AutoSize = true;
            this.lblPrimCesidi.Location = new System.Drawing.Point(17, 77);
            this.lblPrimCesidi.Name = "lblPrimCesidi";
            this.lblPrimCesidi.Size = new System.Drawing.Size(89, 15);
            this.lblPrimCesidi.TabIndex = 0;
            this.lblPrimCesidi.Text = "Prim Çeşidi :";
            // 
            // cmbPrimCesidi
            // 
            this.cmbPrimCesidi.FormattingEnabled = true;
            this.cmbPrimCesidi.Location = new System.Drawing.Point(130, 74);
            this.cmbPrimCesidi.Name = "cmbPrimCesidi";
            this.cmbPrimCesidi.Size = new System.Drawing.Size(204, 23);
            this.cmbPrimCesidi.TabIndex = 2;
            this.cmbPrimCesidi.Click += new System.EventHandler(this.cmbPrimCesidi_Click);
            // 
            // lblPrimMiktari
            // 
            this.lblPrimMiktari.AutoSize = true;
            this.lblPrimMiktari.Location = new System.Drawing.Point(17, 120);
            this.lblPrimMiktari.Name = "lblPrimMiktari";
            this.lblPrimMiktari.Size = new System.Drawing.Size(93, 15);
            this.lblPrimMiktari.TabIndex = 0;
            this.lblPrimMiktari.Text = "Prim Miktarı :";
            // 
            // txtPrimMiktari
            // 
            this.txtPrimMiktari.Location = new System.Drawing.Point(130, 117);
            this.txtPrimMiktari.Name = "txtPrimMiktari";
            this.txtPrimMiktari.Size = new System.Drawing.Size(204, 21);
            this.txtPrimMiktari.TabIndex = 3;
            // 
            // lblPrimTarihi
            // 
            this.lblPrimTarihi.AutoSize = true;
            this.lblPrimTarihi.Location = new System.Drawing.Point(17, 158);
            this.lblPrimTarihi.Name = "lblPrimTarihi";
            this.lblPrimTarihi.Size = new System.Drawing.Size(86, 15);
            this.lblPrimTarihi.TabIndex = 0;
            this.lblPrimTarihi.Text = "Prim Tarihi :";
            // 
            // dtpPrimTarihi
            // 
            this.dtpPrimTarihi.Location = new System.Drawing.Point(130, 158);
            this.dtpPrimTarihi.Name = "dtpPrimTarihi";
            this.dtpPrimTarihi.Size = new System.Drawing.Size(204, 21);
            this.dtpPrimTarihi.TabIndex = 4;
            // 
            // btnPrimVer
            // 
            this.btnPrimVer.BackColor = System.Drawing.Color.DarkGray;
            this.btnPrimVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrimVer.Location = new System.Drawing.Point(130, 197);
            this.btnPrimVer.Name = "btnPrimVer";
            this.btnPrimVer.Size = new System.Drawing.Size(102, 45);
            this.btnPrimVer.TabIndex = 5;
            this.btnPrimVer.Text = "Kaydet";
            this.btnPrimVer.UseVisualStyleBackColor = false;
            this.btnPrimVer.Click += new System.EventHandler(this.btnPrimVer_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.DarkGray;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(238, 197);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(96, 45);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // PrimVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(381, 291);
            this.Controls.Add(this.grpPrimVer);
            this.Name = "PrimVer";
            this.Text = "PrimVer";
            this.grpPrimVer.ResumeLayout(false);
            this.grpPrimVer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPrimVer;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnPrimVer;
        private System.Windows.Forms.DateTimePicker dtpPrimTarihi;
        private System.Windows.Forms.TextBox txtPrimMiktari;
        private System.Windows.Forms.Label lblPrimTarihi;
        private System.Windows.Forms.Label lblPrimMiktari;
        private System.Windows.Forms.Label lblPrimCesidi;
        private System.Windows.Forms.Label lblPersonel;
        public System.Windows.Forms.ComboBox cmbPrimCesidi;
        public System.Windows.Forms.ComboBox cmbPersonel;
    }
}