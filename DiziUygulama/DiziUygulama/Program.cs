using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiziUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            Random rnd = new Random();
            int[] a = new int[10];          
            //1 ile 100 arasında üretilen 10 adet rastgele sayı dizi  içerisine girilecek
            for (int i = 0; i < 10; i++)
            {               
                sayi = rnd.Next(1, 100);

                a[i] = sayi;               
                Console.WriteLine(a[i]);
            }
            int b, sayac = 0;
            Console.WriteLine("sayı gir ");
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                if (a[i] == b)
                {
                    sayac++;

                }
            }
            if (sayac != 0)
            {
                Console.WriteLine(b + " sayısından " + sayac + " tane var ");
            }
            else
            {
                Console.WriteLine("girdiginiz sayı bulunmamıştır");
            }
            
            Console.ReadKey();
        }
    }
}
