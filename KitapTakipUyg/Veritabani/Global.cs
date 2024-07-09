using KitapTakipUyg.Modeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapTakipUyg.Veritabani
{
    public static class Global
    {
        public static KitapContext Ctx = new KitapContext();
        public static Kullanici OturumAcanKullanici = null;
    }
}
