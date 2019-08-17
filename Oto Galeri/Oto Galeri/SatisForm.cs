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
    public partial class SatisForm : Form
    {
        baglan b = new baglan();
        DataSet set = new DataSet();
        float fiyat = 0;
        public SatisForm()
        {
            InitializeComponent();
        }

        private void SatisForm_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.DarkBlue;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
            listele();
            tcCek();

        }
        void temizle()
        {
            tbPlaka.Clear(); tbFiyat.Clear(); cbTC.Text = ""; dtSatisTarih.Value = DateTime.Now; tbFiyat.Clear(); button2.Visible = false;
        }
        void listele()
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
                fiyat = Convert.ToInt32(dataGridView1.CurrentRow.Cells[12].Value);
                tbFiyat.Text = fiyat.ToString();
            }
            catch (Exception r)
            { MessageBox.Show(r.Message); }
        }

        private void cbOdemeTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOdemeTip.Text== "Taksit")
            {
                lblTaksit.Visible = true;
                cbTaksitSayisi.Visible = true;
                lblAylikTaksitTutari.Visible = true;
            }
            else
            {
                lblTaksit.Visible = false;
                cbTaksitSayisi.Visible = false;
                lblAylikTaksitTutari.Visible = false;
            }
        }

        private void cbTaksitSayisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAylikTaksitTutari.Text = (fiyat / Convert.ToInt32(cbTaksitSayisi.Text)).ToString();
        }

        private void btnSAT_Click(object sender, EventArgs e)
        {
            string durum = "Satıldı";
            try
            {
                if (cbOdemeTip.Text=="Nakit")
                {
                    SqlCommand komut = new SqlCommand("insert into SatisRaporu(plaka,tc,satisTarih,odemetip,satisFiyat)values('" + tbPlaka.Text + "','" + cbTC.Text + "','" + dtSatisTarih.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + cbOdemeTip.Text + "',"+tbFiyat.Text+")", b.con);
                    b.con.Open();
                    komut.ExecuteNonQuery();
                    string kyt = "update araba set durum=@durum where plaka=@plaka";
                    SqlCommand cmd = new SqlCommand(kyt, b.con);
                    cmd.Parameters.AddWithValue("durum", durum);
                    cmd.Parameters.AddWithValue("plaka", tbPlaka.Text);
                    cmd.ExecuteNonQuery();
                    b.con.Close();
                    listele();
                    temizle();
                }
                else if(cbOdemeTip.Text == "Taksit")
                {
                    SqlCommand komut = new SqlCommand("insert into SatisRaporu values('" + tbPlaka.Text + "','" + cbTC.Text + "','" + dtSatisTarih.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + cbOdemeTip.Text + "',"+Convert.ToInt32(cbTaksitSayisi.Text)+"," + tbFiyat.Text + ")", b.con);
                    b.con.Open();
                    komut.ExecuteNonQuery();
                    string kyt = "update araba set durum=@durum where plaka=@plaka";
                    SqlCommand cmd = new SqlCommand(kyt, b.con);
                    cmd.Parameters.AddWithValue("durum", durum);
                    cmd.Parameters.AddWithValue("plaka", tbPlaka.Text);
                    cmd.ExecuteNonQuery();
                    b.con.Close();
                    listele();
                    temizle();
                }
            }
            catch (Exception r)
            {MessageBox.Show(r.Message);}
            finally { b.con.Close(); }
        }

        private void button2_Click(object sender, EventArgs e)
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
            if (cbTC.Text != "")
            {
                button2.Visible = true;
            }
        }


    }
}
