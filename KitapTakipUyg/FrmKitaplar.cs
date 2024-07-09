using KitapTakipUyg.Modeller;
using KitapTakipUyg.Veritabani;


namespace KitapTakipUyg
{
    public partial class FrmKitaplar : Form
    {
        public FrmKitaplar()
        {
            InitializeComponent();
        }

        private void FrmKitaplar_Load(object sender, EventArgs e)
        {
            colKategori.DataSource = Global.Ctx.Kategoriler.Local.ToList();
            colKategori.DisplayMember = "Ad";
            colKategori.ValueMember = "Id";

            var katListe = Global.Ctx.Kategoriler.Local.ToList();
            katListe.Insert(0, new Kategori() { Ad = "Tümü", Id = -1 });

            comboBox1.DataSource = katListe;
            comboBox1.DisplayMember = "Ad";
            comboBox1.ValueMember = "Id";


            dataGridView1.AutoGenerateColumns = false;//sadece benim eklediğim sütunlar görünsün
            var list = Global.Ctx.Kitaplar.Local.ToBindingList();

            Kitap son = list.LastOrDefault();

            if (son != null)
            {
                if (string.IsNullOrEmpty(son.Ad))
                {
                    list.Remove(son);
                }
            }

            dataGridView1.DataSource = list;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == colSil.Index)
            {
                Kitap kitap = dataGridView1.Rows[e.RowIndex].DataBoundItem as Kitap;

                if (kitap != null)
                {
                    var cevap = MessageBox.Show(kitap.Ad + " adlı kitabı silmek istediğinize " +
                        "emin misiniz?", "Dikkat", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (cevap == DialogResult.Yes)
                    {
                        //kitap eğer local cache üzerinde var ise sil
                        if (Global.Ctx.Kitaplar.Local.Contains(kitap))
                            Global.Ctx.Kitaplar.Remove(kitap);
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kategori seciliKat = comboBox1.SelectedItem as Kategori;

            if (seciliKat != null) 
            {
                dataGridView1.AutoGenerateColumns = false;//sadece benim eklediğim sütunlar görünsün

                if (seciliKat.Id == -1)
                {
                    var list = Global.Ctx.Kitaplar.Local.ToBindingList();//düzenlenebilir
                    dataGridView1.DataSource = list;
                }
                else
                {
                    var list = Global.Ctx.Kitaplar.Local.Where(x => x.KategoriId == seciliKat.Id)
                        .ToList();//sabit liste

                    dataGridView1.DataSource = list;
                }
            }
        }
    }
}
