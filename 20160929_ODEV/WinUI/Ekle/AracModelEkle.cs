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

namespace WinUI
{
    public partial class AracModelEkle : Form
    {
        EkleController _ekleController;
        ExtensionMethods _extension;
        ListeleController _listeleController;
        public AracModelEkle()
        {
            InitializeComponent();
            _ekleController = new EkleController();
            _extension = new ExtensionMethods();
            _listeleController = new ListeleController();
            _extension.ComboDoldur(_listeleController.AracMarkalariListele(), cmbMarkaAdi);
            cmbMarkaAdi.SelectedIndex = 0;
        }

        private void btnModelEkle_Click(object sender, EventArgs e)
        {
            AracModel _model = new AracModel();
            _model.Model = txtModelAdi.Text;
            _model.MarkaID = ((AracMarka)cmbMarkaAdi.SelectedItem).MarkaID;
            _model.AktifMi = true;
            _ekleController.EklemeyeGonder(_model);
            this.Close();
        }
    }
}
