
using System.ComponentModel.DataAnnotations;

namespace KitapTakipUyg.Modeller
{
    public class Kategori
    { 
        public int Id { get; set; }
        [MaxLength(100)] //Attribute
        public string Ad { get; set; }
    }
}
