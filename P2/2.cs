using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_270925_2
{
    class Program
    {
        static void Main(string[] args)
        {
            short nilai = 0;
            Console.Write("Masukkan Nilai : ");
            nilai = short.Parse(Console.ReadLine());
            if (nilai >= 0)
                Console.WriteLine("{0} termasuk bilangan positif", nilai);
            else
                Console.WriteLine("{0} termasuk bilangan negatif", nilai);
            Console.Read();
        }
    }
}
