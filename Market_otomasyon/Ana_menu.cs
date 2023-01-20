using Market_otomasyon.Context;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_otomasyon
{
    public partial class Ana_menu : Form
    {
        DataTable tablo = new DataTable();
        double tutar = 0;
        public Ana_menu()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MarketDbContext db = new MarketDbContext();
            var cntxt = new MarketDbContext();
            _ = cntxt.PesinSatis.Add(new Moduls.Entity.PesinSatis
            {
                Tutar = Convert.ToInt32(textBox2.Text)
            });
            var cevap = cntxt.SaveChanges();
            if (cevap <= 0)
            {
                MessageBox.Show("Satın Alma İşlemi Tamamlanamamıştır");
            }
            else
            {
                MessageBox.Show("Satın Alma İşlemi Tamamlanmıştır");

            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void button9_Click(object sender, EventArgs e)
        {
            groupBox8.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            müşteriler müşteri = new müşteriler();
            müşteri.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ÜrünStok ürün = new ÜrünStok();
            ürün.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TedarikçiBilgi tedarikci = new TedarikçiBilgi();
            tedarikci.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string barkodNo = "869" + textBox1.Text.Trim();
            using (var bb = new MarketDbContext())
            {
                var urun = bb.Stoks.FirstOrDefault(a => a.Barkod== barkodNo);
                if (urun != null)
                {
                    tablo.Rows.Add(urun.UrunKodu, urun.UrunAdi, urun.Cesit, urun.SatisFiyati);
                    dataGridView1.DataSource = tablo;
                    tutar += urun.SatisFiyati;
                    textBox2.Text = tutar.ToString();
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Ürün Bulunamadı");
                }
                // tutar += urun.SatisFiyati;
                // textBox2.Text = tutar.ToString();
            }
            //textBox1.Clear();
        }

        private void Ana_menu_Load(object sender, EventArgs e)
        {
            groupBox3.Hide();
            groupBox8.Hide();
            tablo.Columns.Add("Ürün Kodu", typeof(int));
            tablo.Columns.Add("Ürün Adı", typeof(string));
            tablo.Columns.Add("Çeşidi", typeof(string));
            tablo.Columns.Add("Fiyatı", typeof(double));
            dtpTarih.CustomFormat = "dd-MM-yyyy";
            dtpTarih.Format = DateTimePickerFormat.Custom;

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            int para;
            para = Convert.ToInt32(textBox5.Text) - Convert.ToInt32(textBox2.Text);
            textBox4.Text = para.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Yeni_Müsteri yenimüsteri = new Yeni_Müsteri();
            yenimüsteri.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            groupBox3.Show();


            /* if (dataGridView1.SelectedRows.Count > 0)
             {
                 dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
             }
             else
             {
                 MessageBox.Show("Lüffen silinecek satırı seçin.");
             } */



        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(textBox6.Text) == 123)
            {
                MessageBox.Show("Seçilen Satır Listeden Silindi");
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                textBox6.Clear();
                groupBox3.Hide();
            }

            else
            {
                MessageBox.Show("Yanlış Şifre Girdiniz");
                textBox6.Clear();
            }
        }

       

        private void button13_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim().Length == 0) return;

            string musteriadi = " ";
            string soyadi = " ";
            MarketDbContext db = new MarketDbContext();
            foreach (var deger in db.Musteris)
            {
                if (deger.MusteriID == Convert.ToInt32(textBox3.Text))
                {
                    musteriadi = deger.MusteriAd;
                    soyadi = deger.MusteriSoyad;
                }
            }
            var cntxtt = new MarketDbContext();
            _ = cntxtt.Borcs.Add(new Moduls.Entity.Borc
            {
                MusteriAd = musteriadi,
                MusteriSoyad = soyadi,
                MusteriID = Convert.ToInt32(textBox3.Text),
                Tutar = Convert.ToInt32(textBox2.Text),
                SatinAlmaTarihi =Convert.ToDateTime(dtpTarih.Value.ToShortDateString()),
            });

            var cevap = cntxtt.SaveChanges();
            if (cevap <= 0)
            {
                MessageBox.Show("Satın Alma İşlemi Tamamlanamamıştır");
            }
            else
            {
                MessageBox.Show("Satın Alma İşlemi Tamamlanmıştır");
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
