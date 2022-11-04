using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = false;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu Göster");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu öster");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu Göster");
            }
            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            
            Console.WriteLine(kategoriEtiketi);

        }
    }
}
