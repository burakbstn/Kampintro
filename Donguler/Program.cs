﻿using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Geliştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç için Temel Kurs";
            string kurs3 = "Java";

            string[] kurslar = new string[] { "Yazılım Geliştirici Geliştirme Kampı", "Programlamaya Başlangıç için Temel Kurs", "Java","Python","C#"};

            for (int i = 0; i <kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]); 
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu");
        }
    }
}
