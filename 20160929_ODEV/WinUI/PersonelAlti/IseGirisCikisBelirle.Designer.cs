namespace WinUI.PersonelAlti
{
    partial class IseGirisCikisBelirle
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
            this.grpIseGirisCikis = new System.Windows.Forms.GroupBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnTarihKaydet = new System.Windows.Forms.Button();
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.dtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblIstenCikisTarihi = new System.Windows.Forms.Label();
            this.dtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblIseGirisTarihi = new System.Windows.Forms.Label();
            this.lblPersonel = new System.Windows.Forms.Label();
            this.grpIseGirisCikis.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpIseGirisCikis
            // 
            this.grpIseGirisCikis.Controls.Add(this.btnCikis);
            this.grpIseGirisCikis.Controls.Add(this.btnTarihKaydet);
            this.grpIseGirisCikis.Controls.Add(this.cmbPersonel);
            this.grpIseGirisCikis.Controls.Add(this.dtpCikisTarihi);
            this.grpIseGirisCikis.Controls.Add(this.lblIstenCikisTarihi);
            this.grpIseGirisCikis.Controls.Add(this.dtpGirisTarihi);
            this.grpIseGirisCikis.Controls.Add(this.lblIseGirisTarihi);
            this.grpIseGirisCikis.Controls.Add(this.lblPersonel);
            this.grpIseGirisCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpIseGirisCikis.Location = new System.Drawing.Point(12, 12);
            this.grpIseGirisCikis.Name = "grpIseGirisCikis";
            this.grpIseGirisCikis.Size = new System.Drawing.Size(351, 181);
            this.grpIseGirisCikis.TabIndex = 0;
            this.grpIseGirisCikis.TabStop = false;
            this.grpIseGirisCikis.Text = "İşe Giriş/Çıkış Tanımla";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.DarkGray;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(239, 121);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(88, 42);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnTarihKaydet
            // 
            this.btnTarihKaydet.BackColor = System.Drawing.Color.DarkGray;
            this.btnTarihKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTarihKaydet.Location = new System.Drawing.Point(133, 121);
            this.btnTarihKaydet.Name = "btnTarihKaydet";
            this.btnTarihKaydet.Size = new System.Drawing.Size(100, 42);
            this.btnTarihKaydet.TabIndex = 3;
            this.btnTarihKaydet.Text = "Kaydet";
            this.btnTarihKaydet.UseVisualStyleBackColor = false;
            this.btnTarihKaydet.Click += new System.EventHandler(this.btnTarihKaydet_Click);
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(133, 31);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(194, 23);
            this.cmbPersonel.TabIndex = 2;
            this.cmbPersonel.SelectedIndexChanged += new System.EventHandler(this.cmbPersonel_SelectedIndexChanged);
            this.cmbPersonel.Click += new System.EventHandler(this.cmbPersonel_Click);
            // 
            // dtpCikisTarihi
            // 
            this.dtpCikisTarihi.Enabled = false;
            this.dtpCikisTarihi.Location = new System.Drawing.Point(133, 93);
            this.dtpCikisTarihi.Name = "dtpCikisTarihi";
            this.dtpCikisTarihi.Size = new System.Drawing.Size(194, 21);
            this.dtpCikisTarihi.TabIndex = 1;
            // 
            // lblIstenCikisTarihi
            // 
            this.lblIstenCikisTarihi.AutoSize = true;
            this.lblIstenCikisTarihi.Location = new System.Drawing.Point(6, 98);
            this.lblIstenCikisTarihi.Name = "lblIstenCikisTarihi";
            this.lblIstenCikisTarihi.Size = new System.Drawing.Size(122, 15);
            this.lblIstenCikisTarihi.TabIndex = 0;
            this.lblIstenCikisTarihi.Text = "İşten Çıkış Tarihi :";
            // 
            // dtpGirisTarihi
            // 
            this.dtpGirisTarihi.Location = new System.Drawing.Point(133, 66);
            this.dtpGirisTarihi.Name = "dtpGirisTarihi";
            this.dtpGirisTarihi.Size = new System.Drawing.Size(194, 21);
            this.dtpGirisTarihi.TabIndex = 1;
            this.dtpGirisTarihi.ValueChanged += new System.EventHandler(this.dtpGirisTarihi_ValueChanged);
            // 
            // lblIseGirisTarihi
            // 
            this.lblIseGirisTarihi.AutoSize = true;
            this.lblIseGirisTarihi.Location = new System.Drawing.Point(6, 71);
            this.lblIseGirisTarihi.Name = "lblIseGirisTarihi";
            this.lblIseGirisTarihi.Size = new System.Drawing.Size(109, 15);
            this.lblIseGirisTarihi.TabIndex = 0;
            this.lblIseGirisTarihi.Text = "İşe Giriş Tarihi :";
            // 
            // lblPersonel
            // 
            this.lblPersonel.AutoSize = true;
            this.lblPersonel.Location = new System.Drawing.Point(6, 34);
            this.lblPersonel.Name = "lblPersonel";
            this.lblPersonel.Size = new System.Drawing.Size(72, 15);
            this.lblPersonel.TabIndex = 0;
            this.lblPersonel.Text = "Personel :";
            // 
            // IseGirisCikisBelirle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(373, 204);
            this.Controls.Add(this.grpIseGirisCikis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "IseGirisCikisBelirle";
            this.Text = "IseGirisCikisBelirle";
            this.grpIseGirisCikis.ResumeLayout(false);
            this.grpIseGirisCikis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpIseGirisCikis;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnTarihKaydet;
        private System.Windows.Forms.ComboBox cmbPersonel;
        private System.Windows.Forms.DateTimePicker dtpCikisTarihi;
        private System.Windows.Forms.Label lblIstenCikisTarihi;
        private System.Windows.Forms.DateTimePicker dtpGirisTarihi;
        private System.Windows.Forms.Label lblIseGirisTarihi;
        private System.Windows.Forms.Label lblPersonel;
    }
}