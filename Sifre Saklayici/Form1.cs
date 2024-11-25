using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sifre_Saklayici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ekleButon_Click(object sender, EventArgs e)
        {
            // Verileri Çek
            string site = siteGirdisi.Text;
            string kullaniciAdi = epostaGirdisi.Text;
            string sifre = sifreGirdisi.Text;
            // Eksik veri kontrolü
            if (site.Length == 0 || kullaniciAdi.Length == 0 || sifre.Length == 0) {
                MessageBox.Show("Eksik bir veri girdiniz, lütfen kontrol ediniz.");
                return;
            };
            // ListBox'a Ekle
            sifreListesi.Items.Add($"{site} - {kullaniciAdi} - {sifre}");
            // Girdileri temizle
            siteGirdisi.Text = "";
            epostaGirdisi.Text = "";
            sifreGirdisi.Text = "";
            // Şifre sayacını güncelle
            sifreSayaci.Text = $"Toplam {sifreListesi.Items.Count} şifre kaydedildi";
        }

        private void kaldirButon_Click(object sender, EventArgs e)
        {
            // Veri seçilmediyse uyarı ver
            if (sifreListesi.SelectedIndex == -1) {
                MessageBox.Show("Lütfen bir veri seçiniz.");
                return;
            }
            // Seçilen elemanı kaldır
            sifreListesi.Items.Remove(sifreListesi.SelectedItem);
            // Şifre sayacını güncelle
            sifreSayaci.Text = $"Toplam {sifreListesi.Items.Count} şifre kaydedildi";
        }

        private void araButon_Click(object sender, EventArgs e)
        {
            string arananMetin = aramaGirdisi.Text;
            // Eksik veri kontrolü
            if (arananMetin.Length == 0) {
                MessageBox.Show("Lütfen aranacak metni giriniz.");
                return;
            }
            // Aranan elemanın varlığını kontrol et
            if (sifreListesi.FindString(arananMetin) == ListBox.NoMatches) { 
                MessageBox.Show("Aranan metin bulunamadı.");
                return;
            }
            // Seçilen elemanı aranan eleman olarak ayarla
            sifreListesi.SelectedIndex = sifreListesi.FindString(arananMetin);
        }

        private void gizleButon_Click(object sender, EventArgs e)
        {
            // Şifre listesini gizle 
            sifreListesi.Visible = !sifreListesi.Visible;
            gizleButon.Text = (gizleButon.Text == "Şifreleri Gizle") ? "Şifreleri Göster" : "Şifreleri Gizle";
        }
    }
}
