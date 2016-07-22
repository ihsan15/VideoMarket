using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoMarket1
{
    public partial class frmDetayliSatisSorgulama : Form
    {
        public frmDetayliSatisSorgulama()
        {
            InitializeComponent();
        }

        private void frmDetayliSatisSorgulama_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            cFilmTuru ft = new cFilmTuru();
            ft.FilmTurleriGetir(cbFilmTurleri);
            cbFilmTurleri.Items.Insert(0, "Tüm Müşteriler");
            cbFilmTurleri.SelectedIndex = 0;

        }

        private void btnGetir_Click(object sender, EventArgs e)
        {

        }

        private void btnFilmAra_Click(object sender, EventArgs e)
        {

        }

        private void btnMusteriAra_Click(object sender, EventArgs e)
        {

        }
    }
}
