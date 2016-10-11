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
    public partial class IzinTanımla : Form
    {
        EkleController _ekleController;
        ListeleController _listeleController;
        ExtensionMethods _extensionMethods;
        public IzinTanımla()
        {
            InitializeComponent();
            _ekleController = new EkleController();
            _listeleController = new ListeleController();
            _extensionMethods = new ExtensionMethods();
            _extensionMethods.ComboDoldur(_listeleController.PersonelListele(), cmbPersonel);
            DateTime endDate = dtpIzinBaslamaTarihi.Value;
            dtpIzinBitisTarihi.MinDate = endDate.AddDays(1);
        }

        private void btnIzinKaydet_Click(object sender, EventArgs e)
        {
            PersonelIzin _personelIzin = new PersonelIzin();
            try
            {
                _personelIzin.PersonelID = ((Personel)cmbPersonel.SelectedItem).ID;
                _personelIzin.IzinTurID = ((IzinTur)cmbIzinTuru.SelectedItem).IzinTurID;
                _personelIzin.IzinBasTarihi = dtpIzinBaslamaTarihi.Value;
                _personelIzin.IzinBitisTarihi = dtpIzinBitisTarihi.Value;
                _personelIzin.AktifMi = true;
                _ekleController.EklemeyeGonder(_personelIzin);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            this.Close();
        }

        private void cmbIzinTuru_Click(object sender, EventArgs e)
        {
            _extensionMethods.ComboDoldur(_listeleController.IzinTurleriListele(), cmbIzinTuru);
        }

        private void dtpIzinBaslamaTarihi_ValueChanged(object sender, EventArgs e)
        {
            DateTime endDate = dtpIzinBaslamaTarihi.Value;
            dtpIzinBitisTarihi.MinDate = endDate.AddDays(1);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
