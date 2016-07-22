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
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void FormAcilacakmi(Form AcilacakForm)
        {
            bool acikmi = false;
            for (int i = 0; i < this.MdiChildren.Count(); i++)
            {
                if (this.MdiChildren[i].Name == AcilacakForm.Name)
                {
                    this.MdiChildren[i].Focus();
                    acikmi = true;
                }
            }
            if (acikmi == false)
            {
                AcilacakForm.MdiParent = this;
                AcilacakForm.Show();
            }
            else
            {
                AcilacakForm.Dispose(); // oluşturulmuş form listesini doğrudan atabiliriz.
            }
        }

        private void çıkışToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void filmTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFilmTanimlama hesap = new frmFilmTanimlama();
            FormAcilacakmi(hesap);
        }

        private void miFilmTuruTanimlama_Click(object sender, EventArgs e)
        {
            frmFilmTuruTanimlama hesap = new frmFilmTuruTanimlama();
            FormAcilacakmi(hesap);
        }

        private void miFilmSorgulama_Click(object sender, EventArgs e)
        {
            frmFilmSorgulama hesap = new frmFilmSorgulama();
            FormAcilacakmi(hesap);
        }

        private void müşteriTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriTanimlama hesap = new frmMusteriTanimlama();
            FormAcilacakmi(hesap);
        }

        private void miMusteriSorgulama_Click(object sender, EventArgs e)
        {
            frmMusteriSorgulama hesap = new frmMusteriSorgulama();
            FormAcilacakmi(hesap);
        }

        private void filmSatışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFilmSatis hesap = new frmFilmSatis();
            FormAcilacakmi(hesap);
        }

        private void miSatisSorgulama_Click(object sender, EventArgs e)
        {
            frmSatisSorgulama hesap = new frmSatisSorgulama();
            FormAcilacakmi(hesap);
        }

        private void detaylıSatışRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetayliSatisSorgulama hesap = new frmDetayliSatisSorgulama();
            FormAcilacakmi(hesap);
        }
    }
}
