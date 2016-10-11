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
    public partial class PrimVer : Form
    {
        EkleController _ekleController;
        ListeleController _listeleController;
        ExtensionMethods _extensionMethods;
        public PrimVer()
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

        private void btnPrimVer_Click(object sender, EventArgs e)
        {
            PrimIslem _primVer = new PrimIslem();
            _primVer.AktifMi = true;
            try
            {
                _primVer.PersonelID = ((Personel)cmbPersonel.SelectedItem).ID;
                _primVer.PrimID = ((PrimCesidi)cmbPrimCesidi.SelectedItem).PrimID;
                _primVer.PrimTutari = Convert.ToDecimal(txtPrimMiktari.Text);
                _primVer.PrimTarihi = dtpPrimTarihi.Value;
                _ekleController.EklemeyeGonder(_primVer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            
            this.Close();
        }

        private void cmbPrimCesidi_Click(object sender, EventArgs e)
        {
            _extensionMethods.ComboDoldur(_listeleController.PrimCesidiListele(), cmbPrimCesidi);
        }

        private void cmbPersonel_Click(object sender, EventArgs e)
        {
            _extensionMethods.ComboDoldur(_listeleController.PersonelListele(), cmbPersonel);
        }
    }
}
