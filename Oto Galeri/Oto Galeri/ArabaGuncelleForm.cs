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
    public partial class ArabaGuncelleForm : Form
    {
        baglan b = new baglan();
        DataSet set = new DataSet();
        string oldPlaka = "";
        public string Newplaka = "";
        string kayit;
        public ArabaGuncelleForm()
        {
            InitializeComponent();
        }

        private void ArabaGuncelleForm_Load(object sender, EventArgs e)
        { 
            plakaCek();

        }
        public void liste()
        {       //Buradaki kod parçaları sayesinde Combobox'taki plakaya göre 
                //diğer textbox ve comboboxlara veriler doldurulmuştur.
            try
            {
                
                SqlCommand cmd = new SqlCommand("select * from araba where plaka='" + cbPlaka.Text + "'", b.con);
                b.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    tbMarka.Text = dr["marka"].ToString();
                    tbModel.Text = dr["model"].ToString();
                    tbYil.Text = dr["yil"].ToString();
                    cbYakit.Text = dr["yakit"].ToString();
                    tbKm.Text = dr["km"].ToString();
                    cbVitesTipi.Text = dr["vitestip"].ToString();
                    tbRenk.Text = dr["renk"].ToString();
                    tbMotorhacmi.Text = dr["motorhacmi"].ToString();
                    tbMotorgucu.Text = dr["motorgucu"].ToString();
                    tbHasarKaydi.Text = dr["hasarKaydi"].ToString();
                    cbDurum.Text = dr["durum"].ToString();
                    tbKiralamaBedeli.Text = dr["kiralamaFiyat"].ToString();
                    tbFiyat.Text = dr["fiyat"].ToString();
                    tbAciklama.Text = dr["aciklama"].ToString();
                }
                oldPlaka = cbPlaka.Text;
                
            }
            catch (Exception r)
            { MessageBox.Show(r.Message); }
            finally { b.con.Close(); }
        }

        private void cbPlaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            liste();
        }
        void temizle()
        {
            try
            {
                cbPlaka.Text = ""; tbMarka.Clear(); tbModel.Clear(); tbYil.Clear();
                cbYakit.Text = ""; tbKm.Clear(); cbVitesTipi.Text = ""; tbRenk.Clear();
                tbMotorhacmi.Clear(); tbMotorgucu.Clear(); tbKiralamaBedeli.Clear(); tbFiyat.Clear(); cbDurum.Text = ""; tbAciklama.Text = ""; tbHasarKaydi.Text = "";
            }
            catch (Exception r)
            { MessageBox.Show(r.Message); }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Newplaka = cbPlaka.Text;
            try
            {

                if (cbPlaka.Text == "" || tbMarka.Text == "" || tbModel.Text == "" || tbYil.Text == "" || cbYakit.Text == "" || tbKm.Text == "" || cbVitesTipi.Text == "" || tbRenk.Text == "" || tbMotorhacmi.Text == "" || tbMotorgucu.Text == "" || tbHasarKaydi.Text == "" || cbDurum.Text == "" || tbKiralamaBedeli.Text == "" || tbFiyat.Text == "" || tbAciklama.Text == "")
                {
                    MessageBox.Show("Lütfen tüm alanların dolu olduğuna emin olun!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (MessageBox.Show(oldPlaka + " Plakalı Araç bilgilerini Güncellemek İstediğinizden Emin Misiniz?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {

                        ArabaGuncelleClass arc = new ArabaGuncelleClass(oldPlaka,  tbMarka.Text, tbModel.Text, tbYil.Text, cbYakit.Text, int.Parse(tbKm.Text), cbVitesTipi.Text, tbRenk.Text, tbMotorhacmi.Text, tbMotorgucu.Text, tbHasarKaydi.Text, cbDurum.Text, int.Parse(tbKiralamaBedeli.Text), int.Parse(tbFiyat.Text), tbAciklama.Text,Newplaka);
                        plakaCek();
                        liste();
                        temizle();

                    }

                }
            }
            catch (Exception r)
            { MessageBox.Show(r.Message);  }
        }



        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {

                Newplaka = cbPlaka.Text;
                if (Newplaka == "")
                {
                    MessageBox.Show("Lütfen Araç Plakasının Seçili Olduğundan Emin Olun!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    temizle();
                }
                else
                {
                    if (MessageBox.Show(Newplaka + " Plakalı aracı silmek istediğinize emin misiniz ? ", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        kayit = "delete from araba where plaka=@plaka";
                        SqlCommand komut = new SqlCommand(kayit, b.con);
                        komut.Parameters.AddWithValue("@plaka", oldPlaka);
                        b.con.Open();
                        komut.ExecuteNonQuery();
                        plakaCek();
                    }
                }

            }
            catch (Exception r)
            { MessageBox.Show(r.Message); }
            finally { b.con.Close(); liste(); temizle(); }
        }


        void plakaCek()
        {        //burada Combobox'ın ' Items kısmını araç plakalarıyla doldurduk.
            try
            {
                cbPlaka.Items.Clear();
                SqlCommand cmd = new SqlCommand("select plaka from araba", b.con);
                b.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                { cbPlaka.Items.Add(dr["plaka"]); }

            }
            catch (Exception r)
            { MessageBox.Show(r.Message); }
            finally { b.con.Close(); }
        }
    }
}
