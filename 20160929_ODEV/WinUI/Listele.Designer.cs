namespace WinUI
{
    partial class Listele
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
            this.dgvListele = new System.Windows.Forms.DataGridView();
            this.btnPersonelListele = new System.Windows.Forms.Button();
            this.btnMaasListele = new System.Windows.Forms.Button();
            this.btnIzinListele = new System.Windows.Forms.Button();
            this.btnAracListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListele)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListele
            // 
            this.dgvListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListele.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvListele.Location = new System.Drawing.Point(0, 0);
            this.dgvListele.Name = "dgvListele";
            this.dgvListele.Size = new System.Drawing.Size(889, 741);
            this.dgvListele.TabIndex = 0;
            // 
            // btnPersonelListele
            // 
            this.btnPersonelListele.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPersonelListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelListele.Location = new System.Drawing.Point(903, 12);
            this.btnPersonelListele.Name = "btnPersonelListele";
            this.btnPersonelListele.Size = new System.Drawing.Size(120, 66);
            this.btnPersonelListele.TabIndex = 1;
            this.btnPersonelListele.Text = "Personel Listele";
            this.btnPersonelListele.UseVisualStyleBackColor = false;
            this.btnPersonelListele.Click += new System.EventHandler(this.btnPersonelListele_Click);
            // 
            // btnMaasListele
            // 
            this.btnMaasListele.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMaasListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMaasListele.Location = new System.Drawing.Point(903, 96);
            this.btnMaasListele.Name = "btnMaasListele";
            this.btnMaasListele.Size = new System.Drawing.Size(120, 66);
            this.btnMaasListele.TabIndex = 1;
            this.btnMaasListele.Text = "Maaş Listele";
            this.btnMaasListele.UseVisualStyleBackColor = false;
            this.btnMaasListele.Click += new System.EventHandler(this.btnMaasListele_Click);
            // 
            // btnIzinListele
            // 
            this.btnIzinListele.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnIzinListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIzinListele.Location = new System.Drawing.Point(903, 177);
            this.btnIzinListele.Name = "btnIzinListele";
            this.btnIzinListele.Size = new System.Drawing.Size(120, 66);
            this.btnIzinListele.TabIndex = 1;
            this.btnIzinListele.Text = "İzin Listele";
            this.btnIzinListele.UseVisualStyleBackColor = false;
            this.btnIzinListele.Click += new System.EventHandler(this.btnIzinListele_Click);
            // 
            // btnAracListele
            // 
            this.btnAracListele.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAracListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracListele.Location = new System.Drawing.Point(903, 261);
            this.btnAracListele.Name = "btnAracListele";
            this.btnAracListele.Size = new System.Drawing.Size(120, 66);
            this.btnAracListele.TabIndex = 1;
            this.btnAracListele.Text = "Araç Listele";
            this.btnAracListele.UseVisualStyleBackColor = false;
            this.btnAracListele.Click += new System.EventHandler(this.btnAracListele_Click);
            // 
            // Listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1075, 741);
            this.Controls.Add(this.btnAracListele);
            this.Controls.Add(this.btnIzinListele);
            this.Controls.Add(this.btnMaasListele);
            this.Controls.Add(this.btnPersonelListele);
            this.Controls.Add(this.dgvListele);
            this.Name = "Listele";
            this.Text = "Listele";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListele;
        private System.Windows.Forms.Button btnPersonelListele;
        private System.Windows.Forms.Button btnMaasListele;
        private System.Windows.Forms.Button btnIzinListele;
        private System.Windows.Forms.Button btnAracListele;
    }
}