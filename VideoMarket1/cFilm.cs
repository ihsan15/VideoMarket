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
    class cFilm
    {
        private int _filmNo;
        private string _filmAd;
        private int _filmTurNo;
        private string _turAd;
        private string _yonetmen;
        private string _oyuncular;
        private string _ozet;
        private decimal _fiyat;
        private int _miktar;

        #region Properties
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

        public int FilmTurNo
        {
            get
            {
                return _filmTurNo;
            }

            set
            {
                _filmTurNo = value;
            }
        }

        public string TurAd
        {
            get
            {
                return _turAd;
            }

            set
            {
                _turAd = value;
            }
        }

        public string Yonetmen
        {
            get
            {
                return _yonetmen;
            }

            set
            {
                _yonetmen = value;
            }
        }

        public string Oyuncular
        {
            get
            {
                return _oyuncular;
            }

            set
            {
                _oyuncular = value;
            }
        }

        public string Ozet
        {
            get
            {
                return _ozet;
            }

            set
            {
                _ozet = value;
            }
        }

        public decimal Fiyat
        {
            get
            {
                return _fiyat;
            }

            set
            {
                _fiyat = value;
            }
        }

        public int Miktar
        {
            get
            {
                return _miktar;
            }

            set
            {
                _miktar = value;
            }
        }
        #endregion

        SqlConnection conn = new SqlConnection(cGenel.connStr);

        public void FilmleriGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select FilmNo,FilmAd,TurAd,Yonetmen,Oyuncular,Ozet,Fiyat,Miktar,Filmler.FilmTurNo from Filmler inner join FilmTurleri on Filmler.FilmTurNo=FilmTurleri.FilmTurNo where Filmler.Varmi=1", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows) // eğer dr dolu ise çalışır boş ise çalışmaz.
            {
                int i = 0;
                while (dr.Read())
                {
                    liste.Items.Add(dr["FilmNo"].ToString());
                    liste.Items[i].SubItems.Add(dr["FilmAd"].ToString());
                    liste.Items[i].SubItems.Add(dr["TurAd"].ToString());
                    liste.Items[i].SubItems.Add(dr["Yonetmen"].ToString());
                    liste.Items[i].SubItems.Add(dr["Oyuncular"].ToString());
                    liste.Items[i].SubItems.Add(dr["Ozet"].ToString());
                    liste.Items[i].SubItems.Add(dr["Fiyat"].ToString());
                    liste.Items[i].SubItems.Add(dr["Miktar"].ToString());
                    liste.Items[i].SubItems.Add(dr["FilmTurNo"].ToString());
                    i++;
                }
                dr.Close();
            }
            conn.Close();
        }

        public bool FilmVarmi(string FilmAdi, string Yonetmen)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("select Count(*) from Filmler where Varmi=1 and FilmAd=@FilmAd and Yonetmen=@Yonetmen", conn);
            comm.Parameters.Add("@FilmAd", SqlDbType.VarChar).Value = FilmAdi;
            comm.Parameters.Add("@Yonetmen", SqlDbType.VarChar).Value = Yonetmen;
            if (conn.State == ConnectionState.Closed) conn.Open();
            int sayisi = Convert.ToInt32(comm.ExecuteScalar());
            if (sayisi>0) // eğer dr dolu ise çalışır boş ise çalışmaz.
            {
                sonuc = true;
            }
            conn.Close();
            return sonuc;
        }

        public bool FilmEkle(cFilm f)
        {
            bool sonuc=false;
            SqlCommand comm = new SqlCommand("Insert into Filmler (FilmAd , FilmTurNo,Yonetmen,Oyuncular,Ozet,Fiyat,Miktar) values (@FilmAd , @FilmTurNo,@Yonetmen,@Oyuncular,@Ozet,@Fiyat,@Miktar)", conn);
            comm.Parameters.Add("@FilmAd", SqlDbType.VarChar).Value = f._filmAd;
            comm.Parameters.Add("@FilmTurNo", SqlDbType.Int).Value = f._filmTurNo;
            comm.Parameters.Add("@Yonetmen", SqlDbType.VarChar).Value = f._yonetmen;
            comm.Parameters.Add("@Oyuncular", SqlDbType.VarChar).Value = f._oyuncular;
            comm.Parameters.Add("@Ozet", SqlDbType.VarChar).Value = f._ozet;
            comm.Parameters.Add("@Fiyat", SqlDbType.Money).Value = f._fiyat;
            comm.Parameters.Add("@Miktar", SqlDbType.Int).Value = f._miktar;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery()); // hata çıkabilecek kodu try içine alıyoruz.
            }
            catch (SqlException ex) // hata durumunda programın çalışması catch bloğuna düşecektir.
            {
                string hata = ex.Message;
            }

            finally { conn.Close(); } // hata olsun olmasın mutlaka Finally bloğu çalışır.
            return sonuc;
        }

        public bool FilmGuncelle(cFilm f)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("update Filmler set FilmAd=@FilmAd , FilmTurNo=@FilmTurNo, Yonetmen=@Yonetmen, Oyuncular=@Oyuncular, Ozet=@Ozet, Fiyat=@Fiyat,Miktar=@Miktar where FilmNo=@FilmNo", conn);
            comm.Parameters.Add("@FilmNo", SqlDbType.Int).Value = f._filmNo;
            comm.Parameters.Add("@FilmAd", SqlDbType.VarChar).Value = f._filmAd;
            comm.Parameters.Add("@FilmTurNo", SqlDbType.Int).Value = f._filmTurNo;
            comm.Parameters.Add("@Yonetmen", SqlDbType.VarChar).Value = f._yonetmen;
            comm.Parameters.Add("@Oyuncular", SqlDbType.VarChar).Value = f._oyuncular;
            comm.Parameters.Add("@Ozet", SqlDbType.VarChar).Value = f._ozet;
            comm.Parameters.Add("@Fiyat", SqlDbType.Money).Value = f._fiyat;
            comm.Parameters.Add("@Miktar", SqlDbType.Int).Value = f._miktar;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sonuc = Convert.ToBoolean(comm.ExecuteNonQuery()); // hata çıkabilecek kodu try içine alıyoruz.
            }
            catch (SqlException ex) // hata durumunda programın çalışması catch bloğuna düşecektir.
            {
                string hata = ex.Message;
            }

            finally { conn.Close(); } // hata olsun olmasın mutlaka Finally bloğu çalışır.
            return sonuc;
        }

        public bool StokGuncelleFromSatisIptal(int filmNo, int adet)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("update Filmler set Miktar=Miktar + @Adet where FilmNo=@FilmNo", conn);
            comm.Parameters.Add("@Adet", SqlDbType.Int).Value = adet;
            comm.Parameters.Add("@FilmNo", SqlDbType.Int).Value = filmNo;
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

        public bool FilmVarmi(string FilmAdi, string Yonetmen, int FilmNo)
        {
             bool sonuc = false;
            SqlCommand comm = new SqlCommand("select Count(*) from Filmler where Varmi=1 and FilmAd=@FilmAd and Yonetmen=@Yonetmen and FilmNo!=@FilmNo", conn);
            comm.Parameters.Add("@FilmAd", SqlDbType.VarChar).Value = FilmAdi;
            comm.Parameters.Add("@Yonetmen", SqlDbType.VarChar).Value = Yonetmen;
            comm.Parameters.Add("@FilmNo", SqlDbType.Int).Value = FilmNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            int sayisi = Convert.ToInt32(comm.ExecuteScalar());
            if (sayisi>0) // eğer dr dolu ise çalışır boş ise çalışmaz.
            {
                sonuc = true;
            }
            conn.Close();
            return sonuc;
        }

        public bool FilmSil(int FilmNo)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("update Filmler set Varmi=0 where FilmNo=@FilmNo", conn);
            comm.Parameters.Add("@FilmNo", SqlDbType.Int).Value = FilmNo;
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

        public void FilmleriGetirByAdaGore(ListView liste , string AramaTuru)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select FilmNo,FilmAd,TurAd,Yonetmen,Oyuncular,Ozet,Fiyat,Miktar,Filmler.FilmTurNo from Filmler inner join FilmTurleri on Filmler.FilmTurNo=FilmTurleri.FilmTurNo where Filmler.Varmi=1 and Filmler.FilmAd like @AramaTuru+'%'", conn);
            comm.Parameters.Add("@AramaTuru", SqlDbType.VarChar).Value = AramaTuru;
            conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows) // eğer dr dolu ise çalışır boş ise çalışmaz.
            {
                int i = 0;
                while (dr.Read())
                {
                    liste.Items.Add(dr["FilmNo"].ToString());
                    liste.Items[i].SubItems.Add(dr["FilmAd"].ToString());
                    liste.Items[i].SubItems.Add(dr["TurAd"].ToString());
                    liste.Items[i].SubItems.Add(dr["Yonetmen"].ToString());
                    liste.Items[i].SubItems.Add(dr["Oyuncular"].ToString());
                    liste.Items[i].SubItems.Add(dr["Ozet"].ToString());
                    liste.Items[i].SubItems.Add(dr["Fiyat"].ToString());
                    liste.Items[i].SubItems.Add(dr["Miktar"].ToString());
                    liste.Items[i].SubItems.Add(dr["FilmTurNo"].ToString());
                    i++;
                }
                dr.Close();
            }
            conn.Close();
        }

        public void FilmleriGetirByTureGore(ListView liste, string AramaTuru)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select FilmNo,FilmAd,TurAd,Yonetmen,Oyuncular,Ozet,Fiyat,Miktar,Filmler.FilmTurNo from Filmler inner join FilmTurleri on Filmler.FilmTurNo=FilmTurleri.FilmTurNo where Filmler.Varmi=1 and FilmTurleri.TurAd like @AramaTuru+'%'", conn);
            comm.Parameters.Add("@AramaTuru", SqlDbType.VarChar).Value = AramaTuru;
            conn.Open();
            try
            {
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows) // eğer dr dolu ise çalışır boş ise çalışmaz.
                {
                    int i = 0;
                    while (dr.Read())
                    {
                        liste.Items.Add(dr["FilmNo"].ToString());
                        liste.Items[i].SubItems.Add(dr["FilmAd"].ToString());
                        liste.Items[i].SubItems.Add(dr["TurAd"].ToString());
                        liste.Items[i].SubItems.Add(dr["Yonetmen"].ToString());
                        liste.Items[i].SubItems.Add(dr["Oyuncular"].ToString());
                        liste.Items[i].SubItems.Add(dr["Ozet"].ToString());
                        liste.Items[i].SubItems.Add(dr["Fiyat"].ToString());
                        liste.Items[i].SubItems.Add(dr["Miktar"].ToString());
                        liste.Items[i].SubItems.Add(dr["FilmTurNo"].ToString());
                        i++;
                    }
                    dr.Close();
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
        }

        public string IlkHarfBuyutme(string text)
        {
            int len; 
            len = text.Length;
            string a;
            a = text.Substring(0, 1); 
            return a.ToUpper() + text.Substring(1, len - 1);
        }

        public void FilmleriGetirByDetaySorgulama(string adagore, string TureGore, string Yonetmenegore, string oyuncuyagore, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select FilmNo,FilmAd,TurAd,Yonetmen,Oyuncular,Ozet,Fiyat,Miktar,Filmler.FilmTurNo from Filmler inner join FilmTurleri on Filmler.FilmTurNo=FilmTurleri.FilmTurNo where Filmler.Varmi=1 and Filmler.FilmAd like @FilmAd+'%' and FilmTurleri.TurAd like @TurAd+'%' and  Filmler.Yonetmen like '%' + @Yonetmen+'%' and Filmler.Oyuncular like '%'+@Oyuncular+'%' ", conn);
            comm.Parameters.Add("@FilmAd", SqlDbType.VarChar).Value = adagore;
            comm.Parameters.Add("@TurAd", SqlDbType.VarChar).Value = TureGore;
            comm.Parameters.Add("@Yonetmen", SqlDbType.VarChar).Value = Yonetmenegore;
            comm.Parameters.Add("@Oyuncular", SqlDbType.VarChar).Value = oyuncuyagore;
            if(conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows) // eğer dr dolu ise çalışır boş ise çalışmaz.
            {
                int i = 0;
                while (dr.Read())
                {
                    liste.Items.Add(dr["FilmNo"].ToString());
                    liste.Items[i].SubItems.Add(dr["FilmAd"].ToString());
                    liste.Items[i].SubItems.Add(dr["TurAd"].ToString());
                    liste.Items[i].SubItems.Add(dr["Yonetmen"].ToString());
                    liste.Items[i].SubItems.Add(dr["Oyuncular"].ToString());
                    liste.Items[i].SubItems.Add(dr["Ozet"].ToString());
                    liste.Items[i].SubItems.Add(dr["Fiyat"].ToString());
                    liste.Items[i].SubItems.Add(dr["Miktar"].ToString());
                    liste.Items[i].SubItems.Add(dr["FilmTurNo"].ToString());
                    i++;
                }
                dr.Close();
            }
            
            conn.Close();


        }

        public bool StokGuncelleFromSatisEkle(int filmno,int adet)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("update Filmler set Miktar=Miktar-@Miktar where FilmNo=@FilmNo", conn);
            comm.Parameters.Add("@Miktar", SqlDbType.Int).Value = adet;
            comm.Parameters.Add("@FilmNo", SqlDbType.Int).Value = filmno;
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
    }
}
