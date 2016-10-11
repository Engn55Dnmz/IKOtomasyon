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

namespace WinUI
{
    public partial class SehirEkle : Form
    {
        EkleController _ekleConroller;
        public SehirEkle()
        {
            InitializeComponent();
            _ekleConroller = new EkleController();
        }

        private void btnSehirEkle_Click(object sender, EventArgs e)
        {
            Sehir_T _sehir = new Sehir_T();
            _sehir.SehirAdi = txtSehirAdi.Text;
            _sehir.AktifMi = true;
            _ekleConroller.EklemeyeGonder(_sehir);
            this.Close();
        }
    }
}
