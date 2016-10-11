using BLL;
using Entity;
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
    public partial class UniversiteEkle : Form
    {
        EkleController _ekleController;
        public UniversiteEkle()
        {
            InitializeComponent();
            _ekleController = new EkleController();
        }

        private void btnUniversiteEkle_Click(object sender, EventArgs e)
        {
            Okul _okul = new Okul();
            _okul.OkulAdi = txtUniversite.Text;
            _okul.AktifMi = true;
            _ekleController.EklemeyeGonder(_okul);
            this.Close();
        }
    }
}
