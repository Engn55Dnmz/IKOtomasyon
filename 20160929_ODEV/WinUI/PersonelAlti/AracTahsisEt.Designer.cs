namespace WinUI.PersonelAlti
{
    partial class AracTahsisEt
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
            this.grpAracTahsisi = new System.Windows.Forms.GroupBox();
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.lblAraclar = new System.Windows.Forms.Label();
            this.lblPersonel = new System.Windows.Forms.Label();
            this.cmbAraclar = new System.Windows.Forms.ComboBox();
            this.btnTahsisEt = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.lblAldigiTarih = new System.Windows.Forms.Label();
            this.dtpAldigiTarih = new System.Windows.Forms.DateTimePicker();
            this.lblBiraktigiTarih = new System.Windows.Forms.Label();
            this.dtpBiraktigiTarih = new System.Windows.Forms.DateTimePicker();
            this.grpAracTahsisi.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAracTahsisi
            // 
            this.grpAracTahsisi.Controls.Add(this.dtpBiraktigiTarih);
            this.grpAracTahsisi.Controls.Add(this.dtpAldigiTarih);
            this.grpAracTahsisi.Controls.Add(this.btnCikis);
            this.grpAracTahsisi.Controls.Add(this.btnTahsisEt);
            this.grpAracTahsisi.Controls.Add(this.cmbAraclar);
            this.grpAracTahsisi.Controls.Add(this.lblBiraktigiTarih);
            this.grpAracTahsisi.Controls.Add(this.cmbPersonel);
            this.grpAracTahsisi.Controls.Add(this.lblAldigiTarih);
            this.grpAracTahsisi.Controls.Add(this.lblAraclar);
            this.grpAracTahsisi.Controls.Add(this.lblPersonel);
            this.grpAracTahsisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpAracTahsisi.Location = new System.Drawing.Point(12, 12);
            this.grpAracTahsisi.Name = "grpAracTahsisi";
            this.grpAracTahsisi.Size = new System.Drawing.Size(341, 258);
            this.grpAracTahsisi.TabIndex = 0;
            this.grpAracTahsisi.TabStop = false;
            this.grpAracTahsisi.Text = "Araç Tahsisi";
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(128, 33);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(200, 23);
            this.cmbPersonel.TabIndex = 1;
            this.cmbPersonel.Click += new System.EventHandler(this.cmbPersonel_Click);
            // 
            // lblAraclar
            // 
            this.lblAraclar.AutoSize = true;
            this.lblAraclar.Location = new System.Drawing.Point(7, 75);
            this.lblAraclar.Name = "lblAraclar";
            this.lblAraclar.Size = new System.Drawing.Size(60, 15);
            this.lblAraclar.TabIndex = 0;
            this.lblAraclar.Text = "Araçlar :";
            // 
            // lblPersonel
            // 
            this.lblPersonel.AutoSize = true;
            this.lblPersonel.Location = new System.Drawing.Point(7, 36);
            this.lblPersonel.Name = "lblPersonel";
            this.lblPersonel.Size = new System.Drawing.Size(72, 15);
            this.lblPersonel.TabIndex = 0;
            this.lblPersonel.Text = "Personel :";
            // 
            // cmbAraclar
            // 
            this.cmbAraclar.FormattingEnabled = true;
            this.cmbAraclar.Location = new System.Drawing.Point(128, 72);
            this.cmbAraclar.Name = "cmbAraclar";
            this.cmbAraclar.Size = new System.Drawing.Size(200, 23);
            this.cmbAraclar.TabIndex = 2;
            this.cmbAraclar.Click += new System.EventHandler(this.cmbAraclar_Click);
            // 
            // btnTahsisEt
            // 
            this.btnTahsisEt.BackColor = System.Drawing.Color.DarkGray;
            this.btnTahsisEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTahsisEt.Location = new System.Drawing.Point(128, 203);
            this.btnTahsisEt.Name = "btnTahsisEt";
            this.btnTahsisEt.Size = new System.Drawing.Size(100, 45);
            this.btnTahsisEt.TabIndex = 3;
            this.btnTahsisEt.Text = "Kaydet";
            this.btnTahsisEt.UseVisualStyleBackColor = false;
            this.btnTahsisEt.Click += new System.EventHandler(this.btnTahsisEt_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.DarkGray;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(234, 203);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(94, 45);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // lblAldigiTarih
            // 
            this.lblAldigiTarih.AutoSize = true;
            this.lblAldigiTarih.Location = new System.Drawing.Point(7, 117);
            this.lblAldigiTarih.Name = "lblAldigiTarih";
            this.lblAldigiTarih.Size = new System.Drawing.Size(88, 15);
            this.lblAldigiTarih.TabIndex = 0;
            this.lblAldigiTarih.Text = "Aldığı Tarih :";
            // 
            // dtpAldigiTarih
            // 
            this.dtpAldigiTarih.Location = new System.Drawing.Point(128, 117);
            this.dtpAldigiTarih.Name = "dtpAldigiTarih";
            this.dtpAldigiTarih.Size = new System.Drawing.Size(200, 21);
            this.dtpAldigiTarih.TabIndex = 4;
            this.dtpAldigiTarih.ValueChanged += new System.EventHandler(this.dtpAldigiTarih_ValueChanged);
            // 
            // lblBiraktigiTarih
            // 
            this.lblBiraktigiTarih.AutoSize = true;
            this.lblBiraktigiTarih.Location = new System.Drawing.Point(7, 157);
            this.lblBiraktigiTarih.Name = "lblBiraktigiTarih";
            this.lblBiraktigiTarih.Size = new System.Drawing.Size(105, 15);
            this.lblBiraktigiTarih.TabIndex = 0;
            this.lblBiraktigiTarih.Text = "Bıraktığı Tarih :";
            // 
            // dtpBiraktigiTarih
            // 
            this.dtpBiraktigiTarih.Location = new System.Drawing.Point(128, 157);
            this.dtpBiraktigiTarih.Name = "dtpBiraktigiTarih";
            this.dtpBiraktigiTarih.Size = new System.Drawing.Size(200, 21);
            this.dtpBiraktigiTarih.TabIndex = 4;
            // 
            // AracTahsisEt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(360, 275);
            this.Controls.Add(this.grpAracTahsisi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AracTahsisEt";
            this.Text = "AracTahsisEt";
            this.grpAracTahsisi.ResumeLayout(false);
            this.grpAracTahsisi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAracTahsisi;
        private System.Windows.Forms.Label lblAraclar;
        private System.Windows.Forms.Label lblPersonel;
        private System.Windows.Forms.DateTimePicker dtpBiraktigiTarih;
        private System.Windows.Forms.DateTimePicker dtpAldigiTarih;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnTahsisEt;
        private System.Windows.Forms.Label lblBiraktigiTarih;
        private System.Windows.Forms.Label lblAldigiTarih;
        public System.Windows.Forms.ComboBox cmbPersonel;
        public System.Windows.Forms.ComboBox cmbAraclar;
    }
}