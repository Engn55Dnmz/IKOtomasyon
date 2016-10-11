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

namespace WinUI.PersonelAlti
{
    public partial class EgitimBilgisiEkle : Form
    {
        EkleController _ekleController;
        ListeleController _listeleController;
        ExtensionMethods _extensionMethods;
        public EgitimBilgisiEkle()
        {
            InitializeComponent();
            _ekleController = new EkleController();
            _listeleController = new ListeleController();
            _extensionMethods = new ExtensionMethods();
            _extensionMethods.ComboDoldur(_listeleController.PersonelListele(), cmbPersonel);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEgitimBilgisiEkle_Click(object sender, EventArgs e)
        {
            PersonelEgitim nesne = new PersonelEgitim();
            try
            {
                nesne.PersonelID = ((Personel)cmbPersonel.SelectedItem).ID;
                nesne.BolumID = ((Bolum)cmbBolum.SelectedItem).BolumID;
                nesne.AktifMi = true;
                _ekleController.EklemeyeGonder(nesne);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            this.Close();
        }

        private void cmbPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Personel _personel = new Personel();
            PersonelEgitim _personelEgitim = new PersonelEgitim();
            _personel = (Personel)cmbPersonel.SelectedItem;
            _personelEgitim = _listeleController.PersonelEgitimListele(_personel);
            _extensionMethods.ComboDoldur(_listeleController.OkulListele(), cmbUniversite);
            ControlDoldur(_personelEgitim);
        }

        private void ControlDoldur(PersonelEgitim nesne)
        {
            if (nesne.BolumID != null)
            {
                cmbUniversite.SelectedItem = nesne.Bolum.Fakulte.Okul;
                _extensionMethods.ComboDoldur(_listeleController.FakulteListele(nesne.Bolum.Fakulte.Okul.OkulID), cmbFakulte);
                cmbFakulte.SelectedItem = nesne.Bolum.Fakulte;
                _extensionMethods.ComboDoldur(_listeleController.BolumListele(nesne.Bolum.Fakulte.FakulteID), cmbBolum);
                cmbBolum.SelectedItem = nesne.Bolum;
            }
        }

        private void cmbUniversite_SelectedIndexChanged(object sender, EventArgs e)
        {
            _extensionMethods.CmbSifirla(cmbFakulte);
            Okul _okul = new Okul();
            _okul = ((Okul)cmbUniversite.SelectedItem);
            if (_okul != null) _extensionMethods.ComboDoldur(_listeleController.FakulteListele(_okul.OkulID), cmbFakulte);
        }

        private void cmbFakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            _extensionMethods.CmbSifirla(cmbBolum);
            Fakulte _fakulte = new Fakulte();
            _fakulte = ((Fakulte)cmbFakulte.SelectedItem);
            if (_fakulte != null) _extensionMethods.ComboDoldur(_listeleController.BolumListele(_fakulte.FakulteID), cmbBolum);
        }
    }
}
