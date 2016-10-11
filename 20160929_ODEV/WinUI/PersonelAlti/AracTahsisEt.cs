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
    public partial class AracTahsisEt : Form
    {
        EkleController _ekleController;
        ListeleController _listeleController;
        ExtensionMethods _extensionMethods;
        public AracTahsisEt()
        {
            InitializeComponent();
            _ekleController = new EkleController();
            _listeleController = new ListeleController();
            _extensionMethods = new ExtensionMethods();
            DateTime endDate = dtpAldigiTarih.Value;
            dtpBiraktigiTarih.MinDate = endDate.AddDays(1);
        }

        private void dtpAldigiTarih_ValueChanged(object sender, EventArgs e)
        {
            DateTime endDate = dtpAldigiTarih.Value;
            dtpBiraktigiTarih.MinDate = endDate.AddDays(1);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTahsisEt_Click(object sender, EventArgs e)
        {
            AracPersonel islem = new AracPersonel();
            //try
            //{
            islem.PersonelID = ((Personel)cmbPersonel.SelectedItem).ID;
            islem.AracID = ((Araclar)cmbAraclar.SelectedItem).AracID;
            islem.AldigiTarih = dtpAldigiTarih.Value;
            islem.BiraktigiTarih = dtpBiraktigiTarih.Value;
            islem.AktifMi = true;
            _ekleController.EklemeyeGonder(islem);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //    return;
            //}

            this.Close();
        }

        private void cmbPersonel_Click(object sender, EventArgs e)
        {
            _extensionMethods.ComboDoldur(_listeleController.PersonelListele(), cmbPersonel);
        }

        private void cmbAraclar_Click(object sender, EventArgs e)
        {
            _extensionMethods.ComboDoldur(_listeleController.AraclarListele(), cmbAraclar);
        }
    }
}
