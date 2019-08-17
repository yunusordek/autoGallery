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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        bool dragging;

        Point offset;
        baglan b = new baglan();
        DataSet set = new DataSet();
        string adsoyad = "", sifre = "", kullaniciAdi = "", eposta = "", identity = "";
        TimeSpan fark;
        int say = 1,deger=0;
        int [] KalanGunSayisi;
        string[] _tcNumarasi;
        string TeslimAlinacakPlaka="";

        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Uygulamayı Kapatmak istiyor musunuz ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void arabaEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ArabaEkleForm arabaEkle = new ArabaEkleForm();
            arabaEkle.Show();
            this.Visible = false;
            arabaEkle.FormClosed += ArabaEkle_FormClosed;

        }

        private void ArabaEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
            AracTarihiKontrolu();
            bosAraclar();
            kiradakiAraclar();
        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriEkleForm musteriEkle = new MusteriEkleForm();
            musteriEkle.Show();
            this.Visible = false;
            musteriEkle.FormClosed += MusteriEkle_FormClosed;
        }

        private void MusteriEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void araçBilgisiGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArabaGuncelleForm arabaGuncelleFRM = new ArabaGuncelleForm();
            arabaGuncelleFRM.Show();
            this.Visible = false;
            arabaGuncelleFRM.FormClosed += ArabaGuncelleFRM_FormClosed;
        }

        private void ArabaGuncelleFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
            AracTarihiKontrolu();
            bosAraclar();
            kiradakiAraclar();
        }

        private void müşteriBilgisiGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriGuncelleForm mstriGuncellefrm = new MusteriGuncelleForm();
            mstriGuncellefrm.Show();
            this.Visible = false;
            mstriGuncellefrm.FormClosed += MstriGuncellefrm_FormClosed;
        }

        private void MstriGuncellefrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
            AracTarihiKontrolu();
            bosAraclar();
            kiradakiAraclar();
        }


        private void AnaForm_Load(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                SqlCommand cmd = new SqlCommand("select adiSoyadi,sifre,kullaniciAdi,eposta from kullanici ", b.con);
                b.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    adsoyad = dr["adiSoyadi"].ToString();
                    sifre = dr["sifre"].ToString();
                    kullaniciAdi= dr["kullaniciAdi"].ToString();
                    eposta= dr["eposta"].ToString();
                }
                toolStripMenuItem1.Text = adsoyad;
                b.con.Close();
                AracTarihiKontrolu();
                bosAraclar();
                kiradakiAraclar();
                
            }
            catch (Exception r)
            { MessageBox.Show(r.Message); }
         

        }
        public void bosAraclar()
        {
            try
            {
                set.Clear();
                b.con.Open();
                SqlDataAdapter adp = new SqlDataAdapter("select distinct plaka as PLAKA,marka as MARKA, model as MODEL, yil as YIL ,yakit as YAKIT ,km as KM,vitestip as 'VİTES TİPİ',renk AS RENK, motorhacmi AS 'MOTOR HACMİ',motorgucu as 'MOTOR GÜCÜ' ,hasarKaydi as 'HASAR KAYDI', kiralamaFiyat as 'KİRALAMA BEDELİ' ,fiyat as FİYAT ,durum as DURUM ,aciklama AS AÇIKLAMA  from araba where durum='Boşta'", b.con);
                adp.Fill(set, "araba");
                dGridBosArac.DataSource = set.Tables["araba"];

            }
            catch (Exception r) { MessageBox.Show(r.Message); }
            finally { b.con.Close();}
        }
        public void kiradakiAraclar()
        {
            try
            {
                DataSet ds = new DataSet();
                ds.Clear();
                b.con.Open();
                SqlDataAdapter adaptor = new SqlDataAdapter("select musteri.tc as 'TC',adsoyad as'AD SOYAD',ctelefon as'CEP TELEFONU',kiralamaTarih as 'KİRALAMA TARİHİ',teslimTarih AS 'TESLİM TARİHİ',kalanGun AS 'KALAN GÜN', KiralamaRaporu.plaka as PLAKA,marka as MARKA, model as MODEL, km as KM,hasarKaydi as 'HASAR KAYDI'  from araba INNER JOIN KiralamaRaporu on araba.plaka=KiralamaRaporu.plaka INNER JOIN musteri on musteri.tc=KiralamaRaporu.tc where durum='Kiralandı'", b.con);
                adaptor.Fill(ds, "araba");
                dGridKiradaOlanlar.DataSource = ds.Tables["araba"];

            }
            catch (Exception r) { MessageBox.Show(r.Message);}
            finally{b.con.Close();}

        }

        private void oturumuKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış Yapmak İstediğinizden Emin Misiniz", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Giris grsfrm = new Giris();
                grsfrm.Visible = true;
                this.Visible = false;
            }
        }



        private void btnSifreDegis_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbEskiSifre.Text == sifre)
                {
                   
                    if (tbYeniSifre.Text == tbYeniSifre2.Text)
                    {
                        string kayit = "UPDATE kullanici set sifre=@sifre where kullaniciAdi=@kullaniciAdi";
                        SqlCommand komut = new SqlCommand(kayit, b.con);
                        b.con.Open();
                        komut.Parameters.AddWithValue("@sifre", tbYeniSifre.Text);
                        komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                        komut.ExecuteNonQuery();
                        b.con.Close();
                        MessageBox.Show("ŞİFRENİZ BAŞARIYLA GÜNCELLEMİŞTİR");
                        SqlCommand cmd = new SqlCommand("select sifre from kullanici ", b.con);
                        b.con.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            sifre = dr["sifre"].ToString();
                        }
                        b.con.Close();
                        tbEskiSifre.Clear();tbYeniSifre.Clear();tbYeniSifre2.Clear();
                        sifreDegistirPanel.Visible = false;
                    }
                    else { MessageBox.Show("LÜTFEN GİRDİĞİNİZ ŞİFRELERİN AYNI OLDUĞUNDAN EMİN OLUNUZ", "", MessageBoxButtons.OK, MessageBoxIcon.Hand); }
                }
                else MessageBox.Show("Girdiğiniz Şifre Eski Şifrenizle Uyuşmamaktadır.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            catch (Exception r)
            { MessageBox.Show(r.Message); }
            
            
        }

        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sifreDegistirPanel.Visible = true;
            kullaniciAdiPanel.Visible = false;
            epostaPanel.Visible = false;
            acilisPanel.Visible = false;
        }

        private void btnKullaniciAdi_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (MessageBox.Show("Kullanıcı adınızı değiştirmek istiyor musunuz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (tbEskiKullanici.Text != null)
                    {
                        string kayit = "UPDATE kullanici set kullaniciAdi=@kullaniciAdi where eposta=@eposta";
                        SqlCommand komut = new SqlCommand(kayit, b.con);
                        b.con.Open();
                        komut.Parameters.AddWithValue("@kullaniciAdi", tbYeniKullanici.Text);
                        komut.Parameters.AddWithValue("@eposta", eposta);
                        komut.ExecuteNonQuery();
                        b.con.Close();
                        MessageBox.Show("KULLANICI ADINIZ BAŞARIYLA GÜNCELLEMİŞTİR");
                        SqlCommand cmd = new SqlCommand("select kullaniciAdi from kullanici ", b.con);
                        b.con.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            kullaniciAdi = dr["kullaniciAdi"].ToString();
                        }
                        b.con.Close();
                        tbEskiKullanici.Clear(); tbYeniKullanici.Clear();
                        
                    }
                }
                
            }
            catch (Exception r)
            { MessageBox.Show(r.Message); }
        }

        private void kullanıcıAdıGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kullaniciAdiPanel.Visible = true;
            sifreDegistirPanel.Visible = false;
            epostaPanel.Visible = false;
            acilisPanel.Visible = false;
        }



        private void ePostaGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kullaniciAdiPanel.Visible = false;
            sifreDegistirPanel.Visible = false;
            epostaPanel.Visible = true;
            acilisPanel.Visible = false;
        }

        private void btneposta_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Eposta adresinizi değiştirmek istiyor musunuz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (tbEskiEposta.Text != null)
                    {
                        
                        string kayit = "UPDATE kullanici set eposta=@eposta where kullaniciAdi=@kullaniciAdi";
                        SqlCommand komut = new SqlCommand(kayit, b.con);
                        b.con.Open();
                        komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                        komut.Parameters.AddWithValue("@eposta", tbYenieposta.Text);
                        komut.ExecuteNonQuery();
                        b.con.Close();
                        MessageBox.Show("E-POSTA ADRESİNİZ BAŞARIYLA GÜNCELLEMİŞTİR");
                        SqlCommand cmd = new SqlCommand("select eposta from kullanici ", b.con);
                        b.con.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            kullaniciAdi = dr["eposta"].ToString();
                        }
                        b.con.Close();
                        tbEskiEposta.Clear(); tbYenieposta.Clear();

                    }
                }

            }
            catch (Exception r)
            { MessageBox.Show(r.Message); }
        }

        private void kiralamaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KiralamaForm kiralamaFrm = new KiralamaForm();
            kiralamaFrm.Show();
            kiralamaFrm.dataGridView1.Visible = true;
            kiralamaFrm.btnKirala.Visible = true;
            kiralamaFrm.dataGridKiralik.Visible = false;
            kiralamaFrm.btnGuncelle.Visible = false;
            kiralamaFrm.listele();
            this.Visible = false;
            kiralamaFrm.FormClosed += KiralamaFrm_FormClosed;
        }

        private void KiralamaFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            AracTarihiKontrolu();
            bosAraclar();
            kiradakiAraclar();

        }

        private void satışİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SatisForm satisFrm = new SatisForm();
            satisFrm.Show();
            this.Visible = false;
            satisFrm.FormClosed += SatisFrm_FormClosed;
        }

        private void SatisFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            AracTarihiKontrolu();
            bosAraclar();
            kiradakiAraclar();
        }

        private void btnEPanelGizle_Click(object sender, EventArgs e)
        {
            epostaPanel.Visible = false;
            acilisPanel.Visible = true;
        }

        private void btnKApnelGizle_Click(object sender, EventArgs e)
        {
            kullaniciAdiPanel.Visible = false;
            acilisPanel.Visible = true;
        }

        private void btnSifrePanlGizle_Click(object sender, EventArgs e)
        {
            sifreDegistirPanel.Visible = false;
            acilisPanel.Visible = true;
        }



        private void kiralıkDurumGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KiralamaForm kiralikGuncellefrm = new KiralamaForm();
            kiralikGuncellefrm.Show();
            kiralikGuncellefrm.dataGridView1.Visible = false;
            kiralikGuncellefrm.btnKirala.Visible = false;
            kiralikGuncellefrm.dataGridKiralik.Visible = true;
            kiralikGuncellefrm.btnGuncelle.Visible = true;
            kiralikGuncellefrm.kiralikBilgisiCek();
            this.Visible = false;
            kiralikGuncellefrm.FormClosed += KiralikGuncellefrm_FormClosed;

        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            MusteriBilgileriGoruntulemeFormu mst = new MusteriBilgileriGoruntulemeFormu();
            mst.tc = tbMusteriTC.Text;
            mst.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (listBox1.SelectedIndex == i)
                    {
                        tbMusteriTC.Text = _tcNumarasi[i];
                    }
                }
            }
            catch (Exception r)
            {

                MessageBox.Show(r.Message);
                

            }
            

        }

        private void raporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rapor raporfrm = new Rapor();
            raporfrm.Show();
            this.Visible = false;
            raporfrm.FormClosed += Raporfrm_FormClosed;
        }

        private void Raporfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void btnAracTeslimAl_Click(object sender, EventArgs e)
        {   string durum = "Boşta";
            if (TeslimAlinacakPlaka!="")
            {
                if (MessageBox.Show(TeslimAlinacakPlaka + "'Plakalı Aracı Teslim Almayı Onaylıyor Musunuz ? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string kyt = "update araba set durum=@durum where plaka=@plaka";
                    SqlCommand kmd = new SqlCommand(kyt, b.con);
                    b.con.Open();
                    kmd.Parameters.AddWithValue("durum", durum);
                    kmd.Parameters.AddWithValue("plaka", TeslimAlinacakPlaka);
                    kmd.ExecuteNonQuery();
                    b.con.Close();
                  
                }
            }
            else if (TeslimAlinacakPlaka =="")
            {
                MessageBox.Show("Lütfen önce kiradaki araçlar listesinden teslim alınacak aracı seçiniz !");
            }

        }

        private void dGridKiradaOlanlar_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                TeslimAlinacakPlaka =dGridKiradaOlanlar.CurrentRow.Cells[6].Value.ToString();

                
            }
            catch (Exception r)
            { MessageBox.Show(r.Message); }
        }

        private void acilisPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void KiralikGuncellefrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
            AracTarihiKontrolu();
            bosAraclar();
            kiradakiAraclar();
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            offset = e.Location;
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new
                Point(currentScreenPos.X - offset.X,
                currentScreenPos.Y - offset.Y);
            }
        }

        private void menuStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        void AracTarihiKontrolu()
        {

            try
            {
                
                int id = 0, kalangun = 0;
                string TeslimTar = "", tc = "", kontrolPlaka = "";
                SqlCommand cmd = new SqlCommand("select COUNT(*) as sayi from KiralamaRaporu", b.con);
                b.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    identity = dr["sayi"].ToString();
                }
                deger = int.Parse(identity);
                b.con.Close();

                KalanGunSayisi = new int[deger];
                _tcNumarasi = new string[deger];
                listBox1.Items.Clear();
                if (deger > 0)
                {

                    for (int i = 0; i < deger; i++)
                    {
                        
                        SqlCommand komut = new SqlCommand("select id,plaka,kalanGun,tc,teslimTarih from KiralamaRaporu where id='"+i+"'", b.con);
                        b.con.Open();
                        SqlDataReader data = komut.ExecuteReader();
                        while (data.Read())
                        {
                            id = int.Parse(data["id"].ToString());
                            kontrolPlaka = data["plaka"].ToString();
                            kalangun = int.Parse(data["kalanGun"].ToString());
                            tc = data["tc"].ToString();
                            TeslimTar = data["teslimTarih"].ToString();

                        }
                        KalanGunSayisi[i] = kalangun;
                        _tcNumarasi[i] = tc;
                        
                        


                        b.con.Close();

                        DateTime kiralamaTarih = Convert.ToDateTime(dtBugun.Text);
                        DateTime teslimTarih = Convert.ToDateTime(TeslimTar);
                        fark = teslimTarih - kiralamaTarih;
                        say = Convert.ToInt32(fark.TotalDays);
                        
                        if (say == 1)
                        {
                            listBox1.Items.Add(tc + " TC Kimlik Numaralı Müşterinin Kiralamış \n olduğu =" + kontrolPlaka + "'lı aracın Teslim Tarihine 1 gün Kalmıştır");
                            
                        }


                        if (say != KalanGunSayisi[i])
                        {
                            string kayit = "update KiralamaRaporu set kalanGun=@kalanGun where id=@id ";
                            SqlCommand komt = new SqlCommand(kayit, b.con);
                            komt.Parameters.AddWithValue("@kalanGun", say);
                            komt.Parameters.AddWithValue("@id", id);
                            b.con.Open();
                            komt.ExecuteNonQuery();
                            b.con.Close();
                        }

                    }
                }

            }
            catch (Exception r)
            {

                MessageBox.Show(r.Message);
            }
        }

    }
}
