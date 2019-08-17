using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Oto_Galeri
{
    class MusteriEkleClass
    {
        baglan b = new baglan();
        DataSet set = new DataSet();

        public string mesaj="False";
        public MusteriEkleClass(string _tc, string _adsoyad, string _cinsiyet, string _dtarihi, string _dyeri,string eBelgeNo ,string _telefon, string _ctelefon, string _adres, string _email)
        {
            try
            {
                kontroltc(_tc);
                if (mesaj == "True")
                {
                    SqlCommand komut = new SqlCommand("insert into musteri values('" + _tc + "','" + _adsoyad + "','" + _cinsiyet + "',+'" + _dtarihi + "','" + _dyeri + "','"+eBelgeNo+"','" + _telefon + "','" + _ctelefon + "','" + _adres + "','" + _email + "')", b.con);
                    b.con.Open();
                    komut.ExecuteNonQuery();
                    b.con.Close();
                }
                else
                    System.Windows.Forms.MessageBox.Show("Yanlış TC numarası");

            }
            catch (Exception r)
            {
                System.Windows.Forms.MessageBox.Show(r.Message);
         
            }

        }
        public void kontroltc(string _tc)
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
