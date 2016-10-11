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

namespace WinUI
{
    public partial class SemtEkle : Form
    {
        EkleController _ekleController;
        ListeleController _listeleController;
        ExtensionMethods _extension;

        public SemtEkle()
        {
            InitializeComponent();
            _ekleController = new EkleController();
            _listeleController = new ListeleController();
            _extension = new ExtensionMethods();
            _extension.ComboDoldur(_listeleController.SehirlerListele(), cmbSehirAdi);
            cmbSehirAdi.SelectedIndex = 0;
        }

        private void btnSemtEkle_Click(object sender, EventArgs e)
        {
            Semt_T _semt = new Semt_T();
            _semt.SemtAdi = txtSemtAdi.Text;
            _semt.IlceID = ((Ilce_T)cmbIlceAdi.SelectedItem).ID;
            _semt.AktifMi = true;
            _ekleController.EklemeyeGonder(_semt);
            this.Close();
        }

        private void cmbSehirAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sehir_T _sehir = new Sehir_T();
            _sehir = ((Sehir_T)cmbSehirAdi.SelectedItem);
            if (_sehir != null) _extension.ComboDoldur(_listeleController.IlcelerListele(_sehir.ID), cmbIlceAdi);
        }
    }
}
