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
            //                     Veritabanı  cache  SaveChanges
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

                //listBox1.SelectedItem = null;//yeni eleman eklemek için
            }
            else
            {
                kat.Ad = txtKategoriAdi.Text;

                listBox1.DataSource = null;
                var liste = Global.Ctx.Kategoriler.Local.ToBindingList();

                listBox1.DataSource = liste;
                listBox1.DisplayMember = "Ad";
                listBox1.ValueMember = "Id";

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
            else//veri yok ise
            {
                btnEkleGuncelle.Text = "Ekle";
                txtKategoriAdi.Text = "";
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItem = null;
            txtKategoriAdi.Focus();//text boxa imleci konumlandırır
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            //Diyalog pencerelerinde geriye bişey döndüğünde form kapanır
            DialogResult = DialogResult.OK;

            //Close();
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                listBox1.SelectedIndex = listBox1.IndexFromPoint(e.Location);
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kategori kat = listBox1.SelectedItem as Kategori;

            if(kat!=null)
            {
                DialogResult cevap =  MessageBox.Show($"{kat.Ad} adlı kategoriyi silmek istediği" +
                    $"nize emin misiniz?", "Dikkat", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if(cevap == DialogResult.Yes)
                {
                    Global.Ctx.Kategoriler.Remove(kat);//local cache'den siler
                    //Ne zaman: SaveChanges() --> DELETE FROM Kategoriler Where Id = ?
                }
            }
        }
    }
}
