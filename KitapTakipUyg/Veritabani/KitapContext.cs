using KitapTakipUyg.Modeller;
using Microsoft.EntityFrameworkCore;


namespace KitapTakipUyg.Veritabani
{
    public class KitapContext : DbContext
    {
        public DbSet<Kategori> Kategoriler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //sen burayı override ediyorsun ama
            //temeldeki metodun gövdesini de çalıştır
            //base.OnConfiguring(optionsBuilder);
            string root = Application.StartupPath;
            optionsBuilder.UseSqlite($"Data Source ={root}\\kitaplar.db;");
        }
    }
}
