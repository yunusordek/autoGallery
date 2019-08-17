using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Oto_Galeri
{
    class MusteriGuncelleClass
    {
        baglan b = new baglan();
        DataSet set = new DataSet();
        public string mesaj = "";
        public MusteriGuncelleClass(string _tc, string _adsoyad, string _cinsiyet, string _dtarihi, string _dyeri ,string eBelgeNo, string _telefon, string _ctelefon, string _adres, string _email)
        {

            try
            {

                kontrol(_tc);
                if (mesaj == "True")
                {
                    try
                    {
                        string kayit = "update musteri set tc=@tc,adsoyad=@adsoyad,cinsiyet=@cinsiyet,dtarihi=@dtarihi,dyeri=@dyeri,ehliyetBelgeNo=@ehliyetBelgeNo,telefon=@telefon,ctelefon=@ctelefon,adres=@adres,email=@email where tc=@tc";
                        SqlCommand komut = new SqlCommand(kayit, b.con);
                        komut.Parameters.AddWithValue("@tc", _tc);
                        komut.Parameters.AddWithValue("@adsoyad", _adsoyad);
                        komut.Parameters.AddWithValue("@cinsiyet", _cinsiyet);
                        komut.Parameters.AddWithValue("@dtarihi", _dtarihi);
                        komut.Parameters.AddWithValue("@dyeri", _dyeri);
                        komut.Parameters.AddWithValue("@ehliyetBelgeNo", eBelgeNo);
                        komut.Parameters.AddWithValue("@telefon", _telefon);
                        komut.Parameters.AddWithValue("@ctelefon", _ctelefon);
                        komut.Parameters.AddWithValue("@adres", _adres);
                        komut.Parameters.AddWithValue("@email", _email);
                        b.con.Open();
                        komut.ExecuteNonQuery();
                    }
                    catch (Exception r)
                    { System.Windows.Forms.MessageBox.Show(r.Message); }
                    finally { b.con.Close(); }


                }
            }
            catch (Exception r)
            { System.Windows.Forms.MessageBox.Show(r.Message); }
            


        }
        public void kontrol(string _tc)
        {
            int toplam = 0;
            for (int i = 0; i < _tc.Length - 1; i++)
            {
                toplam += int.Parse(_tc.Substring(i, 1));
            }
            if (toplam % 10 != int.Parse(_tc.Substring(10, 1)))
                mesaj = "Yanlıç Tc Numarası";
            else
                mesaj = "True";
        }
    }
}
