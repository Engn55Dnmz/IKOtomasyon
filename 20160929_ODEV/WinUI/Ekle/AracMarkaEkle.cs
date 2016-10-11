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
    public partial class AracMarkaEkle : Form
    {
        EkleController _ekleController;
        public AracMarkaEkle()
        {
            InitializeComponent();
            _ekleController = new EkleController();
        }

        private void btnMarkaEkle_Click(object sender, EventArgs e)
        {
            AracMarka _marka = new AracMarka();
            try
            {
                _marka.Marka = txtMarkaAdi.Text;
                _marka.AktifMi = true;
                _ekleController.EklemeyeGonder(_marka);
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
