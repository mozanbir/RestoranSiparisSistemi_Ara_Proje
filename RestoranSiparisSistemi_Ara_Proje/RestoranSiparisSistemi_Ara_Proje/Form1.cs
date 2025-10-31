using RestoranSiparisSistemi_Ara_Proje.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranSiparisSistemi_Ara_Proje
{
    public partial class Form1 : Form
    {
        private List<Yemek> Menumuz = new List<Yemek>(); //menüdeki yemekleri tutan liste olacak.

        private Musteri Musteri1 = new Musteri(1, "Ali VELİ", "0555 555 55 55");

        private Siparis AktifSiparis;
        public Form1()
        {
            InitializeComponent();


            MenuHazirla();

            AktifSiparis = new Siparis(1, Musteri1);

            rtxSiparisOzet.Text = $"Hoş Geldiniz, {Musteri1.AdSoyad} . Yeni Sipariş oluşturuldu (ID:{AktifSiparis.Id}).";


        }

        private void MenuHazirla()//menü oluştur 
        {
            Menumuz.Add(new Yemek(1, "Kuzu Tandır", 1100.0, 45));
            Menumuz.Add(new Yemek(2, "Karışık Izgara", 1800.0, 30));
            Menumuz.Add(new Yemek(3, "Adana Kebap", 450.0, 15));
            Menumuz.Add(new Yemek(4, "Lahmacun", 250.0, 35));


            foreach (Yemek yemek in Menumuz)
            {
                lstMenuler.Items.Add(yemek);
            }








        }
    }
}
