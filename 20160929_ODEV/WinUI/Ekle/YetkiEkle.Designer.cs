namespace WinUI.Ekle
{
    partial class YetkiEkle
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
            this.grpYetkiEkle = new System.Windows.Forms.GroupBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnYetkiEkle = new System.Windows.Forms.Button();
            this.txtUniversite = new System.Windows.Forms.TextBox();
            this.lblYetkiEkle = new System.Windows.Forms.Label();
            this.grpYetkiEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpYetkiEkle
            // 
            this.grpYetkiEkle.Controls.Add(this.btnCikis);
            this.grpYetkiEkle.Controls.Add(this.btnYetkiEkle);
            this.grpYetkiEkle.Controls.Add(this.txtUniversite);
            this.grpYetkiEkle.Controls.Add(this.lblYetkiEkle);
            this.grpYetkiEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpYetkiEkle.Location = new System.Drawing.Point(12, 12);
            this.grpYetkiEkle.Name = "grpYetkiEkle";
            this.grpYetkiEkle.Size = new System.Drawing.Size(251, 122);
            this.grpYetkiEkle.TabIndex = 2;
            this.grpYetkiEkle.TabStop = false;
            this.grpYetkiEkle.Text = "Yetki Ekle";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.DarkGray;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(166, 62);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(68, 45);
            this.btnCikis.TabIndex = 8;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnYetkiEkle
            // 
            this.btnYetkiEkle.BackColor = System.Drawing.Color.DarkGray;
            this.btnYetkiEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYetkiEkle.Location = new System.Drawing.Point(72, 62);
            this.btnYetkiEkle.Name = "btnYetkiEkle";
            this.btnYetkiEkle.Size = new System.Drawing.Size(88, 45);
            this.btnYetkiEkle.TabIndex = 9;
            this.btnYetkiEkle.Text = "Ekle";
            this.btnYetkiEkle.UseVisualStyleBackColor = false;
            // 
            // txtUniversite
            // 
            this.txtUniversite.Location = new System.Drawing.Point(72, 35);
            this.txtUniversite.Name = "txtUniversite";
            this.txtUniversite.Size = new System.Drawing.Size(163, 21);
            this.txtUniversite.TabIndex = 1;
            // 
            // lblYetkiEkle
            // 
            this.lblYetkiEkle.AutoSize = true;
            this.lblYetkiEkle.Location = new System.Drawing.Point(6, 38);
            this.lblYetkiEkle.Name = "lblYetkiEkle";
            this.lblYetkiEkle.Size = new System.Drawing.Size(46, 15);
            this.lblYetkiEkle.TabIndex = 0;
            this.lblYetkiEkle.Text = "Yetki :";
            // 
            // YetkiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(274, 143);
            this.Controls.Add(this.grpYetkiEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "YetkiEkle";
            this.Text = "YetkiEkle";
            this.grpYetkiEkle.ResumeLayout(false);
            this.grpYetkiEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpYetkiEkle;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnYetkiEkle;
        private System.Windows.Forms.TextBox txtUniversite;
        private System.Windows.Forms.Label lblYetkiEkle;
    }
}