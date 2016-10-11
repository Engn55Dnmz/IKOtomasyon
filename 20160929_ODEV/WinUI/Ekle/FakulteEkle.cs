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

namespace IKProje
{
    public partial class FakulteEkle : Form
    {
        EkleController _ekleController;
        ListeleController _listeleController;
        ExtensionMethods _extension;
        public FakulteEkle()
        {
            InitializeComponent();
            _ekleController = new EkleController();
            _listeleController = new ListeleController();
            _extension = new ExtensionMethods();
            _extension.ComboDoldur(_listeleController.OkulListele(), cmbUniversiteAdi);
            cmbUniversiteAdi.SelectedIndex = 0;
        }

        private void btnFakulteEkle_Click(object sender, EventArgs e)
        {
            Fakulte _fakulte = new Fakulte();
            _fakulte.FakulteAdi = txtFakulteAdi.Text;
            _fakulte.OkulID = ((Okul)cmbUniversiteAdi.SelectedItem).OkulID;
            _fakulte.AktifMi = true;
            _ekleController.EklemeyeGonder(_fakulte);
            this.Close();
        }
    }
}
