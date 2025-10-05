using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_130925_3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a, b;
            Console.Write("\n\nKalkulator Penjumlahan\n");
            Console.ReadLine();
            Console.Write("Angka 1 : ");
            a = Convert.ToByte(Console.ReadLine());
            Console.Write("Angka 2 : ");
            b = Convert.ToByte(Console.ReadLine());
            Console.Write("Hasil   : {0}", a + b);
            Console.Read();

            byte c, d;
            Console.Write("\n\nKalkulator Perkalian\n");
            Console.ReadLine();
            Console.Write("Angka 1 : ");
            c = Convert.ToByte(Console.ReadLine());
            Console.Write("Angka 2 : ");
            d = Convert.ToByte(Console.ReadLine());
            Console.Write("Hasil   : {0}", c * d);
            Console.Read();

            byte panjang, lebar;
            Console.WriteLine("\nMenghitung Luas 2 Keliling Lingkaran");
            Console.ReadLine();
            Console.Write("Panjang  : ");
            panjang = Convert.ToByte(Console.ReadLine());
            Console.Write("Lebar    : ");
            lebar = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("\nLuas     : {0}", panjang * lebar);
            Console.Write("Keliling : {0}", 2 * (panjang + lebar));
            Console.Read();
        }
    }
}
