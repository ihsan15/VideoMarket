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
    public partial class frmFilmTuruTanimlama : Form
    {
        public frmFilmTuruTanimlama()
        {
            InitializeComponent();
        }

        private void frmFilmTuruTanimlama_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;
            cFilmTuru FilmTuru = new cFilmTuru();
            FilmTuru.FilmTurleriGetir(lvFilmTuruGoruntuleme);
        }

        private void Temizle()
        {
            txtAciklama.Clear();
            txtFilmTuru.Clear();
            txtTurNo.Clear();
            txtFilmTuru.Focus();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            btnKaydet.Enabled = true;
            Temizle();
            txtFilmTuru.Focus();
        }

        private void lvFilmTuruGoruntuleme_DoubleClick(object sender, EventArgs e)
        {
            txtTurNo.Text = lvFilmTuruGoruntuleme.SelectedItems[0].SubItems[0].Text;
            txtFilmTuru.Text = lvFilmTuruGoruntuleme.SelectedItems[0].SubItems[1].Text;
            txtAciklama.Text = lvFilmTuruGoruntuleme.SelectedItems[0].SubItems[2].Text;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            txtFilmTuru.Focus();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool Sonuc = false;
            if (txtFilmTuru.Text.Trim() != "")
            {
                cFilmTuru ft = new cFilmTuru();
                Sonuc = ft.FilmTuruVarmi(txtFilmTuru.Text);
                if (Sonuc == true)
                {
                    MessageBox.Show("Bu film türü daha önce eklenmiştir.");
                    txtFilmTuru.Focus();
                }
                else
                {
                    // Sonuc = ft.FilmTuruEkle(txtFilmTuru.Text, txtAciklama.Text);
                    ft.TurAd = txtFilmTuru.Text;
                    ft.Aciklama = txtAciklama.Text;
                    Sonuc = ft.FilmTuruEkle(ft);
                    if (Sonuc == true)
                    {
                        MessageBox.Show("Film Türü Eklendi");
                        btnKaydet.Enabled = false;
                        ft.FilmTurleriGetir(lvFilmTuruGoruntuleme);
                        Temizle();
                    }
                }
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            bool Sonuc = false;
            if (txtFilmTuru.Text.Trim() != "")
            {
                cFilmTuru ft = new cFilmTuru();
                Sonuc = ft.FilmTuruVarmi(txtFilmTuru.Text, Convert.ToInt32(txtTurNo.Text));
                if (Sonuc == true)
                {
                    MessageBox.Show("Bu film türü daha önceden Kayıtlı.");
                    txtFilmTuru.Focus();
                }
                else
                {
                    // Sonuc = ft.FilmTuruEkle(txtFilmTuru.Text, txtAciklama.Text);
                    ft.FilmTurNo = int.Parse(txtTurNo.Text);
                    ft.TurAd = txtFilmTuru.Text;
                    ft.Aciklama = txtAciklama.Text;
                    Sonuc = ft.FilmTuruGuncelle(ft);
                    if (Sonuc == true)
                    {
                        MessageBox.Show("Film Türü Güncellendi");
                        btnDegistir.Enabled = false;
                        btnSil.Enabled = false;
                        ft.FilmTurleriGetir(lvFilmTuruGoruntuleme);
                        Temizle();
                    }
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Silmek İstiyor musunuz?", "Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                cFilmTuru ft = new cFilmTuru();
                bool sonuc = ft.FilmTuruSil(Convert.ToInt32(txtTurNo.Text));
                if (sonuc)
                {
                    MessageBox.Show("Film Türü Silindi!");
                    ft.FilmTurleriGetir(lvFilmTuruGoruntuleme);
                    btnDegistir.Enabled = false;
                    btnSil.Enabled = false;
                    Temizle();
                }
            }
        }


    }
}
