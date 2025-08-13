using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C_SayiTahminOyunum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen İsminizi Giriniz");

            string isim = Console.ReadLine();

   Console.WriteLine($"Merhaba {isim},Şimdi bir sayı tutacağım ve bulmanı isteyeceğim.(1 ile 10 arasında)");

    Random rastgeleSayi = new Random();
                    int sayi = rastgeleSayi.Next(1,10);
                    Console.WriteLine("Tuttum !! tahmin et bakalım kaç?");

            while (true)
            { 
                try

                {
                    int tahmin = 0;
                    tahmin = Convert.ToInt32(Console.ReadLine());
                    if (tahmin < sayi)
                    {
                        Console.WriteLine("Daha büyük bir sayı giriniz.");
                        

                    }
                    else if (tahmin > sayi)
                    {
                        Console.WriteLine("Daha küçük bir sayı giriniz.");
                        


                    }
                    else if (tahmin == sayi)
                    {
                        Console.WriteLine("Doğru tahminnnnn!");

                    }

                }
                catch
                {
                    Console.WriteLine("Sadece sayı gir bu bir sayı değil");
                    continue;
                }
                Console.ReadKey();
            }
        }

    }




}

        



    












            






    
    


/* 
 
 Kendi Şifreleme Algoritmamı yazmak istiyorum.

Sessiz harfleri 3 harf ileri çevirsin.
Sesli harfleri 2 harf ileri çevirsin. 
Bu şekilde bir şifreleme algoritması yazacağım.
Tek sayıları 1 ileri çevirsin.
Çift sayıları 2 ileri çevirsin.
 
 
 
 
 
 
 
 
 */
