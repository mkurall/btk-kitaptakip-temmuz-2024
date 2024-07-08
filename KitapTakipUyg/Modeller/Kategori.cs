
using System.ComponentModel.DataAnnotations;

namespace KitapTakipUyg.Modeller
{
    public class Kategori
    { 
        public int Id { get; set; }//PK
        [MaxLength(100)] //Attribute
        public string Ad { get; set; }
        public List<Kitap> Kitaplar { get; set; } = new();
    }
}
