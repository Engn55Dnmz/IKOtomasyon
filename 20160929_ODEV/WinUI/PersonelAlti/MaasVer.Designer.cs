namespace WinUI.PersonelAlti
{
    partial class MaasVer
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
            this.grpMaasVer = new System.Windows.Forms.GroupBox();
            this.lblPersonel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.cmbMaas = new System.Windows.Forms.ComboBox();
            this.btnMaasVer = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.lblMaasTarihi = new System.Windows.Forms.Label();
            this.dtpMaasTarihi = new System.Windows.Forms.DateTimePicker();
            this.grpMaasVer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMaasVer
            // 
            this.grpMaasVer.Controls.Add(this.dtpMaasTarihi);
            this.grpMaasVer.Controls.Add(this.btnCikis);
            this.grpMaasVer.Controls.Add(this.btnMaasVer);
            this.grpMaasVer.Controls.Add(this.cmbMaas);
            this.grpMaasVer.Controls.Add(this.cmbPersonel);
            this.grpMaasVer.Controls.Add(this.lblMaasTarihi);
            this.grpMaasVer.Controls.Add(this.label1);
            this.grpMaasVer.Controls.Add(this.lblPersonel);
            this.grpMaasVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpMaasVer.Location = new System.Drawing.Point(12, 12);
            this.grpMaasVer.Name = "grpMaasVer";
            this.grpMaasVer.Size = new System.Drawing.Size(368, 231);
            this.grpMaasVer.TabIndex = 0;
            this.grpMaasVer.TabStop = false;
            this.grpMaasVer.Text = "Maaş Ver";
            // 
            // lblPersonel
            // 
            this.lblPersonel.AutoSize = true;
            this.lblPersonel.Location = new System.Drawing.Point(15, 42);
            this.lblPersonel.Name = "lblPersonel";
            this.lblPersonel.Size = new System.Drawing.Size(72, 15);
            this.lblPersonel.TabIndex = 0;
            this.lblPersonel.Text = "Personel :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maas Tutari :";
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(135, 39);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(212, 23);
            this.cmbPersonel.TabIndex = 1;
            this.cmbPersonel.Click += new System.EventHandler(this.cmbPersonel_Click);
            // 
            // cmbMaas
            // 
            this.cmbMaas.FormattingEnabled = true;
            this.cmbMaas.Location = new System.Drawing.Point(135, 75);
            this.cmbMaas.Name = "cmbMaas";
            this.cmbMaas.Size = new System.Drawing.Size(212, 23);
            this.cmbMaas.TabIndex = 1;
            this.cmbMaas.Click += new System.EventHandler(this.cmbMaas_Click);
            // 
            // btnMaasVer
            // 
            this.btnMaasVer.BackColor = System.Drawing.Color.DarkGray;
            this.btnMaasVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMaasVer.Location = new System.Drawing.Point(135, 164);
            this.btnMaasVer.Name = "btnMaasVer";
            this.btnMaasVer.Size = new System.Drawing.Size(109, 42);
            this.btnMaasVer.TabIndex = 2;
            this.btnMaasVer.Text = "Kaydet";
            this.btnMaasVer.UseVisualStyleBackColor = false;
            this.btnMaasVer.Click += new System.EventHandler(this.btnMaasVer_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.DarkGray;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(250, 164);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(97, 42);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // lblMaasTarihi
            // 
            this.lblMaasTarihi.AutoSize = true;
            this.lblMaasTarihi.Location = new System.Drawing.Point(15, 117);
            this.lblMaasTarihi.Name = "lblMaasTarihi";
            this.lblMaasTarihi.Size = new System.Drawing.Size(91, 15);
            this.lblMaasTarihi.TabIndex = 0;
            this.lblMaasTarihi.Text = "Maas Tarihi: ";
            // 
            // dtpMaasTarihi
            // 
            this.dtpMaasTarihi.Location = new System.Drawing.Point(147, 117);
            this.dtpMaasTarihi.Name = "dtpMaasTarihi";
            this.dtpMaasTarihi.Size = new System.Drawing.Size(200, 21);
            this.dtpMaasTarihi.TabIndex = 3;
            // 
            // MaasVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(392, 255);
            this.Controls.Add(this.grpMaasVer);
            this.Name = "MaasVer";
            this.Text = "MaasVer";
            this.grpMaasVer.ResumeLayout(false);
            this.grpMaasVer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMaasVer;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnMaasVer;
        private System.Windows.Forms.ComboBox cmbMaas;
        private System.Windows.Forms.ComboBox cmbPersonel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPersonel;
        private System.Windows.Forms.DateTimePicker dtpMaasTarihi;
        private System.Windows.Forms.Label lblMaasTarihi;
    }
}