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
    public partial class MusteriGuncelleForm : Form
    {
        baglan b = new baglan();
        DataSet set = new DataSet();
        public string tc, adsoyad;
        string kayit;
        public MusteriGuncelleForm()
        {
            InitializeComponent();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                string Mustericinsiyet;
                if (rb_bay.Checked)
                {
                    Mustericinsiyet = rb_bay.Text;
                }
                else
                    Mustericinsiyet = rb_bayan.Text;

                

                if (tB_tc.Text == "" || tB_Adsoyad.Text == "" || Mustericinsiyet == "" || tB_Dtarih.Text == "" || tB_DYeri.Text == "" || tB_ctelefon.Text == "" || tB_telefon.Text == "" || tB_adres.Text == "" || tB_email.Text == "")
                {
                    MessageBox.Show("Lütfen tüm alanların dolu olduğuna emin olun!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (MessageBox.Show("Değişiklik Yapmak İstediğinizden Emin Misiniz ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        MusteriGuncelleClass mguncelle = new MusteriGuncelleClass(tB_tc.Text, tB_Adsoyad.Text, Mustericinsiyet, tB_Dtarih.Text, tB_DYeri.Text, tB_ehliyetBelge.Text, tB_telefon.Text, tB_ctelefon.Text, tB_adres.Text, tB_email.Text);
                        temizle();

                    }
                }


            }
            catch (Exception r)
            { MessageBox.Show(r.Message); }
            finally { listele(); }
        }
        void listele()
        {
            try
            {
                set.Clear();
                b.con.Open();
                SqlDataAdapter adp = new SqlDataAdapter("select tc as 'TC',adsoyad AS 'AD SOYAD',cinsiyet AS 'CİNSİYET' , dtarihi AS 'DOĞUM TARİHİ',dyeri AS 'DOĞUM YERİ',ehliyetBelgeNo AS 'EHLİYET BELGE NO',telefon as 'TELEFON' , ctelefon as 'CEP TELEFONU' ,email as 'EMAİL',adres as 'ADRES' from musteri", b.con);
                adp.Fill(set, "musteri");
                dataGridView1.DataSource = set.Tables["musteri"];
            }
            catch (Exception r)
            { MessageBox.Show(r.Message); }
            finally { b.con.Close(); }


        }

        private void MusteriGuncelleForm_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.DarkBlue;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
            

            listele();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            string a = "";

            tB_tc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tB_Adsoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            a = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            if (a == "Bay")
            { rb_bay.Checked = true; }
            else { rb_bayan.Checked = true; }
            tB_Dtarih.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tB_DYeri.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tB_ehliyetBelge.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tB_telefon.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tB_ctelefon.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            tB_adres.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            tB_email.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                tc = tB_tc.Text;
                adsoyad = tB_Adsoyad.Text;
                if (tB_tc.Text == "")
                {
                    MessageBox.Show("Lütfen Tc Kimlik Numarasını Giriniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (MessageBox.Show(tc + " Tc Kimlik numaralı " + adsoyad + " kişisini silmek istediğinizden emin misiniz ?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        kayit = "delete from musteri where tc=@tc";
                        SqlCommand komut = new SqlCommand(kayit, b.con);
                        komut.Parameters.AddWithValue("@tc", tc);
                        b.con.Open();
                        komut.ExecuteNonQuery();
                        temizle();

                    }

                }

            }
            catch (Exception r)
            { MessageBox.Show(r.Message); }
            finally { b.con.Close(); listele(); }
        }

        void temizle()
        {
            tB_tc.Clear(); tB_Adsoyad.Clear(); rb_bay.Checked = false; rb_bayan.Checked = false; tB_Dtarih.Clear(); ; tB_telefon.Clear();
            tB_ctelefon.Clear(); tB_adres.Clear(); tB_email.Clear();
             tB_DYeri.Clear();tB_ehliyetBelge.Clear();
        }
    }
}
