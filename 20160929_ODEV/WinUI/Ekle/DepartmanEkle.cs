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
    public partial class DepartmanEkle : Form
    {
        EkleController _ekleController;
        public DepartmanEkle()
        {
            InitializeComponent();
            _ekleController = new EkleController();
        }

        private void btnDepartmanEkle_Click(object sender, EventArgs e)
        {
             Departman_T _departman = new Departman_T();
             _departman.DepartmanAdi = txtDeparmanAdi.Text;
             _departman.AktifMi = true;
             _ekleController.EklemeyeGonder(_departman);
             this.Close();
        }

    }
}
