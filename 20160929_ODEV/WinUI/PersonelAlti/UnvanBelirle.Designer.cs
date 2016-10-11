namespace WinUI.Ekle
{
    partial class UnvanBelirle
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
            this.grpUnvanBelirle = new System.Windows.Forms.GroupBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnUnvanBelirle = new System.Windows.Forms.Button();
            this.cmbUnvan = new System.Windows.Forms.ComboBox();
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.lblUnvan = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.grpUnvanBelirle.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUnvanBelirle
            // 
            this.grpUnvanBelirle.Controls.Add(this.btnCikis);
            this.grpUnvanBelirle.Controls.Add(this.btnUnvanBelirle);
            this.grpUnvanBelirle.Controls.Add(this.cmbUnvan);
            this.grpUnvanBelirle.Controls.Add(this.cmbPersonel);
            this.grpUnvanBelirle.Controls.Add(this.lblUnvan);
            this.grpUnvanBelirle.Controls.Add(this.lblKullanici);
            this.grpUnvanBelirle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpUnvanBelirle.Location = new System.Drawing.Point(12, 12);
            this.grpUnvanBelirle.Name = "grpUnvanBelirle";
            this.grpUnvanBelirle.Size = new System.Drawing.Size(320, 172);
            this.grpUnvanBelirle.TabIndex = 0;
            this.grpUnvanBelirle.TabStop = false;
            this.grpUnvanBelirle.Text = "Ünvan Belirle";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.DarkGray;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(198, 107);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(91, 44);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnUnvanBelirle
            // 
            this.btnUnvanBelirle.BackColor = System.Drawing.Color.DarkGray;
            this.btnUnvanBelirle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUnvanBelirle.Location = new System.Drawing.Point(93, 107);
            this.btnUnvanBelirle.Name = "btnUnvanBelirle";
            this.btnUnvanBelirle.Size = new System.Drawing.Size(99, 44);
            this.btnUnvanBelirle.TabIndex = 3;
            this.btnUnvanBelirle.Text = "Kaydet";
            this.btnUnvanBelirle.UseVisualStyleBackColor = false;
            this.btnUnvanBelirle.Click += new System.EventHandler(this.btnUnvanBelirle_Click);
            // 
            // cmbUnvan
            // 
            this.cmbUnvan.FormattingEnabled = true;
            this.cmbUnvan.Location = new System.Drawing.Point(93, 78);
            this.cmbUnvan.Name = "cmbUnvan";
            this.cmbUnvan.Size = new System.Drawing.Size(196, 23);
            this.cmbUnvan.TabIndex = 2;
            this.cmbUnvan.Click += new System.EventHandler(this.cmbUnvan_Click);
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(93, 31);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(196, 23);
            this.cmbPersonel.TabIndex = 2;
            this.cmbPersonel.SelectedIndexChanged += new System.EventHandler(this.cmbPersonel_SelectedIndexChanged);
            // 
            // lblUnvan
            // 
            this.lblUnvan.AutoSize = true;
            this.lblUnvan.Location = new System.Drawing.Point(6, 81);
            this.lblUnvan.Name = "lblUnvan";
            this.lblUnvan.Size = new System.Drawing.Size(55, 15);
            this.lblUnvan.TabIndex = 1;
            this.lblUnvan.Text = "Ünvan :";
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Location = new System.Drawing.Point(6, 34);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(72, 15);
            this.lblKullanici.TabIndex = 0;
            this.lblKullanici.Text = "Personel :";
            // 
            // UnvanBelirle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(343, 194);
            this.Controls.Add(this.grpUnvanBelirle);
            this.Name = "UnvanBelirle";
            this.Text = "UnvanBelirle";
            this.grpUnvanBelirle.ResumeLayout(false);
            this.grpUnvanBelirle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUnvanBelirle;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnUnvanBelirle;
        private System.Windows.Forms.ComboBox cmbUnvan;
        private System.Windows.Forms.ComboBox cmbPersonel;
        private System.Windows.Forms.Label lblUnvan;
        private System.Windows.Forms.Label lblKullanici;
    }
}