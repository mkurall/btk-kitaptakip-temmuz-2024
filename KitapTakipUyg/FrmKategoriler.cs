using KitapTakipUyg.Modeller;
using KitapTakipUyg.Veritabani;
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
    public partial class FrmKategoriler : Form
    {
        public FrmKategoriler()
        {
            InitializeComponent();
        }

        private void FrmKategoriler_Load(object sender, EventArgs e)
        {
            //
            //Global.Ctx.Kategoriler.ToList();
            //Form uygulamalarında Ef Local cache i kullanılabilir
            //Yeni eklenen veriler veya değişiklikler bu cache üzerinde saklanır 
            //Kaydet dediğinizde veriler cache üzerinden Veritabanına gönderilir
            var liste = Global.Ctx.Kategoriler.Local.ToBindingList();

            listBox1.DataSource = liste;
            listBox1.DisplayMember = "Ad";
            listBox1.ValueMember = "Id";
        }

        private void btnEkleGuncelle_Click(object sender, EventArgs e)
        {
            var kat = new Kategori();
            //kat.Id = Otomatik Artan Sayı
            kat.Ad = txtKategoriAdi.Text;

            Global.Ctx.Kategoriler.Add(kat);
        }

        private void txtKategoriAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                btnEkleGuncelle_Click(sender, EventArgs.Empty);
        }
    }
}
