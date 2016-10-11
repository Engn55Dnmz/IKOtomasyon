namespace WinUI.PersonelAlti
{
    partial class BirimBelirle
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
            this.grpBirimBelirle = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBirimKaydet = new System.Windows.Forms.Button();
            this.cmbBirim = new System.Windows.Forms.ComboBox();
            this.lblBirim = new System.Windows.Forms.Label();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.lblDepartman = new System.Windows.Forms.Label();
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.lblPersonel = new System.Windows.Forms.Label();
            this.grpBirimBelirle.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBirimBelirle
            // 
            this.grpBirimBelirle.Controls.Add(this.button2);
            this.grpBirimBelirle.Controls.Add(this.btnBirimKaydet);
            this.grpBirimBelirle.Controls.Add(this.cmbBirim);
            this.grpBirimBelirle.Controls.Add(this.lblBirim);
            this.grpBirimBelirle.Controls.Add(this.cmbDepartman);
            this.grpBirimBelirle.Controls.Add(this.lblDepartman);
            this.grpBirimBelirle.Controls.Add(this.cmbPersonel);
            this.grpBirimBelirle.Controls.Add(this.lblPersonel);
            this.grpBirimBelirle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBirimBelirle.Location = new System.Drawing.Point(12, 12);
            this.grpBirimBelirle.Name = "grpBirimBelirle";
            this.grpBirimBelirle.Size = new System.Drawing.Size(323, 194);
            this.grpBirimBelirle.TabIndex = 0;
            this.grpBirimBelirle.TabStop = false;
            this.grpBirimBelirle.Text = "Personel Birim Belirle";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(212, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 52);
            this.button2.TabIndex = 3;
            this.button2.Text = "Çıkış";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBirimKaydet
            // 
            this.btnBirimKaydet.BackColor = System.Drawing.Color.DarkGray;
            this.btnBirimKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBirimKaydet.Location = new System.Drawing.Point(105, 120);
            this.btnBirimKaydet.Name = "btnBirimKaydet";
            this.btnBirimKaydet.Size = new System.Drawing.Size(101, 52);
            this.btnBirimKaydet.TabIndex = 4;
            this.btnBirimKaydet.Text = "Kaydet";
            this.btnBirimKaydet.UseVisualStyleBackColor = false;
            this.btnBirimKaydet.Click += new System.EventHandler(this.btnBirimKaydet_Click);
            // 
            // cmbBirim
            // 
            this.cmbBirim.FormattingEnabled = true;
            this.cmbBirim.Location = new System.Drawing.Point(105, 91);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(202, 23);
            this.cmbBirim.TabIndex = 1;
            this.cmbBirim.Click += new System.EventHandler(this.cmbBirim_Click);
            // 
            // lblBirim
            // 
            this.lblBirim.AutoSize = true;
            this.lblBirim.Location = new System.Drawing.Point(6, 94);
            this.lblBirim.Name = "lblBirim";
            this.lblBirim.Size = new System.Drawing.Size(49, 15);
            this.lblBirim.TabIndex = 0;
            this.lblBirim.Text = "Birim :";
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Location = new System.Drawing.Point(105, 62);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(202, 23);
            this.cmbDepartman.TabIndex = 1;
            this.cmbDepartman.Click += new System.EventHandler(this.cmbDepartman_Click);
            // 
            // lblDepartman
            // 
            this.lblDepartman.AutoSize = true;
            this.lblDepartman.Location = new System.Drawing.Point(6, 65);
            this.lblDepartman.Name = "lblDepartman";
            this.lblDepartman.Size = new System.Drawing.Size(86, 15);
            this.lblDepartman.TabIndex = 0;
            this.lblDepartman.Text = "Departman :";
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(105, 33);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(202, 23);
            this.cmbPersonel.TabIndex = 1;
            this.cmbPersonel.SelectedIndexChanged += new System.EventHandler(this.cmbPersonel_SelectedIndexChanged);
            // 
            // lblPersonel
            // 
            this.lblPersonel.AutoSize = true;
            this.lblPersonel.Location = new System.Drawing.Point(6, 36);
            this.lblPersonel.Name = "lblPersonel";
            this.lblPersonel.Size = new System.Drawing.Size(72, 15);
            this.lblPersonel.TabIndex = 0;
            this.lblPersonel.Text = "Personel :";
            // 
            // BirimBelirle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(345, 216);
            this.Controls.Add(this.grpBirimBelirle);
            this.Name = "BirimBelirle";
            this.Text = "BirimBelirle";
            this.grpBirimBelirle.ResumeLayout(false);
            this.grpBirimBelirle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBirimBelirle;
        private System.Windows.Forms.Label lblBirim;
        private System.Windows.Forms.Label lblDepartman;
        private System.Windows.Forms.Label lblPersonel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBirimKaydet;
        public System.Windows.Forms.ComboBox cmbBirim;
        public System.Windows.Forms.ComboBox cmbDepartman;
        public System.Windows.Forms.ComboBox cmbPersonel;
    }
}