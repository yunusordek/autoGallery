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
    public partial class KiralamaForm : Form
    {
        baglan b = new baglan();
        DataSet set = new DataSet();
        int KiralamaFiyat = 0;
        int say = 1;
        TimeSpan fark;
        string identity;
        int deger;
        public KiralamaForm()
        {
            InitializeComponent();
        }

        private void KiralamaForm_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.DarkBlue;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
            tcCek();
        }
        public void listele()
        {
            try
            {
                set.Clear();
                b.con.Open();
                SqlDataAdapter adp = new SqlDataAdapter("select distinct plaka as PLAKA,marka as MARKA, model as MODEL, yil as YIL ,yakit as YAKIT ,km as KM,vitestip as 'VİTES TİPİ',renk AS RENK, motorhacmi AS 'MOTOR HACMİ',motorgucu as 'MOTOR GÜCÜ' ,hasarKaydi as 'HASAR KAYDI', kiralamaFiyat as 'KİRALAMA BEDELİ' ,fiyat as FİYAT ,durum as DURUM ,aciklama AS AÇIKLAMA  from araba where durum='Boşta'", b.con);
                adp.Fill(set, "araba");
                dataGridView1.DataSource = set.Tables["araba"];

            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message);
            }
            finally
            {
                b.con.Close();
            }

        }
         public void kiralikBilgisiCek()
        {
            try
            {
                set.Clear();
                b.con.Open();
                SqlDataAdapter adp = new SqlDataAdapter("select distinct plaka as PLAKA,tc as TC, kiralamaTarih as 'KİRALAMA TARİHİ', teslimTarih as 'TESLİM TARİHİ' ,kiralamaFiyat as 'KİRALANAN FİYAT' ,kalanGun as 'KAÇ GÜN KALDI' from KiralamaRaporu", b.con);
                adp.Fill(set, "KiralamaRaporu");
                dataGridKiralik.DataSource = set.Tables["KiralamaRaporu"];
                b.con.Close();
            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message);
            }
            finally
            {
                b.con.Close();
            }
        }
        void tcCek()
        {
            try
            {
                cbTC.Items.Clear();
                SqlCommand cmd = new SqlCommand("select tc from musteri", b.con);
                b.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                { cbTC.Items.Add(dr["tc"]); }
                b.con.Close();

            }
            catch (Exception r)
            { MessageBox.Show(r.Message); }
            finally { b.con.Close(); }

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                tbPlaka.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                KiralamaFiyat = Convert.ToInt32(dataGridView1.CurrentRow.Cells[11].Value);
                tbFiyat.Text = KiralamaFiyat.ToString();
                SqlCommand cmd = new SqlCommand("select kiralamaFiyat from araba where plaka=@plaka", b.con);
                b.con.Open();
                cmd.Parameters.AddWithValue("plaka", tbPlaka.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                string a = "";
                while (dr.Read())
                {
                    a = dr["kiralamaFiyat"].ToString();
                }
                KiralamaFiyat = int.Parse(a);
                b.con.Close();
            }
            catch (Exception r)
            { MessageBox.Show(r.Message); }
            
        }

        private void dtTeslimTarih_ValueChanged(object sender, EventArgs e)
        {
            
            DateTime kiralamaTarih = Convert.ToDateTime(dtKiralamaTarih.Text);
            DateTime teslimTarih = Convert.ToDateTime(dtTeslimTarih.Text);
            fark = teslimTarih - kiralamaTarih;
            say =Convert.ToInt32(fark.TotalDays);
            fiyatcek();
            if (say==0)
            { tbFiyat.Text =KiralamaFiyat.ToString();  }
            else if (say>0)
            { tbFiyat.Text = (KiralamaFiyat * say).ToString(); }
            else { tbFiyat.Text = "0"; }            
        }
        
        private void btnKirala_Click(object sender, EventArgs e)
        {
            
            string durum = "Kiralandı";
            try
            {
                SqlCommand cmd = new SqlCommand("select COUNT(*) as sayi from KiralamaRaporu", b.con);
                b.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    identity = dr["sayi"].ToString();
                }
                deger = int.Parse(identity);
                b.con.Close();
                if (deger == 0)
                {
                    SqlCommand komuts = new SqlCommand("DBCC CHECKIDENT ('KiralamaRaporu', RESEED, 0)", b.con);
                    b.con.Open();
                    SqlDataReader data = komuts.ExecuteReader();
                    b.con.Close();
                }

                SqlCommand komut = new SqlCommand("insert into KiralamaRaporu values('" + tbPlaka.Text + "','"+cbTC.Text+"','"+dtKiralamaTarih.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','"+ dtTeslimTarih.Value.ToString("yyyy-MM-dd HH:mm:ss") + "',"+tbFiyat.Text+","+(say-2)+")", b.con);
                b.con.Open();
                komut.ExecuteNonQuery();
                string kyt = "update araba set durum=@durum where plaka=@plaka";
                SqlCommand kmd = new SqlCommand(kyt, b.con);
                kmd.Parameters.AddWithValue("durum",durum );
                kmd.Parameters.AddWithValue("plaka", tbPlaka.Text);
                kmd.ExecuteNonQuery();
                b.con.Close();
                listele();
                

            }
            catch (Exception r)
            {

                MessageBox.Show(r.Message);
            }
        }

        private void btnMusteriBilgisi_Click(object sender, EventArgs e)
        {
            MusteriBilgileriGoruntulemeFormu mbf = new MusteriBilgileriGoruntulemeFormu();
            mbf.tc = cbTC.Text;
            mbf.Show();
            this.Visible = false;
            mbf.FormClosed += Mbf_FormClosed;
        }

        private void Mbf_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void cbTC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTC.Text!="")
            {
                btnMusteriBilgisi.Visible = true;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                string kayit = "update KiralamaRaporu set plaka=@plaka,tc=@tc,kiralamaTarih=@kiralamaTarih,teslimTarih=@teslimTarih,kiralamaFiyat=@kiralamaFiyat,kalanGun=@kalanGun where plaka=@plaka and tc=@tc and kiralamaTarih=@kiralamaTarih";
                SqlCommand komut = new SqlCommand(kayit, b.con);
                komut.Parameters.AddWithValue("@plaka", tbPlaka.Text);
                komut.Parameters.AddWithValue("@tc", cbTC.Text);
                komut.Parameters.AddWithValue("@kiralamaTarih", dtKiralamaTarih.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                komut.Parameters.AddWithValue("@teslimTarih", dtTeslimTarih.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                komut.Parameters.AddWithValue("@kiralamaFiyat", Convert.ToInt32(tbFiyat.Text));
                komut.Parameters.AddWithValue("@kalanGun", say);
                b.con.Open();
                komut.ExecuteNonQuery();
                b.con.Close();
                kiralikBilgisiCek();
                
            }
            catch (Exception r)
            {

                MessageBox.Show(r.Message);
            }
            finally { b.con.Close(); }
            
        }

        private void dataGridKiralik_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                tbPlaka.Text = dataGridKiralik.CurrentRow.Cells[0].Value.ToString();
                dtKiralamaTarih.Value = Convert.ToDateTime(dataGridKiralik.CurrentRow.Cells[2].Value);
                dtTeslimTarih.Value = Convert.ToDateTime(dataGridKiralik.CurrentRow.Cells[3].Value);
                b.con.Close();

            }
            catch (Exception r)
            { MessageBox.Show(r.Message); }
        }
        public void fiyatcek()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select kiralamaFiyat from araba where plaka=@plaka", b.con);
                b.con.Open();
                cmd.Parameters.AddWithValue("plaka", tbPlaka.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                string a = "";
                while (dr.Read())
                {
                    a = dr["kiralamaFiyat"].ToString();
                }
                KiralamaFiyat = int.Parse(a);
                b.con.Close();
            }
            catch (Exception r)
            {

                MessageBox.Show(r.Message);
            }
            
        }
    }
}
