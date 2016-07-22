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
    public partial class frmSatisSorgulama : Form
    {
        public frmSatisSorgulama()
        {
            InitializeComponent();
        }



        private void frmSatisSorgulama_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
        }
        DataTable dt = new DataTable();
        private void btnGetir_Click(object sender, EventArgs e)
        {
            int TAdet = 0;
            int TTutar = 0;
            cFilmSatis fs = new cFilmSatis();
            dt = fs.SatislariGetirByTarihlereGore(dtpTarih1.Value, dtpTarih2.Value);
            dgvDetayliSatis.DataSource = dt;

            dgvDetayliSatis.Columns[0].Visible = false;
            dgvDetayliSatis.Columns["Adet"].Width = 45;
            dgvDetayliSatis.Columns["Adet"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetayliSatis.Columns["BirimFiyat"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetayliSatis.Columns["Tutar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //foreach (DataRow dr in dt.Rows)
            //{
            //    TAdet += Convert.ToInt32(dr["Adet"]);
            //    TTutar += Convert.ToInt32(dr["Tutar"]);
            //}

            for (int i = 0; i < dgvDetayliSatis.Rows.Count; i++)
            {
                TAdet += Convert.ToInt32(dgvDetayliSatis.Rows[i].Cells["Adet"].Value);
                TTutar += Convert.ToInt32(dgvDetayliSatis.Rows[i].Cells["Tutar"].Value);
            }   

            txtToplamAdet.Text = TAdet.ToString();
            txtToplamTutar.Text = TTutar.ToString();
        }
    }
}
