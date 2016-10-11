using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    public partial class KullaniciEkle : Form
    {
        EkleController _ekleController;
        public KullaniciEkle()
        {
            InitializeComponent();
            _ekleController = new EkleController();
        }

        #region EktraDeneme
        //public const int WM_NCLBUTTONDOWN = 0xA1;
        //public const int HT_CAPTION = 0x2;

        //[DllImportAttribute("user32.dll")]
        //public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        //[DllImportAttribute("user32.dll")]
        //public static extern bool ReleaseCapture();
        //private void KullaniciEkle_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        ReleaseCapture();
        //        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        //    }
        //}
        #endregion


        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            Kullanici _kullanici = new Kullanici();
            _kullanici.KullaniciAdi = txtKullaniciAdi.Text;
            _kullanici.AdminMi = chkAdminMi.Checked;
            _kullanici.AktifMi = true; 
            KullaniciSifre _sifre = new KullaniciSifre();
            _sifre.Sifre = txtSifre.Text;
            _sifre.KullaniciID = _ekleController.EklemeyeGonder(_kullanici);
            _sifre.AktifMi = true;
            _ekleController.EklemeyeGonder(_sifre);
            this.Close();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
