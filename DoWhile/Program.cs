using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ORDER BARANG");
            Console.WriteLine("============");

            int hargaBarang, jumlahBarang, totalJumlah = 0, totalHarga = 0, index = 1;
            string namaBarang = "";

            do
            {
                Console.Write($"\n{index}. Nama Barang : ");
                index += 1;
                namaBarang = Console.ReadLine();

                if (namaBarang == "") break;

                Console.Write("   Harga       : ");
                hargaBarang = int.Parse(Console.ReadLine());
                Console.Write("   Jumlah      : ");
                jumlahBarang = int.Parse(Console.ReadLine());
                Console.WriteLine("   Sub Total   : {0}", hargaBarang * jumlahBarang);

                totalJumlah += jumlahBarang;
                totalHarga += hargaBarang * jumlahBarang;
            } while (namaBarang != "");
            if (namaBarang == "")
            {
                Console.WriteLine("Total          :");
                Console.WriteLine("   Jumlah      : {0}", totalJumlah);
                Console.WriteLine("   Total Harga : {0:N}", totalHarga);
                Console.ReadLine();
            }
        }
    }
}
