using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projeYonetimiVtys
{
    public partial class gorev : Form
    {
        private string proje_adi;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-05O65PK\\SQLEXPRESS;Initial Catalog=proje_yonetimi_veritabani;Integrated Security=True");

        public gorev(string proje_adi)
        {
            InitializeComponent();
            this.proje_adi = proje_adi;
            label5.Text = proje_adi;
            label8.Text = GetDefaultBaslangicTarihi().ToString("dd.MM.yyyy");
            label9.Text = GetDefaultBitisTarihi().ToString("dd.MM.yyyy");

        }






        private void gorev_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'proje_yonetimi_veritabaniDataSet6.Gorev' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.gorevTableAdapter1.Fill(this.proje_yonetimi_veritabaniDataSet6.Gorev);
            // TODO: Bu kod satırı 'proje_yonetimi_veritabaniDataSet2.Gorev' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.gorevTableAdapter.Fill(this.proje_yonetimi_veritabaniDataSet2.Gorev);
            // TODO: Bu kod satırı 'proje_yonetimi_veritabaniDataSet5.Gorev' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.gorevTableAdapter3.Fill(this.proje_yonetimi_veritabaniDataSet5.Gorev);
          

            try
            {
                baglanti.Open();

                string calisanSorgu = "SELECT calisan_id, adi_soyadi FROM Calisan";
                SqlDataAdapter calisanAdapter = new SqlDataAdapter(calisanSorgu, baglanti);
                DataTable calisanTablo = new DataTable();
                calisanAdapter.Fill(calisanTablo);

                comboBox1.DataSource = calisanTablo;
                comboBox1.DisplayMember = "adi_soyadi";
                comboBox1.ValueMember = "calisan_id";

                string durumSorgu = "SELECT durum_id, durum_adi FROM GorevDurum";
                SqlDataAdapter durumAdapter = new SqlDataAdapter(durumSorgu, baglanti);
                DataTable durumTablo = new DataTable();
                durumAdapter.Fill(durumTablo);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Combobox Veri Yükleme Hatası: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

            listele();
        }

        private void listele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                string sorgu = "SELECT * FROM Gorev WHERE proje_adi = @proje_adi";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                da.SelectCommand.Parameters.AddWithValue("@proje_adi", proje_adi);

                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri Getirme Hatası: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }

           
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }

                    string sorgu = "SELECT  GD.durum_adi, G.gorev_adi " +
                                   "FROM Gorev G " +
                                   "INNER JOIN GorevDurum GD ON G.durum_id = GD.durum_id " +
                                   "WHERE G.proje_adi = @proje_adi";

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    da.SelectCommand.Parameters.AddWithValue("@proje_adi", proje_adi);

                    DataTable tablo = new DataTable();
                    da.Fill(tablo);
                    dataGridView2.DataSource = tablo;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri Getirme Hatası: " + ex.Message);
                }
                finally
                {
                    if (baglanti.State == ConnectionState.Open)
                    {
                        baglanti.Close();
                    }
                }
            

        }

        private DateTime GetDefaultBaslangicTarihi()
        {
            DateTime defaultBaslangicTarihi = DateTime.MaxValue;

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                string sorgu = "SELECT baslangic_tarihi FROM Proje WHERE proje_adi = @proje_adi";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@proje_adi", proje_adi);

                object result = komut.ExecuteScalar();
                
                    defaultBaslangicTarihi = (DateTime)result;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Varsayılan Başlangıç Tarihi Getirme Hatası: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }

            return defaultBaslangicTarihi;
        }

        private DateTime GetDefaultBitisTarihi()
        {
            DateTime defaultBitisTarihi = DateTime.MinValue;

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                string sorgu = "SELECT bitis_tarihi FROM Proje WHERE proje_adi = @proje_adi";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@proje_adi", proje_adi);

                object result = komut.ExecuteScalar();
               
                    defaultBitisTarihi = (DateTime)result;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Varsayılan Bitiş Tarihi Getirme Hatası: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }

            return defaultBitisTarihi;
        }

        private void button1_Click(object sender, EventArgs e)

        {
            DateTime bitisTarihi = GetDefaultBitisTarihi();
            DateTime baslangicTarihi = GetDefaultBaslangicTarihi();
            DateTime bugun = DateTime.Now;

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                string kayit = "INSERT INTO Gorev (gorev_adi, baslangic_tarihi, adam_gun_degeri, bitis_tarihi, durum_id, proje_adi, calisan_id,gecikme_miktari) " +
                               "VALUES(@ad, @basTarih, @adamGun, @bitTarih, @durum, @projeAd, @calisan,@gecikmeMik)";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@ad", textBox1.Text);
                komut.Parameters.AddWithValue("@basTarih",baslangicTarihi);
                komut.Parameters.AddWithValue("@adamGun", textBox3.Text);
                komut.Parameters.AddWithValue("@bitTarih", bitisTarihi);

                DateTime gunumuz_tarihi = DateTime.Now;

               


                if (bitisTarihi > bugun && baslangicTarihi > bugun)
                {
                    komut.Parameters.AddWithValue("@durum", 1);
                    komut.Parameters.AddWithValue("@gecikmeMik", 0);
                }
                else if(bitisTarihi > bugun && baslangicTarihi <= bugun)
                {
                    komut.Parameters.AddWithValue("@durum", 3);
                    komut.Parameters.AddWithValue("@gecikmeMik", 0);
                }
                else
                {
                    // Gecikme miktarını hesapla
                    int gecikme_miktari = (int)(bugun - bitisTarihi).TotalDays;
                    komut.Parameters.AddWithValue("@durum", 3);
                    komut.Parameters.AddWithValue("@gecikmeMik", gecikme_miktari);

                }

                komut.Parameters.AddWithValue("@projeAd", label5.Text);
                komut.Parameters.AddWithValue("@calisan", comboBox1.SelectedValue);

                komut.ExecuteNonQuery();
                listele();

                MessageBox.Show("Kayıt ekleme işlemi başarılı");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata var!" + hata.Message);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["GorevDurumu"].Index && e.RowIndex >= 0)
            {
                // DataGridView'dan seçilen satırı al
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // "calisan_id" değerini al 
                string gorev_adi = selectedRow.Cells["gorev_adi"].Value.ToString();

                // Detay formunu aç
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }

                    string kayit = "UPDATE Gorev SET durum_id = 2 WHERE gorev_adi = @gorev_adi ";

                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.Parameters.AddWithValue("@gorev_adi", gorev_adi);

                    komut.ExecuteNonQuery();
                    listele();

                    MessageBox.Show("Durum değiştirme başarılı");
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Bir hata var!" + hata.Message);
                }
                finally
                {
                    if (baglanti.State == ConnectionState.Open)
                    {
                        baglanti.Close();
                    }
                }

            }

            DateTime bitis_tarihi = GetDefaultBitisTarihi();// Bitiş tarihini al

            if (e.ColumnIndex == dataGridView1.Columns["GorevDurumu"].Index && e.RowIndex >= 0)
            {
                // DataGridView'dan seçilen satırı al
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // "calisan_id" değerini al
                string gorev_adi = selectedRow.Cells["gorev_adi"].Value.ToString();
               

                // Günümüz tarihini al
                DateTime gunumuz_tarihi = DateTime.Now;

                // Gecikme miktarını hesapla
                int gecikme_miktari = (int)(gunumuz_tarihi - bitis_tarihi).TotalDays;

                // Detay formunu aç
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }

                    // Gecikme miktarını tabloya eklemek için UPDATE sorgusunu güncelle
                    string kayit = "UPDATE Gorev SET gecikme_miktari = @gecikme_miktari WHERE gorev_adi = @gorev_adi";

                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.Parameters.AddWithValue("@gorev_adi", gorev_adi);
                    komut.Parameters.AddWithValue("@gecikme_miktari", gecikme_miktari);

                    komut.ExecuteNonQuery();
                    listele();

                    MessageBox.Show("Durum değiştirme başarılı");
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Bir hata var!" + hata.Message);
                }
                finally
                {
                    if (baglanti.State == ConnectionState.Open)
                    {
                        baglanti.Close();
                    }
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
