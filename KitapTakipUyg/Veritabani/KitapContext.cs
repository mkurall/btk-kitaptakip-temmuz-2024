using KitapTakipUyg.Modeller;
using Microsoft.EntityFrameworkCore;


namespace KitapTakipUyg.Veritabani
{
    public class KitapContext : DbContext
    {
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //sen burayı override ediyorsun ama
            //temeldeki metodun gövdesini de çalıştır
            //base.OnConfiguring(optionsBuilder);
            string root = Application.StartupPath;
            optionsBuilder.UseSqlite($"Data Source ={root}\\kitaplar.db;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategori>()//fluent
                 .HasMany(e => e.Kitaplar)
                 .WithOne(e => e.Kategori)
                 .HasForeignKey(e => e.KategoriId)
                 .HasPrincipalKey(e => e.Id);

            //modelBuilder.Entity<Kitap>()
            //    .HasOne(e => e.Kategori)
            //    .WithMany(e => e.Kitaplar)
            //    .HasForeignKey(e => e.KategoriId)
            //    .HasPrincipalKey( e => e.Id);
        }
    }
}
