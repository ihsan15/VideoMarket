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
    public partial class frmFilmTanimlama : Form
    {
        public frmFilmTanimlama()
        {
            InitializeComponent();
        }

        private void frmFilmTanimlama_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;
            cFilmTuru ft = new cFilmTuru();
            ft.FilmTurleriGetir(cbFilmTuru);

            cFilm f = new cFilm();
            f.FilmleriGetir(lvFilmGoruntuleme);

            cbAramaTuru.SelectedIndex = 0;
        }

        private void lvFilmGoruntuleme_DoubleClick(object sender, EventArgs e)
        {
            txtFilmNo.Text = lvFilmGoruntuleme.SelectedItems[0].SubItems[0].Text;
            txtFilmAdi.Text = lvFilmGoruntuleme.SelectedItems[0].SubItems[1].Text;
            cbFilmTuru.Text = lvFilmGoruntuleme.SelectedItems[0].SubItems[2].Text;
            txtYonetmen.Text = lvFilmGoruntuleme.SelectedItems[0].SubItems[3].Text;
            txtOyuncular.Text = lvFilmGoruntuleme.SelectedItems[0].SubItems[4].Text;
            txtOzet.Text = lvFilmGoruntuleme.SelectedItems[0].SubItems[5].Text;
            txtFiyat.Text = lvFilmGoruntuleme.SelectedItems[0].SubItems[6].Text;
            txtMiktar.Text = lvFilmGoruntuleme.SelectedItems[0].SubItems[7].Text;
            txtTurNo.Text = lvFilmGoruntuleme.SelectedItems[0].SubItems[8].Text;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            txtFilmAdi.Focus();
        }


        private void cbFilmTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTurNo.Clear();
            cFilmTuru ft = (cFilmTuru)cbFilmTuru.SelectedItem;
            cbFilmTuru.SelectedItem = ft.TurAd;
            txtTurNo.Text = Convert.ToString(ft.FilmTurNo);            
            //txtTurNo.Text = ft.FilmTurNoGetir(cbFilmTuru.SelectedItem.ToString());
            txtYonetmen.Focus();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            Temizle();
            txtFilmAdi.Focus();
        }

        private void Temizle()
        {
            txtFilmAdi.Clear();
            cbAramaTuru.Text = "";
            txtFilmNo.Clear();
            txtFiyat.Clear();
            txtMiktar.Clear();
            txtOyuncular.Clear();
            txtOzet.Clear();
            txtTurNo.Clear();
            txtYonetmen.Clear();
            cbFilmTuru.Text = "Film Türü Seciniz..";
        }

        private void txtAramaTuru_TextChanged(object sender, EventArgs e)
        {
            if (txtAramaTuru.Text.Trim() != "" && cbAramaTuru.SelectedItem.ToString() == "Film Adına Göre")
            {
                cFilm f = new cFilm();
                txtAramaTuru.Text = f.IlkHarfBuyutme(txtAramaTuru.Text);                
                f.FilmleriGetirByAdaGore(lvFilmGoruntuleme, txtAramaTuru.Text);
            }
            else
            {
                cFilm f = new cFilm();
                f.FilmleriGetir(lvFilmGoruntuleme);
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(txtFilmAdi.Text.Trim() != "" && txtTurNo.Text.Trim() != "" && txtYonetmen.Text.Trim() != "")
            {
                cFilm f = new cFilm();
                bool sonuc = f.FilmVarmi(txtFilmAdi.Text, txtYonetmen.Text);
                if (sonuc)
                {
                    MessageBox.Show("Bu Film önceden kayıtlı!");
                    txtFilmAdi.Focus();
                }
                else
                {
                    f.FilmAd = txtFilmAdi.Text;
                    f.FilmTurNo = Convert.ToInt32(txtTurNo.Text);
                    f.Yonetmen = txtYonetmen.Text;
                    f.Oyuncular = txtOyuncular.Text;
                    f.Ozet = txtOzet.Text;
                    f.Fiyat = Convert.ToDecimal(txtFiyat.Text);
                    f.Miktar = int.Parse(txtMiktar.Text);
                    sonuc = f.FilmEkle(f);
                    if (sonuc == true)
                    {
                        MessageBox.Show("Film Eklendi");
                        btnKaydet.Enabled = false;
                        f.FilmleriGetir(lvFilmGoruntuleme);
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Hata Oluştu");
                        txtFilmAdi.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Film Adı, Türü ve Yönetmen alanları boş geçilemez", "DİKKAT Eksik Bilgi!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtFilmAdi.Text.Trim() != "" && txtTurNo.Text.Trim() != "" && txtYonetmen.Text.Trim() != "")
            {
                cFilm f = new cFilm();
                bool sonuc = f.FilmVarmi(txtFilmAdi.Text, txtYonetmen.Text, Convert.ToInt32(txtFilmNo.Text));
                if (sonuc)
                {
                    MessageBox.Show("Bu Film önceden kayıtlı!");
                    txtFilmAdi.Focus();
                }
                else
                {
                    f.FilmNo = int.Parse(txtFilmNo.Text);
                    f.FilmAd = txtFilmAdi.Text;
                    f.FilmTurNo = Convert.ToInt32(txtTurNo.Text);
                    f.Yonetmen = txtYonetmen.Text;
                    f.Oyuncular = txtOyuncular.Text;
                    f.Ozet = txtOzet.Text;
                    f.Fiyat = Convert.ToDecimal(txtFiyat.Text);
                    f.Miktar = int.Parse(txtMiktar.Text);
                    sonuc = f.FilmGuncelle(f);
                    if (sonuc == true)
                    {
                        MessageBox.Show("Film Güncellendi");
                        btnDegistir.Enabled = false;
                        btnSil.Enabled = false;
                        f.FilmleriGetir(lvFilmGoruntuleme);
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Hata Oluştu");
                        txtFilmAdi.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Film Adı, Türü ve Yönetmen alanları boş geçilemez", "DİKKAT Eksik Bilgi!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cFilm f = new cFilm();
                bool sonuc = f.FilmSil(Convert.ToInt32(txtTurNo.Text));
                if (sonuc)
                {
                    MessageBox.Show("Film Türü Silindi!");
                    f.FilmleriGetir(lvFilmGoruntuleme);
                    btnDegistir.Enabled = false;
                    btnSil.Enabled = false;
                    Temizle();
                }
            }
        }


    }
}
