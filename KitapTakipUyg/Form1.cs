using KitapTakipUyg.Veritabani;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace KitapTakipUyg
{
    public partial class Form1 : Form
    {
        //WinApi
        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        //-------------------------------


        public Form1()
        {
            InitializeComponent();

            //daha önce kayýtlanmýþ verileri cache alýr
            Global.Ctx.Kategoriler.Load();
            Global.Ctx.Kitaplar.Load();


            SendMessage(txtAranan.Handle, EM_SETCUEBANNER, 0, "Aradýðýnýz kitabýn adý");
        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            FrmKategoriler form = new FrmKategoriler();
            form.ShowDialog();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Global.Ctx.SaveChanges();
            MessageBox.Show("Veriler kayýt edildi!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmKitaplar form = new FrmKitaplar();
            form.ShowDialog();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            //Where metodu belistilen þarta uyan kayýtlarý getirir
            var liste = Global.Ctx.Kitaplar.Local
                .Where(k => k.Ad.ToLower().Contains(txtAranan.Text.ToLower()))
                .ToList();
            //Contains

            colKategori.DataSource = Global.Ctx.Kategoriler.Local.ToList();
            colKategori.DisplayMember = "Ad";//Kategori.Ad
            colKategori.ValueMember = "Id";//Kategori.Id

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = liste;
            dataGridView1.ReadOnly = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Opacity = 0.85;

            FrmGiris form = new FrmGiris();
            var cevap = form.ShowDialog();//x butonuna basarsam geri ne döner?(DialogResult.Cancel)
        
            if(cevap == DialogResult.OK)//kullanýcý parolayý bildi!
            {
                //
                if (Global.OturumAcanKullanici.Ad == null)
                    btnKullanici.Text = Global.OturumAcanKullanici.KullaniciAdi;
                else 
                    btnKullanici.Text = 
                    Global.OturumAcanKullanici.Ad + " " +
                    Global.OturumAcanKullanici.Soyad;


                Opacity = 1;
            }
            else//Kullanýcý x butonuna bastý
            {
                Application.Exit();
            }
        
        
        }
    }
}
