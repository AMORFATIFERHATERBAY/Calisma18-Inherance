using System;
using CSharp;
using System.IO;

namespace Calisma18_Inherance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World...");
            RastgeleSayi rst = new RastgeleSayi();

            // Console.WriteLine(rst.Sayi);
            // rst.Degistir();
            // Console.WriteLine(rst.Sayi);

            // Console.WriteLine("\n----------------------\n");

            // Kedi kedi1 = new Kedi();

            // kedi1.Boy = 0.25;
            // kedi1.Agirlik = 3.2;
            // kedi1.Turu = "Van";

            // kedi1.OzellikGoster();
            // kedi1.TuruGoster();

            // Console.WriteLine("\n----------------------\n");

            // Kedi kedi2 = new Kedi();

            // kedi2.Boy = 0.30;
            // kedi2.Agirlik = 3.5;
            // kedi2.Turu = "Skotish";

            // kedi2.OzellikGoster();
            // kedi2.TuruGoster();
            string secim;
            do
            {
                Console.WriteLine("\nKaydetmek için          --> c");
                Console.WriteLine("Okumak&Arama için       --> r");
                Console.WriteLine("Güncelleme için         --> u");
                Console.WriteLine("Silmek için             --> d");
                Console.WriteLine("\nProgramdan çıkmak için  --> Q/q\n");

                Console.Write("İşleminizi seçiniz : ");
                secim = Console.ReadLine().ToLower();
                Console.WriteLine();
                if (secim == "c")
                {

                    Kedi kedi1 = new Kedi();

                    kedi1.KayitNo = rst.Sayi;
                    Console.WriteLine("KayıtNo        :{0}", kedi1.KayitNo);


                    bool adiDogruMu = true;
                    do
                    {

                        Console.Write("Adini giriniz  :");
                        kedi1.Adi = Console.ReadLine();
                        adiDogruMu = string.IsNullOrEmpty(kedi1.Adi);

                    } while (adiDogruMu);

                    Console.Write("Türünü giriniz : ");
                    kedi1.Turu=Console.ReadLine();

                    

                }
            } while (secim != "q");


        }
    }
}
