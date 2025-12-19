using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LATIHAN_UAS
{
    class Program
    {
        // Global Array & Variable
        static string[] namaBarang = new string[100];
        static int[] jumlah = new int[100];
        static int[] harga = new int[100];
        static int[] total = new int[100];
        static int index = 0;

        static void Main(string[] args)
        {
            int pilihan;
            do
            {
                Console.Clear();
                Console.WriteLine("------------------------");
                Console.WriteLine("MENU");
                Console.WriteLine("1 - Input Penjualan");
                Console.WriteLine("2 - Laporan Penjualan");
                Console.WriteLine("3 - Keluar");
                Console.WriteLine("------------------------");
                Console.Write("Masukkan Pilihan : ");
                pilihan = int.Parse(Console.ReadLine());

                switch (pilihan)
                {
                    case 1:
                        inputPenjualan();
                        break;
                    case 2:
                        laporanPenjualan();
                        break;
                }
            } while (pilihan != 3);
            Console.ReadLine();
        }

        static void inputPenjualan()
        {
            Console.WriteLine("    WARUNG ATUN");
            Console.WriteLine("    -----------\n");
            Console.Write("Masukkan Pembeli    : ");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Tanggal             : " + DateTime.Now.ToString("dd MMMM yyyy") + "\n");
            
            while (true)
            {
                Console.Write($"    {index + 1}. Nama Barang  : ");
                string nama = Console.ReadLine();

                if (nama == "")
                    break;

                namaBarang[index] = nama;
                
                Console.Write("       Harga        : ");
                harga[index] = int.Parse(Console.ReadLine());

                Console.Write("       Jumlah       : ");
                jumlah[index] = int.Parse(Console.ReadLine());

                total[index] = harga[index] * jumlah[index];

                Console.WriteLine("       Total        : " + total[index]);
                index++;
            }

            Console.WriteLine("Enter untuk kembali ke menu...");
            Console.ReadLine();
        }

        static void laporanPenjualan()
        {
            Console.WriteLine("NO      NAMA BARANG      JUMLAH      HARGA      TOTAL");
            Console.WriteLine("--------------------------------------------------------");
            
            int grandTotal = 0;

            for (int i = 0; i < index; i++)
            {
                Console.WriteLine($"{(i + 1)}          {namaBarang[i]}            {jumlah[i]}            {harga[i]}            {total[i]}");
                grandTotal += total[i];
            }

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Grand Total                                  : " + grandTotal);

            Console.WriteLine("Enter untuk kembali ke menu...");
            Console.ReadLine();
            Console.WriteLine("--------------------------------------------------------");
        }
    }
}
