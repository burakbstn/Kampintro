using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {

            Console.WriteLine("Tebrikler. Sepete Eklendi! : " + urun.Adi );
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat)//bu şekilde yapma çünkü yeni bir bilgi geldiğinde sıçarsın. git urun classına yeni bir propery ekle
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi! : " + urunAdi);


        }
    }


}
