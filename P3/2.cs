using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_100425_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Percabangan

            byte nilai;
            Console.Write("NPM     : ");
            Console.ReadLine();
            Console.Write("NAMA    : ");
            Console.ReadLine();
            Console.Write("NILAI   : ");
            nilai = byte.Parse(Console.ReadLine());
            if (nilai > 80)
                Console.Write("STATUS  : Baik");
            else
                Console.Write("STATUS  : Buruk");
            Console.Read();
        }
    }
}
