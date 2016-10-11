namespace WinUI
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tspListele = new System.Windows.Forms.ToolStripMenuItem();
            this.tspEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tspPersonelEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tspKullaniciEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tspTanimEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tspDepartmanEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tspBirimEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tspYetkiEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tspUnvanEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.aracEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspAracEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tspAracMarkaEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tspAracModelEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.eğitimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspUniversiteEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tspFakulteEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tspBolumEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tspIzinCesidiEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.adresBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspSehirEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tspIlceEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tspSemtEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.muhasebeBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspMaasEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tspPrimCesidiEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tspPersonel = new System.Windows.Forms.ToolStripMenuItem();
            this.tspPersonelIletisim = new System.Windows.Forms.ToolStripMenuItem();
            this.tspPersonelEgitim = new System.Windows.Forms.ToolStripMenuItem();
            this.tspPersonelUnvanBelirle = new System.Windows.Forms.ToolStripMenuItem();
            this.tspPersonelBirimBelirle = new System.Windows.Forms.ToolStripMenuItem();
            this.tspPersonelIzinTanimla = new System.Windows.Forms.ToolStripMenuItem();
            this.tspPersonelGirisCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.tspPersonelMaasVer = new System.Windows.Forms.ToolStripMenuItem();
            this.tspPrimVer = new System.Windows.Forms.ToolStripMenuItem();
            this.tspAracTahsisi = new System.Windows.Forms.ToolStripMenuItem();
            this.tspYetkiAta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspListele,
            this.tspEkle,
            this.tspPersonel});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(822, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tspListele
            // 
            this.tspListele.Name = "tspListele";
            this.tspListele.Size = new System.Drawing.Size(52, 20);
            this.tspListele.Text = "Listele";
            this.tspListele.Click += new System.EventHandler(this.tspListele_Click);
            // 
            // tspEkle
            // 
            this.tspEkle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspPersonelEkle,
            this.tspKullaniciEkle,
            this.tspTanimEkle,
            this.adresBilgileriToolStripMenuItem,
            this.muhasebeBilgileriToolStripMenuItem});
            this.tspEkle.Name = "tspEkle";
            this.tspEkle.Size = new System.Drawing.Size(40, 20);
            this.tspEkle.Text = "Ekle";
            // 
            // tspPersonelEkle
            // 
            this.tspPersonelEkle.Name = "tspPersonelEkle";
            this.tspPersonelEkle.Size = new System.Drawing.Size(336, 22);
            this.tspPersonelEkle.Text = "Personel Ekle";
            this.tspPersonelEkle.Click += new System.EventHandler(this.tspPersonelEkle_Click);
            // 
            // tspKullaniciEkle
            // 
            this.tspKullaniciEkle.Name = "tspKullaniciEkle";
            this.tspKullaniciEkle.Size = new System.Drawing.Size(336, 22);
            this.tspKullaniciEkle.Text = "Kullanıcı Ekle";
            this.tspKullaniciEkle.Click += new System.EventHandler(this.tspKullaniciEkle_Click);
            // 
            // tspTanimEkle
            // 
            this.tspTanimEkle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspDepartmanEkle,
            this.tspBirimEkle,
            this.tspYetkiEkle,
            this.tspUnvanEkle,
            this.aracEkleToolStripMenuItem,
            this.eğitimToolStripMenuItem,
            this.tspIzinCesidiEkle});
            this.tspTanimEkle.Name = "tspTanimEkle";
            this.tspTanimEkle.Size = new System.Drawing.Size(336, 22);
            this.tspTanimEkle.Text = "Tanım Ekle                                                                    ";
            // 
            // tspDepartmanEkle
            // 
            this.tspDepartmanEkle.Name = "tspDepartmanEkle";
            this.tspDepartmanEkle.Size = new System.Drawing.Size(157, 22);
            this.tspDepartmanEkle.Text = "Departman Ekle";
            this.tspDepartmanEkle.Click += new System.EventHandler(this.tspDepartmanEkle_Click);
            // 
            // tspBirimEkle
            // 
            this.tspBirimEkle.Name = "tspBirimEkle";
            this.tspBirimEkle.Size = new System.Drawing.Size(157, 22);
            this.tspBirimEkle.Text = "Birim Ekle";
            this.tspBirimEkle.Click += new System.EventHandler(this.tspBirimEkle_Click);
            // 
            // tspYetkiEkle
            // 
            this.tspYetkiEkle.Name = "tspYetkiEkle";
            this.tspYetkiEkle.Size = new System.Drawing.Size(157, 22);
            this.tspYetkiEkle.Text = "Yetki Ekle";
            this.tspYetkiEkle.Click += new System.EventHandler(this.tspYetkiEkle_Click);
            // 
            // tspUnvanEkle
            // 
            this.tspUnvanEkle.Name = "tspUnvanEkle";
            this.tspUnvanEkle.Size = new System.Drawing.Size(157, 22);
            this.tspUnvanEkle.Text = "Ünvan Ekle";
            this.tspUnvanEkle.Click += new System.EventHandler(this.tspUnvanEkle_Click);
            // 
            // aracEkleToolStripMenuItem
            // 
            this.aracEkleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspAracEkle,
            this.tspAracMarkaEkle,
            this.tspAracModelEkle});
            this.aracEkleToolStripMenuItem.Name = "aracEkleToolStripMenuItem";
            this.aracEkleToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.aracEkleToolStripMenuItem.Text = "Araç";
            // 
            // tspAracEkle
            // 
            this.tspAracEkle.Name = "tspAracEkle";
            this.tspAracEkle.Size = new System.Drawing.Size(132, 22);
            this.tspAracEkle.Text = "Araç Ekle";
            this.tspAracEkle.Click += new System.EventHandler(this.tspAracEkle_Click);
            // 
            // tspAracMarkaEkle
            // 
            this.tspAracMarkaEkle.Name = "tspAracMarkaEkle";
            this.tspAracMarkaEkle.Size = new System.Drawing.Size(132, 22);
            this.tspAracMarkaEkle.Text = "Marka Ekle";
            this.tspAracMarkaEkle.Click += new System.EventHandler(this.tspAracMarkaEkle_Click);
            // 
            // tspAracModelEkle
            // 
            this.tspAracModelEkle.Name = "tspAracModelEkle";
            this.tspAracModelEkle.Size = new System.Drawing.Size(132, 22);
            this.tspAracModelEkle.Text = "Model Ekle";
            this.tspAracModelEkle.Click += new System.EventHandler(this.tspAracModelEkle_Click);
            // 
            // eğitimToolStripMenuItem
            // 
            this.eğitimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspUniversiteEkle,
            this.tspFakulteEkle,
            this.tspBolumEkle});
            this.eğitimToolStripMenuItem.Name = "eğitimToolStripMenuItem";
            this.eğitimToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.eğitimToolStripMenuItem.Text = "Eğitim";
            // 
            // tspUniversiteEkle
            // 
            this.tspUniversiteEkle.Name = "tspUniversiteEkle";
            this.tspUniversiteEkle.Size = new System.Drawing.Size(150, 22);
            this.tspUniversiteEkle.Text = "Üniversite Ekle";
            this.tspUniversiteEkle.Click += new System.EventHandler(this.tspUniversiteEkle_Click);
            // 
            // tspFakulteEkle
            // 
            this.tspFakulteEkle.Name = "tspFakulteEkle";
            this.tspFakulteEkle.Size = new System.Drawing.Size(150, 22);
            this.tspFakulteEkle.Text = "Fakülte Ekle";
            this.tspFakulteEkle.Click += new System.EventHandler(this.tspFakulteEkle_Click);
            // 
            // tspBolumEkle
            // 
            this.tspBolumEkle.Name = "tspBolumEkle";
            this.tspBolumEkle.Size = new System.Drawing.Size(150, 22);
            this.tspBolumEkle.Text = "Bölüm Ekle";
            this.tspBolumEkle.Click += new System.EventHandler(this.tspBolumEkle_Click);
            // 
            // tspIzinCesidiEkle
            // 
            this.tspIzinCesidiEkle.Name = "tspIzinCesidiEkle";
            this.tspIzinCesidiEkle.Size = new System.Drawing.Size(157, 22);
            this.tspIzinCesidiEkle.Text = "İzin Çeşidi Ekle";
            this.tspIzinCesidiEkle.Click += new System.EventHandler(this.tspIzinCesidiEkle_Click);
            // 
            // adresBilgileriToolStripMenuItem
            // 
            this.adresBilgileriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspSehirEkle,
            this.tspIlceEkle,
            this.tspSemtEkle});
            this.adresBilgileriToolStripMenuItem.Name = "adresBilgileriToolStripMenuItem";
            this.adresBilgileriToolStripMenuItem.Size = new System.Drawing.Size(336, 22);
            this.adresBilgileriToolStripMenuItem.Text = "Adres Bilgileri";
            // 
            // tspSehirEkle
            // 
            this.tspSehirEkle.Name = "tspSehirEkle";
            this.tspSehirEkle.Size = new System.Drawing.Size(125, 22);
            this.tspSehirEkle.Text = "Şehir Ekle";
            this.tspSehirEkle.Click += new System.EventHandler(this.tspSehirEkle_Click);
            // 
            // tspIlceEkle
            // 
            this.tspIlceEkle.Name = "tspIlceEkle";
            this.tspIlceEkle.Size = new System.Drawing.Size(125, 22);
            this.tspIlceEkle.Text = "İlçe Ekle";
            this.tspIlceEkle.Click += new System.EventHandler(this.tspIlceEkle_Click);
            // 
            // tspSemtEkle
            // 
            this.tspSemtEkle.Name = "tspSemtEkle";
            this.tspSemtEkle.Size = new System.Drawing.Size(125, 22);
            this.tspSemtEkle.Text = "Semt Ekle";
            this.tspSemtEkle.Click += new System.EventHandler(this.tspSemtEkle_Click);
            // 
            // muhasebeBilgileriToolStripMenuItem
            // 
            this.muhasebeBilgileriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspMaasEkle,
            this.tspPrimCesidiEkle});
            this.muhasebeBilgileriToolStripMenuItem.Name = "muhasebeBilgileriToolStripMenuItem";
            this.muhasebeBilgileriToolStripMenuItem.Size = new System.Drawing.Size(336, 22);
            this.muhasebeBilgileriToolStripMenuItem.Text = "Muhasebe Bilgileri";
            // 
            // tspMaasEkle
            // 
            this.tspMaasEkle.Name = "tspMaasEkle";
            this.tspMaasEkle.Size = new System.Drawing.Size(158, 22);
            this.tspMaasEkle.Text = "Maaş Ekle";
            this.tspMaasEkle.Click += new System.EventHandler(this.tspMaasEkle_Click);
            // 
            // tspPrimCesidiEkle
            // 
            this.tspPrimCesidiEkle.Name = "tspPrimCesidiEkle";
            this.tspPrimCesidiEkle.Size = new System.Drawing.Size(158, 22);
            this.tspPrimCesidiEkle.Text = "Prim Çeşidi Ekle";
            this.tspPrimCesidiEkle.Click += new System.EventHandler(this.tspPrimCesidiEkle_Click);
            // 
            // tspPersonel
            // 
            this.tspPersonel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspPersonelIletisim,
            this.tspPersonelEgitim,
            this.tspPersonelUnvanBelirle,
            this.tspPersonelBirimBelirle,
            this.tspPersonelIzinTanimla,
            this.tspPersonelGirisCikis,
            this.tspPersonelMaasVer,
            this.tspPrimVer,
            this.tspAracTahsisi,
            this.tspYetkiAta});
            this.tspPersonel.Name = "tspPersonel";
            this.tspPersonel.Size = new System.Drawing.Size(64, 20);
            this.tspPersonel.Text = "Personel";
            // 
            // tspPersonelIletisim
            // 
            this.tspPersonelIletisim.Name = "tspPersonelIletisim";
            this.tspPersonelIletisim.Size = new System.Drawing.Size(181, 22);
            this.tspPersonelIletisim.Text = "İletişim Bilgisi Belirle";
            this.tspPersonelIletisim.Click += new System.EventHandler(this.tspPersonelIletisim_Click);
            // 
            // tspPersonelEgitim
            // 
            this.tspPersonelEgitim.Name = "tspPersonelEgitim";
            this.tspPersonelEgitim.Size = new System.Drawing.Size(181, 22);
            this.tspPersonelEgitim.Text = "Eğitim Bilgisi Ekle";
            this.tspPersonelEgitim.Click += new System.EventHandler(this.tspPersonelEgitim_Click);
            // 
            // tspPersonelUnvanBelirle
            // 
            this.tspPersonelUnvanBelirle.Name = "tspPersonelUnvanBelirle";
            this.tspPersonelUnvanBelirle.Size = new System.Drawing.Size(181, 22);
            this.tspPersonelUnvanBelirle.Text = "Unvan Belirle";
            this.tspPersonelUnvanBelirle.Click += new System.EventHandler(this.tspPersonelUnvanBelirle_Click);
            // 
            // tspPersonelBirimBelirle
            // 
            this.tspPersonelBirimBelirle.Name = "tspPersonelBirimBelirle";
            this.tspPersonelBirimBelirle.Size = new System.Drawing.Size(181, 22);
            this.tspPersonelBirimBelirle.Text = "Birim Belirle";
            this.tspPersonelBirimBelirle.Click += new System.EventHandler(this.tspPersonelBirimBelirle_Click);
            // 
            // tspPersonelIzinTanimla
            // 
            this.tspPersonelIzinTanimla.Name = "tspPersonelIzinTanimla";
            this.tspPersonelIzinTanimla.Size = new System.Drawing.Size(181, 22);
            this.tspPersonelIzinTanimla.Text = "İzin Tanımla";
            this.tspPersonelIzinTanimla.Click += new System.EventHandler(this.tspPersonelIzinTanimla_Click);
            // 
            // tspPersonelGirisCikis
            // 
            this.tspPersonelGirisCikis.Name = "tspPersonelGirisCikis";
            this.tspPersonelGirisCikis.Size = new System.Drawing.Size(181, 22);
            this.tspPersonelGirisCikis.Text = "İşe Giriş/Çıkış";
            this.tspPersonelGirisCikis.Click += new System.EventHandler(this.tspPersonelGirisCikis_Click);
            // 
            // tspPersonelMaasVer
            // 
            this.tspPersonelMaasVer.Name = "tspPersonelMaasVer";
            this.tspPersonelMaasVer.Size = new System.Drawing.Size(181, 22);
            this.tspPersonelMaasVer.Text = "Maaş Ver";
            this.tspPersonelMaasVer.Click += new System.EventHandler(this.tspPersonelMaasVer_Click);
            // 
            // tspPrimVer
            // 
            this.tspPrimVer.Name = "tspPrimVer";
            this.tspPrimVer.Size = new System.Drawing.Size(181, 22);
            this.tspPrimVer.Text = "Prim Ver";
            this.tspPrimVer.Click += new System.EventHandler(this.tspPrimVer_Click);
            // 
            // tspAracTahsisi
            // 
            this.tspAracTahsisi.Name = "tspAracTahsisi";
            this.tspAracTahsisi.Size = new System.Drawing.Size(181, 22);
            this.tspAracTahsisi.Text = "Araç Tahsis Et";
            this.tspAracTahsisi.Click += new System.EventHandler(this.tspAracTahsisi_Click);
            // 
            // tspYetkiAta
            // 
            this.tspYetkiAta.Name = "tspYetkiAta";
            this.tspYetkiAta.Size = new System.Drawing.Size(181, 22);
            this.tspYetkiAta.Text = "Yetki Ata";
            this.tspYetkiAta.Click += new System.EventHandler(this.tspYetkiAta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 595);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tspListele;
        private System.Windows.Forms.ToolStripMenuItem tspTanimEkle;
        private System.Windows.Forms.ToolStripMenuItem tspDepartmanEkle;
        private System.Windows.Forms.ToolStripMenuItem tspBirimEkle;
        private System.Windows.Forms.ToolStripMenuItem tspYetkiEkle;
        private System.Windows.Forms.ToolStripMenuItem tspUnvanEkle;
        private System.Windows.Forms.ToolStripMenuItem aracEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tspAracEkle;
        private System.Windows.Forms.ToolStripMenuItem tspAracMarkaEkle;
        private System.Windows.Forms.ToolStripMenuItem tspAracModelEkle;
        public System.Windows.Forms.ToolStripMenuItem tspEkle;
        private System.Windows.Forms.ToolStripMenuItem tspKullaniciEkle;
        private System.Windows.Forms.ToolStripMenuItem eğitimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tspUniversiteEkle;
        private System.Windows.Forms.ToolStripMenuItem tspFakulteEkle;
        private System.Windows.Forms.ToolStripMenuItem tspBolumEkle;
        private System.Windows.Forms.ToolStripMenuItem tspIzinCesidiEkle;
        private System.Windows.Forms.ToolStripMenuItem adresBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tspSehirEkle;
        private System.Windows.Forms.ToolStripMenuItem tspIlceEkle;
        private System.Windows.Forms.ToolStripMenuItem tspSemtEkle;
        private System.Windows.Forms.ToolStripMenuItem muhasebeBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tspMaasEkle;
        private System.Windows.Forms.ToolStripMenuItem tspPrimCesidiEkle;
        private System.Windows.Forms.ToolStripMenuItem tspPersonelEkle;
        private System.Windows.Forms.ToolStripMenuItem tspPersonel;
        private System.Windows.Forms.ToolStripMenuItem tspPersonelIletisim;
        private System.Windows.Forms.ToolStripMenuItem tspPersonelEgitim;
        private System.Windows.Forms.ToolStripMenuItem tspPersonelUnvanBelirle;
        private System.Windows.Forms.ToolStripMenuItem tspPersonelBirimBelirle;
        private System.Windows.Forms.ToolStripMenuItem tspPersonelIzinTanimla;
        private System.Windows.Forms.ToolStripMenuItem tspPersonelGirisCikis;
        private System.Windows.Forms.ToolStripMenuItem tspPersonelMaasVer;
        private System.Windows.Forms.ToolStripMenuItem tspAracTahsisi;
        private System.Windows.Forms.ToolStripMenuItem tspPrimVer;
        private System.Windows.Forms.ToolStripMenuItem tspYetkiAta;
    }
}

