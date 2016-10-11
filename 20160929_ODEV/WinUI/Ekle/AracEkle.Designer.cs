namespace WinUI.Ekle
{
    partial class AracEkle
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
            this.grpAracEkle = new System.Windows.Forms.GroupBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnAracEkle = new System.Windows.Forms.Button();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.cmbModeller = new System.Windows.Forms.ComboBox();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.lblAracModeli = new System.Windows.Forms.Label();
            this.cmbMarkalar = new System.Windows.Forms.ComboBox();
            this.lblMarka = new System.Windows.Forms.Label();
            this.grpAracEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAracEkle
            // 
            this.grpAracEkle.Controls.Add(this.btnCikis);
            this.grpAracEkle.Controls.Add(this.btnAracEkle);
            this.grpAracEkle.Controls.Add(this.txtPlaka);
            this.grpAracEkle.Controls.Add(this.cmbModeller);
            this.grpAracEkle.Controls.Add(this.lblPlaka);
            this.grpAracEkle.Controls.Add(this.lblAracModeli);
            this.grpAracEkle.Controls.Add(this.cmbMarkalar);
            this.grpAracEkle.Controls.Add(this.lblMarka);
            this.grpAracEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpAracEkle.Location = new System.Drawing.Point(12, 12);
            this.grpAracEkle.Name = "grpAracEkle";
            this.grpAracEkle.Size = new System.Drawing.Size(324, 168);
            this.grpAracEkle.TabIndex = 0;
            this.grpAracEkle.TabStop = false;
            this.grpAracEkle.Text = "Araç Ekle";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.DarkGray;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(230, 115);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(83, 42);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnAracEkle
            // 
            this.btnAracEkle.BackColor = System.Drawing.Color.DarkGray;
            this.btnAracEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracEkle.Location = new System.Drawing.Point(134, 115);
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.Size = new System.Drawing.Size(90, 42);
            this.btnAracEkle.TabIndex = 3;
            this.btnAracEkle.Text = "Ekle";
            this.btnAracEkle.UseVisualStyleBackColor = false;
            this.btnAracEkle.Click += new System.EventHandler(this.btnAracEkle_Click);
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(134, 87);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(179, 21);
            this.txtPlaka.TabIndex = 2;
            // 
            // cmbModeller
            // 
            this.cmbModeller.FormattingEnabled = true;
            this.cmbModeller.Location = new System.Drawing.Point(134, 58);
            this.cmbModeller.Name = "cmbModeller";
            this.cmbModeller.Size = new System.Drawing.Size(179, 23);
            this.cmbModeller.TabIndex = 1;
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Location = new System.Drawing.Point(6, 90);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(83, 15);
            this.lblPlaka.TabIndex = 0;
            this.lblPlaka.Text = "Arac Plaka :";
            // 
            // lblAracModeli
            // 
            this.lblAracModeli.AutoSize = true;
            this.lblAracModeli.Location = new System.Drawing.Point(6, 61);
            this.lblAracModeli.Name = "lblAracModeli";
            this.lblAracModeli.Size = new System.Drawing.Size(91, 15);
            this.lblAracModeli.TabIndex = 0;
            this.lblAracModeli.Text = "Arac Modeli :";
            // 
            // cmbMarkalar
            // 
            this.cmbMarkalar.FormattingEnabled = true;
            this.cmbMarkalar.Location = new System.Drawing.Point(134, 29);
            this.cmbMarkalar.Name = "cmbMarkalar";
            this.cmbMarkalar.Size = new System.Drawing.Size(179, 23);
            this.cmbMarkalar.TabIndex = 1;
            this.cmbMarkalar.SelectedIndexChanged += new System.EventHandler(this.cmbMarkalar_SelectedIndexChanged);
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(6, 32);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(98, 15);
            this.lblMarka.TabIndex = 0;
            this.lblMarka.Text = "Arac Markası :";
            // 
            // AracEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(345, 190);
            this.Controls.Add(this.grpAracEkle);
            this.Name = "AracEkle";
            this.Text = "AracEkle";
            this.grpAracEkle.ResumeLayout(false);
            this.grpAracEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAracEkle;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnAracEkle;
        private System.Windows.Forms.TextBox txtPlaka;
        public System.Windows.Forms.ComboBox cmbModeller;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Label lblAracModeli;
        public System.Windows.Forms.ComboBox cmbMarkalar;
        private System.Windows.Forms.Label lblMarka;
    }
}