using System;
using System.Collections.Generic;

namespace nyp_odev2
{ 

    public class HesapBilgileri
    {
        public int HesapNo { get; set; }
        public decimal Bakiye { get; set; }
        public decimal EkHesap { get; set; }
        public decimal GunlukCekilenTutar { get; set; }
        public DateTime SonIslemTarihi { get; set; }
        public List<IslemBilgileri> HesapOzeti { get; set; } 

        public HesapBilgileri(int hesapNo, decimal ekHesap)
        {
            HesapNo = hesapNo;
            Bakiye = 0;
            EkHesap = ekHesap;
            GunlukCekilenTutar = 0;
            SonIslemTarihi = DateTime.Today;
            HesapOzeti = new List<IslemBilgileri>();
        }
    }
}
