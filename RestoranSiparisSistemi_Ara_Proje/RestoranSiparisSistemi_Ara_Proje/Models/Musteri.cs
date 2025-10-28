using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranSiparisSistemi_Ara_Proje.Models
{
    public class Musteri
    {
        //müşteri özellikleir
        public int Id { get; set; }
        public string AdSoyad { get; set; }

        public string Telefon { get; set; }



        public Musteri(int id, string adsoyad, string telefon)
        {
            this.Id = id;
            this.AdSoyad = adsoyad;
            this.Telefon = telefon;

        }






    }
}
