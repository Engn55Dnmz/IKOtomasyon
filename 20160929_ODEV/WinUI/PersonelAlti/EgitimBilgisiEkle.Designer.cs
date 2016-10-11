namespace WinUI.PersonelAlti
{
    partial class EgitimBilgisiEkle
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
            this.grpEgitimBilgisiEkle = new System.Windows.Forms.GroupBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnEgitimBilgisiEkle = new System.Windows.Forms.Button();
            this.cmbBolum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFakulte = new System.Windows.Forms.ComboBox();
            this.lblFakulte = new System.Windows.Forms.Label();
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.lblPersonel = new System.Windows.Forms.Label();
            this.cmbUniversite = new System.Windows.Forms.ComboBox();
            this.lblUniversite = new System.Windows.Forms.Label();
            this.grpEgitimBilgisiEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEgitimBilgisiEkle
            // 
            this.grpEgitimBilgisiEkle.Controls.Add(this.btnCikis);
            this.grpEgitimBilgisiEkle.Controls.Add(this.btnEgitimBilgisiEkle);
            this.grpEgitimBilgisiEkle.Controls.Add(this.cmbBolum);
            this.grpEgitimBilgisiEkle.Controls.Add(this.label2);
            this.grpEgitimBilgisiEkle.Controls.Add(this.cmbFakulte);
            this.grpEgitimBilgisiEkle.Controls.Add(this.lblFakulte);
            this.grpEgitimBilgisiEkle.Controls.Add(this.cmbPersonel);
            this.grpEgitimBilgisiEkle.Controls.Add(this.lblPersonel);
            this.grpEgitimBilgisiEkle.Controls.Add(this.cmbUniversite);
            this.grpEgitimBilgisiEkle.Controls.Add(this.lblUniversite);
            this.grpEgitimBilgisiEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpEgitimBilgisiEkle.Location = new System.Drawing.Point(12, 12);
            this.grpEgitimBilgisiEkle.Name = "grpEgitimBilgisiEkle";
            this.grpEgitimBilgisiEkle.Size = new System.Drawing.Size(328, 212);
            this.grpEgitimBilgisiEkle.TabIndex = 0;
            this.grpEgitimBilgisiEkle.TabStop = false;
            this.grpEgitimBilgisiEkle.Text = "Personel Eğitim Bilgisi Ekle";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.DarkGray;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(217, 139);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(95, 52);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnEgitimBilgisiEkle
            // 
            this.btnEgitimBilgisiEkle.BackColor = System.Drawing.Color.DarkGray;
            this.btnEgitimBilgisiEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEgitimBilgisiEkle.Location = new System.Drawing.Point(110, 140);
            this.btnEgitimBilgisiEkle.Name = "btnEgitimBilgisiEkle";
            this.btnEgitimBilgisiEkle.Size = new System.Drawing.Size(101, 52);
            this.btnEgitimBilgisiEkle.TabIndex = 2;
            this.btnEgitimBilgisiEkle.Text = "Kaydet";
            this.btnEgitimBilgisiEkle.UseVisualStyleBackColor = false;
            this.btnEgitimBilgisiEkle.Click += new System.EventHandler(this.btnEgitimBilgisiEkle_Click);
            // 
            // cmbBolum
            // 
            this.cmbBolum.FormattingEnabled = true;
            this.cmbBolum.Location = new System.Drawing.Point(110, 112);
            this.cmbBolum.Name = "cmbBolum";
            this.cmbBolum.Size = new System.Drawing.Size(202, 21);
            this.cmbBolum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bölüm :";
            // 
            // cmbFakulte
            // 
            this.cmbFakulte.FormattingEnabled = true;
            this.cmbFakulte.Location = new System.Drawing.Point(110, 85);
            this.cmbFakulte.Name = "cmbFakulte";
            this.cmbFakulte.Size = new System.Drawing.Size(202, 21);
            this.cmbFakulte.TabIndex = 1;
            this.cmbFakulte.SelectedIndexChanged += new System.EventHandler(this.cmbFakulte_SelectedIndexChanged);
            // 
            // lblFakulte
            // 
            this.lblFakulte.AutoSize = true;
            this.lblFakulte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFakulte.Location = new System.Drawing.Point(10, 86);
            this.lblFakulte.Name = "lblFakulte";
            this.lblFakulte.Size = new System.Drawing.Size(62, 15);
            this.lblFakulte.TabIndex = 0;
            this.lblFakulte.Text = "Fakülte :";
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(110, 31);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(202, 21);
            this.cmbPersonel.TabIndex = 1;
            this.cmbPersonel.SelectedIndexChanged += new System.EventHandler(this.cmbPersonel_SelectedIndexChanged);
            // 
            // lblPersonel
            // 
            this.lblPersonel.AutoSize = true;
            this.lblPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonel.Location = new System.Drawing.Point(10, 32);
            this.lblPersonel.Name = "lblPersonel";
            this.lblPersonel.Size = new System.Drawing.Size(72, 15);
            this.lblPersonel.TabIndex = 0;
            this.lblPersonel.Text = "Personel :";
            // 
            // cmbUniversite
            // 
            this.cmbUniversite.FormattingEnabled = true;
            this.cmbUniversite.Location = new System.Drawing.Point(110, 58);
            this.cmbUniversite.Name = "cmbUniversite";
            this.cmbUniversite.Size = new System.Drawing.Size(202, 21);
            this.cmbUniversite.TabIndex = 1;
            this.cmbUniversite.SelectedIndexChanged += new System.EventHandler(this.cmbUniversite_SelectedIndexChanged);
            // 
            // lblUniversite
            // 
            this.lblUniversite.AutoSize = true;
            this.lblUniversite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUniversite.Location = new System.Drawing.Point(10, 59);
            this.lblUniversite.Name = "lblUniversite";
            this.lblUniversite.Size = new System.Drawing.Size(79, 15);
            this.lblUniversite.TabIndex = 0;
            this.lblUniversite.Text = "Üniversite :";
            // 
            // EgitimBilgisiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(353, 235);
            this.Controls.Add(this.grpEgitimBilgisiEkle);
            this.Name = "EgitimBilgisiEkle";
            this.Text = "EgitimBilgisiEkle";
            this.grpEgitimBilgisiEkle.ResumeLayout(false);
            this.grpEgitimBilgisiEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnEgitimBilgisiEkle;
        private System.Windows.Forms.ComboBox cmbBolum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFakulte;
        private System.Windows.Forms.Label lblFakulte;
        private System.Windows.Forms.ComboBox cmbPersonel;
        private System.Windows.Forms.Label lblPersonel;
        private System.Windows.Forms.ComboBox cmbUniversite;
        private System.Windows.Forms.Label lblUniversite;
        public System.Windows.Forms.GroupBox grpEgitimBilgisiEkle;
    }
}