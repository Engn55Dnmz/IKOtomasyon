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
    public partial class IseGirisCikisBelirle : Form
    {
        EkleController _ekleController;
        ListeleController _listeleController;
        ExtensionMethods _extensionMethods;
        bool _aktifMi;
        PersonelGirisCikis girisCikis;
        public IseGirisCikisBelirle()
        {
            InitializeComponent();
            _ekleController = new EkleController();
            _listeleController = new ListeleController();
            _extensionMethods = new ExtensionMethods();
            DateTime endDate = dtpGirisTarihi.Value;
            dtpCikisTarihi.MinDate = endDate.AddDays(1);
        }

        private void dtpGirisTarihi_ValueChanged(object sender, EventArgs e)
        {
            DateTime endDate = dtpGirisTarihi.Value;
            dtpCikisTarihi.MinDate = endDate.AddDays(1);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbPersonel_Click(object sender, EventArgs e)
        {
            _extensionMethods.ComboDoldur(_listeleController.ButunPersonelListele(), cmbPersonel);
        }

        private void btnTarihKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                girisCikis.IseBaslamaTarihi = dtpGirisTarihi.Value;
                girisCikis.IstenCikmaTarihi = dtpCikisTarihi.Value;
                _ekleController.EklemeyeGonder(girisCikis,_aktifMi);
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
            girisCikis = new PersonelGirisCikis();
            _aktifMi = (bool)((Personel)cmbPersonel.SelectedItem).AktifMi;
            if (_aktifMi)
            {
                girisCikis = _listeleController.PersonelinGirisCikisiListele((Personel)cmbPersonel.SelectedItem);
                dtpGirisTarihi.Value = (DateTime)girisCikis.IseBaslamaTarihi;
                dtpCikisTarihi.Enabled = true;
                dtpGirisTarihi.Enabled = false;
            }
            else
            {
                girisCikis.PersonelID = ((Personel)cmbPersonel.SelectedItem).ID;
                dtpCikisTarihi.Enabled = false;
                dtpGirisTarihi.Enabled = true;
            }
        }
    }
}
