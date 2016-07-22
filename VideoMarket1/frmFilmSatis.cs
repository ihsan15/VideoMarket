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
    public partial class frmFilmSatis : Form
    {
        public frmFilmSatis()
        {
            InitializeComponent();
        }

        private void frmFilmSatis_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            txtTarih.Text = DateTime.Now.ToShortDateString();

            cFilmSatis fs = new cFilmSatis();
            fs.SatislariGetir(lvSatisGoruntuleme,txtToplamAdet,txtToplamTutar);

        }

        private void btnMusteriAra_Click(object sender, EventArgs e)
        {
            frmMusteriSorgulama ms = new frmMusteriSorgulama();
            ms.StartPosition = FormStartPosition.CenterScreen;
            ms.ShowDialog();
            txtMusteriNo.Text = (cGenel.musterino).ToString();
            txtMusteri.Text = cGenel.musteri;
            if (txtMusteri.Text.Trim() != "" && txtFilm.Text.Trim() == "")
            {
                Temizle();
                btnFilmAra.PerformClick();
                txtAdet.Focus();
            }
        }
        
        private void btnFilm_Click(object sender, EventArgs e)
        {
            frmFilmSorgulama fis = new frmFilmSorgulama();
            fis.StartPosition = FormStartPosition.CenterScreen;
            fis.ShowDialog();
            txtFilmNo.Text = cGenel.filmno.ToString();
            txtFilm.Text = cGenel.film;
            txtStok.Text = cGenel.stok.ToString();
            txtFiyat.Text = cGenel.fiyat.ToString();           
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnFilmAra.Enabled = true;
            btnKaydet.Enabled = true;
            btnMusteriAra.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            if(txtSatisNo.Text.Trim() != "")
            {
                txtSatisNo.Clear();
                txtMusteri.Clear();
            }
            Temizle();
            if (txtMusteri.Text.Trim() == "" && txtFilm.Text.Trim() == "")
            {
                txtMusteri.Focus();
                btnMusteriAra.PerformClick();
            }
            if(txtMusteri.Text.Trim() != "" && txtFilm.Text.Trim() == "")
            {                                
                btnFilmAra.PerformClick();
                txtAdet.Focus();
            }
            
        }

        private void Temizle()
        {
            txtAdet.Text = "1";
            txtFiyat.Text = "0";
            txtTutar.Text = "0";
            txtFilm.Clear();
            txtFilmNo.Clear();
            txtStok.Clear();
            txtFilm.Focus();
        }

        private void txtFiyat_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFiyat.Text)) { txtFiyat.Text = "0"; txtFiyat.Select(0, 2); }
            if (string.IsNullOrEmpty(txtAdet.Text)) { txtAdet.Text = "1"; txtAdet.Select(0, 2); }
            txtTutar.Text = (Convert.ToDecimal(txtFiyat.Text) * Convert.ToInt32(txtAdet.Text)).ToString();
        }

        private void txtAdet_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFiyat.Text)) { txtFiyat.Text = "0"; txtFiyat.Select(0, 2); }
            if (string.IsNullOrEmpty(txtAdet.Text)) { txtAdet.Text = "1"; txtAdet.Select(0, 2); }
            txtTutar.Text = (Convert.ToDecimal(txtFiyat.Text) * Convert.ToInt32(txtAdet.Text)).ToString();            
        }

        private void dtpSatisTarihi_ValueChanged(object sender, EventArgs e)
        {
            txtTarih.Text = dtpSatisTarihi.Value.ToShortDateString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtMusteri.Text.Trim() != "" && txtFilm.Text.Trim() != "" && txtTutar.Text.Trim() != "0")
            {
                if (Convert.ToInt32(txtAdet.Text) > Convert.ToInt32(txtStok.Text))
                {
                    MessageBox.Show("Stok Yeterli Değil!");
                    txtAdet.Text = txtStok.Text;
                    txtAdet.Focus();
                }
                else
                {
                    cFilmSatis fs = new cFilmSatis();
                    fs.MusteriNo =int.Parse(txtMusteriNo.Text);
                    fs.FilmNo = int.Parse(txtFilmNo.Text);
                    fs.Tarih = Convert.ToDateTime(txtTarih.Text);
                    fs.Adet = Convert.ToInt32(txtAdet.Text);
                    fs.BirimFiyat = Convert.ToDecimal(txtFiyat.Text);
                    if (fs.SatisEkle(fs))
                    {
                        MessageBox.Show("Satış Bilgisi Eklendi");
                        cFilm f = new cFilm();
                       if(f.StokGuncelleFromSatisEkle(fs.FilmNo, fs.Adet))
                        {
                            fs.SatislariGetir(lvSatisGoruntuleme, txtToplamAdet, txtToplamTutar);
                            btnKaydet.Enabled = false;
                            btnMusteriAra.Enabled = false;
                            btnFilmAra.Enabled = false;
                            Temizle();
                            txtFilm.Focus();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Müşteri Eklenemedi!! ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMusteri.Focus();
                    }
                }                
            }
            else
            {
                MessageBox.Show("Müşteri ve Film boş geçilemez!!", "Eksik Bilgi");
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cFilmSatis fs = new cFilmSatis();
                fs.SatisNo = Convert.ToInt32(txtSatisNo.Text);
                if (fs.SatisIptal(fs))
                {
                    MessageBox.Show("Satış Bilgileri Silindi!");
                    cFilm f = new cFilm();
                    if(f.StokGuncelleFromSatisIptal(Convert.ToInt32(txtFilmNo.Text),Convert.ToInt32(txtAdet.Text)))
                    {
                        fs.SatislariGetir(lvSatisGoruntuleme, txtToplamAdet, txtToplamTutar);
                        btnDegistir.Enabled = false;
                        btnSil.Enabled = false;
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Stok Guncellenemedi!!");
                    }
                }
                else
                {
                    MessageBox.Show("Satış Bilgileri silinemedi!!");
                }
            }
        }

        private void txtAdet_Click(object sender, EventArgs e)
        {
            if (txtAdet.Text=="1") { txtAdet.Text = "1"; txtAdet.Select(0, 2); }
        }

        private void txtFiyat_Click(object sender, EventArgs e)
        {
            if (txtFiyat.Text == "0") { txtFiyat.Text = "0"; txtFiyat.Select(0, 2); }
        }

        private void lvSatisGoruntuleme_DoubleClick(object sender, EventArgs e)
        {
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            txtMusteri.Focus();
            txtSatisNo.Text = lvSatisGoruntuleme.SelectedItems[0].SubItems[0].Text;
            txtTarih.Text = lvSatisGoruntuleme.SelectedItems[0].SubItems[1].Text;
            txtMusteriNo.Text = lvSatisGoruntuleme.SelectedItems[0].SubItems[2].Text;
            txtMusteri.Text = lvSatisGoruntuleme.SelectedItems[0].SubItems[3].Text;
            txtFilmNo.Text = lvSatisGoruntuleme.SelectedItems[0].SubItems[4].Text;
            txtFilm.Text = lvSatisGoruntuleme.SelectedItems[0].SubItems[5].Text;
            txtAdet.Text = lvSatisGoruntuleme.SelectedItems[0].SubItems[6].Text;
            txtFiyat.Text = lvSatisGoruntuleme.SelectedItems[0].SubItems[7].Text;
            //txtTutar.Text = lvSatisGoruntuleme.SelectedItems[0].SubItems[8].Text;

        }
    }
}
