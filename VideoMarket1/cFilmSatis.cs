using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoMarket1
{
    class cFilmSatis
    {
        private int _satisNo;
        private DateTime _tarih;
        private int _musteriNo;
        private string _MusteriAd;
        private string _MusteriSoyad;
        private int _filmNo;
        private string _filmAd;
        private int _adet;
        private decimal _birimFiyat;
        private decimal _tutar;

        #region Properties
        public int SatisNo
        {
            get
            {
                return _satisNo;
            }

            set
            {
                _satisNo = value;
            }
        }

        public DateTime Tarih
        {
            get
            {
                return _tarih;
            }

            set
            {
                _tarih = value;
            }
        }

        public int MusteriNo
        {
            get
            {
                return _musteriNo;
            }

            set
            {
                _musteriNo = value;
            }
        }

        public string MusteriAd
        {
            get
            {
                return _MusteriAd;
            }

            set
            {
                _MusteriAd = value;
            }
        }

        public string MusteriSoyad
        {
            get
            {
                return _MusteriSoyad;
            }

            set
            {
                _MusteriSoyad = value;
            }
        }

        public int FilmNo
        {
            get
            {
                return _filmNo;
            }

            set
            {
                _filmNo = value;
            }
        }

        public string FilmAd
        {
            get
            {
                return _filmAd;
            }

            set
            {
                _filmAd = value;
            }
        }

        public int Adet
        {
            get
            {
                return _adet;
            }

            set
            {
                _adet = value;
            }
        }

        public decimal BirimFiyat
        {
            get
            {
                return _birimFiyat;
            }

            set
            {
                _birimFiyat = value;
            }
        }

        public decimal Tutar
        {
            get
            {
                return _tutar;
            }

            set
            {
                _tutar = value;
            }
        }
        #endregion

        SqlConnection conn = new SqlConnection(cGenel.connStr);

        public void SatislariGetir(ListView liste,TextBox TAdet,TextBox TTutar)
        {
            int ToplamAdet = 0;
            double ToplamTutar = 0;
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select SatisNo,Tarih,FilmSatis.MusteriNo,MusteriAd + ' ' + MusteriSoyad as Musteri,FilmSatis.FilmNo,FilmAd,Adet,BirimFiyat,Adet*BirimFiyat as Tutar from FilmSatis inner join Musteriler on FilmSatis.MusteriNo = Musteriler.MusteriNo inner join Filmler on FilmSatis.FilmNo=Filmler.FilmNo where FilmSatis.Silindi=0 order by Tarih desc", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if(dr.HasRows)
            {
                int i = 0;
                while(dr.Read())
                {
                    liste.Items.Add(dr["SatisNo"].ToString());
                    liste.Items[i].SubItems.Add(dr["Tarih"].ToString());
                    liste.Items[i].SubItems.Add(dr["MusteriNo"].ToString());
                    liste.Items[i].SubItems.Add(dr["Musteri"].ToString());
                    liste.Items[i].SubItems.Add(dr["FilmNo"].ToString());
                    liste.Items[i].SubItems.Add(dr["FilmAd"].ToString());
                    liste.Items[i].SubItems.Add(dr["Adet"].ToString());
                    liste.Items[i].SubItems.Add(dr["BirimFiyat"].ToString()); 
                    liste.Items[i].SubItems.Add(dr["Tutar"].ToString());
                    ToplamAdet += int.Parse(dr[6].ToString());
                    ToplamTutar += Convert.ToDouble(dr[8].ToString());
                    i++;
                }
                dr.Close();
                TAdet.Text = ToplamAdet.ToString();
                TTutar.Text = ToplamTutar.ToString();
            }
            conn.Close();
        }

        public bool SatisEkle(cFilmSatis fs)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Insert into FilmSatis (Tarih , FilmNo,MusteriNo,Adet,BirimFiyat) values (@Tarih , @FilmNo,@MusteriNo,@Adet,@BirimFiyat)", conn);
            comm.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = fs._tarih;
            comm.Parameters.Add("@FilmNo", SqlDbType.Int).Value = fs._filmNo;
            comm.Parameters.Add("@MusteriNo", SqlDbType.Int).Value = fs._musteriNo;
            comm.Parameters.Add("@Adet", SqlDbType.Int).Value = fs._adet;
            comm.Parameters.Add("@BirimFiyat", SqlDbType.Money).Value = fs._birimFiyat;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }

            return sonuc;
        }

        public bool SatisIptal(cFilmSatis fs)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("update FilmSatis set Silindi=1 where SatisNo=@SatisNo",conn);
            comm.Parameters.Add("@SatisNo", SqlDbType.Int).Value = fs._satisNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            conn.Close();
            return sonuc;
        }

        public DataTable SatislariGetirByTarihlereGore(DateTime tarih1,DateTime tarih2)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select SatisNo,Convert(Date, Tarih ,104),MusteriAd + ' ' + MusteriSoyad as Musteri,FilmAd,Adet,BirimFiyat,Adet*BirimFiyat as Tutar from FilmSatis inner join Musteriler on FilmSatis.MusteriNo = Musteriler.MusteriNo inner join Filmler on FilmSatis.FilmNo=Filmler.FilmNo where FilmSatis.Silindi=0 and Convert(Date, Tarih ,104) Between convert(Date,@tarih1,104) and convert(Date,@tarih2,104)", conn);
            da.SelectCommand.Parameters.Add("@tarih1", SqlDbType.DateTime).Value = tarih1;
            da.SelectCommand.Parameters.Add("@tarih2", SqlDbType.DateTime).Value = tarih2;
            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return dt;
        }

        public DataTable SatislariGetirByDetayliSatisSorgulama(DateTime tarih1, DateTime tarih2, string Musteri, string film, string filmturu)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select SatisNo,Convert(Date, Tarih ,104),MusteriAd + ' ' + MusteriSoyad as Musteri,FilmAd,Adet,BirimFiyat,Adet*BirimFiyat as Tutar from FilmSatis inner join Musteriler on FilmSatis.MusteriNo = Musteriler.MusteriNo inner join Filmler on FilmSatis.FilmNo=Filmler.FilmNo where FilmSatis.Silindi=0 and Convert(Date, Tarih ,104) Between convert(Date,@tarih1,104) and convert(Date,@tarih2,104)", conn);
            da.SelectCommand.Parameters.Add("@tarih1", SqlDbType.DateTime).Value = tarih1;
            da.SelectCommand.Parameters.Add("@tarih2", SqlDbType.DateTime).Value = tarih2;
            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return dt;
        }
    }
}
