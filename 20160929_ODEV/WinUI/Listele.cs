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
    public partial class Listele : Form
    {
        ListeleController _listeleController;
        public Listele()
        {
            InitializeComponent();
            _listeleController = new ListeleController();
        }

        private void btnPersonelListele_Click(object sender, EventArgs e)
        {
            dgvListele.DataSource = _listeleController.PersonelAyrintiListele();
        }

        private void btnMaasListele_Click(object sender, EventArgs e)
        {
            dgvListele.DataSource = _listeleController.PersonelMaaslariListele();
        }

        private void btnIzinListele_Click(object sender, EventArgs e)
        {
            dgvListele.DataSource = _listeleController.PersonelIzinleriListele();
        }

        private void btnAracListele_Click(object sender, EventArgs e)
        {
            dgvListele.DataSource = _listeleController.PersonelAracTahsisleriListele();
        }
    }
}
