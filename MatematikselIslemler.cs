using System;

namespace nyp_odev1
{
    public class MatematikselIslemler
    {
        public bool AsalSayiKontrol(int sayi)
        {
            if (sayi < 2) return false;
            for (int i = 2; i <= Math.Sqrt(sayi); i++)
            {
                if (sayi % i == 0) return false;
            }
            return true;
        }

        public bool MukemmelSayiKontrol(int sayi)
        {
            if (sayi < 1) return false;
            int toplam = 0;
            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0) toplam += i;
            }
            return toplam == sayi;
        }
    }
}
