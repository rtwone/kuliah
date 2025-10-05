using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_270925_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5; int b = 7; int c = 3; int max, max2, m;
            max = a > b ? a : b;
            max2 = b > c ? b : c;
            m = a > b ? (c > a ? c : a) : (c > b ? c : b);
            Console.WriteLine(max);
            Console.WriteLine(max2);
            Console.WriteLine(m);
            Console.ReadLine();
        }
    }
}
