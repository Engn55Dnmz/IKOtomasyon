namespace WinUI.Ekle
{
    partial class MaasEkle
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
            this.grpMaasEkle = new System.Windows.Forms.GroupBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnMaasEkle = new System.Windows.Forms.Button();
            this.txtMaasTutari = new System.Windows.Forms.TextBox();
            this.lblMaas = new System.Windows.Forms.Label();
            this.grpMaasEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMaasEkle
            // 
            this.grpMaasEkle.Controls.Add(this.btnCikis);
            this.grpMaasEkle.Controls.Add(this.btnMaasEkle);
            this.grpMaasEkle.Controls.Add(this.txtMaasTutari);
            this.grpMaasEkle.Controls.Add(this.lblMaas);
            this.grpMaasEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpMaasEkle.Location = new System.Drawing.Point(12, 12);
            this.grpMaasEkle.Name = "grpMaasEkle";
            this.grpMaasEkle.Size = new System.Drawing.Size(299, 122);
            this.grpMaasEkle.TabIndex = 0;
            this.grpMaasEkle.TabStop = false;
            this.grpMaasEkle.Text = "Maaş Ekle";
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
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnMaasEkle
            // 
            this.btnMaasEkle.BackColor = System.Drawing.Color.DarkGray;
            this.btnMaasEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMaasEkle.Location = new System.Drawing.Point(123, 62);
            this.btnMaasEkle.Name = "btnMaasEkle";
            this.btnMaasEkle.Size = new System.Drawing.Size(88, 45);
            this.btnMaasEkle.TabIndex = 9;
            this.btnMaasEkle.Text = "Ekle";
            this.btnMaasEkle.UseVisualStyleBackColor = false;
            this.btnMaasEkle.Click += new System.EventHandler(this.btnMaasEkle_Click);
            // 
            // txtMaasTutari
            // 
            this.txtMaasTutari.Location = new System.Drawing.Point(123, 35);
            this.txtMaasTutari.Name = "txtMaasTutari";
            this.txtMaasTutari.Size = new System.Drawing.Size(163, 21);
            this.txtMaasTutari.TabIndex = 1;
            // 
            // lblMaas
            // 
            this.lblMaas.AutoSize = true;
            this.lblMaas.Location = new System.Drawing.Point(6, 38);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(98, 15);
            this.lblMaas.TabIndex = 0;
            this.lblMaas.Text = "Maaş Miktarı :";
            // 
            // MaasEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(321, 148);
            this.Controls.Add(this.grpMaasEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MaasEkle";
            this.Text = "MaasEkle";
            this.grpMaasEkle.ResumeLayout(false);
            this.grpMaasEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMaasEkle;
        private System.Windows.Forms.TextBox txtMaasTutari;
        private System.Windows.Forms.Label lblMaas;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnMaasEkle;
    }
}