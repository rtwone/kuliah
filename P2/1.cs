using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_270925_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int b, a = 2;
            b = a++ + a-- + a--;
            Console.WriteLine(b);
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
