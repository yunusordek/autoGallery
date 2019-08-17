using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oto_Galeri
{
    public partial class sifreOgrenForm : Form
    {
        public sifreOgrenForm()
        {
            InitializeComponent();
        }
        baglan b = new baglan();
        DataSet set = new DataSet();
        string sifre = "";
        string kullaniciAdi="";
        String ePosta = "";
        Random rastgele = new Random();
        StringBuilder sb = new StringBuilder();

        private void sifreOgrenForm_Load(object sender, EventArgs e)
        {

        }

        private void sifreOgren_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbKullaniciAdi.Text == "" || tbEposta.Text == "")
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                { sifreYola();  }
            }
            catch (Exception r)
            { MessageBox.Show(r.Message); }

            
        }

        public bool Gonder(string konu, string icerik)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("otogaleriotomasyon@gmail.com");//buraya kendi gmail hesabınız
            ePosta.To.Add(tbEposta.Text);//bura şifre unutanın maili textboxdan çekdiniz.
            ePosta.Subject = konu; //butonda veri tabanı çekdikden sonra aldımız değer konu değeri
            ePosta.Body = icerik;  // buda şifremiz
            
            SmtpClient smtp = new SmtpClient();
            
            smtp.Credentials = new System.Net.NetworkCredential("otogaleriotomasyon@gmail.com", "sifremiunuttum5");
            //kendi gmail hesabiniz var şifresi
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            object userState = ePosta;
            bool kontrol = true;
            try
            {
                smtp.SendAsync(ePosta, (object)ePosta);
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
            }
            return kontrol;

        }

        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
            this.FormClosed += SifreOgrenForm_FormClosed;
        }

        private void SifreOgrenForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Giris girisfrm = new Giris();
            girisfrm.Show();
            this.Visible = false;
        
        }

        private void tbEposta_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (tbKullaniciAdi.Text == "" || tbEposta.Text == "")
                    {
                        MessageBox.Show("Lütfen tüm alanları doldurunuz!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else { sifreYola(); this.Close(); }
                }
            }
            catch (Exception r)
            { MessageBox.Show(r.Message); }
 
        }
        void sifreYola()
        {
            SqlCommand cmd = new SqlCommand("select kullaniciAdi,eposta from kullanici ", b.con);
            b.con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                kullaniciAdi = dr["kullaniciAdi"].ToString();
                ePosta = dr["eposta"].ToString();
            }
            b.con.Close();
            if (tbKullaniciAdi.Text == kullaniciAdi && tbEposta.Text == ePosta)
            {
                b.con.Open();
                for (int i = 0; i < 8; i++)
                {
                    int ascii = rastgele.Next(65, 91);
                    char karakter = Convert.ToChar(ascii);
                    sb.Append(karakter);
                }
                sifre = sb.ToString();

                string kayit = "UPDATE kullanici set sifre=@sifre where kullaniciAdi=@kullaniciAdi";
                SqlCommand kmt = new SqlCommand(kayit, b.con);
                kmt.Parameters.AddWithValue("@sifre", sifre);
                kmt.Parameters.AddWithValue("@kullaniciAdi", tbKullaniciAdi.Text);
                kmt.ExecuteNonQuery();
                MessageBox.Show("Girmiş Oldunuz Bilgiler Uyuşuyor Şifreniz Mail adresinize yollanıyor");
                Gonder("Unutmuş Olduğunuz Şifreniz Ektedir", sifre);
            }
            else
            {
                MessageBox.Show("Lüffen Girmiş olduğunuz Bilgileri Kontrol Ediniz");
                tbKullaniciAdi.Clear();
                b.con.Close();
            }
        }
    }
 

}
