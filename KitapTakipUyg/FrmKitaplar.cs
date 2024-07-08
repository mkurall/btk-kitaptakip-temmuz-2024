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
            dataGridView1.DataSource = Global.Ctx.Kitaplar.Local.ToBindingList();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
