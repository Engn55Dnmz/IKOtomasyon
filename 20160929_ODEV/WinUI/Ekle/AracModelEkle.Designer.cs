namespace WinUI
{
    partial class AracModelEkle
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
            this.btnModelEkle = new System.Windows.Forms.Button();
            this.txtModelAdi = new System.Windows.Forms.TextBox();
            this.lblModelAdi = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.cmbMarkaAdi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnModelEkle
            // 
            this.btnModelEkle.BackColor = System.Drawing.Color.DarkGray;
            this.btnModelEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnModelEkle.Location = new System.Drawing.Point(174, 145);
            this.btnModelEkle.Name = "btnModelEkle";
            this.btnModelEkle.Size = new System.Drawing.Size(89, 43);
            this.btnModelEkle.TabIndex = 8;
            this.btnModelEkle.Text = "EKLE";
            this.btnModelEkle.UseVisualStyleBackColor = false;
            this.btnModelEkle.Click += new System.EventHandler(this.btnModelEkle_Click);
            // 
            // txtModelAdi
            // 
            this.txtModelAdi.Location = new System.Drawing.Point(126, 106);
            this.txtModelAdi.Name = "txtModelAdi";
            this.txtModelAdi.Size = new System.Drawing.Size(137, 20);
            this.txtModelAdi.TabIndex = 7;
            // 
            // lblModelAdi
            // 
            this.lblModelAdi.AutoSize = true;
            this.lblModelAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblModelAdi.Location = new System.Drawing.Point(24, 106);
            this.lblModelAdi.Name = "lblModelAdi";
            this.lblModelAdi.Size = new System.Drawing.Size(75, 15);
            this.lblModelAdi.TabIndex = 6;
            this.lblModelAdi.Text = "Model Adı:";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMarka.Location = new System.Drawing.Point(24, 68);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(75, 15);
            this.lblMarka.TabIndex = 6;
            this.lblMarka.Text = "Marka Adı:";
            // 
            // cmbMarkaAdi
            // 
            this.cmbMarkaAdi.FormattingEnabled = true;
            this.cmbMarkaAdi.Location = new System.Drawing.Point(126, 68);
            this.cmbMarkaAdi.Name = "cmbMarkaAdi";
            this.cmbMarkaAdi.Size = new System.Drawing.Size(137, 21);
            this.cmbMarkaAdi.TabIndex = 9;
            // 
            // AracModelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(311, 269);
            this.Controls.Add(this.cmbMarkaAdi);
            this.Controls.Add(this.btnModelEkle);
            this.Controls.Add(this.txtModelAdi);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.lblModelAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AracModelEkle";
            this.Text = "AracModelEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModelEkle;
        private System.Windows.Forms.TextBox txtModelAdi;
        private System.Windows.Forms.Label lblModelAdi;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.ComboBox cmbMarkaAdi;
    }
}