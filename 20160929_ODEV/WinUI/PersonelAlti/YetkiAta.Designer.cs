namespace WinUI.PersonelAlti
{
    partial class YetkiAta
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
            this.grpYetkiAta = new System.Windows.Forms.GroupBox();
            this.lblPersonel = new System.Windows.Forms.Label();
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.lblYetki = new System.Windows.Forms.Label();
            this.cmbYetki = new System.Windows.Forms.ComboBox();
            this.btnYetkiAta = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.grpYetkiAta.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpYetkiAta
            // 
            this.grpYetkiAta.Controls.Add(this.btnCikis);
            this.grpYetkiAta.Controls.Add(this.btnYetkiAta);
            this.grpYetkiAta.Controls.Add(this.cmbYetki);
            this.grpYetkiAta.Controls.Add(this.lblYetki);
            this.grpYetkiAta.Controls.Add(this.cmbPersonel);
            this.grpYetkiAta.Controls.Add(this.lblPersonel);
            this.grpYetkiAta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpYetkiAta.Location = new System.Drawing.Point(12, 12);
            this.grpYetkiAta.Name = "grpYetkiAta";
            this.grpYetkiAta.Size = new System.Drawing.Size(337, 188);
            this.grpYetkiAta.TabIndex = 0;
            this.grpYetkiAta.TabStop = false;
            this.grpYetkiAta.Text = "Yetki Ata";
            // 
            // lblPersonel
            // 
            this.lblPersonel.AutoSize = true;
            this.lblPersonel.Location = new System.Drawing.Point(16, 37);
            this.lblPersonel.Name = "lblPersonel";
            this.lblPersonel.Size = new System.Drawing.Size(72, 15);
            this.lblPersonel.TabIndex = 0;
            this.lblPersonel.Text = "Personel :";
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(116, 34);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(205, 23);
            this.cmbPersonel.TabIndex = 1;
            this.cmbPersonel.Click += new System.EventHandler(this.cmbPersonel_Click);
            // 
            // lblYetki
            // 
            this.lblYetki.AutoSize = true;
            this.lblYetki.Location = new System.Drawing.Point(16, 83);
            this.lblYetki.Name = "lblYetki";
            this.lblYetki.Size = new System.Drawing.Size(46, 15);
            this.lblYetki.TabIndex = 0;
            this.lblYetki.Text = "Yetki :";
            // 
            // cmbYetki
            // 
            this.cmbYetki.FormattingEnabled = true;
            this.cmbYetki.Location = new System.Drawing.Point(116, 80);
            this.cmbYetki.Name = "cmbYetki";
            this.cmbYetki.Size = new System.Drawing.Size(205, 23);
            this.cmbYetki.TabIndex = 1;
            this.cmbYetki.Click += new System.EventHandler(this.cmbYetki_Click);
            // 
            // btnYetkiAta
            // 
            this.btnYetkiAta.BackColor = System.Drawing.Color.DarkGray;
            this.btnYetkiAta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYetkiAta.Location = new System.Drawing.Point(116, 120);
            this.btnYetkiAta.Name = "btnYetkiAta";
            this.btnYetkiAta.Size = new System.Drawing.Size(103, 48);
            this.btnYetkiAta.TabIndex = 2;
            this.btnYetkiAta.Text = "Kaydet";
            this.btnYetkiAta.UseVisualStyleBackColor = false;
            this.btnYetkiAta.Click += new System.EventHandler(this.btnYetkiAta_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.DarkGray;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(225, 120);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(96, 48);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            // 
            // YetkiAta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(359, 209);
            this.Controls.Add(this.grpYetkiAta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "YetkiAta";
            this.Text = "YetkiAta";
            this.grpYetkiAta.ResumeLayout(false);
            this.grpYetkiAta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpYetkiAta;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnYetkiAta;
        private System.Windows.Forms.Label lblYetki;
        private System.Windows.Forms.Label lblPersonel;
        public System.Windows.Forms.ComboBox cmbYetki;
        public System.Windows.Forms.ComboBox cmbPersonel;
    }
}