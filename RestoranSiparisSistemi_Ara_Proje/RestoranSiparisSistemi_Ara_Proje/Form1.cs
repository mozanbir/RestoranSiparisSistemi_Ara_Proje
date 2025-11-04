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

            rtxSiparisOzet.Text = $"Hoş Geldiniz, {Musteri1.AdSoyad} . Yeni Sipariş oluşturuluyor. (ID:{AktifSiparis.Id}).";


        }

        private void MenuHazirla()//menü oluştur 
        {
            Menumuz.Add(new Yemek(1, "Kuzu Tandır", 1100.0, 45));
            Menumuz.Add(new Yemek(2, "Karışık Izgara", 1800.0, 30));
            Menumuz.Add(new Yemek(3, "Adana Kebap", 450.0, 15));
            Menumuz.Add(new Yemek(4, "Lahmacun", 250.0, 15));
            Menumuz.Add(new Yemek(5, "Kuzu Külbastı", 850.0, 25));
            Menumuz.Add(new Yemek(6, "İskender", 750.0, 35));
            Menumuz.Add(new Yemek(7, "Tavuk şiş", 350.0, 35));
            Menumuz.Add(new Yemek(8, "İçli köfte (adet)", 70.0, 5));
            Menumuz.Add(new Yemek(9, "Künefe", 250.0, 25));


            foreach (Yemek yemek in Menumuz)
            {
                lstMenuler.Items.Add(yemek);
            }








        }

        private void btnYemekEkle_Click(object sender, EventArgs e)
        {
            if (lstMenuler.SelectedItem != null)
            {
                Yemek secilenYemek = lstMenuler.SelectedItem as Yemek;

                AktifSiparis.YemekEkle(secilenYemek);


                double toplamTutar = AktifSiparis.ToplamTutarHesapla();
                lblToplamTutar.Text = toplamTutar.ToString("C");

                rtxSiparisOzet.Text += $"\n->{secilenYemek.Ad} sepete eklendi. Yeni Tutar: {lblToplamTutar.Text}";

            }
            else 
            {
            MessageBox.Show("Lütfen menüden bir yemek seçin." , "Uyarı" , MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnSiparisTamamla_Click(object sender, EventArgs e)
        {
            if (AktifSiparis.Yemekler.Count == 0)
            {
                MessageBox.Show("Sipariş listesi boş. Lütfen önce sepete yemek ekleyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string siparisOzeti = AktifSiparis.SiparisBilgisiGoster();


            rtxSiparisOzet.Text = siparisOzeti;

            MessageBox.Show("Sipariş başarıyla oluşturuldu! Özet altta görünüyor." , "Başarılı" , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDurumGuncelle_Click(object sender, EventArgs e)
        {
            AktifSiparis.SiparisDurumGuncelle("Yolda");

            rtxSiparisOzet.Text += $"\n\n---- SİPARİŞ DURUMU GÜNCELLENDİ ---\n";
            rtxSiparisOzet.Text += $"Yeni Durum:{AktifSiparis.Durum}\n";
            rtxSiparisOzet.Text += $"Müşteir: {AktifSiparis.Musteri.AdSoyad}'ın siparişi kuryeye verildi!";

            MessageBox.Show("Sipariş Durumu 'Yolda' olarak güncellendi.", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rtxSiparisOzet_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
