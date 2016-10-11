namespace WinUI.Ekle
{
    partial class IlceEkle
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
            this.grpIlceEkle = new System.Windows.Forms.GroupBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnIlceEkle = new System.Windows.Forms.Button();
            this.txtIlceAdi = new System.Windows.Forms.TextBox();
            this.cmbSehir = new System.Windows.Forms.ComboBox();
            this.lblIlce = new System.Windows.Forms.Label();
            this.lblSehir = new System.Windows.Forms.Label();
            this.grpIlceEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpIlceEkle
            // 
            this.grpIlceEkle.Controls.Add(this.btnCikis);
            this.grpIlceEkle.Controls.Add(this.btnIlceEkle);
            this.grpIlceEkle.Controls.Add(this.txtIlceAdi);
            this.grpIlceEkle.Controls.Add(this.cmbSehir);
            this.grpIlceEkle.Controls.Add(this.lblIlce);
            this.grpIlceEkle.Controls.Add(this.lblSehir);
            this.grpIlceEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpIlceEkle.Location = new System.Drawing.Point(12, 12);
            this.grpIlceEkle.Name = "grpIlceEkle";
            this.grpIlceEkle.Size = new System.Drawing.Size(277, 163);
            this.grpIlceEkle.TabIndex = 0;
            this.grpIlceEkle.TabStop = false;
            this.grpIlceEkle.Text = "İlçe Ekle";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.DarkGray;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(183, 100);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(80, 45);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnIlceEkle
            // 
            this.btnIlceEkle.BackColor = System.Drawing.Color.DarkGray;
            this.btnIlceEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIlceEkle.Location = new System.Drawing.Point(89, 100);
            this.btnIlceEkle.Name = "btnIlceEkle";
            this.btnIlceEkle.Size = new System.Drawing.Size(88, 45);
            this.btnIlceEkle.TabIndex = 7;
            this.btnIlceEkle.Text = "Ekle";
            this.btnIlceEkle.UseVisualStyleBackColor = false;
            this.btnIlceEkle.Click += new System.EventHandler(this.btnIlceEkle_Click);
            // 
            // txtIlceAdi
            // 
            this.txtIlceAdi.Location = new System.Drawing.Point(89, 73);
            this.txtIlceAdi.Name = "txtIlceAdi";
            this.txtIlceAdi.Size = new System.Drawing.Size(174, 21);
            this.txtIlceAdi.TabIndex = 2;
            // 
            // cmbSehir
            // 
            this.cmbSehir.FormattingEnabled = true;
            this.cmbSehir.Location = new System.Drawing.Point(89, 32);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Size = new System.Drawing.Size(174, 23);
            this.cmbSehir.TabIndex = 1;
            this.cmbSehir.SelectedIndexChanged += new System.EventHandler(this.cmbSehir_SelectedIndexChanged);
            // 
            // lblIlce
            // 
            this.lblIlce.AutoSize = true;
            this.lblIlce.Location = new System.Drawing.Point(6, 76);
            this.lblIlce.Name = "lblIlce";
            this.lblIlce.Size = new System.Drawing.Size(38, 15);
            this.lblIlce.TabIndex = 0;
            this.lblIlce.Text = "İlçe :";
            // 
            // lblSehir
            // 
            this.lblSehir.AutoSize = true;
            this.lblSehir.Location = new System.Drawing.Point(6, 35);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(49, 15);
            this.lblSehir.TabIndex = 0;
            this.lblSehir.Text = "Şehir :";
            // 
            // IlceEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(298, 188);
            this.Controls.Add(this.grpIlceEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "IlceEkle";
            this.Text = "IlceEkle";
            this.grpIlceEkle.ResumeLayout(false);
            this.grpIlceEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpIlceEkle;
        private System.Windows.Forms.Label lblSehir;
        public System.Windows.Forms.ComboBox cmbSehir;
        private System.Windows.Forms.TextBox txtIlceAdi;
        private System.Windows.Forms.Label lblIlce;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnIlceEkle;
    }
}