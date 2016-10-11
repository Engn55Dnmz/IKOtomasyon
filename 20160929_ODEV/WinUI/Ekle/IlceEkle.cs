using BLL;
using Entity;
using Extension;
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
    public partial class IlceEkle : Form
    {
        EkleController _ekleController;
        ListeleController _listeleController;
        ExtensionMethods _extension;
        int SehirID = 0;
        public IlceEkle()
        {
            InitializeComponent();
            _ekleController = new EkleController();
            _listeleController = new ListeleController();
            _extension = new ExtensionMethods();
            _extension.ComboDoldur(_listeleController.SehirlerListele(), cmbSehir);
            cmbSehir.SelectedIndex = 0;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIlceEkle_Click(object sender, EventArgs e)
        {
            Ilce_T _ilce = new Ilce_T();
            _ilce.IlceAdi = txtIlceAdi.Text;
            _ilce.SehirID = SehirID;
            _ilce.AktifMi = true;
            _ekleController.EklemeyeGonder(_ilce);
            this.Close();
        }

        private void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sehir_T _sehir = new Sehir_T();
            _sehir = ((Sehir_T)cmbSehir.SelectedItem);
            SehirID = _sehir.ID;
        }
    }
}
