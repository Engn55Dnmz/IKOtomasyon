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
    public partial class UnvanBelirle : Form
    {
        EkleController _ekleController;
        ListeleController _listeleController;
        ExtensionMethods _extensionMethods;
        public UnvanBelirle()
        {
            InitializeComponent();
            _ekleController = new EkleController();
            _listeleController = new ListeleController();
            _extensionMethods = new ExtensionMethods();
            _extensionMethods.ComboDoldur(_listeleController.PersonelListele(), cmbPersonel);
        }

        private void btnUnvanBelirle_Click(object sender, EventArgs e)
        {
            UnvanIslem _islem = new UnvanIslem();
            try
            {
                _islem.PersonelID = ((Personel)cmbPersonel.SelectedItem).ID;
                _islem.UnvanID = ((Unvan)cmbUnvan.SelectedItem).ID;
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

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbUnvan_Click(object sender, EventArgs e)
        {
            _extensionMethods.ComboDoldur(_listeleController.UnvanListele(), cmbUnvan);
        }

        private void cmbPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Personel _personel = new Personel();
            Unvan _unvan = new Unvan();
            _personel = (Personel)cmbPersonel.SelectedItem;
            _unvan = _listeleController.UnvanListele(_personel);
            _extensionMethods.CmbSifirla(cmbUnvan);
            ControlDoldur(_unvan);
        }

        private void ControlDoldur(Unvan nesne)
        {
            if (nesne != null)
            {
                _extensionMethods.ComboDoldur(_listeleController.UnvanListele(), cmbUnvan);
                cmbUnvan.SelectedItem = nesne;
            }
        }

    }
}
