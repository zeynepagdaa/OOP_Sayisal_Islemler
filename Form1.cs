using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nyp_odev1
{
    public partial class Form1: Form
    {

        MatematikselIslemler islem = new MatematikselIslemler();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = "Programa hoş geldiniz!";
            notifyIcon1.BalloonTipText = "Nesne Yönelimli Programlama Ödev 1\nTekCift";
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(3000); 

            
            mtbBaslangic.Text = "1";
            mtbBitis.Text = "10000";
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalistir_Click(object sender, EventArgs e)
        {
            if (!GirisleriDogrula(out int baslangic, out int bitis))
                return;

            EkranTemizle();

            
            long tekToplam = 0, ciftToplam = 0, asalToplam = 0, mukemmelToplam = 0;
            double tekCarpim = 1, ciftCarpim = 1, asalCarpim = 1, mukemmelCarpim = 1;

           
            bool tekVarMi = false, ciftVarMi = false, asalVarMi = false, mukemmelVarMi = false;

            for (int i = baslangic; i <= bitis; i++)
            {
                
                if (i % 2 != 0)
                {
                    lbTekSayilar.Items.Add(i);
                    tekToplam += i;
                    tekCarpim *= i;
                    tekVarMi = true;
                }
                else
                {
                    lbCiftSayilar.Items.Add(i);
                    ciftToplam += i;
                    ciftCarpim *= i;
                    ciftVarMi = true;
                }

                
                if (islem.AsalSayiKontrol(i))
                {
                    lbAsalSayilar.Items.Add(i);
                    asalToplam += i;
                    asalCarpim *= i;
                    asalVarMi = true;
                }

                
                if (islem.MukemmelSayiKontrol(i))
                {
                    lbMukemmelSayilar.Items.Add(i);
                    mukemmelToplam += i;
                    mukemmelCarpim *= i;
                    mukemmelVarMi = true;
                }
            }

            
            IstatistikYazdir(lbTekSayilar, tekToplam, tekVarMi ? tekCarpim : 0);
            IstatistikYazdir(lbCiftSayilar, ciftToplam, ciftVarMi ? ciftCarpim : 0);
            IstatistikYazdir(lbAsalSayilar, asalToplam, asalVarMi ? asalCarpim : 0);
            IstatistikYazdir(lbMukemmelSayilar, mukemmelToplam, mukemmelVarMi ? mukemmelCarpim : 0);
        }

        
        
        private bool GirisleriDogrula(out int baslangic, out int bitis)
        {
            baslangic = 0;
            bitis = 0;

            if (string.IsNullOrWhiteSpace(mtbBaslangic.Text) || string.IsNullOrWhiteSpace(mtbBitis.Text))
            {
                MessageBox.Show("Lütfen başlangıç ve bitiş değerlerini giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(mtbBaslangic.Text, out baslangic) || !int.TryParse(mtbBitis.Text, out bitis))
            {
                MessageBox.Show("Lütfen geçerli tam sayılar giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (baslangic > bitis)
            {
                MessageBox.Show("Başlangıç değeri, bitiş değerinden büyük olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        
        private void EkranTemizle()
        {
            lbTekSayilar.Items.Clear();
            lbCiftSayilar.Items.Clear();
            lbAsalSayilar.Items.Clear();
            lbMukemmelSayilar.Items.Clear();
        }

        
        private void IstatistikYazdir(ListBox liste, long toplam, double carpim)
        {
            liste.Items.Insert(0,"-------------------");
            liste.Items.Insert(0,"Toplam: " + toplam.ToString());

           
            liste.Items.Insert(0,"Çarpım: " + carpim.ToString());
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex < tabControl.TabCount - 1)
                tabControl.SelectedIndex++;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex > 0)
                tabControl.SelectedIndex--;
        }

        private void lbTekSayilar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    

    

