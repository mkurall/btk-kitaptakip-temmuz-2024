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
                .Where(k => k.Ad.ToLower() == txtAranan.Text.ToLower())
                .ToList();

            dataGridView1.DataSource = liste;
        }
    }
}
