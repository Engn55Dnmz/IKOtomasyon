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
    public partial class AracEkle : Form
    {
        EkleController _ekleController;
        ExtensionMethods _extension;
        ListeleController _listeleController;
        public AracEkle()
        {
            InitializeComponent();
            _ekleController = new EkleController();
            _extension = new ExtensionMethods();
            _listeleController = new ListeleController();
            _extension.ComboDoldur(_listeleController.AracMarkalariListele(), cmbMarkalar);
            cmbMarkalar.SelectedIndex = 0;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            Araclar _arac = new Araclar();
            try
            {
                _arac.ModelID = ((AracModel)cmbModeller.SelectedItem).ModelID;
                _arac.Plaka = txtPlaka.Text;
                _arac.AktifMi = true;
                _ekleController.EklemeyeGonder(_arac);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            this.Close();
        }

        private void cmbMarkalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            AracMarka _marka = new AracMarka();
            _marka = ((AracMarka)cmbMarkalar.SelectedItem);
            if (_marka != null) _extension.ComboDoldur(_listeleController.AracModelleriListele(_marka.MarkaID), cmbModeller);
        }
    }
}
