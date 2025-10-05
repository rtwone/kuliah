using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_100425_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Percabangan

            char jenisKelamin = 'P';

            if (jenisKelamin == 'L')
                Console.WriteLine("Cowok");
            else if (jenisKelamin == 'P')
                Console.WriteLine("Cewek");
            else
                Console.WriteLine("Boti");
            Console.Read();
        }
    }
}
