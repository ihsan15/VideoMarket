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
    public partial class frmMusteriSorgulama : Form
    {
        public frmMusteriSorgulama()
        {
            InitializeComponent();
        }

        private void frmMusteriSorgulama_Load(object sender, EventArgs e)
        {
            //this.Top = 0;
            //this.Left = 0;
            cMusteri m = new cMusteri();
            m.MusterileriGetir(lvMusteriGoruntuleme);
        }

        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            MusterileriGetir();
        }

        private void txtSoyadaGore_TextChanged(object sender, EventArgs e)
        {
            MusterileriGetir();
        }

        private void txtTelefonaGore_TextChanged(object sender, EventArgs e)
        {
            MusterileriGetir();
        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {
            MusterileriGetir();
        }

        private void MusterileriGetir()
        {
            cMusteri m = new cMusteri();
            m.MusterileriGetirByDetaySorgulama(txtAdaGore.Text, txtSoyadaGore.Text, txtTelefonaGore.Text,txtAdres.Text, lvMusteriGoruntuleme);
        }

        private void lvMusteriGoruntuleme_DoubleClick(object sender, EventArgs e)
        {
            cGenel.musterino = Convert.ToInt32(lvMusteriGoruntuleme.SelectedItems[0].SubItems[0].Text);
            cGenel.musteri = lvMusteriGoruntuleme.SelectedItems[0].SubItems[1].Text + " " + lvMusteriGoruntuleme.SelectedItems[0].SubItems[2].Text;
            this.Close();

        }
    }
}
