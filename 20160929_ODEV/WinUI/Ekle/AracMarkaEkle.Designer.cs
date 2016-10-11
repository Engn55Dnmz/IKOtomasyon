namespace WinUI
{
    partial class AracMarkaEkle
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
            this.btnMarkaEkle = new System.Windows.Forms.Button();
            this.txtMarkaAdi = new System.Windows.Forms.TextBox();
            this.lblMarkaAdi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMarkaEkle
            // 
            this.btnMarkaEkle.BackColor = System.Drawing.Color.DarkGray;
            this.btnMarkaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMarkaEkle.Location = new System.Drawing.Point(167, 127);
            this.btnMarkaEkle.Name = "btnMarkaEkle";
            this.btnMarkaEkle.Size = new System.Drawing.Size(89, 43);
            this.btnMarkaEkle.TabIndex = 5;
            this.btnMarkaEkle.Text = "EKLE";
            this.btnMarkaEkle.UseVisualStyleBackColor = false;
            this.btnMarkaEkle.Click += new System.EventHandler(this.btnMarkaEkle_Click);
            // 
            // txtMarkaAdi
            // 
            this.txtMarkaAdi.Location = new System.Drawing.Point(119, 91);
            this.txtMarkaAdi.Name = "txtMarkaAdi";
            this.txtMarkaAdi.Size = new System.Drawing.Size(137, 20);
            this.txtMarkaAdi.TabIndex = 4;
            // 
            // lblMarkaAdi
            // 
            this.lblMarkaAdi.AutoSize = true;
            this.lblMarkaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMarkaAdi.Location = new System.Drawing.Point(29, 92);
            this.lblMarkaAdi.Name = "lblMarkaAdi";
            this.lblMarkaAdi.Size = new System.Drawing.Size(75, 15);
            this.lblMarkaAdi.TabIndex = 3;
            this.lblMarkaAdi.Text = "Marka Adı:";
            // 
            // AracMarkaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnMarkaEkle);
            this.Controls.Add(this.txtMarkaAdi);
            this.Controls.Add(this.lblMarkaAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AracMarkaEkle";
            this.Text = "AracMarkaEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMarkaEkle;
        private System.Windows.Forms.TextBox txtMarkaAdi;
        private System.Windows.Forms.Label lblMarkaAdi;
    }
}