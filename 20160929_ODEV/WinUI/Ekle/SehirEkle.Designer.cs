namespace WinUI
{
    partial class SehirEkle
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
            this.lblSehirAdi = new System.Windows.Forms.Label();
            this.txtSehirAdi = new System.Windows.Forms.TextBox();
            this.btnSehirEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSehirAdi
            // 
            this.lblSehirAdi.AutoSize = true;
            this.lblSehirAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSehirAdi.Location = new System.Drawing.Point(28, 48);
            this.lblSehirAdi.Name = "lblSehirAdi";
            this.lblSehirAdi.Size = new System.Drawing.Size(69, 15);
            this.lblSehirAdi.TabIndex = 0;
            this.lblSehirAdi.Text = "Şehir Adı:";
            // 
            // txtSehirAdi
            // 
            this.txtSehirAdi.Location = new System.Drawing.Point(118, 47);
            this.txtSehirAdi.Name = "txtSehirAdi";
            this.txtSehirAdi.Size = new System.Drawing.Size(137, 20);
            this.txtSehirAdi.TabIndex = 1;
            // 
            // btnSehirEkle
            // 
            this.btnSehirEkle.BackColor = System.Drawing.Color.DarkGray;
            this.btnSehirEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSehirEkle.Location = new System.Drawing.Point(166, 83);
            this.btnSehirEkle.Name = "btnSehirEkle";
            this.btnSehirEkle.Size = new System.Drawing.Size(89, 43);
            this.btnSehirEkle.TabIndex = 2;
            this.btnSehirEkle.Text = "EKLE";
            this.btnSehirEkle.UseVisualStyleBackColor = false;
            this.btnSehirEkle.Click += new System.EventHandler(this.btnSehirEkle_Click);
            // 
            // SehirEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(288, 186);
            this.Controls.Add(this.btnSehirEkle);
            this.Controls.Add(this.txtSehirAdi);
            this.Controls.Add(this.lblSehirAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SehirEkle";
            this.Text = "SehirEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSehirAdi;
        private System.Windows.Forms.TextBox txtSehirAdi;
        private System.Windows.Forms.Button btnSehirEkle;
    }
}