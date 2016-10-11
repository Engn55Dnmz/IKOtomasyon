namespace WinUI
{
    partial class SemtEkle
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
            this.cmbIlceAdi = new System.Windows.Forms.ComboBox();
            this.btnSemtEkle = new System.Windows.Forms.Button();
            this.txtSemtAdi = new System.Windows.Forms.TextBox();
            this.lblIlceAdi = new System.Windows.Forms.Label();
            this.lblSemtAdi = new System.Windows.Forms.Label();
            this.cmbSehirAdi = new System.Windows.Forms.ComboBox();
            this.lblSehirAdi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbIlceAdi
            // 
            this.cmbIlceAdi.FormattingEnabled = true;
            this.cmbIlceAdi.Location = new System.Drawing.Point(126, 76);
            this.cmbIlceAdi.Name = "cmbIlceAdi";
            this.cmbIlceAdi.Size = new System.Drawing.Size(137, 21);
            this.cmbIlceAdi.TabIndex = 11;
            // 
            // btnSemtEkle
            // 
            this.btnSemtEkle.BackColor = System.Drawing.Color.DarkGray;
            this.btnSemtEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSemtEkle.Location = new System.Drawing.Point(162, 156);
            this.btnSemtEkle.Name = "btnSemtEkle";
            this.btnSemtEkle.Size = new System.Drawing.Size(90, 44);
            this.btnSemtEkle.TabIndex = 10;
            this.btnSemtEkle.Text = "EKLE";
            this.btnSemtEkle.UseVisualStyleBackColor = false;
            this.btnSemtEkle.Click += new System.EventHandler(this.btnSemtEkle_Click);
            // 
            // txtSemtAdi
            // 
            this.txtSemtAdi.Location = new System.Drawing.Point(126, 113);
            this.txtSemtAdi.Name = "txtSemtAdi";
            this.txtSemtAdi.Size = new System.Drawing.Size(137, 20);
            this.txtSemtAdi.TabIndex = 9;
            // 
            // lblIlceAdi
            // 
            this.lblIlceAdi.AutoSize = true;
            this.lblIlceAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIlceAdi.Location = new System.Drawing.Point(35, 77);
            this.lblIlceAdi.Name = "lblIlceAdi";
            this.lblIlceAdi.Size = new System.Drawing.Size(62, 15);
            this.lblIlceAdi.TabIndex = 7;
            this.lblIlceAdi.Text = "İlçe Adı :";
            // 
            // lblSemtAdi
            // 
            this.lblSemtAdi.AutoSize = true;
            this.lblSemtAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSemtAdi.Location = new System.Drawing.Point(35, 113);
            this.lblSemtAdi.Name = "lblSemtAdi";
            this.lblSemtAdi.Size = new System.Drawing.Size(68, 15);
            this.lblSemtAdi.TabIndex = 8;
            this.lblSemtAdi.Text = "Semt Adı:";
            // 
            // cmbSehirAdi
            // 
            this.cmbSehirAdi.FormattingEnabled = true;
            this.cmbSehirAdi.Location = new System.Drawing.Point(126, 43);
            this.cmbSehirAdi.Name = "cmbSehirAdi";
            this.cmbSehirAdi.Size = new System.Drawing.Size(137, 21);
            this.cmbSehirAdi.TabIndex = 13;
            this.cmbSehirAdi.SelectedIndexChanged += new System.EventHandler(this.cmbSehirAdi_SelectedIndexChanged);
            // 
            // lblSehirAdi
            // 
            this.lblSehirAdi.AutoSize = true;
            this.lblSehirAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSehirAdi.Location = new System.Drawing.Point(35, 44);
            this.lblSehirAdi.Name = "lblSehirAdi";
            this.lblSehirAdi.Size = new System.Drawing.Size(73, 15);
            this.lblSehirAdi.TabIndex = 12;
            this.lblSehirAdi.Text = "Şehir Adı :";
            // 
            // SemtEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmbSehirAdi);
            this.Controls.Add(this.lblSehirAdi);
            this.Controls.Add(this.cmbIlceAdi);
            this.Controls.Add(this.btnSemtEkle);
            this.Controls.Add(this.txtSemtAdi);
            this.Controls.Add(this.lblIlceAdi);
            this.Controls.Add(this.lblSemtAdi);
            this.Name = "SemtEkle";
            this.Text = "SemtEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbIlceAdi;
        private System.Windows.Forms.Button btnSemtEkle;
        private System.Windows.Forms.TextBox txtSemtAdi;
        private System.Windows.Forms.Label lblIlceAdi;
        private System.Windows.Forms.Label lblSemtAdi;
        private System.Windows.Forms.ComboBox cmbSehirAdi;
        private System.Windows.Forms.Label lblSehirAdi;
    }
}