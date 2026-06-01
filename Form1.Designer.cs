namespace nyp_odev1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnCalistir = new System.Windows.Forms.Button();
            this.mtbBitis = new System.Windows.Forms.MaskedTextBox();
            this.mtbBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.labelbit = new System.Windows.Forms.Label();
            this.labelbas = new System.Windows.Forms.Label();
            this.btnIleri = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbTekSayilar = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbCiftSayilar = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbAsalSayilar = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lbMukemmelSayilar = new System.Windows.Forms.ListBox();
            this.groupBox.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox.Controls.Add(this.btnCalistir);
            this.groupBox.Controls.Add(this.mtbBitis);
            this.groupBox.Controls.Add(this.mtbBaslangic);
            this.groupBox.Controls.Add(this.labelbit);
            this.groupBox.Controls.Add(this.labelbas);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox.Location = new System.Drawing.Point(1, 2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(787, 160);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Giriş Bilgileri";
            // 
            // btnCalistir
            // 
            this.btnCalistir.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCalistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalistir.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalistir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalistir.Location = new System.Drawing.Point(488, 48);
            this.btnCalistir.Name = "btnCalistir";
            this.btnCalistir.Size = new System.Drawing.Size(147, 59);
            this.btnCalistir.TabIndex = 4;
            this.btnCalistir.Text = "ÇALIŞTIR";
            this.btnCalistir.UseVisualStyleBackColor = false;
            this.btnCalistir.Click += new System.EventHandler(this.btnCalistir_Click);
            // 
            // mtbBitis
            // 
            this.mtbBitis.Location = new System.Drawing.Point(195, 84);
            this.mtbBitis.Mask = "000000000000";
            this.mtbBitis.Name = "mtbBitis";
            this.mtbBitis.Size = new System.Drawing.Size(176, 27);
            this.mtbBitis.TabIndex = 3;
            // 
            // mtbBaslangic
            // 
            this.mtbBaslangic.Location = new System.Drawing.Point(195, 31);
            this.mtbBaslangic.Mask = "00000000000";
            this.mtbBaslangic.Name = "mtbBaslangic";
            this.mtbBaslangic.Size = new System.Drawing.Size(176, 27);
            this.mtbBaslangic.TabIndex = 2;
            // 
            // labelbit
            // 
            this.labelbit.AutoSize = true;
            this.labelbit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelbit.ForeColor = System.Drawing.Color.Black;
            this.labelbit.Location = new System.Drawing.Point(149, 87);
            this.labelbit.Name = "labelbit";
            this.labelbit.Size = new System.Drawing.Size(40, 20);
            this.labelbit.TabIndex = 1;
            this.labelbit.Text = "Bitiş:";
            // 
            // labelbas
            // 
            this.labelbas.AutoSize = true;
            this.labelbas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelbas.ForeColor = System.Drawing.Color.Black;
            this.labelbas.Location = new System.Drawing.Point(114, 31);
            this.labelbas.Name = "labelbas";
            this.labelbas.Size = new System.Drawing.Size(75, 20);
            this.labelbas.TabIndex = 0;
            this.labelbas.Text = "Başlangıç:";
            // 
            // btnIleri
            // 
            this.btnIleri.BackColor = System.Drawing.Color.SandyBrown;
            this.btnIleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIleri.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIleri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIleri.Location = new System.Drawing.Point(454, 168);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(45, 40);
            this.btnIleri.TabIndex = 7;
            this.btnIleri.Text = ">";
            this.btnIleri.UseVisualStyleBackColor = false;
            this.btnIleri.Click += new System.EventHandler(this.btnIleri_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.SandyBrown;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGeri.Location = new System.Drawing.Point(412, 168);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(45, 40);
            this.btnGeri.TabIndex = 6;
            this.btnGeri.Text = "<";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Location = new System.Drawing.Point(1, 189);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(787, 278);
            this.tabControl.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbTekSayilar);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(779, 249);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tek Sayılar";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lbTekSayilar
            // 
            this.lbTekSayilar.BackColor = System.Drawing.Color.SeaShell;
            this.lbTekSayilar.FormattingEnabled = true;
            this.lbTekSayilar.ItemHeight = 16;
            this.lbTekSayilar.Location = new System.Drawing.Point(2, 0);
            this.lbTekSayilar.Name = "lbTekSayilar";
            this.lbTekSayilar.Size = new System.Drawing.Size(774, 228);
            this.lbTekSayilar.TabIndex = 0;
            this.lbTekSayilar.SelectedIndexChanged += new System.EventHandler(this.lbTekSayilar_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbCiftSayilar);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(779, 249);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Çift Sayılar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbCiftSayilar
            // 
            this.lbCiftSayilar.BackColor = System.Drawing.Color.SeaShell;
            this.lbCiftSayilar.FormattingEnabled = true;
            this.lbCiftSayilar.ItemHeight = 16;
            this.lbCiftSayilar.Location = new System.Drawing.Point(6, 3);
            this.lbCiftSayilar.Name = "lbCiftSayilar";
            this.lbCiftSayilar.Size = new System.Drawing.Size(767, 244);
            this.lbCiftSayilar.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbAsalSayilar);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(779, 249);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Asal Sayılar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbAsalSayilar
            // 
            this.lbAsalSayilar.BackColor = System.Drawing.Color.SeaShell;
            this.lbAsalSayilar.FormattingEnabled = true;
            this.lbAsalSayilar.ItemHeight = 16;
            this.lbAsalSayilar.Location = new System.Drawing.Point(6, 3);
            this.lbAsalSayilar.Name = "lbAsalSayilar";
            this.lbAsalSayilar.Size = new System.Drawing.Size(767, 244);
            this.lbAsalSayilar.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lbMukemmelSayilar);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(779, 249);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Mükemmel Sayılar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lbMukemmelSayilar
            // 
            this.lbMukemmelSayilar.BackColor = System.Drawing.Color.SeaShell;
            this.lbMukemmelSayilar.FormattingEnabled = true;
            this.lbMukemmelSayilar.ItemHeight = 16;
            this.lbMukemmelSayilar.Location = new System.Drawing.Point(2, 3);
            this.lbMukemmelSayilar.Name = "lbMukemmelSayilar";
            this.lbMukemmelSayilar.Size = new System.Drawing.Size(771, 244);
            this.lbMukemmelSayilar.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIleri);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.MaskedTextBox mtbBitis;
        private System.Windows.Forms.MaskedTextBox mtbBaslangic;
        private System.Windows.Forms.Label labelbit;
        private System.Windows.Forms.Label labelbas;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCalistir;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox lbTekSayilar;
        private System.Windows.Forms.ListBox lbCiftSayilar;
        private System.Windows.Forms.ListBox lbAsalSayilar;
        private System.Windows.Forms.ListBox lbMukemmelSayilar;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnIleri;
    }
}

