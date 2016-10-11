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

namespace IKProje
{
    public partial class IzinTurEkle : Form
    {
        EkleController _ekleController;
        public IzinTurEkle()
        {
            InitializeComponent();
            _ekleController = new EkleController();
        }

        private void btnIzinTurEkle_Click(object sender, EventArgs e)
        {
            IzinTur _izinTur = new IzinTur();
            _izinTur.IzinTuru = txtIzinTuru.Text;
            _izinTur.AktifMi = true;
            _ekleController.EklemeyeGonder(_izinTur);
            this.Close();
        }
    }
}
