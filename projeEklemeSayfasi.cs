using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Net.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projeYonetimiVtys
{
    public partial class projeEklemeSayfasi : Form
    {
        public projeEklemeSayfasi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-05O65PK\\SQLEXPRESS; Initial Catalog=proje_yonetimi_veritabani;Integrated Security=True");
        private void projeEklemeSayfasi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'proje_yonetimi_veritabaniDataSet3.Proje' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.projeTableAdapter.Fill(this.proje_yonetimi_veritabaniDataSet3.Proje);


            listele();
        }

        private void listele()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Proje", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //PROJE EKLEME
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                    string kayit = "INSERT INTO Proje (proje_adi, baslangic_tarihi, bitis_tarihi) VALUES(@ad, @basTarih, @bitTarih)";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.Parameters.AddWithValue("@ad", textBox2.Text);
                    komut.Parameters.AddWithValue("@basTarih", dateTimePicker1.Value.Date);
                  

                    DateTime bugun = DateTime.Now;
                    DateTime bitisTarihi = dateTimePicker2.Value.Date;

                    if (bitisTarihi < bugun )
                    {
                        DateTime yeniTarih = bugun.AddDays(7);
                        komut.Parameters.AddWithValue("@bitTarih", yeniTarih);
                        komut.ExecuteNonQuery();

                        int gecikme_miktari = (int)(bugun - bitisTarihi).TotalDays;
                        // Bitiş tarihi bugünden sonraya rastlıyorsa gecikme miktarını 0 olarak güncelle
                        string gecikmeGuncelle = "UPDATE Proje SET gecikme_miktari = @gecikmeMik  WHERE proje_adi = @ad";
                        SqlCommand guncelleKomut = new SqlCommand(gecikmeGuncelle, baglanti);
                        guncelleKomut.Parameters.AddWithValue("@gecikmeMik", gecikme_miktari);
                        guncelleKomut.Parameters.AddWithValue("@ad", textBox2.Text);
                        guncelleKomut.ExecuteNonQuery();

                    }

                    

                    if (bitisTarihi >= bugun)
                    {
                        komut.Parameters.AddWithValue("@bitTarih", dateTimePicker2.Value.Date);
                        komut.ExecuteNonQuery();
                        // Bitiş tarihi bugünden sonraya rastlıyorsa gecikme miktarını 0 olarak güncelle
                        string gecikmeGuncelle = "UPDATE Proje SET gecikme_miktari = 0 WHERE proje_adi = @ad";
                        SqlCommand guncelleKomut = new SqlCommand(gecikmeGuncelle, baglanti);
                        guncelleKomut.Parameters.AddWithValue("@ad", textBox2.Text);
                        guncelleKomut.ExecuteNonQuery();
                    }
                    

                    baglanti.Close();
                    listele();

                    textBox2.Clear();

                    MessageBox.Show("Kayit ekleme islemi basarili");

                    anasayfa anasayfa = new anasayfa();
                    anasayfa.Show();
                    this.Close();
                    anasayfa.listele();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata var!" + hata.Message);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Close();
            anasayfa.listele();


        }
    }
}

