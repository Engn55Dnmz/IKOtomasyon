namespace IKProje
{
    partial class IzinTurEkle
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
            this.grpIzin = new System.Windows.Forms.GroupBox();
            this.btnIzinTurEkle = new System.Windows.Forms.Button();
            this.txtIzinTuru = new System.Windows.Forms.TextBox();
            this.lblIzinTuru = new System.Windows.Forms.Label();
            this.grpIzin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpIzin
            // 
            this.grpIzin.Controls.Add(this.btnIzinTurEkle);
            this.grpIzin.Controls.Add(this.txtIzinTuru);
            this.grpIzin.Controls.Add(this.lblIzinTuru);
            this.grpIzin.Location = new System.Drawing.Point(12, 12);
            this.grpIzin.Name = "grpIzin";
            this.grpIzin.Size = new System.Drawing.Size(310, 153);
            this.grpIzin.TabIndex = 0;
            this.grpIzin.TabStop = false;
            // 
            // btnIzinTurEkle
            // 
            this.btnIzinTurEkle.BackColor = System.Drawing.Color.DarkGray;
            this.btnIzinTurEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIzinTurEkle.Location = new System.Drawing.Point(208, 66);
            this.btnIzinTurEkle.Name = "btnIzinTurEkle";
            this.btnIzinTurEkle.Size = new System.Drawing.Size(75, 40);
            this.btnIzinTurEkle.TabIndex = 8;
            this.btnIzinTurEkle.Text = "Ekle";
            this.btnIzinTurEkle.UseVisualStyleBackColor = false;
            this.btnIzinTurEkle.Click += new System.EventHandler(this.btnIzinTurEkle_Click);
            // 
            // txtIzinTuru
            // 
            this.txtIzinTuru.Location = new System.Drawing.Point(95, 33);
            this.txtIzinTuru.Multiline = true;
            this.txtIzinTuru.Name = "txtIzinTuru";
            this.txtIzinTuru.Size = new System.Drawing.Size(188, 27);
            this.txtIzinTuru.TabIndex = 7;
            // 
            // lblIzinTuru
            // 
            this.lblIzinTuru.AutoSize = true;
            this.lblIzinTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIzinTuru.Location = new System.Drawing.Point(16, 34);
            this.lblIzinTuru.Name = "lblIzinTuru";
            this.lblIzinTuru.Size = new System.Drawing.Size(71, 15);
            this.lblIzinTuru.TabIndex = 6;
            this.lblIzinTuru.Text = "İzin Türü :";
            // 
            // IzinTurEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(333, 189);
            this.Controls.Add(this.grpIzin);
            this.Name = "IzinTurEkle";
            this.Text = "IzinBilgisi";
            this.grpIzin.ResumeLayout(false);
            this.grpIzin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpIzin;
        private System.Windows.Forms.Button btnIzinTurEkle;
        private System.Windows.Forms.TextBox txtIzinTuru;
        private System.Windows.Forms.Label lblIzinTuru;

    }
}