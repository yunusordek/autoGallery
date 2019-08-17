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
    public partial class KayitFormu : Form
    {
        public KayitFormu()
        {
            InitializeComponent();
        }
        baglan b = new baglan();
        DataSet set = new DataSet();

        private void btnKayit_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand komut = new SqlCommand("insert into kullanici values('" + tbKullaniciAdi.Text + "','"+tbAdsoyad.Text+"','" + tbEposta.Text + "','" + tbPassword.Text + "')", b.con);
                b.con.Open();
                komut.ExecuteNonQuery();
                b.con.Close();

            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message);
            }
            finally { b.con.Close(); this.Close(); }
        }
    }
}
