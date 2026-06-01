using System;
using System.Collections.Generic;

namespace nyp_odev2
{
    public class IslemBilgileri
    {

        public string IslemTipi { get; set; }
        public decimal Miktar { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }

        public IslemBilgileri(string islemTipi, decimal miktar, string aciklama)
        {

            IslemTipi = islemTipi;
            Miktar = miktar;
            Aciklama = aciklama;
            Tarih = DateTime.Now;
        }
    }
}