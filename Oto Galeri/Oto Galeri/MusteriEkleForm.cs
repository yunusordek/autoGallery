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
    enum sehir
    { İstanbul, Ankara, İzmir, Adana, Adıyaman, Afyonkarahisar, Ağrı, Aksaray, Amasya, Antalya, Ardahan, Artvin, Aydın, Balıkesir, Bartın, Batman, Bayburt, Bilecik, Bingöl, Bitlis, Bolu, Burdur, Bursa, Çanakkale, Çankırı, Çorum, Denizli, Diyarbakır, Düzce, Edirne, Elazığ, Erzincan, Erzurum, Eskişehir, Gaziantep, Giresun, Gümüşhane, Hakkari, Hatay, Iğdır, Isparta, Kahramanmaraş, Karabük, Karaman, Kars, Kastamonu, Kayseri, Kırıkkale, Kırklareli, Kırşehir, Kilis, Kocaeli, Konya, Kütahya, Malatya, Manisa, Mardin, Mersin, Muğla, Muş, Nevşehir, Niğde, Ordu, Osmaniye, Rize, Sakarya, Samsun, Siirt, Sinop, Sivas, Şırnak, Tekirdağ, Tokat, Trabzon, Tunceli, Şanlıurfa, Uşak, Van, Yalova, Yozgat, Zonguldak }
    public partial class MusteriEkleForm : Form
    {
        baglan b = new baglan();
        DataSet set = new DataSet();
        string[] sehirler = Enum.GetNames(typeof(sehir));
        public MusteriEkleForm()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string Mustericinsiyet;
           
            if (rb_bay.Checked)
            {Mustericinsiyet = rb_bay.Text;}
            else
                Mustericinsiyet = rb_bayan.Text;



            try
            {
                if (tB_tc.Text == "" || tB_Adsoyad.Text == "" || Mustericinsiyet == "" || cB_dtarih.Text == "" || cB_dyeri.Text == "" ||  tB_ctelefon.Text == "" || tB_adres.Text == "" || tB_email.Text == "" || tB_ehliyetBelge.Text == "")
                {
                    MessageBox.Show("Lütfen tüm alanların dolu olduğuna emin olun!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    b.con.Close();
                    MusteriEkleClass musteri = new MusteriEkleClass(tB_tc.Text, tB_Adsoyad.Text, Mustericinsiyet, cB_dtarih.Text, cB_dyeri.Text, tB_ehliyetBelge.Text, tB_telefon.Text, tB_ctelefon.Text, tB_adres.Text, tB_email.Text);
                    listele();

                }
            }
            catch (Exception r)
            {

                MessageBox.Show(r.Message);
            }
            
        }
        void temizle()
        {
            tB_tc.Clear(); tB_Adsoyad.Clear(); rb_bay.Checked = false; rb_bayan.Checked = false; cB_dtarih.Text = ""; tB_telefon.Clear();
            tB_ctelefon.Clear(); tB_adres.Clear(); tB_email.Clear();cB_dyeri.Text = ""; tB_ehliyetBelge.Clear();
        }

        private void MusteriEkleForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8);
                this.dataGridView1.DefaultCellStyle.ForeColor = Color.DarkBlue;
                this.dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
                listele();
                foreach (var item in sehirler)
                {
                    cB_dyeri.Items.Add(item);
                }
                for (int i = 1945; i <= 1997; i++)
                {
                    cB_dtarih.Items.Add(i);
                }
            }
            catch (Exception r)
            {

                MessageBox.Show(r.Message);
            }
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
            {

                MessageBox.Show(r.Message);
            }
            finally { b.con.Close(); }
        }

        private void tB_telefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        

        private void tB_ctelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tB_tc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
