using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapTakipUyg.Modeller
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public YetkiTurleri Yetki { get; set; }
    }

    public enum YetkiTurleri
    {
        Yonetici = 0,
        Personel  = 1
    };
}
