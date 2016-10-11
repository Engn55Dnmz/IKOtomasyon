namespace WinUI.Ekle
{
    partial class BirimEkle
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
            this.grpBirimEkle = new System.Windows.Forms.GroupBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnBirimEkle = new System.Windows.Forms.Button();
            this.txtBirim = new System.Windows.Forms.TextBox();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.lblBirim = new System.Windows.Forms.Label();
            this.lblDepartman = new System.Windows.Forms.Label();
            this.grpBirimEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBirimEkle
            // 
            this.grpBirimEkle.Controls.Add(this.btnCikis);
            this.grpBirimEkle.Controls.Add(this.btnBirimEkle);
            this.grpBirimEkle.Controls.Add(this.txtBirim);
            this.grpBirimEkle.Controls.Add(this.cmbDepartman);
            this.grpBirimEkle.Controls.Add(this.lblBirim);
            this.grpBirimEkle.Controls.Add(this.lblDepartman);
            this.grpBirimEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBirimEkle.Location = new System.Drawing.Point(12, 12);
            this.grpBirimEkle.Name = "grpBirimEkle";
            this.grpBirimEkle.Size = new System.Drawing.Size(317, 166);
            this.grpBirimEkle.TabIndex = 0;
            this.grpBirimEkle.TabStop = false;
            this.grpBirimEkle.Text = "Birim Ekle";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.DarkGray;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(208, 103);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(89, 45);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnBirimEkle
            // 
            this.btnBirimEkle.BackColor = System.Drawing.Color.DarkGray;
            this.btnBirimEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBirimEkle.Location = new System.Drawing.Point(114, 103);
            this.btnBirimEkle.Name = "btnBirimEkle";
            this.btnBirimEkle.Size = new System.Drawing.Size(89, 45);
            this.btnBirimEkle.TabIndex = 3;
            this.btnBirimEkle.Text = "Ekle";
            this.btnBirimEkle.UseVisualStyleBackColor = false;
            this.btnBirimEkle.Click += new System.EventHandler(this.btnBirimEkle_Click);
            // 
            // txtBirim
            // 
            this.txtBirim.Location = new System.Drawing.Point(114, 76);
            this.txtBirim.Name = "txtBirim";
            this.txtBirim.Size = new System.Drawing.Size(183, 21);
            this.txtBirim.TabIndex = 2;
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Location = new System.Drawing.Point(114, 32);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(183, 23);
            this.cmbDepartman.TabIndex = 1;
            // 
            // lblBirim
            // 
            this.lblBirim.AutoSize = true;
            this.lblBirim.Location = new System.Drawing.Point(6, 79);
            this.lblBirim.Name = "lblBirim";
            this.lblBirim.Size = new System.Drawing.Size(49, 15);
            this.lblBirim.TabIndex = 0;
            this.lblBirim.Text = "Birim :";
            // 
            // lblDepartman
            // 
            this.lblDepartman.AutoSize = true;
            this.lblDepartman.Location = new System.Drawing.Point(6, 35);
            this.lblDepartman.Name = "lblDepartman";
            this.lblDepartman.Size = new System.Drawing.Size(86, 15);
            this.lblDepartman.TabIndex = 0;
            this.lblDepartman.Text = "Departman :";
            // 
            // BirimEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(339, 189);
            this.Controls.Add(this.grpBirimEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BirimEkle";
            this.Text = "BirimEkle";
            this.grpBirimEkle.ResumeLayout(false);
            this.grpBirimEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBirimEkle;
        public System.Windows.Forms.ComboBox cmbDepartman;
        private System.Windows.Forms.Label lblDepartman;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnBirimEkle;
        private System.Windows.Forms.TextBox txtBirim;
        private System.Windows.Forms.Label lblBirim;
    }
}