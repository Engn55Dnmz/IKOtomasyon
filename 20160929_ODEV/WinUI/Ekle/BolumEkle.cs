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
    public partial class BolumEkle : Form
    {
        EkleController _ekleController;
        ListeleController _listeleController;
        ExtensionMethods _extension;
        public BolumEkle()
        {
            InitializeComponent();
            _ekleController = new EkleController();
            _listeleController = new ListeleController();
            _extension = new ExtensionMethods();
            _extension.ComboDoldur(_listeleController.OkulListele(), cmbUniversite);
            cmbUniversite.SelectedIndex = 0;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBolumEkle_Click(object sender, EventArgs e)
        {
            Bolum _bolum = new Bolum();
            _bolum.BolumAdi = txtBolum.Text;
            _bolum.FakulteID = ((Fakulte)cmbFakulte.SelectedItem).FakulteID;
            _bolum.AktifMi = true;
            _ekleController.EklemeyeGonder(_bolum);
            this.Close();
        }

        private void cmbUniversite_SelectedIndexChanged(object sender, EventArgs e)
        {
            Okul _universite = new Okul();
            _universite = ((Okul)cmbUniversite.SelectedItem);
            if (_universite != null) _extension.ComboDoldur(_listeleController.FakulteListele(_universite.OkulID), cmbFakulte);
        }
    }
}
