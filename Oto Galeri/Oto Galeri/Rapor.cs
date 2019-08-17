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
    public partial class Rapor : Form
    {
        baglan b = new baglan();
        DataSet set = new DataSet();
        int tutar = 0;
        public Rapor()
        {
            InitializeComponent();
        }

        private void Rapor_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.DarkBlue;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
            listele();
        }
        void listele()
        {
            try
            {
                set.Clear();
                b.con.Open();
                SqlDataAdapter adp = new SqlDataAdapter("select plaka as 'PLAKA' ,tc as 'TC',tarih as 'KAZANILAN TARİH',fiyat as 'NE KADAR',kazanctipi as 'NASIL KAZANILDI'  from Rapor", b.con);
                adp.Fill(set, "Rapor");
                dataGridView1.DataSource = set.Tables["Rapor"];
                b.con.Close();

                SqlCommand komut = new SqlCommand("select sum(fiyat) as tutar from Rapor ", b.con);
                b.con.Open();
                SqlDataReader data = komut.ExecuteReader();
                while (data.Read())
                {
                    tutar = int.Parse(data["tutar"].ToString());
                }
                label2.Text = tutar.ToString()+" TL";
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
    }
}
