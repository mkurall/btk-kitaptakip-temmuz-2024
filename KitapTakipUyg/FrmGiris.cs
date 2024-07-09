using KitapTakipUyg.Modeller;
using KitapTakipUyg.Veritabani;

namespace KitapTakipUyg
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void btnOturumAc_Click(object sender, EventArgs e)
        {
            //Asıl amaç geriye "DialogResult.OK" dönmek

            Kullanici kullanici = Global.Ctx.Kullanicilar
                .FirstOrDefault(
                k =>
                k.KullaniciAdi.ToLower() == txtKullaniciAdi.Text.ToLower() &&
                k.Parola == txtParola.Text);

            if (kullanici != null)//kullnıcı bulundu
            {
                //Daha sonra bu kullanıcıyı kullanmak için sakla
                Global.OturumAcanKullanici = kullanici;
                DialogResult = DialogResult.OK;
            }
            else
            {
                lblHata.Visible = true;
            }
        }
    }
}
