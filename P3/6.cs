using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_100425_6
{
    class Program
    {
        static void Main(string[] args)
        {
            String jenis;
            Console.Write("Masukkan Jenis Pembelian   : ");
            jenis = Console.ReadLine();

            int jumlahBeli;
            Console.Write("Masukkan Jumlah Beli       : Rp");
            jumlahBeli = int.Parse(Console.ReadLine());

            double diskon = 0;

            if (jenis.ToLower() == "tunai")
            {
                if (jumlahBeli >= 12000000 && jumlahBeli <= 12500000)
                    diskon = 0.025; // 2,5%
                else if (jumlahBeli >= 12500000 && jumlahBeli <= 15000000)
                    diskon = 0.05; // 5%
                else if (jumlahBeli >= 15000000 && jumlahBeli <= 20000000)
                    diskon = 0.075; // 7,5%
                else if (jumlahBeli > 20000000)
                    diskon = 0.10; // 10%
            }
            else if (jenis.ToLower() == "kredit")
            {
                if (jumlahBeli >= 12000000 && jumlahBeli <= 20000000)
                    diskon = 0.08; // 8%
                else if (jumlahBeli > 20000000)
                    diskon = 0.125; // 12,5 %
            }

            double totalDiskon = jumlahBeli * diskon;
            double afterDiskon = jumlahBeli - totalDiskon;

            Console.WriteLine("\nJenis Pembelian  : " + jenis.ToUpper());
            Console.WriteLine($"Jumlah           : Rp{jumlahBeli:N0}");
            Console.WriteLine($"Diskon           : Rp{totalDiskon:N0} ({diskon.ToString("P")})");
            Console.WriteLine($"Total            : Rp{afterDiskon:N0}");
            Console.Read();
        }
    }
}
