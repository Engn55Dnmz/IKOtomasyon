namespace IKProje
{
    partial class FakulteEkle
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
            this.grpFakulte = new System.Windows.Forms.GroupBox();
            this.btnFakulteEkle = new System.Windows.Forms.Button();
            this.txtFakulteAdi = new System.Windows.Forms.TextBox();
            this.lblFakulteAdi = new System.Windows.Forms.Label();
            this.lblOkulAdi = new System.Windows.Forms.Label();
            this.cmbUniversiteAdi = new System.Windows.Forms.ComboBox();
            this.grpFakulte.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFakulte
            // 
            this.grpFakulte.Controls.Add(this.cmbUniversiteAdi);
            this.grpFakulte.Controls.Add(this.btnFakulteEkle);
            this.grpFakulte.Controls.Add(this.txtFakulteAdi);
            this.grpFakulte.Controls.Add(this.lblOkulAdi);
            this.grpFakulte.Controls.Add(this.lblFakulteAdi);
            this.grpFakulte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpFakulte.Location = new System.Drawing.Point(12, 12);
            this.grpFakulte.Name = "grpFakulte";
            this.grpFakulte.Size = new System.Drawing.Size(302, 143);
            this.grpFakulte.TabIndex = 0;
            this.grpFakulte.TabStop = false;
            this.grpFakulte.Text = "Fakülte Ekle";
            // 
            // btnFakulteEkle
            // 
            this.btnFakulteEkle.BackColor = System.Drawing.Color.DarkGray;
            this.btnFakulteEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFakulteEkle.Location = new System.Drawing.Point(167, 87);
            this.btnFakulteEkle.Name = "btnFakulteEkle";
            this.btnFakulteEkle.Size = new System.Drawing.Size(90, 43);
            this.btnFakulteEkle.TabIndex = 5;
            this.btnFakulteEkle.Text = "Ekle";
            this.btnFakulteEkle.UseVisualStyleBackColor = false;
            this.btnFakulteEkle.Click += new System.EventHandler(this.btnFakulteEkle_Click);
            // 
            // txtFakulteAdi
            // 
            this.txtFakulteAdi.Location = new System.Drawing.Point(128, 60);
            this.txtFakulteAdi.Name = "txtFakulteAdi";
            this.txtFakulteAdi.Size = new System.Drawing.Size(168, 21);
            this.txtFakulteAdi.TabIndex = 4;
            // 
            // lblFakulteAdi
            // 
            this.lblFakulteAdi.AutoSize = true;
            this.lblFakulteAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFakulteAdi.Location = new System.Drawing.Point(6, 63);
            this.lblFakulteAdi.Name = "lblFakulteAdi";
            this.lblFakulteAdi.Size = new System.Drawing.Size(86, 15);
            this.lblFakulteAdi.TabIndex = 3;
            this.lblFakulteAdi.Text = "Fakülte Adı :";
            // 
            // lblOkulAdi
            // 
            this.lblOkulAdi.AutoSize = true;
            this.lblOkulAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOkulAdi.Location = new System.Drawing.Point(6, 25);
            this.lblOkulAdi.Name = "lblOkulAdi";
            this.lblOkulAdi.Size = new System.Drawing.Size(103, 15);
            this.lblOkulAdi.TabIndex = 3;
            this.lblOkulAdi.Text = "Üniversite Adı :";
            // 
            // cmbUniversiteAdi
            // 
            this.cmbUniversiteAdi.FormattingEnabled = true;
            this.cmbUniversiteAdi.Location = new System.Drawing.Point(128, 22);
            this.cmbUniversiteAdi.Name = "cmbUniversiteAdi";
            this.cmbUniversiteAdi.Size = new System.Drawing.Size(168, 23);
            this.cmbUniversiteAdi.TabIndex = 6;
            // 
            // FakulteEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(322, 167);
            this.Controls.Add(this.grpFakulte);
            this.Name = "FakulteEkle";
            this.Text = "FakulteEkle";
            this.grpFakulte.ResumeLayout(false);
            this.grpFakulte.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFakulte;
        private System.Windows.Forms.Button btnFakulteEkle;
        private System.Windows.Forms.TextBox txtFakulteAdi;
        private System.Windows.Forms.Label lblFakulteAdi;
        private System.Windows.Forms.Label lblOkulAdi;
        public System.Windows.Forms.ComboBox cmbUniversiteAdi;

    }
}