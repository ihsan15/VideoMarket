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
    public partial class frmMusteriTanimlama : Form
    {
        public frmMusteriTanimlama()
        {
            InitializeComponent();
        }

        private void frmMusteriTanimlama_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            cMusteri m = new cMusteri();
            m.MusterileriGetir(lvMusteriGoruntuleme);
    
            cbAramaTuru.SelectedIndex = 0;
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            Temizle();
        }

        private void Temizle()
        {
            txtMusteriAdi.Clear();
            txtMusteriNo.Clear();
            txtAdres.Clear();
            txtMusteriSoyad.Clear();
            txtTelefon.Clear();
            txtMusteriAdi.Focus();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(txtMusteriAdi.Text.Trim() != "" && txtMusteriSoyad.Text.Trim() != "" && txtTelefon.Text.Trim() != "" )
            {
                cMusteri m = new cMusteri();
                if(m.MusteriVarmi(txtMusteriAdi.Text,txtMusteriSoyad.Text,txtTelefon.Text))
                {
                    MessageBox.Show("Girdiğiniz müşteri bilgisi zaten kayıtlı !");
                    txtMusteriAdi.Focus();
                }
                else
                {
                    m.Ad = txtMusteriAdi.Text;
                    m.Soyad = txtMusteriSoyad.Text;
                    m.Telefon =txtTelefon.Text;
                    m.Adres = txtAdres.Text;
                    if(m.MusteriEkle(m))
                    {
                        MessageBox.Show("Müşteri bilgileri Eklendi");
                        m.MusterileriGetir(lvMusteriGoruntuleme);
                        btnKaydet.Enabled = false;
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Müşteri Eklenemedi!! ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMusteriAdi.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Musteri Adı, Soyadı ve Telefonu boş geçilemez!!", "Eksik Bilgi");
            }
        }

        private void txtAramaTuru_TextChanged(object sender, EventArgs e)
        {
            if(txtAramaTuru.Text.Trim() != "" && cbAramaTuru.SelectedItem.ToString() == "Müşteri Adına Göre")
            {
                cMusteri m = new cMusteri();
                m.MusterileriGetirByAdaGore(txtAramaTuru.Text,lvMusteriGoruntuleme);
            }
            else
            {
                cMusteri m = new cMusteri();
                m.MusterileriGetir(lvMusteriGoruntuleme);
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtMusteriAdi.Text.Trim() != "" && txtMusteriSoyad.Text.Trim() != "" && txtTelefon.Text.Trim() != "")
            {
                cMusteri m = new cMusteri();
                m.MusteriNo = int.Parse(txtMusteriNo.Text);
                m.Ad = txtMusteriAdi.Text;
                m.Soyad = txtMusteriSoyad.Text;
                m.Telefon = txtTelefon.Text;
                m.Adres = txtAdres.Text;
                if (m.MusteriGuncelle(m))
                {
                    MessageBox.Show("Müşteri bilgileri Güncellendi");
                    m.MusterileriGetir(lvMusteriGoruntuleme);
                    btnKaydet.Enabled = false;
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Müşteri Güncellenemedi!! ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMusteriAdi.Focus();
                }
            }        
        }

        private void lvMusteriGoruntuleme_DoubleClick(object sender, EventArgs e)
        {
            txtMusteriNo.Text = lvMusteriGoruntuleme.SelectedItems[0].SubItems[0].Text;
            txtMusteriAdi.Text = lvMusteriGoruntuleme.SelectedItems[0].SubItems[1].Text;
            txtMusteriSoyad.Text = lvMusteriGoruntuleme.SelectedItems[0].SubItems[2].Text;
            txtTelefon.Text = lvMusteriGoruntuleme.SelectedItems[0].SubItems[3].Text;
            txtAdres.Text = lvMusteriGoruntuleme.SelectedItems[0].SubItems[4].Text;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            txtMusteriAdi.Focus();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cMusteri m = new cMusteri();
                if (m.MusteriSil(Convert.ToInt32(txtMusteriNo.Text)))
                {
                    MessageBox.Show("Film Türü Silindi!");
                    m.MusterileriGetir(lvMusteriGoruntuleme);
                    btnDegistir.Enabled = false;
                    btnSil.Enabled = false;
                    Temizle();
                }
            }
        }
    }
}
