using Market_otomasyon.Context;
using Market_otomasyon.Moduls.Entity;
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
    public partial class müşteriler : Form
    {
        public müşteriler()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Yeni_Müsteri yenimüsteri = new Yeni_Müsteri();
            yenimüsteri.Show();
            //this.Hide();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            Musteri_Sil musteri_Sil = new Musteri_Sil();
            musteri_Sil.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ana_menu ANA = new Ana_menu();
            ANA.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Giris_ekrani giris = new Giris_ekrani();
            giris.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ÜrünStok ürün = new ÜrünStok();
            ürün.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MarketDbContext db = new MarketDbContext();
            var müsteri = db.Musteris.ToList();
            dataGridView1.DataSource = müsteri;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MarketDbContext aa = new MarketDbContext();
            var borc = aa.Borcs.ToList();
            dataGridView1.DataSource = borc;


            int id = Convert.ToInt32(textBox4.Text);
            var x = aa.Borcs.Find(id);
            //dataGridView1.DataSource = x;
            textBox1.Text = Convert.ToString(x.Tutar);
            textBox1.Refresh();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            TedarikçiBilgi tedarikci = new TedarikçiBilgi();
            tedarikci.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int paraüstü;
            paraüstü = int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
            textBox3.Text = paraüstü.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string musteriadi = " ";
            string soyadi = " ";
            MarketDbContext db = new MarketDbContext();
            foreach (var deger in db.Musteris)
            {
                if (deger.MusteriID == Convert.ToInt32(textBox4.Text))
                {
                    musteriadi = deger.MusteriAd;
                    soyadi = deger.MusteriSoyad;
                }
            }
            var cntxt = new MarketDbContext();
            _ = cntxt.Borcs.Add(new Moduls.Entity.Borc
            {
                MusteriAd = musteriadi,
                MusteriSoyad = soyadi,
                MusteriID = Convert.ToInt32(textBox4.Text),
                MusteriOdeme = Convert.ToInt32(textBox2.Text),
                //SatinAlmaTarihi = Convert.ToDateTime(textBox8.Text),

            });

            int paraüstü;
            paraüstü = int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
            textBox3.Text = paraüstü.ToString();
            
            int id = Convert.ToInt32(textBox4.Text);
            var musteri = db.Borcs.Find(id);
            musteri.Tutar = Convert.ToInt32(textBox3.Text);
            db.SaveChanges();
            dataGridView1.Refresh();

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void müşteriler_Load(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

