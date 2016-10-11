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
    public partial class YetkiAta : Form
    {
        EkleController _ekleController;
        ListeleController _listeleController;
        ExtensionMethods _extensionMethods;
        public YetkiAta()
        {
            InitializeComponent();
            _ekleController = new EkleController();
            _listeleController = new ListeleController();
            _extensionMethods = new ExtensionMethods();
        }

        private void btnYetkiAta_Click(object sender, EventArgs e)
        {
            YetkiIslem islem = new YetkiIslem();
            try
            {
                islem.PersonelID = ((Personel)cmbPersonel.SelectedItem).ID;
                islem.YetkiID = ((Yetki_T)cmbYetki.SelectedItem).YetkiID;
                islem.AktifMi = true;
                _ekleController.EklemeyeGonder(islem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            this.Close();
        }

        private void cmbPersonel_Click(object sender, EventArgs e)
        {
            _extensionMethods.ComboDoldur(_listeleController.PersonelListele(), cmbPersonel);
        }

        private void cmbYetki_Click(object sender, EventArgs e)
        {
            _extensionMethods.ComboDoldur(_listeleController.YetkiListele(), cmbYetki);
        }
    }
}
