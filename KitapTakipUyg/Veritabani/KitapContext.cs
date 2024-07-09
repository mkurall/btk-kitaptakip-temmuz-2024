using KitapTakipUyg.Modeller;
using Microsoft.EntityFrameworkCore;


namespace KitapTakipUyg.Veritabani
{
    public class KitapContext : DbContext
    {
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //sen burayı override ediyorsun ama
            //temeldeki metodun gövdesini de çalıştır
            //base.OnConfiguring(optionsBuilder);
            //string root = Application.StartupPath;

            string appDataFolder = Environment.
                GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\BtkAkademi";

            if(!Directory.Exists(appDataFolder))
                Directory.CreateDirectory(appDataFolder);


            optionsBuilder.UseSqlite($"Data Source ={appDataFolder}\\kitaplar.db;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategori>()//fluent
                 .HasMany(e => e.Kitaplar)
                 .WithOne(e => e.Kategori)
                 .HasForeignKey(e => e.KategoriId)
                 .HasPrincipalKey(e => e.Id);

            //çekirdek veri
            modelBuilder.Entity<Kullanici>().HasData(
                new Kullanici() { 
                    Id = 1, KullaniciAdi = "admin", 
                    Parola = "1234", Yetki = YetkiTurleri.Yonetici}
                );

            //modelBuilder.Entity<Kitap>()
            //    .HasOne(e => e.Kategori)
            //    .WithMany(e => e.Kitaplar)
            //    .HasForeignKey(e => e.KategoriId)
            //    .HasPrincipalKey( e => e.Id);
        }
    }
}
