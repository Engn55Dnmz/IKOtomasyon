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
    public partial class BirimEkle : Form
    {
        EkleController _ekleController;
        ExtensionMethods _extension;
        ListeleController _listeleController;
        public BirimEkle()
        {
            InitializeComponent();
             _ekleController = new EkleController();
            _extension = new ExtensionMethods();
            _listeleController = new ListeleController();
            _extension.ComboDoldur(_listeleController.DepartmanListele(), cmbDepartman);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBirimEkle_Click(object sender, EventArgs e)
        {
            Birim_T _birim = new Birim_T();
            DepartmanIslem _departmanIslem = new DepartmanIslem();
            _birim.BirimAdi = txtBirim.Text;
            _birim.AktifMi = true;

            _departmanIslem.DerpartmanID = ((Departman_T)cmbDepartman.SelectedItem).ID;
            _departmanIslem.BirimID = _ekleController.EklemeyeGonder(_birim);
            _departmanIslem.AktifMi = true;
            _ekleController.EklemeyeGonder(_departmanIslem);
            this.Close();
        }
    }
}
