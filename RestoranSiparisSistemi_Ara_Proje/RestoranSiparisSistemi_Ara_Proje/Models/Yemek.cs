using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranSiparisSistemi_Ara_Proje.Models
{
    public class Yemek
    {
        //Özellikler
        public int Id { get; set; }
        public string Ad { get; set; }
        public double Fiyat { get; set; }
        public int HazirlanmaSuresi { get; set; }

        //yapıcı metotlarımızı oluşturalım
        public Yemek(int id, string ad, double fiyat, int sure)
        {
            this.Id = id;
            this.Ad = ad;
            this.Fiyat = fiyat;
            this.HazirlanmaSuresi = sure;


        }
        //ToString metodunu override ediyoruz.

        public override string ToString()
        {
            //:C para birimi formatı için kullanıyoruz.
            return $"{Ad} - {Fiyat:C}";
}
    }
}
