using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_100425_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Percabangan

            String barang;
            int harga, jumlah;
            Console.Write("BARANG  : ");
            barang = Console.ReadLine();

            if (barang.ToUpper() == "MAKANAN")
            {
                Console.WriteLine("HARGA   : Rp10.000");
                harga = 10000;
            }
            else
            {
                Console.WriteLine("HARGA   : Rp2.000");
                harga = 2000;
            }

            Console.Write("JUMLAH  : ");
            jumlah = byte.Parse(Console.ReadLine());
            Console.WriteLine("TOTAL   : Rp" + harga * jumlah);
            Console.Read();
        }
    }
}
