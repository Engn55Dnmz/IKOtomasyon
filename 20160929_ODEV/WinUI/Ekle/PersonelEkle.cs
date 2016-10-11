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

namespace WinUI.Ekle
{
    public partial class PersonelEkle : Form
    {
        EkleController _ekle;
        public PersonelEkle()
        {
            InitializeComponent();
            _ekle = new EkleController();
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            Personel _personel = new Personel();
            try
            {
                _personel.Adi = txtAd.Text;
                _personel.Soyadi = txtSoyad.Text;
                _personel.TCNo = mtxtTCNo.Text;
                _personel.AktifMi = false;
                _ekle.EklemeyeGonder(_personel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            

            this.Close();
        }
    }
}
