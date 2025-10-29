using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranSiparisSistemi_Ara_Proje.Models
{
    public class Siparis
    {
        public int Id { get; set; }
        //bir siparişin bir müşterisi olması gerekir.
        public Musteri Musteri { get; set; }
        //bir sipariş ise birden fazla yemek içerebikir.

        public List<Yemek> Yemekler { get; set; }

        public DateTime SiparisTarihi { get; set; }

        public string Durum { get; set; }

        public Siparis(int id, Musteri musteri)
        {

            this.Id = id;
            this.Musteri = musteri;
            this.Yemekler = new List<Yemek>();//boş yemek listesini olusturduk.
            this.SiparisTarihi = DateTime.Now;
            this.Durum = "Hazırlanıyor";//olası durum


        }

        //metod : yemek ekleme
        public void YemekEkle(Yemek yemek)
        {
            Yemekler.Add(yemek);
        
        }

        //toplam tutar hesaplama
        public double ToplamTutarHesapla()
        {
            double toplam = 0;
            foreach (Yemek yemek in Yemekler)
            {
                toplam += yemek.Fiyat;
            
            }
            return toplam;

        }
        //durum güncelleme
        public void DurumGuncelle(string yeniDurum)
        {
            this.Durum = yeniDurum;
        }
        public string SiparisBilgisiGoster()
        { 
        string bilgi =  "----- SİPARİŞ DETAYLARI -----\n";
            bilgi += $"Sipariş ID: {Id}\n";
            bilgi += $"Müşteri: {Musteri.AdSoyad} ({Musteri.Telefon})\n";
            bilgi += $"Tarih: {SiparisTarihi.ToShortDateString()}\n";
            bilgi += $"Durum: {Durum}\n";
            bilgi += "-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n";


            //yemekleri listele
            foreach (Yemek y in Yemekler)
            {
                bilgi += $"-{y.Ad} ({y.Fiyat:C})\n";

            }
            //toplam tutarı ekle
            bilgi += $"\nTOPLAM TUTAR: {ToplamTutarHesapla():C}\n";

            return bilgi;

        }

    }
}
