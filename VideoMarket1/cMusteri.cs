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
    class cMusteri
    {
        private int _musteriNo;
        private string _ad;
        private string _soyad;
        private string _telefon;
        private string _adres;

        #region Properties
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

        public string Ad
        {
            get
            {
                return _ad;
            }

            set
            {
                _ad = value;
            }
        }

        public string Soyad
        {
            get
            {
                return _soyad;
            }

            set
            {
                _soyad = value;
            }
        }

        public string Telefon
        {
            get
            {
                return _telefon;
            }

            set
            {
                _telefon = value;
            }
        }

        public string Adres
        {
            get
            {
                return _adres;
            }

            set
            {
                _adres = value;
            }
        }

        
        #endregion

        SqlConnection conn = new SqlConnection(cGenel.connStr);

        public void MusterileriGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select MusteriNo , MusteriAd ,MusteriSoyad, Telefon ,Adres from Musteriler where Silindi = 0", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if(dr.HasRows)
            {
                int i = 0;
                while(dr.Read())
                {
                    liste.Items.Add(dr["MusteriNo"].ToString());
                    liste.Items[i].SubItems.Add(dr["MusteriAd"].ToString());
                    liste.Items[i].SubItems.Add(dr["MusteriSoyad"].ToString());
                    liste.Items[i].SubItems.Add(dr["Telefon"].ToString());
                    liste.Items[i].SubItems.Add(dr["Adres"].ToString());
                    i++;
                }
                dr.Close();
            }
            conn.Close();
        }

        public bool MusteriEkle(cMusteri m)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("Insert into Musteriler (MusteriAd , MusteriSoyad,Telefon,Adres) values (@MusteriAd , @MusteriSoyad,@Telefon,@Adres)", conn);
            comm.Parameters.Add("@MusteriAd", SqlDbType.VarChar).Value = m._ad;
            comm.Parameters.Add("@MusteriSoyad", SqlDbType.VarChar).Value = m._soyad;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = m._telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = m._adres;
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

        public void MusterileriGetirByAdaGore(string AramaTuru, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select MusteriNo , MusteriAd ,MusteriSoyad, Telefon ,Adres from Musteriler where Silindi = 0 and MusteriAd like @AramaTuru + '%'", conn);
            comm.Parameters.Add("@AramaTuru", SqlDbType.VarChar).Value = AramaTuru;
            conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows) // eğer dr dolu ise çalışır boş ise çalışmaz.
            {
                int i = 0;
                while (dr.Read())
                {
                    liste.Items.Add(dr["MusteriNo"].ToString());
                    liste.Items[i].SubItems.Add(dr["MusteriAd"].ToString());
                    liste.Items[i].SubItems.Add(dr["MusteriSoyad"].ToString());
                    liste.Items[i].SubItems.Add(dr["Telefon"].ToString());
                    liste.Items[i].SubItems.Add(dr["Adres"].ToString());
                    i++;
                }
                dr.Close();
            }
            conn.Close();
        }

        public bool MusteriGuncelle(cMusteri m)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("update Musteriler set MusteriAd=@Ad , MusteriSoyad=@Soyad, Telefon=@Tel, Adres=@Adres where MusteriNo=@MusteriNo", conn);
            comm.Parameters.Add("@MusteriNo", SqlDbType.Int).Value = m._musteriNo;
            comm.Parameters.Add("@Ad", SqlDbType.VarChar).Value = m._ad;
            comm.Parameters.Add("@Soyad", SqlDbType.VarChar).Value = m._soyad;
            comm.Parameters.Add("@Tel", SqlDbType.VarChar).Value = m._telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = m._adres;
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

        public bool MusteriSil(int MusteriNo)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("update Musteriler set Silindi=1 where MusteriNo=@MusteriNo", conn);
            comm.Parameters.Add("@MusteriNo", SqlDbType.Int).Value = MusteriNo;
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

        public bool MusteriVarmi(string Ad, string Soyad, string Telefon)
        {
            bool sonuc = false;
            SqlCommand comm = new SqlCommand("select Count(*) from Musteriler where Silindi=0 and MusteriAd=@Ad and MusteriSoyad=@Soyad and Telefon=@Tel", conn);
            comm.Parameters.Add("@Ad", SqlDbType.VarChar).Value = Ad;
            comm.Parameters.Add("@Soyad", SqlDbType.VarChar).Value = Soyad;
            comm.Parameters.Add("@Tel", SqlDbType.VarChar).Value = Telefon;
            if (conn.State == ConnectionState.Closed) conn.Open();
            int sayisi = Convert.ToInt32(comm.ExecuteScalar());
            if (sayisi > 0) // eğer dr dolu ise çalışır boş ise çalışmaz.
            {
                sonuc = true;
            }
            conn.Close();
            return sonuc;
        }

        public void MusterileriGetirByDetaySorgulama(string Ad, string Soyad, string Telefon, string Adres, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select MusteriNo , MusteriAd ,MusteriSoyad, Telefon ,Adres from Musteriler where Silindi=0 and MusteriAd like @Ad+'%' and MusteriSoyad like @Soyad+'%' and Telefon like  @Telefon+'%' and Adres like '%'+@Adres+'%' ", conn);
            comm.Parameters.Add("@Ad", SqlDbType.VarChar).Value = Ad;
            comm.Parameters.Add("@Soyad", SqlDbType.VarChar).Value = Soyad;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = Telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = Adres;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows) // eğer dr dolu ise çalışır boş ise çalışmaz.
            {
                int i = 0;
                while (dr.Read())
                {
                    liste.Items.Add(dr["MusteriNo"].ToString());
                    liste.Items[i].SubItems.Add(dr["MusteriAd"].ToString());
                    liste.Items[i].SubItems.Add(dr["MusteriSoyad"].ToString());
                    liste.Items[i].SubItems.Add(dr["Telefon"].ToString());
                    liste.Items[i].SubItems.Add(dr["Adres"].ToString());
                    i++;
                }
                dr.Close();
            }

            conn.Close();
        }
    }
}
