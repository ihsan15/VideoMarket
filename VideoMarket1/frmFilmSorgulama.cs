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
    public partial class frmFilmSorgulama : Form
    {
        public frmFilmSorgulama()
        {
            InitializeComponent();
        }



        private void frmFilmSorgulama_Load(object sender, EventArgs e)
        {
            //this.Top = 0;
            //this.Left = 0;
            cFilmTuru ft = new cFilmTuru();
            ft.FilmTurleriGetir(cbFilmTuru);

            cFilm f = new cFilm();
            f.FilmleriGetir(lvFilmGoruntuleme);

            cbFilmTuru.Items.Add("Tüm Türler");

            cbFilmTuru.Items.Insert(0, "Tüm Türler");

            cbFilmTuru.SelectedIndex = 0;

        }

        private void cbFilmTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilmleriGetir();
        }       

        private void txtFilmAdi_TextChanged(object sender, EventArgs e)
        {
            FilmleriGetir();
        }

        private void txtYonetmen_TextChanged(object sender, EventArgs e)
        {
            FilmleriGetir();
            //cFilm f = new cFilm();
            //f.FilmleriGetirByYonetmeneGore(lvFilmGoruntuleme, txtYonetmen.Text);
        }

        private void txtOyuncular_TextChanged(object sender, EventArgs e)
        {
            FilmleriGetir();
            //cFilm f = new cFilm();
            //f.FilmleriGetirByOyuncularaGore(lvFilmGoruntuleme, txtOyuncular.Text);
        }

        private void FilmleriGetir()
        {
            string tur = "";
            
            if(cbFilmTuru.SelectedItem.ToString() != "Tüm Türler")
            {
                tur = cbFilmTuru.SelectedItem.ToString();
            }

            cFilm f = new cFilm();
            f.FilmleriGetirByDetaySorgulama(txtFilmAdi.Text, tur, txtYonetmen.Text, txtOyuncular.Text, lvFilmGoruntuleme);
        }

        private void lvFilmGoruntuleme_DoubleClick(object sender, EventArgs e)
        {
            cGenel.filmno = Convert.ToInt32(lvFilmGoruntuleme.SelectedItems[0].SubItems[0].Text);
            cGenel.film = lvFilmGoruntuleme.SelectedItems[0].SubItems[1].Text;
            cGenel.stok = Convert.ToInt32(lvFilmGoruntuleme.SelectedItems[0].SubItems[7].Text);
            cGenel.fiyat = Convert.ToDouble(lvFilmGoruntuleme.SelectedItems[0].SubItems[6].Text);
            this.Close();
        }
    }
}
