using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;
using Extension;

namespace WinUI
{
    public partial class IletisimBilgisiBelirle : Form
    {
        EkleController eklecontrol;
        ListeleController listelecontrol;
        ExtensionMethods extensionMethods;
        public IletisimBilgisiBelirle()
        {
            InitializeComponent();
            eklecontrol = new EkleController();
            listelecontrol = new ListeleController();
            extensionMethods = new ExtensionMethods();
            extensionMethods.ComboDoldur(listelecontrol.PersonelListele(), cmbPersonel);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Personel _personel = new Personel();
            PersonelIletisim _personelIletisim = new PersonelIletisim();
            _personel = (Personel)cmbPersonel.SelectedItem;
            _personelIletisim = listelecontrol.PersonelIletisimListele(_personel);
            extensionMethods.ComboDoldur(listelecontrol.SehirlerListele(), cmbSehir);
            ControlDoldur(_personelIletisim);
        }

        private void ControlDoldur(PersonelIletisim nesne)
        {
            mtxtCepTel.Text = nesne.CepTel;
            mtxtEvTel.Text = nesne.EvTel;
            txtEMail.Text = nesne.EMail;
            txtAcikAdres.Text = nesne.AcikAdres;
            if (nesne.SemtID != null)
            {
                cmbSehir.SelectedItem = nesne.Semt_T.Ilce_T.Sehir_T;
                cmbIlce.SelectedItem = nesne.Semt_T.Ilce_T;
                cmbSemt.SelectedItem = nesne.Semt_T;
            }

        }

        private void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            extensionMethods.CmbSifirla(cmbIlce);
            Sehir_T _sehir = new Sehir_T();
            _sehir = ((Sehir_T)cmbSehir.SelectedItem);
            if (_sehir != null) extensionMethods.ComboDoldur(listelecontrol.IlcelerListele(_sehir.ID), cmbIlce);
        }

        private void cmbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            extensionMethods.CmbSifirla(cmbSemt);
            Ilce_T _ilce = new Ilce_T();
            _ilce = ((Ilce_T)cmbIlce.SelectedItem);
            if (_ilce != null) extensionMethods.ComboDoldur(listelecontrol.SemtlerListele(_ilce.ID), cmbSemt);
        }

        private void btnIletisimKaydet_Click(object sender, EventArgs e)
        {
            PersonelIletisim nesne = new PersonelIletisim();
            try
            {
                nesne = extensionMethods.IletisimEklemeyeGonder(((Personel)cmbPersonel.SelectedItem).ID, mtxtCepTel.Text, mtxtEvTel.Text, txtEMail.Text, ((Semt_T)cmbSemt.SelectedItem).ID, txtAcikAdres.Text, true);
                eklecontrol.EklemeyeGonder(nesne);
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
