using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_270925_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5; int b = 7;
            if ((a < 2) || (b++ < 10)) b += 2;
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
