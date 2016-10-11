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
    public partial class BirimBelirle : Form
    {
        EkleController _ekleController;
        ListeleController _listeleController;
        ExtensionMethods _extensionMethods;
        public BirimBelirle()
        {
            InitializeComponent();
            _ekleController = new EkleController();
            _listeleController = new ListeleController();
            _extensionMethods = new ExtensionMethods();
            _extensionMethods.ComboDoldur(_listeleController.PersonelListele(), cmbPersonel);
        }

        private void btnBirimKaydet_Click(object sender, EventArgs e)
        {
            BirimIslem _islem = new BirimIslem();
            try
            {
                _islem.PersonelID = ((Personel)cmbPersonel.SelectedItem).ID;
                _islem.BirimID = ((Birim_T)cmbBirim.SelectedItem).ID;
                _islem.AktifMi = true;
                _ekleController.EklemeyeGonder(_islem);
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
            Birim_T _personelbirimi = new Birim_T();
            Departman_T _departman = new Departman_T();
            _personel = (Personel)cmbPersonel.SelectedItem;
            _personelbirimi = _listeleController.PersoneleAitBirim(_personel);
            _extensionMethods.CmbSifirla(cmbDepartman);
            _extensionMethods.CmbSifirla(cmbBirim);
            if (_personelbirimi != null)
            {
                _departman = _listeleController.BiriminDepartmani(_personelbirimi);
                cmbBirim.Text = _personelbirimi.BirimAdi;
                cmbDepartman.Text = _departman.DepartmanAdi;
            }
        }

        private void cmbDepartman_Click(object sender, EventArgs e)
        {
            _extensionMethods.ComboDoldur(_listeleController.DepartmanListele(), cmbDepartman);
        }

        private void cmbBirim_Click(object sender, EventArgs e)
        {
            _extensionMethods.ComboDoldur(_listeleController.BirimListele(((Departman_T)cmbDepartman.SelectedItem).ID), cmbBirim);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
