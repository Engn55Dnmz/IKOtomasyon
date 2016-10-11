using IKProje;
using WinUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinUI.Ekle;
using WinUI.PersonelAlti;

namespace WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tspPersonelEkle_Click(object sender, EventArgs e)
        {
            PersonelEkle nesne = new PersonelEkle();
            nesne.MdiParent = this;
            nesne.Show();
        }

        private void tspSehirEkle_Click(object sender, EventArgs e)
        {
            SehirEkle nesne = new SehirEkle();
            nesne.MdiParent = this;
            nesne.Show();
        }

        private void tspIlceEkle_Click(object sender, EventArgs e)
        {
            IlceEkle nesne = new IlceEkle();
            nesne.MdiParent = this;
            nesne.Show();
        }

        private void tspSemtEkle_Click(object sender, EventArgs e)
        {
            SemtEkle nesne = new SemtEkle();
            nesne.MdiParent = this;
            nesne.Show();
        }

        private void tspAracEkle_Click(object sender, EventArgs e)
        {
            AracEkle nesne = new AracEkle();
            nesne.MdiParent = this;
            nesne.Show();
        }

        private void tspAracMarkaEkle_Click(object sender, EventArgs e)
        {
            AracMarkaEkle nesne = new AracMarkaEkle();
            nesne.MdiParent = this;
            nesne.Show();

        }

        private void tspAracModelEkle_Click(object sender, EventArgs e)
        {
            AracModelEkle nesne = new AracModelEkle();
            nesne.MdiParent = this;
            nesne.Show();
        }

        private void personelListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tspKullaniciEkle_Click(object sender, EventArgs e)
        {
            KullaniciEkle nesne = new KullaniciEkle();
            nesne.MdiParent = this;
            nesne.Show();
        }

        private void tspDepartmanEkle_Click(object sender, EventArgs e)
        {
            DepartmanEkle nesne = new DepartmanEkle();
            nesne.MdiParent = this;
            nesne.Show();
        }

        private void tspBirimEkle_Click(object sender, EventArgs e)
        {
            BirimEkle nesne = new BirimEkle();
            nesne.MdiParent = this;
            nesne.Show();
        }

        private void tspYetkiEkle_Click(object sender, EventArgs e)
        {
            YetkiEkle nesne = new YetkiEkle();
            nesne.MdiParent = this;
            nesne.Show();
        }

        private void tspUnvanEkle_Click(object sender, EventArgs e)
        {
            UnvanEkle nesne = new UnvanEkle();
            nesne.MdiParent = this;
            nesne.Show();
        }

        private void tspUniversiteEkle_Click(object sender, EventArgs e)
        {
            UniversiteEkle nesne = new UniversiteEkle();
            nesne.MdiParent = this;
            nesne.Show();
        }

        private void tspFakulteEkle_Click(object sender, EventArgs e)
        {
            FakulteEkle nesne = new FakulteEkle();
            nesne.MdiParent = this;
            nesne.Show();
        }

        private void tspBolumEkle_Click(object sender, EventArgs e)
        {
            BolumEkle nesne = new BolumEkle();
            nesne.MdiParent = this;
            nesne.Show();
        }

        private void tspIzinCesidiEkle_Click(object sender, EventArgs e)
        {
            IzinTurEkle nesne = new IzinTurEkle();
            nesne.MdiParent = this;
            nesne.Show();
        }

        private void tspMaasEkle_Click(object sender, EventArgs e)
        {
            MaasEkle nesne = new MaasEkle();
            nesne.MdiParent = this;
            nesne.Show();
        }

        private void tspPrimCesidiEkle_Click(object sender, EventArgs e)
        {
            PrimEkle nesne = new PrimEkle();
            nesne.MdiParent = this;
            nesne.Show();
        }

        private void tspPersonelIletisim_Click(object sender, EventArgs e)
        {
            IletisimBilgisiBelirle nesne = new IletisimBilgisiBelirle();
            nesne.MdiParent = this;
            nesne.Show();
        }

        private void tspPersonelEgitim_Click(object sender, EventArgs e)
        {
            EgitimBilgisiEkle nesne = new EgitimBilgisiEkle();
            nesne.MdiParent = this;
            nesne.Show();
        }

        private void tspPersonelUnvanBelirle_Click(object sender, EventArgs e)
        {
            UnvanBelirle nesne = new UnvanBelirle();
            nesne.MdiParent = this;
            nesne.Show();
        }

        private void tspPersonelBirimBelirle_Click(object sender, EventArgs e)
        {
            BirimBelirle nesne = new BirimBelirle();
            nesne.MdiParent = this;
            nesne.Show();
        }

        private void tspPersonelIzinTanimla_Click(object sender, EventArgs e)
        {
            IzinTanımla nesne = new IzinTanımla();
            nesne.MdiParent = this;
            nesne.Show();
        }

        private void tspPersonelGirisCikis_Click(object sender, EventArgs e)
        {
            IseGirisCikisBelirle nesne = new IseGirisCikisBelirle();
            nesne.MdiParent = this;
            nesne.Show();
        }

        private void tspAracTahsisi_Click(object sender, EventArgs e)
        {
            AracTahsisEt nesne = new AracTahsisEt();
            nesne.MdiParent = this;
            nesne.Show();
        }

        private void tspPrimVer_Click(object sender, EventArgs e)
        {
            PrimVer nesne = new PrimVer();
            nesne.MdiParent = this;
            nesne.Show();
        }

        private void tspYetkiAta_Click(object sender, EventArgs e)
        {
            YetkiAta nesne = new YetkiAta();
            nesne.MdiParent = this;
            nesne.Show();
        }

        private void tspListele_Click(object sender, EventArgs e)
        {
            Listele nesne = new Listele();
            nesne.MdiParent = this;
            nesne.Show();
        }

        private void tspPersonelMaasVer_Click(object sender, EventArgs e)
        {
            MaasVer nesne = new MaasVer();
            nesne.MdiParent = this;
            nesne.Show();

        }
    }
}
