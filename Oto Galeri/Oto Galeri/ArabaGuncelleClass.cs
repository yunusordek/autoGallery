using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Oto_Galeri
{
    class ArabaGuncelleClass
    {
        baglan b = new baglan();
        DataSet set = new DataSet();
        string id;
        public ArabaGuncelleClass(string _plaka, string marka, string model, string yil, string yakit, int km, string vitesTipi, string renk, string motorHacmi, string motorGucu, string hasarKaydi, string durum, int kiralamaBedeli, int fiyat, string aciklama,string _newplaka)
        {
            try
            {
                if (_plaka != _newplaka)
                {
                    SqlCommand kod = new SqlCommand("select * from araba where plaka='" + _plaka + "'", b.con);
                    b.con.Open();
                    SqlDataReader dr = kod.ExecuteReader();

                    while (dr.Read())
                    {
                        id = dr["id"].ToString();
                    }
                    b.con.Close();
                    string kyt = "update araba set plaka=@plaka, marka=@marka,model=@model,yil=@yil,yakit=@yakit,km=@km,vitestip=@vitestip, renk=@renk,motorhacmi=@motorhacmi,motorgucu=@motorgucu,hasarKaydi=@hasarKaydi,durum=@durum,kiralamaFiyat=@kiralamaFiyat,fiyat=@fiyat,aciklama=@aciklama where id=@id";
                    SqlCommand cmd = new SqlCommand(kyt, b.con);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("plaka", _newplaka);
                    cmd.Parameters.AddWithValue("marka", marka);
                    cmd.Parameters.AddWithValue("model", model);
                    cmd.Parameters.AddWithValue("yil", yil);
                    cmd.Parameters.AddWithValue("yakit", yakit);
                    cmd.Parameters.AddWithValue("km", km);
                    cmd.Parameters.AddWithValue("vitestip", vitesTipi);
                    cmd.Parameters.AddWithValue("renk", renk);
                    cmd.Parameters.AddWithValue("motorhacmi", motorHacmi);
                    cmd.Parameters.AddWithValue("motorgucu", motorGucu);
                    cmd.Parameters.AddWithValue("hasarKaydi", hasarKaydi);
                    cmd.Parameters.AddWithValue("durum", durum);
                    cmd.Parameters.AddWithValue("kiralamaFiyat", kiralamaBedeli);
                    cmd.Parameters.AddWithValue("fiyat", fiyat);
                    cmd.Parameters.AddWithValue("aciklama", aciklama);
                    b.con.Open();
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    string kayit = "update araba set plaka = @plaka, marka = @marka, model = @model, yil = @yil, yakit = @yakit, km = @km, vitestip = @vitestip, renk = @renk, motorhacmi = @motorhacmi, motorgucu = @motorgucu, hasarKaydi = @hasarKaydi, durum = @durum, kiralamaFiyat = @kiralamaFiyat, fiyat = @fiyat, aciklama = @aciklama where plaka = @plaka";
                    SqlCommand komut = new SqlCommand(kayit, b.con);
                    komut.Parameters.AddWithValue("plaka", _newplaka);
                    komut.Parameters.AddWithValue("marka", marka);
                    komut.Parameters.AddWithValue("model", model);
                    komut.Parameters.AddWithValue("yil", yil);
                    komut.Parameters.AddWithValue("yakit", yakit);
                    komut.Parameters.AddWithValue("km", km);
                    komut.Parameters.AddWithValue("vitestip", vitesTipi);
                    komut.Parameters.AddWithValue("renk", renk);
                    komut.Parameters.AddWithValue("motorhacmi", motorHacmi);
                    komut.Parameters.AddWithValue("motorgucu", motorGucu);
                    komut.Parameters.AddWithValue("hasarKaydi", hasarKaydi);
                    komut.Parameters.AddWithValue("durum", durum);
                    komut.Parameters.AddWithValue("kiralamaFiyat", kiralamaBedeli);
                    komut.Parameters.AddWithValue("fiyat", fiyat);
                    komut.Parameters.AddWithValue("aciklama", aciklama);
                    b.con.Open();
                    komut.ExecuteNonQuery();
                }

            }
            catch (Exception r)
            { System.Windows.Forms.MessageBox.Show(r.Message); }
            finally { b.con.Close(); }
        }
    }
}
