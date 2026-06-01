using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using nyp_odev2;

namespace nyp_odev2
{
    public partial class Form1: Form
    {

        BankaYonetim banka = new BankaYonetim();
        public Form1()
        {
            InitializeComponent();
            txtMusteriAd.MaxLength = 50;
            txtMusteriSoyad.MaxLength = 50;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (string.IsNullOrWhiteSpace(txtMusteriAd.Text) ||string.IsNullOrWhiteSpace(txtMusteriSoyad.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               
                
                string ad = txtMusteriAd.Text;
                string soyad = txtMusteriSoyad.Text;

                int musteriNo = BankaYonetim.YeniMusteriNoUret();

                MusteriBilgileri yeniMusteri;
                if (rbBireysel.Checked)
                {
                    yeniMusteri = new BireyselMusteri(ad, soyad, musteriNo);
                }
                else if (rbTicari.Checked)
                {
                    yeniMusteri = new TicariMusteri(ad, soyad, musteriNo);
                }
                else
                {
                    MessageBox.Show("Lütfen müşteri tipini seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                banka.MusteriEkle(yeniMusteri);

                MessageBox.Show("Müşteri başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                txtMusteriAd.Clear();
                txtMusteriSoyad.Clear();
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Müşteri Numarası sadece sayılardan oluşmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
    

