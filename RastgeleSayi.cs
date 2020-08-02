using System;

namespace CSharp
{
    public class RastgeleSayi
    {
        private Random rnd = new Random();
        private int mSayi;
        public long Sayi
        {
            get
            {
                return mSayi;
            }
        }
        public RastgeleSayi()
        {
            mSayi = rnd.Next(0, 1000000);
        }
        public void Degistir()
        {
            mSayi = rnd.Next(0, 1000000);

        }
        public static class Helper
        {
            public static bool KarakterSayisi(string input, int boyut)
            {
                if (input.Length < boyut)
                {
                    Console.WriteLine($"{input} en az {boyut} karakterden oluşmalıdır!");
                    return false;
                }
                else
                    return true;
            }
        }


    }
}
