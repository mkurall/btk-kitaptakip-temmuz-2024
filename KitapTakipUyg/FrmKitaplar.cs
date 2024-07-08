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
            if(e.ColumnIndex == colSil.Index)
            {
                Kitap kitap =  dataGridView1.Rows[e.RowIndex].DataBoundItem as Kitap;

                if(kitap != null)
                {
                    var cevap = MessageBox.Show(kitap.Ad + " adlı kitabı silmek istediğinize " +
                        "emin misiniz?","Dikkat", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if(cevap == DialogResult.Yes)
                    {
                        Global.Ctx.Kitaplar.Remove(kitap);
                    }
                }
            }
        }
    }
}
