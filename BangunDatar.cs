using System;

namespace QUIZ09092019
{
   class BangunDatar
    {
            public void LuasPersegi()
            {
           Console.WriteLine("menghitung Luas Persegi");
           Console.WriteLine("-------------------------");

            int sisi;
            Console.Write("Masukan nilai sisi : ");
            sisi = Convert.ToInt32(Console.ReadLine());

           int luas = sisi * sisi;

            Console.WriteLine("Luas Persegi adalah "+luas);
        }

        public void LuasSegitiga()
        {
            int alas, tinggi, luas;

            Console.WriteLine("menghitung Luas Segitiga");
            Console.WriteLine("-------------------------");

           Console.Write("Masukan nilai alas : ");
           alas = Convert.ToInt32(Console.ReadLine());

           Console.Write("Masukan nilai tinggi : ");
           tinggi = Convert.ToInt32(Console.ReadLine());

           luas = alas * tinggi/2;
           Console.WriteLine("Luas Segitiga adalah "+luas);
        }

        public void LuasLingkaran()
        {
            double phi = 3.14;
            double luas;
            int r;

            Console.WriteLine("menghitung Luas Lingkaran");
            Console.WriteLine("---------------------------");

            Console.Write("Masukan nilai r : ");
            r = Convert.ToInt32(Console.ReadLine());

            luas = phi * r * r;
            Console.WriteLine("Luas lingkaran adalah "+luas);
        }
    } 
}
    

