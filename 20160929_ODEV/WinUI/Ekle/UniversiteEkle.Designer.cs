namespace WinUI.Ekle
{
    partial class UniversiteEkle
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
            this.grpUniversiteEkle = new System.Windows.Forms.GroupBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnUniversiteEkle = new System.Windows.Forms.Button();
            this.txtUniversite = new System.Windows.Forms.TextBox();
            this.lblUniversite = new System.Windows.Forms.Label();
            this.grpUniversiteEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUniversiteEkle
            // 
            this.grpUniversiteEkle.Controls.Add(this.btnCikis);
            this.grpUniversiteEkle.Controls.Add(this.btnUniversiteEkle);
            this.grpUniversiteEkle.Controls.Add(this.txtUniversite);
            this.grpUniversiteEkle.Controls.Add(this.lblUniversite);
            this.grpUniversiteEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpUniversiteEkle.Location = new System.Drawing.Point(12, 12);
            this.grpUniversiteEkle.Name = "grpUniversiteEkle";
            this.grpUniversiteEkle.Size = new System.Drawing.Size(299, 122);
            this.grpUniversiteEkle.TabIndex = 1;
            this.grpUniversiteEkle.TabStop = false;
            this.grpUniversiteEkle.Text = "Üniversite Ekle";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.DarkGray;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(217, 62);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(68, 45);
            this.btnCikis.TabIndex = 8;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            // 
            // btnUniversiteEkle
            // 
            this.btnUniversiteEkle.BackColor = System.Drawing.Color.DarkGray;
            this.btnUniversiteEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUniversiteEkle.Location = new System.Drawing.Point(123, 62);
            this.btnUniversiteEkle.Name = "btnUniversiteEkle";
            this.btnUniversiteEkle.Size = new System.Drawing.Size(88, 45);
            this.btnUniversiteEkle.TabIndex = 9;
            this.btnUniversiteEkle.Text = "Ekle";
            this.btnUniversiteEkle.UseVisualStyleBackColor = false;
            this.btnUniversiteEkle.Click += new System.EventHandler(this.btnUniversiteEkle_Click);
            // 
            // txtUniversite
            // 
            this.txtUniversite.Location = new System.Drawing.Point(123, 35);
            this.txtUniversite.Name = "txtUniversite";
            this.txtUniversite.Size = new System.Drawing.Size(163, 21);
            this.txtUniversite.TabIndex = 1;
            // 
            // lblUniversite
            // 
            this.lblUniversite.AutoSize = true;
            this.lblUniversite.Location = new System.Drawing.Point(6, 38);
            this.lblUniversite.Name = "lblUniversite";
            this.lblUniversite.Size = new System.Drawing.Size(79, 15);
            this.lblUniversite.TabIndex = 0;
            this.lblUniversite.Text = "Üniversite :";
            // 
            // UniversiteEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(325, 150);
            this.Controls.Add(this.grpUniversiteEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UniversiteEkle";
            this.Text = "UniversiteEkle";
            this.grpUniversiteEkle.ResumeLayout(false);
            this.grpUniversiteEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUniversiteEkle;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnUniversiteEkle;
        private System.Windows.Forms.TextBox txtUniversite;
        private System.Windows.Forms.Label lblUniversite;
    }
}