namespace IKProje
{
    partial class DepartmanEkle
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
            this.grpDepartman = new System.Windows.Forms.GroupBox();
            this.btnDepartmanEkle = new System.Windows.Forms.Button();
            this.txtDeparmanAdi = new System.Windows.Forms.TextBox();
            this.lblDepartmanAdi = new System.Windows.Forms.Label();
            this.grpDepartman.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDepartman
            // 
            this.grpDepartman.Controls.Add(this.btnDepartmanEkle);
            this.grpDepartman.Controls.Add(this.txtDeparmanAdi);
            this.grpDepartman.Controls.Add(this.lblDepartmanAdi);
            this.grpDepartman.Location = new System.Drawing.Point(12, 12);
            this.grpDepartman.Name = "grpDepartman";
            this.grpDepartman.Size = new System.Drawing.Size(300, 135);
            this.grpDepartman.TabIndex = 0;
            this.grpDepartman.TabStop = false;
            // 
            // btnDepartmanEkle
            // 
            this.btnDepartmanEkle.BackColor = System.Drawing.Color.DarkGray;
            this.btnDepartmanEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepartmanEkle.Location = new System.Drawing.Point(211, 71);
            this.btnDepartmanEkle.Name = "btnDepartmanEkle";
            this.btnDepartmanEkle.Size = new System.Drawing.Size(75, 40);
            this.btnDepartmanEkle.TabIndex = 5;
            this.btnDepartmanEkle.Text = "Ekle";
            this.btnDepartmanEkle.UseVisualStyleBackColor = false;
            this.btnDepartmanEkle.Click += new System.EventHandler(this.btnDepartmanEkle_Click);
            // 
            // txtDeparmanAdi
            // 
            this.txtDeparmanAdi.Location = new System.Drawing.Point(126, 24);
            this.txtDeparmanAdi.Multiline = true;
            this.txtDeparmanAdi.Name = "txtDeparmanAdi";
            this.txtDeparmanAdi.Size = new System.Drawing.Size(160, 24);
            this.txtDeparmanAdi.TabIndex = 4;
            // 
            // lblDepartmanAdi
            // 
            this.lblDepartmanAdi.AutoSize = true;
            this.lblDepartmanAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDepartmanAdi.Location = new System.Drawing.Point(14, 24);
            this.lblDepartmanAdi.Name = "lblDepartmanAdi";
            this.lblDepartmanAdi.Size = new System.Drawing.Size(106, 15);
            this.lblDepartmanAdi.TabIndex = 3;
            this.lblDepartmanAdi.Text = "Departman Adı:";
            // 
            // DepartmanEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(324, 159);
            this.Controls.Add(this.grpDepartman);
            this.Name = "DepartmanEkle";
            this.Text = "DepartmanEkle";
            this.grpDepartman.ResumeLayout(false);
            this.grpDepartman.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDepartman;
        private System.Windows.Forms.Button btnDepartmanEkle;
        private System.Windows.Forms.TextBox txtDeparmanAdi;
        private System.Windows.Forms.Label lblDepartmanAdi;

    }
}