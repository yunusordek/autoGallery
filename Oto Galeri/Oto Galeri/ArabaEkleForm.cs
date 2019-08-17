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
    public partial class ArabaEkleForm : Form
    {
        baglan b = new baglan();
        DataSet set = new DataSet();
        public ArabaEkleForm()
        {
            InitializeComponent();
        }
        public void listele()
        {
            try
            {
                set.Clear();
                b.con.Open();
                SqlDataAdapter adp = new SqlDataAdapter("select distinct plaka as PLAKA,marka as MARKA, model as MODEL, yil as YIL ,yakit as YAKIT ,km as KM,vitestip as 'VİTES TİPİ',renk AS RENK, motorhacmi AS 'MOTOR HACMİ',motorgucu as 'MOTOR GÜCÜ' ,hasarKaydi as 'HASAR KAYDI', kiralamaFiyat as 'KİRALAMA BEDELİ' ,fiyat as FİYAT ,durum as DURUM ,aciklama AS AÇIKLAMA from araba", b.con);
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


        private void ArabaEkleForm_Load(object sender, EventArgs e)
        {
            listele();
            this.dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.DarkBlue;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (tbPlaka.Text == "" || tbMarka.Text == "" || tbModel.Text == "" || tbYil.Text == "" || cbYakit.Text == "" || tbKm.Text == "" || cbVitesTipi.Text == "" || tbRenk.Text == "" || tbMotorhacmi.Text == "" || tbMotorgucu.Text == "" || tbHasarKaydi.Text == "" || tbKiralamaBedeli.Text == "" || tbFiyat.Text == "" || tbAciklama.Text == "")
                {
                    MessageBox.Show("Lütfen tüm alanların dolu olduğuna emin olun!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    ArabaEkleClass arabaEkle = new ArabaEkleClass(tbPlaka.Text, tbMarka.Text, tbModel.Text, tbYil.Text, cbYakit.Text, int.Parse(tbKm.Text), cbVitesTipi.Text, tbRenk.Text, tbMotorhacmi.Text, tbMotorgucu.Text, tbHasarKaydi.Text, int.Parse(tbKiralamaBedeli.Text), int.Parse(tbFiyat.Text), tbAciklama.Text);
                    listele();
                }
            }
            catch (Exception r)
            { MessageBox.Show(r.Message); }
            finally { b.con.Close(); }
        }
    }
}
