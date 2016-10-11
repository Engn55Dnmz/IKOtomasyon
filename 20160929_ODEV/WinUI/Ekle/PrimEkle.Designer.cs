namespace IKProje
{
    partial class PrimEkle
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
            this.grpPrim = new System.Windows.Forms.GroupBox();
            this.btnPrimEkle = new System.Windows.Forms.Button();
            this.txtPrimEkle = new System.Windows.Forms.TextBox();
            this.lblPrimEkle = new System.Windows.Forms.Label();
            this.grpPrim.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPrim
            // 
            this.grpPrim.Controls.Add(this.btnPrimEkle);
            this.grpPrim.Controls.Add(this.txtPrimEkle);
            this.grpPrim.Controls.Add(this.lblPrimEkle);
            this.grpPrim.Location = new System.Drawing.Point(12, 12);
            this.grpPrim.Name = "grpPrim";
            this.grpPrim.Size = new System.Drawing.Size(292, 125);
            this.grpPrim.TabIndex = 0;
            this.grpPrim.TabStop = false;
            // 
            // btnPrimEkle
            // 
            this.btnPrimEkle.BackColor = System.Drawing.Color.DarkGray;
            this.btnPrimEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrimEkle.Location = new System.Drawing.Point(200, 71);
            this.btnPrimEkle.Name = "btnPrimEkle";
            this.btnPrimEkle.Size = new System.Drawing.Size(75, 40);
            this.btnPrimEkle.TabIndex = 8;
            this.btnPrimEkle.Text = "Ekle";
            this.btnPrimEkle.UseVisualStyleBackColor = false;
            this.btnPrimEkle.Click += new System.EventHandler(this.btnPrimEkle_Click);
            // 
            // txtPrimEkle
            // 
            this.txtPrimEkle.Location = new System.Drawing.Point(104, 27);
            this.txtPrimEkle.Multiline = true;
            this.txtPrimEkle.Name = "txtPrimEkle";
            this.txtPrimEkle.Size = new System.Drawing.Size(171, 27);
            this.txtPrimEkle.TabIndex = 7;
            // 
            // lblPrimEkle
            // 
            this.lblPrimEkle.AutoSize = true;
            this.lblPrimEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrimEkle.Location = new System.Drawing.Point(20, 28);
            this.lblPrimEkle.Name = "lblPrimEkle";
            this.lblPrimEkle.Size = new System.Drawing.Size(78, 15);
            this.lblPrimEkle.TabIndex = 6;
            this.lblPrimEkle.Text = "Prim Türü :";
            // 
            // PrimEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(314, 150);
            this.Controls.Add(this.grpPrim);
            this.Name = "PrimEkle";
            this.Text = "PripEkle";
            this.grpPrim.ResumeLayout(false);
            this.grpPrim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPrim;
        private System.Windows.Forms.Button btnPrimEkle;
        private System.Windows.Forms.TextBox txtPrimEkle;
        private System.Windows.Forms.Label lblPrimEkle;

    }
}