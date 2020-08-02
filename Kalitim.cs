using System;
using CSharp;
using System.IO;

namespace Calisma18_Inherance
{
    class Memeli
    {
        private double mBoy;
        private double mAgirlik;
        private string mCinsiyet;
        private string mYer;
        DateTime mDogumTarihi;

        public double Boy
        {
            get
            {
                return mBoy;
            }
            set
            {
                mBoy = value;
            }
        }
        public double Agirlik
        {
            get
            {
                return mAgirlik;
            }
            set
            {
                mAgirlik = value;
            }
        }
        public string Cinsiyet
        {
            get
            {
                return mCinsiyet;
            }
            set
            {
                mCinsiyet = value;
            }
        }
        public string Yer
        {
            get
            {
                return mYer;
            }
            set
            {
                mYer = value;
            }
        }

        public DateTime DogumTarihi
        {
            get
            {
                return mDogumTarihi;
            }
            set
            {
                mDogumTarihi = value;
            }
        }
        public int Yas
        {
            get
            {
                TimeSpan fark = DateTime.Today - DogumTarihi;
                return fark.Days / 365;
            }

        }
        public void OzellikGoster()
        {
            Console.WriteLine("Boy     = {0}", Boy);
            Console.WriteLine("Agirlik = {0}", Agirlik);
        }
    }
    class Kedi : Memeli
    {
        private string mAdi;
        private string mTuru;
        private long mKayitNo;
        public string Adi
        {
            get
            {

                return mAdi;
            }
            set
            {
                if (!RastgeleSayi.Helper.KarakterSayisi(value, 3))
                    return;
                mAdi = value;
            }
        }
        public string Turu
        {
            get
            {
                return mTuru;
            }
            set
            {
                mTuru = value;
            }
        }
        public long KayitNo
        {
            get
            {
                return mKayitNo;
            }
            set
            {
                mKayitNo = value;
            }
        }

        public void TuruGoster()
        {
            Console.WriteLine("Türü   ={0} Kedisi", mTuru);
        }
        public void KayitYap(string dosya)
        {
            FileStream fs = new FileStream(dosya, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine($"{KayitNo};{Adi};{Boy};{Agirlik};{Cinsiyet};{Turu};{Convert.ToString(DogumTarihi)};{Yas};{Yer};");

            //sw.Flush();
            sw.Close();
            Console.WriteLine(">> Kaydetme işleminiz başarı ile gerçekleştirilmiştir.");
        }
    }

}
