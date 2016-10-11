namespace WinUI.PersonelAlti
{
    partial class IzinTanımla
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
            this.grpIzinTanimla = new System.Windows.Forms.GroupBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnIzinKaydet = new System.Windows.Forms.Button();
            this.dtpIzinBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpIzinBaslamaTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbIzinTuru = new System.Windows.Forms.ComboBox();
            this.lblIzinBitisTarihi = new System.Windows.Forms.Label();
            this.lblIzınBasşamaTarihi = new System.Windows.Forms.Label();
            this.lblIzinTuru = new System.Windows.Forms.Label();
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.lblPersonel = new System.Windows.Forms.Label();
            this.grpIzinTanimla.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpIzinTanimla
            // 
            this.grpIzinTanimla.Controls.Add(this.btnCikis);
            this.grpIzinTanimla.Controls.Add(this.btnIzinKaydet);
            this.grpIzinTanimla.Controls.Add(this.dtpIzinBitisTarihi);
            this.grpIzinTanimla.Controls.Add(this.dtpIzinBaslamaTarihi);
            this.grpIzinTanimla.Controls.Add(this.cmbIzinTuru);
            this.grpIzinTanimla.Controls.Add(this.lblIzinBitisTarihi);
            this.grpIzinTanimla.Controls.Add(this.lblIzınBasşamaTarihi);
            this.grpIzinTanimla.Controls.Add(this.lblIzinTuru);
            this.grpIzinTanimla.Controls.Add(this.cmbPersonel);
            this.grpIzinTanimla.Controls.Add(this.lblPersonel);
            this.grpIzinTanimla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpIzinTanimla.Location = new System.Drawing.Point(12, 12);
            this.grpIzinTanimla.Name = "grpIzinTanimla";
            this.grpIzinTanimla.Size = new System.Drawing.Size(373, 225);
            this.grpIzinTanimla.TabIndex = 0;
            this.grpIzinTanimla.TabStop = false;
            this.grpIzinTanimla.Text = "Personel İzin Tanımla";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.DarkGray;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(268, 153);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(86, 49);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnIzinKaydet
            // 
            this.btnIzinKaydet.BackColor = System.Drawing.Color.DarkGray;
            this.btnIzinKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIzinKaydet.Location = new System.Drawing.Point(161, 153);
            this.btnIzinKaydet.Name = "btnIzinKaydet";
            this.btnIzinKaydet.Size = new System.Drawing.Size(101, 49);
            this.btnIzinKaydet.TabIndex = 3;
            this.btnIzinKaydet.Text = "Kaydet";
            this.btnIzinKaydet.UseVisualStyleBackColor = false;
            this.btnIzinKaydet.Click += new System.EventHandler(this.btnIzinKaydet_Click);
            // 
            // dtpIzinBitisTarihi
            // 
            this.dtpIzinBitisTarihi.Location = new System.Drawing.Point(161, 126);
            this.dtpIzinBitisTarihi.Name = "dtpIzinBitisTarihi";
            this.dtpIzinBitisTarihi.Size = new System.Drawing.Size(193, 21);
            this.dtpIzinBitisTarihi.TabIndex = 2;
            // 
            // dtpIzinBaslamaTarihi
            // 
            this.dtpIzinBaslamaTarihi.Location = new System.Drawing.Point(161, 98);
            this.dtpIzinBaslamaTarihi.Name = "dtpIzinBaslamaTarihi";
            this.dtpIzinBaslamaTarihi.Size = new System.Drawing.Size(193, 21);
            this.dtpIzinBaslamaTarihi.TabIndex = 2;
            this.dtpIzinBaslamaTarihi.ValueChanged += new System.EventHandler(this.dtpIzinBaslamaTarihi_ValueChanged);
            // 
            // cmbIzinTuru
            // 
            this.cmbIzinTuru.FormattingEnabled = true;
            this.cmbIzinTuru.Location = new System.Drawing.Point(161, 56);
            this.cmbIzinTuru.Name = "cmbIzinTuru";
            this.cmbIzinTuru.Size = new System.Drawing.Size(193, 23);
            this.cmbIzinTuru.TabIndex = 1;
            this.cmbIzinTuru.Click += new System.EventHandler(this.cmbIzinTuru_Click);
            // 
            // lblIzinBitisTarihi
            // 
            this.lblIzinBitisTarihi.AutoSize = true;
            this.lblIzinBitisTarihi.Location = new System.Drawing.Point(6, 131);
            this.lblIzinBitisTarihi.Name = "lblIzinBitisTarihi";
            this.lblIzinBitisTarihi.Size = new System.Drawing.Size(111, 15);
            this.lblIzinBitisTarihi.TabIndex = 0;
            this.lblIzinBitisTarihi.Text = "İzin Bitiş Tarihi :";
            // 
            // lblIzınBasşamaTarihi
            // 
            this.lblIzınBasşamaTarihi.AutoSize = true;
            this.lblIzınBasşamaTarihi.Location = new System.Drawing.Point(6, 103);
            this.lblIzınBasşamaTarihi.Name = "lblIzınBasşamaTarihi";
            this.lblIzınBasşamaTarihi.Size = new System.Drawing.Size(139, 15);
            this.lblIzınBasşamaTarihi.TabIndex = 0;
            this.lblIzınBasşamaTarihi.Text = "İzin Başlama Tarihi :";
            // 
            // lblIzinTuru
            // 
            this.lblIzinTuru.AutoSize = true;
            this.lblIzinTuru.Location = new System.Drawing.Point(6, 64);
            this.lblIzinTuru.Name = "lblIzinTuru";
            this.lblIzinTuru.Size = new System.Drawing.Size(71, 15);
            this.lblIzinTuru.TabIndex = 0;
            this.lblIzinTuru.Text = "İzin Türü :";
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(161, 27);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(193, 23);
            this.cmbPersonel.TabIndex = 1;
            // 
            // lblPersonel
            // 
            this.lblPersonel.AutoSize = true;
            this.lblPersonel.Location = new System.Drawing.Point(6, 35);
            this.lblPersonel.Name = "lblPersonel";
            this.lblPersonel.Size = new System.Drawing.Size(72, 15);
            this.lblPersonel.TabIndex = 0;
            this.lblPersonel.Text = "Personel :";
            // 
            // IzinTanımla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(394, 246);
            this.Controls.Add(this.grpIzinTanimla);
            this.Name = "IzinTanımla";
            this.Text = "IzinTanımla";
            this.grpIzinTanimla.ResumeLayout(false);
            this.grpIzinTanimla.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpIzinTanimla;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnIzinKaydet;
        private System.Windows.Forms.DateTimePicker dtpIzinBitisTarihi;
        private System.Windows.Forms.DateTimePicker dtpIzinBaslamaTarihi;
        private System.Windows.Forms.ComboBox cmbIzinTuru;
        private System.Windows.Forms.Label lblIzinBitisTarihi;
        private System.Windows.Forms.Label lblIzınBasşamaTarihi;
        private System.Windows.Forms.Label lblIzinTuru;
        private System.Windows.Forms.ComboBox cmbPersonel;
        private System.Windows.Forms.Label lblPersonel;
    }
}