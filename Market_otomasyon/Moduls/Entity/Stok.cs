using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_otomasyon.Moduls.Entity
{
    public class Stok

    {

        public int StokID { get; set; }
        public int UrunKodu { get; set; }
        public string Barkod { get; set; }
        public string Cesit { get; set; }
        public int StokMiktari { get; set; }
        public string UrunAdi { get; set; }
        public double BirimGirdiFiyat { get; set; }
        public double SatisFiyati { get; set; }
        public int IrsaliyeNo { get; set; }
        public string BarkodOlustur(string _urunkodu)
        {
            Random rnd = new Random();
           return  _urunkodu + rnd.Next(0, 575).ToString();
            
        }
        public double SatisFiyatiOlustur()
        {
            SatisFiyati = BirimGirdiFiyat + (BirimGirdiFiyat * 0.2);
            return SatisFiyati;
        }

    }

}

