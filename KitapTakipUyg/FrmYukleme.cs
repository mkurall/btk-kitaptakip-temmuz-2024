using KitapTakipUyg.Veritabani;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapTakipUyg
{
    public partial class FrmYukleme : Form
    {
        int sure = 0;

        public FrmYukleme()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure++;

            if (sure == 1)
                lblBilgi.Text = "Uygulama başlatılıyor...";
            else if (sure == 2)
            {
                lblBilgi.Text = "Veritabanı kontrol ediliyor...";
                //veritabanı yok ise oluştur
                Global.Ctx.Database.EnsureCreated();
            }
            else if (sure == 3)
                lblBilgi.Text = "Ayarlar okunuyor...";
            else
                lblBilgi.Text = "Çok az kaldı...";

            progressBar1.Value = sure;//0--->4

            if (sure == 4)
            {
                timer1.Stop();
                Close();
            }
        }

        private void FrmYukleme_Shown(object sender, EventArgs e)
        {
            timer1.Start();//işlem başladı
        }
    }
}
