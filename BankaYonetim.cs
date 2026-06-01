using System;
using System.Collections.Generic;
using System.Linq;


namespace nyp_odev2
{
    public class BankaYonetim
    {
        public decimal BankaToplamGeliri { get; set; }
        public List<Musteri> Musteriler { get; set; }


        public BankaYonetim()
        {

            BankaToplamGeliri = 0;
            Musteriler = new List<Musteri>();
        }


        public void MusteriEkle(Musteri yeniMusteri)
        {

            if (Musteriler.Any(m => m.MusteriNo == yeniMusteri.MusteriNo))
            {
                throw new Exception("Bu müşteri numarası zaten kullanılıyor!");
            }
            Musteriler.Add(yeniMusteri);
        }


        public void HesapAc(Musteri musteri, int yeniHesapNo, decimal ekHesap)
        {

            bool hesapNumarasiKullanimda = Musteriler.Any(m => m.Hesaplar.Any(h => h.HesapNo == yeniHesapNo));

            if (hesapNumarasiKullanimda)
            {
                throw new Exception("Bu hesap numarası başka birine ait!");
            }

            Hesap yeniHesap = new Hesap(yeniHesapNo, ekHesap);
            musteri.Hesaplar.Add(yeniHesap);
        }


        public void ParaCek(Hesap hesap, decimal tutar)
        {

            if (hesap.SonIslemTarihi.Date != DateTime.Today)
            {
                hesap.GunlukCekilenTutar = 0;
                hesap.SonIslemTarihi = DateTime.Today;
            }

            if (hesap.GunlukCekilenTutar + tutar > 750m)
            {
                throw new Exception("Günlük 750 TL çekim limitini aşıyorsunuz!");
            }


            if (hesap.Bakiye + hesap.EkHesap < tutar)
            {
                throw new Exception("Bakiye ve ek hesap limitiniz yetersiz!");
            }

            if (hesap.Bakiye >= tutar)
            {
                hesap.Bakiye -= tutar;
            }
            else
            {
                decimal kalan = tutar - hesap.Bakiye;
                hesap.Bakiye = 0;
                hesap.EkHesap -= kalan;
            }

            hesap.GunlukCekilenTutar += tutar;
            hesap.HesapOzeti.Add(new Islem("Para Çekme", tutar, "Hesaptan para çekildi."));
        }


        public void HavaleYap(Musteri gonderenMusteri, Hesap gonderenHesap, Hesap aliciHesap, decimal tutar)
        {

            decimal havaleUcreti = gonderenMusteri.HavaleUcretiHesapla(tutar);
            decimal toplamCikanTutar = tutar + havaleUcreti;

            if (gonderenHesap.Bakiye + gonderenHesap.EkHesap < toplamCikanTutar)
            {
                throw new Exception("Bakiye yetersiz! Havale ücreti dahil hesaplanmıştır.");
            }


            if (gonderenHesap.Bakiye >= toplamCikanTutar)
            {
                gonderenHesap.Bakiye -= toplamCikanTutar;
            }
            else
            {
                decimal kalan = toplamCikanTutar - gonderenHesap.Bakiye;
                gonderenHesap.Bakiye = 0;
                gonderenHesap.EkHesap -= kalan;
            }


            aliciHesap.Bakiye += tutar;
            BankaToplamGeliri += havaleUcreti;

            gonderenHesap.HesapOzeti.Add(new Islem("Giden Havale", tutar, $"Alıcı Hesap No: {aliciHesap.HesapNo}. Kesinti: {havaleUcreti} TL"));
            aliciHesap.HesapOzeti.Add(new Islem("Gelen Havale", tutar, $"Gönderen Hesap No: {gonderenHesap.HesapNo}"));
        }


        public void HesapKapat(Musteri musteri, Hesap hesap)
        {

            if (hesap.Bakiye != 0)
            {
                throw new Exception("Hesap bakiyesi 0 olmadan hesap kapatılamaz!");
            }

            musteri.Hesaplar.Remove(hesap);
        }
    }
}
