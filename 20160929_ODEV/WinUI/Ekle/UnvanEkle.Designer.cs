namespace WinUI.Ekle
{
    partial class UnvanEkle
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
            this.grpUnvanEkle = new System.Windows.Forms.GroupBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnUnvanEkle = new System.Windows.Forms.Button();
            this.txtUnvan = new System.Windows.Forms.TextBox();
            this.lblUniversite = new System.Windows.Forms.Label();
            this.grpUnvanEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUnvanEkle
            // 
            this.grpUnvanEkle.Controls.Add(this.btnCikis);
            this.grpUnvanEkle.Controls.Add(this.btnUnvanEkle);
            this.grpUnvanEkle.Controls.Add(this.txtUnvan);
            this.grpUnvanEkle.Controls.Add(this.lblUniversite);
            this.grpUnvanEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpUnvanEkle.Location = new System.Drawing.Point(12, 12);
            this.grpUnvanEkle.Name = "grpUnvanEkle";
            this.grpUnvanEkle.Size = new System.Drawing.Size(277, 122);
            this.grpUnvanEkle.TabIndex = 2;
            this.grpUnvanEkle.TabStop = false;
            this.grpUnvanEkle.Text = "Ünvan Ekle";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.DarkGray;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(183, 62);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(68, 45);
            this.btnCikis.TabIndex = 8;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnUnvanEkle
            // 
            this.btnUnvanEkle.BackColor = System.Drawing.Color.DarkGray;
            this.btnUnvanEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUnvanEkle.Location = new System.Drawing.Point(89, 62);
            this.btnUnvanEkle.Name = "btnUnvanEkle";
            this.btnUnvanEkle.Size = new System.Drawing.Size(88, 45);
            this.btnUnvanEkle.TabIndex = 9;
            this.btnUnvanEkle.Text = "Ekle";
            this.btnUnvanEkle.UseVisualStyleBackColor = false;
            this.btnUnvanEkle.Click += new System.EventHandler(this.btnUnvanEkle_Click);
            // 
            // txtUnvan
            // 
            this.txtUnvan.Location = new System.Drawing.Point(88, 35);
            this.txtUnvan.Name = "txtUnvan";
            this.txtUnvan.Size = new System.Drawing.Size(163, 21);
            this.txtUnvan.TabIndex = 1;
            // 
            // lblUniversite
            // 
            this.lblUniversite.AutoSize = true;
            this.lblUniversite.Location = new System.Drawing.Point(6, 38);
            this.lblUniversite.Name = "lblUniversite";
            this.lblUniversite.Size = new System.Drawing.Size(55, 15);
            this.lblUniversite.TabIndex = 0;
            this.lblUniversite.Text = "Ünvan :";
            // 
            // UnvanEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(299, 144);
            this.Controls.Add(this.grpUnvanEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UnvanEkle";
            this.Text = "UnvanEkle";
            this.grpUnvanEkle.ResumeLayout(false);
            this.grpUnvanEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUnvanEkle;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnUnvanEkle;
        private System.Windows.Forms.TextBox txtUnvan;
        private System.Windows.Forms.Label lblUniversite;
    }
}