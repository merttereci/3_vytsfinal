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

namespace projeYonetimiVtys
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-05O65PK\\SQLEXPRESS; Initial Catalog=proje_yonetimi_veritabani;Integrated Security=True");
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        private void anasayfa_Load(object sender, EventArgs e)
        {
            GunlukSqlIslemi();
            // TODO: Bu kod satırı 'proje_yonetimi_veritabaniDataSet7.Proje' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.projeTableAdapter.Fill(this.proje_yonetimi_veritabaniDataSet7.Proje);
            // TODO: Bu kod satırı 'proje_yonetimi_veritabaniDataSet.Proje' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.projeTableAdapter1.Fill(this.proje_yonetimi_veritabaniDataSet.Proje);
            

            listele();
        }

        private void GunlukSqlIslemi()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-05O65PK\\SQLEXPRESS; Initial Catalog=proje_yonetimi_veritabani;Integrated Security=True"))
                {
                    
                    baglanti.Open();

                    // Burada bir kere çalışacak SQL işlemini gerçekleştir
                    // Örneğin, projelerin durumunu kontrol etmek, görevleri güncellemek veya başka bir işlem yapmak
                    string sorgu = @"UPDATE Proje
                                        SET 
                                        bitis_tarihi = DATEADD(day, 7, GETDATE()),  -- Bitiş tarihini 7 gün sonraya güncelle
                                   gecikme_miktari = DATEDIFF(day, GETDATE(), bitis_tarihi)  -- Gecikme miktarını hesapla ve güncelle
                    WHERE 
                    proje_adi IN (
                    SELECT p.proje_adi
                    FROM Proje p
                      JOIN Gorev g ON p.proje_adi = g.proje_adi
                      WHERE 
                    p.bitis_tarihi < CAST(GETDATE() AS DATE)  -- Bitiş tarihi bugünü geçmiş projeleri seç
                    AND EXISTS (
                        SELECT 1
                        FROM Gorev g2
                        WHERE 
                    g2.proje_adi = p.proje_adi
                    AND g2.durum_id != 2  -- Durum_id'si 2 olmayan görevleri kontrol et
                            )
                    );
                           ";

                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                 

                    komut.ExecuteNonQuery();
                    listele();


                    baglanti.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL işlemi sırasında bir hata oluştu: " + ex.Message);
            }
        }

        public  void listele()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Proje", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Button"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string proje_adi = selectedRow.Cells["proje_adi"].Value.ToString();

                // Projeye ait görevleri listeleme ve görev ekleme o projeye
                gorev frm = new gorev(proje_adi);
                frm.Show();
                this.Close();

               // dataGridView1.Rows[e.RowIndex].Cells["button"].ReadOnly = false;
            }
            

        }
        

        private void button1_Click(object sender, EventArgs e) //PROJE EKLEME
        {
            projeEklemeSayfasi frm = new projeEklemeSayfasi();
            frm.Show();
            this.Close();
        
        }

      

        private void button2_Click(object sender, EventArgs e)//ÇALIŞAN EKLEME
        {
            calisanlar frm = new calisanlar();
            frm.Show();
            this.Close();
        }


        private void button3_Click(object sender, EventArgs e) //ÇIKIŞ
        {
            
            this.Close();
           ;

        }
    }
}
