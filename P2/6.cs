using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_270925_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 7;
            i = i >> 2;
            Console.WriteLine(i);
            Console.Read();

            /*
             Susunan bit dari nilai 7    0 1 1 1
             Hasil operasi bit -> 1      0 0 0 1
             */
        }
    }
}
