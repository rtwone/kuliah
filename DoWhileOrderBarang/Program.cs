using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBarang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   ORDER BARANG");
            Console.WriteLine("   ------------");
            string namaBarang = "";
            int harga = 0, jumlah = 0, index = 1, jumlahBarang = 0, totalHarga = 0;
            do
            {
                Console.Write($"\n{index}. Nama Barang : ");
                namaBarang = Console.ReadLine();
                if (namaBarang != "")
                {
                    Console.Write("   Harga       : ");
                    harga = int.Parse(Console.ReadLine());
                    Console.Write("   Jumlah      : ");
                    jumlah = int.Parse(Console.ReadLine());
                    jumlahBarang += jumlah;
                    totalHarga += harga * jumlah;
                    Console.WriteLine("   Subtotal    : {0:N}", harga * jumlah);
                    index++;
                }
            } while (namaBarang != "");
            Console.WriteLine("\nTOTAL          :");
            Console.WriteLine("   Jumlah      : " + jumlahBarang);
            Console.WriteLine("   Total       : {0:N}", totalHarga);
            Console.ReadLine();
        }
    }
}
