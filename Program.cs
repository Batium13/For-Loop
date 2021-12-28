using System;

namespace Donguler_For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır.
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                //komutlar
                if(i%2!=0){
                    Console.WriteLine(i);
                }
            }
            // 1-1000 arasındaki tek ve çift sayıların kendi içerisindeki toplamları ekrana yazdır.
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if(i%2==1)
                    tekToplam +=i; // tekToplam +i demektir.
                else
                    ciftToplam +=i; // ciftToplam + i demektir.
            }
            Console.WriteLine("Tek toplam : "+tekToplam);
            Console.WriteLine("Tek toplam : "+ciftToplam);

            //break ve continue..

            for (int i = 1; i <= 10; i++)
            {
                if(i==4)
                break;
                Console.WriteLine(i);
            }

            for (int i = 1; i <= 10; i++)
            {
                if(i==4)
                continue;
                Console.WriteLine(i);
            }
        }
    }
}
