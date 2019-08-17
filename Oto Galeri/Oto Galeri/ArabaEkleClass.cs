using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using System.Threading.Tasks;


namespace Oto_Galeri
{
    class ArabaEkleClass
    {
        baglan b = new baglan();
        DataSet set = new DataSet();
        string identity;
        int deger;
        public ArabaEkleClass(string plaka,string marka,string model,string yil,string yakit,int km,string vitesTipi,string renk,string motorHacmi,string motorGucu,string hasarKaydi, int kiralamaBedeli,int fiyat ,string aciklama)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select COUNT(*) as sayi from araba", b.con);
                b.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    identity = dr["sayi"].ToString() ;
                }
                deger = int.Parse(identity);
                b.con.Close();
                if (deger==0)
                {
                    SqlCommand komuts = new SqlCommand("DBCC CHECKIDENT ('araba', RESEED, 0)", b.con);
                    b.con.Open();
                    SqlDataReader data = komuts.ExecuteReader();
                    b.con.Close();
                }
                
                SqlCommand kmt = new SqlCommand("insert into araba values('" + plaka + "','" + marka + "','" + model + "','" + yil + "','" + yakit + "','" + km + "','" + vitesTipi + "','" + renk + "','" + motorHacmi + "','" + motorGucu + "','" + hasarKaydi + "'," + kiralamaBedeli + ","+ fiyat +",'"+aciklama+"','Boşta')", b.con);
                b.con.Open();
                kmt.ExecuteNonQuery();

            }
            catch (Exception r)
            { System.Windows.Forms.MessageBox.Show(r.Message); }
            finally { b.con.Close(); }
            

        
        }
        

    }
}
