using KitapTakipUyg.Veritabani;
using Microsoft.EntityFrameworkCore;

namespace KitapTakipUyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //daha önce kayýtlanmýþ verileri cache alýr
            Global.Ctx.Kategoriler.Load();
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
    }
}
