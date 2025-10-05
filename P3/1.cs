using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_100425_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Percabangan

            /* int input = 8;
            if (input % 2 == 0)
                Console.WriteLine("Bilangan Genap");
            Console.ReadLine(); */

            /* int a = 0;
            if (a == 0) Console.WriteLine("Nilai a = 0");
                Console.WriteLine("Nilai a = 3");
                Console.WriteLine("Nilai a = 2");
            if (a == 1)
                Console.WriteLine("Nilai a = 1");
                Console.WriteLine("Nilai a = 4");
            Console.ReadLine(); */

            int a, b, c;
            Double r;

            Console.Write("Masukkan angka Pertama = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Masukkan angka Kedua = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Masukkan angka Ketiga = ");
            c = int.Parse(Console.ReadLine());

            r = (a + b + c) / 3;

            if ((a >= b) & (a >= c))
                Console.WriteLine("Jadi, Angka tertingginya adalah = " + a);
            
            if ((b > a) & (b > c))
                Console.WriteLine("Jadi, Angka tertingginya adalah = " + b);

            if ((c >= a) && (c >= b))
                Console.WriteLine("Jadi, Angka tertingginya adalah = " + c);

            if ((a <= b) && (a <= c))
                Console.WriteLine("Jadi, Angka terendahnya adalah = " + a);

            if ((b < a) && (b < c))
                Console.WriteLine("Jadi, Angka terendahnya adalah = " + b);

            if ((c <= a) && (c <= b))
                Console.WriteLine("Jadi, Angka terendahnya adalah = " + c);

            Console.WriteLine("Jadi, Rata-ratanya adalah = " + r);
            Console.ReadKey();
        }
    }
}
