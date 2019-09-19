using System;

namespace QUIZ09092019

{
    class programs
    {
        static void Main(string[] args)
        {
            BangunDatar obj = new BangunDatar();

            obj.LuasPersegi();

            Console.WriteLine();
            Console.WriteLine();
            obj.LuasSegitiga();
            
            Console.WriteLine();
            Console.WriteLine();
            obj.LuasLingkaran();

            BangunRuang objs = new BangunRuang();
            objs.VolumeKubus();

            Console.WriteLine();

            objs.VolumeBalok();
        }
    }
}