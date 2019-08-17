using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oto_Galeri
{
    public partial class MusteriBilgileriGoruntulemeFormu : Form
    {
        baglan b = new baglan();
        DataSet set = new DataSet();
        public string tc = "";
        public MusteriBilgileriGoruntulemeFormu()
        {
            InitializeComponent();
        }

        private void MusteriBilgileriGoruntulemeFormu_Load(object sender, EventArgs e)
        {
            liste();
            
        }
        public void liste()
        {       //Buradaki kod parçaları sayesinde Combobox'taki plakaya göre 
                //diğer textbox ve comboboxlara veriler doldurulmuştur.
            try
            {

                SqlCommand cmd = new SqlCommand("select * from musteri where tc='" + tc+ "'", b.con);
                b.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lblTC.Text = dr["tc"].ToString();
                    lblAdSoyad.Text = dr["adsoyad"].ToString();
                    lblCinsiyet.Text = dr["cinsiyet"].ToString();
                    lblDogumt.Text = dr["dtarihi"].ToString();
                    lblDogumY.Text = dr["dyeri"].ToString();
                    lblEhliyetN.Text = dr["ehliyetBelgeNo"].ToString();
                    lblTelefon.Text = dr["telefon"].ToString();
                    lblCept.Text = dr["ctelefon"].ToString();
                    lblAdres.Text = dr["adres"].ToString();
                    lblEmail.Text = dr["email"].ToString();

                }
          

            }
            catch (Exception r)
            { MessageBox.Show(r.Message); }
            finally { b.con.Close(); }
        }
    }
}
