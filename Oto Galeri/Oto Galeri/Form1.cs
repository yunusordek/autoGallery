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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        baglan b = new baglan();
        DataSet set = new DataSet();
        string kullaniciAdi = "";
        string sifre = "";
        string eposta = "";

        private void Giris_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select kullaniciAdi,eposta,sifre from kullanici ", b.con);
                b.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    kullaniciAdi = dr["kullaniciAdi"].ToString();
                    eposta= dr["eposta"].ToString();
                    sifre = dr["sifre"].ToString();
                }
                if (kullaniciAdi == "" && eposta=="" &&sifre == "")
                {
                    this.Visible = false;
                    MessageBox.Show("Hoşgeldiniz!! \nBilgilerinizi Oluşturup Sisteme Girebilirsiniz", "KULLANICI BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KayitFormu kayitForm = new KayitFormu();
                    kayitForm.Show();
                    this.Visible = false;
                    kayitForm.FormClosed += KayitForm_FormClosed;
                    

                }
               

            }
            catch (Exception r)
            { MessageBox.Show(r.Message); }
            finally { b.con.Close(); }
        }

        private void KayitForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void sifreUnuttumLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sifreOgrenForm sfreOgrnfrm = new sifreOgrenForm();
            sfreOgrnfrm.Show();
            this.Visible = false;
            sfreOgrnfrm.FormClosed += SfreOgrnfrm_FormClosed; 
        }

        private void SfreOgrnfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;

        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbKullaniciAdi.Text == "" || tbPassword.Text == "")
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else { girisYap(); }
            }
        }
        void girisYap()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select kullaniciAdi,sifre from kullanici ", b.con);
                b.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    kullaniciAdi = dr["kullaniciAdi"].ToString(); 
                    sifre = dr["sifre"].ToString();
                }
                if (tbKullaniciAdi.Text == kullaniciAdi && tbPassword.Text == sifre)
                {
                   AnaForm frm = new AnaForm();
                   frm.Show();
                   this.Visible = false;
                   
                }
                else if(tbKullaniciAdi.Text != kullaniciAdi || tbPassword.Text != sifre)
               {
                    MessageBox.Show("Kullanıcı adı ve şifre uyuşmamaktadır!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
               }
            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message);
            }
            finally { b.con.Close(); }
        }
        

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbKullaniciAdi.Text=="" || tbPassword.Text=="" )
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {girisYap(); }
            }
            catch (Exception r)
            {MessageBox.Show(r.Message);}
            
        }

        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Uygulamayı Kapatmak istiyor musunuz ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }




    }
}
