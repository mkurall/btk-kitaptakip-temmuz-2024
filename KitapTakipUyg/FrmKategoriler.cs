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
            Kategori kat = listBox1.SelectedItem as Kategori;
            if (kat == null)//seçili eleman yok ise (Ekle butonu)
            {
                kat = new Kategori();
                //kat.Id = Otomatik Artan Sayı
                kat.Ad = txtKategoriAdi.Text;

                Global.Ctx.Kategoriler.Add(kat);

                listBox1.SelectedItem = null;//yeni eleman eklemek için
            }
            else
            {
                kat.Ad = txtKategoriAdi.Text;
            }
        }

        private void txtKategoriAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnEkleGuncelle_Click(sender, EventArgs.Empty);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //seçili eleman yok ise null gelir (as)
            Kategori kat = listBox1.SelectedItem as Kategori;

            if (kat != null)//var ise
            {
                txtKategoriAdi.Text = kat.Ad;
                btnEkleGuncelle.Text = "Güncelle";
            }
            else
            {
                btnEkleGuncelle.Text = "Ekle";
                txtKategoriAdi.Text = "";
            }
        }
    }
}
