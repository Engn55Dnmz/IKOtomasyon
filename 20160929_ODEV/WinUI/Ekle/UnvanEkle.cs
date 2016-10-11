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
    public partial class UnvanEkle : Form
    {
        EkleController _ekleController;
        public UnvanEkle()
        {
            InitializeComponent();
            _ekleController = new EkleController();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUnvanEkle_Click(object sender, EventArgs e)
        {
            Unvan _unvan = new Unvan();
            _unvan.UnvanAdi = txtUnvan.Text;
            _ekleController.EklemeyeGonder(_unvan);
            this.Close();
        }
    }
}
