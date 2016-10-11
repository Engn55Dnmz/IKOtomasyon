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
    public partial class MaasVer : Form
    {
        EkleController _ekleController;
        ListeleController _listeleController;
        ExtensionMethods _extensionMethods;
        public MaasVer()
        {
            InitializeComponent();
            _ekleController = new EkleController();
            _listeleController = new ListeleController();
            _extensionMethods = new ExtensionMethods();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbPersonel_Click(object sender, EventArgs e)
        {
            _extensionMethods.ComboDoldur(_listeleController.PersonelListele(), cmbPersonel);
        }

        private void cmbMaas_Click(object sender, EventArgs e)
        {
            _extensionMethods.ComboDoldur(_listeleController.MaasListele(), cmbMaas);
        }

        private void btnMaasVer_Click(object sender, EventArgs e)
        {
            MaasIslem islem = new MaasIslem();
            try
            {
                islem.MaasID = ((Maas_T)cmbMaas.SelectedItem).MaasID;
                islem.PersonelID = ((Personel)cmbPersonel.SelectedItem).ID;
                islem.MaasTarihi = dtpMaasTarihi.Value;
                _ekleController.EklemeyeGonder(islem);
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
