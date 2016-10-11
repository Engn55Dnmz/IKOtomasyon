namespace WinUI.Ekle
{
    partial class BolumEkle
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
            this.grpBolumEkle = new System.Windows.Forms.GroupBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnBolumEkle = new System.Windows.Forms.Button();
            this.txtBolum = new System.Windows.Forms.TextBox();
            this.cmbFakulte = new System.Windows.Forms.ComboBox();
            this.lblBolum = new System.Windows.Forms.Label();
            this.lblFakulte = new System.Windows.Forms.Label();
            this.cmbUniversite = new System.Windows.Forms.ComboBox();
            this.lblUniversite = new System.Windows.Forms.Label();
            this.grpBolumEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBolumEkle
            // 
            this.grpBolumEkle.Controls.Add(this.btnCikis);
            this.grpBolumEkle.Controls.Add(this.btnBolumEkle);
            this.grpBolumEkle.Controls.Add(this.txtBolum);
            this.grpBolumEkle.Controls.Add(this.cmbFakulte);
            this.grpBolumEkle.Controls.Add(this.lblBolum);
            this.grpBolumEkle.Controls.Add(this.lblFakulte);
            this.grpBolumEkle.Controls.Add(this.cmbUniversite);
            this.grpBolumEkle.Controls.Add(this.lblUniversite);
            this.grpBolumEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBolumEkle.Location = new System.Drawing.Point(12, 12);
            this.grpBolumEkle.Name = "grpBolumEkle";
            this.grpBolumEkle.Size = new System.Drawing.Size(314, 181);
            this.grpBolumEkle.TabIndex = 0;
            this.grpBolumEkle.TabStop = false;
            this.grpBolumEkle.Text = "Bölüm Ekle";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.DarkGray;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(205, 115);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(89, 45);
            this.btnCikis.TabIndex = 4;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnBolumEkle
            // 
            this.btnBolumEkle.BackColor = System.Drawing.Color.DarkGray;
            this.btnBolumEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBolumEkle.Location = new System.Drawing.Point(108, 115);
            this.btnBolumEkle.Name = "btnBolumEkle";
            this.btnBolumEkle.Size = new System.Drawing.Size(92, 45);
            this.btnBolumEkle.TabIndex = 5;
            this.btnBolumEkle.Text = "Ekle";
            this.btnBolumEkle.UseVisualStyleBackColor = false;
            this.btnBolumEkle.Click += new System.EventHandler(this.btnBolumEkle_Click);
            // 
            // txtBolum
            // 
            this.txtBolum.Location = new System.Drawing.Point(108, 88);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Size = new System.Drawing.Size(186, 21);
            this.txtBolum.TabIndex = 2;
            // 
            // cmbFakulte
            // 
            this.cmbFakulte.FormattingEnabled = true;
            this.cmbFakulte.Location = new System.Drawing.Point(108, 58);
            this.cmbFakulte.Name = "cmbFakulte";
            this.cmbFakulte.Size = new System.Drawing.Size(186, 23);
            this.cmbFakulte.TabIndex = 1;
            // 
            // lblBolum
            // 
            this.lblBolum.AutoSize = true;
            this.lblBolum.Location = new System.Drawing.Point(6, 91);
            this.lblBolum.Name = "lblBolum";
            this.lblBolum.Size = new System.Drawing.Size(56, 15);
            this.lblBolum.TabIndex = 0;
            this.lblBolum.Text = "Bölüm :";
            // 
            // lblFakulte
            // 
            this.lblFakulte.AutoSize = true;
            this.lblFakulte.Location = new System.Drawing.Point(6, 61);
            this.lblFakulte.Name = "lblFakulte";
            this.lblFakulte.Size = new System.Drawing.Size(62, 15);
            this.lblFakulte.TabIndex = 0;
            this.lblFakulte.Text = "Fakülte :";
            // 
            // cmbUniversite
            // 
            this.cmbUniversite.FormattingEnabled = true;
            this.cmbUniversite.Location = new System.Drawing.Point(108, 29);
            this.cmbUniversite.Name = "cmbUniversite";
            this.cmbUniversite.Size = new System.Drawing.Size(186, 23);
            this.cmbUniversite.TabIndex = 1;
            this.cmbUniversite.SelectedIndexChanged += new System.EventHandler(this.cmbUniversite_SelectedIndexChanged);
            // 
            // lblUniversite
            // 
            this.lblUniversite.AutoSize = true;
            this.lblUniversite.Location = new System.Drawing.Point(6, 32);
            this.lblUniversite.Name = "lblUniversite";
            this.lblUniversite.Size = new System.Drawing.Size(79, 15);
            this.lblUniversite.TabIndex = 0;
            this.lblUniversite.Text = "Üniversite :";
            // 
            // BolumEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(333, 204);
            this.Controls.Add(this.grpBolumEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BolumEkle";
            this.Text = "BolumEkle";
            this.grpBolumEkle.ResumeLayout(false);
            this.grpBolumEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBolumEkle;
        private System.Windows.Forms.TextBox txtBolum;
        public System.Windows.Forms.ComboBox cmbFakulte;
        private System.Windows.Forms.Label lblBolum;
        private System.Windows.Forms.Label lblFakulte;
        public System.Windows.Forms.ComboBox cmbUniversite;
        private System.Windows.Forms.Label lblUniversite;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnBolumEkle;
    }
}