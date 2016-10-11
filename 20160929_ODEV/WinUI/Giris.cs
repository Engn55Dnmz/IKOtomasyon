using BLL;
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
    public partial class Giris : Form
    {

        LoginController lc;
        public Giris()
        {
            InitializeComponent();
            lc = new LoginController();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            bool[] giris=lc.KullanıcıKontrol(txtKullaniciAdi.Text, txtSifre.Text);
            if (giris[0]==true)
            {
                Form1 frm = new Form1();
                if (giris[1]==false)
                {
                    frm.tspEkle.Enabled = false;
                }
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş başarısız. Lütfen Girdiğiniz bilgileri konrol ediniz!");
            }
        }
    }
}
