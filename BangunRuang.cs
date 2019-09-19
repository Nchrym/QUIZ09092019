using System;

namespace QUIZ09092019
{
    class BangunRuang
    {
        public void VolumeKubus()
        {
            int sisi, luas;

            Console.WriteLine("menghitung volume Kubus");
            Console.WriteLine("------------------------");

            Console.Write("Masukan nilai sisi : ");
            sisi = Convert.ToInt32(Console.ReadLine());

            luas = sisi * sisi * sisi;
            Console.WriteLine("volume Kubus adalah "+luas);
        }

        public void VolumeBalok()
        {
            int panjang, lebar, tinggi, luas;

            Console.WriteLine("menghitung volume Balok");
            Console.WriteLine("-------------------------");

            Console.Write("Masukan nilai panjang : ");
            panjang = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan nilai lebar : ");
            lebar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan nilai tinggi : ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            luas = panjang * lebar * tinggi;
            Console.WriteLine("volume Kubus adalah "+luas);
        }
    }
}