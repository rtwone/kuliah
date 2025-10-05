using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_270925_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            i = 6 | 13 & 5;
            Console.WriteLine(i);
            Console.Read();

            /*
             Susunan bit dari nilai 6   =  0 1 1 0
             Susunan bit dari nilai 13  =  1 1 0 1
             Susunan bit dari nilai 5   =  0 1 0 1
                                           ------- | &
             Hasil operasi bit -> 7        0 1 1 1
             */
        }
    }
}
