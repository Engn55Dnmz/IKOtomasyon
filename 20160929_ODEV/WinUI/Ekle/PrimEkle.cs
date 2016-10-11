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
    public partial class PrimEkle : Form
    {
        EkleController _ekleController;
        public PrimEkle()
        {
            InitializeComponent();
            _ekleController = new EkleController();
        }

        private void btnPrimEkle_Click(object sender, EventArgs e)
        {
            PrimCesidi _primCesidi = new PrimCesidi();
            _primCesidi.PrimCesidi1 = txtPrimEkle.Text;
            _primCesidi.AktifMi = true;
            _ekleController.EklemeyeGonder(_primCesidi);
            this.Close();
        }
    }
}
