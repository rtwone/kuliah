using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS_PRAKTIKUM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PERSWAAN MOBIL IRFAN");
            Console.WriteLine("====================");

            string namaPeminjam, namaMobil = null, jenisMobil = null;
            int indexJenisMobil, indexNamaMobil, hargaSewa = 0, lamaPinjam;

            Console.Write("Masukkan Nama Peminjam : ");
            namaPeminjam = Console.ReadLine();

            Console.WriteLine("Masukkan Jenis Mobil   : 1. Pickup");
            Console.WriteLine("                       : 2. Minibus");
            Console.WriteLine("                       : 3. Sedan");
            Console.Write("                       : ");
            indexJenisMobil = int.Parse(Console.ReadLine());

            if (indexJenisMobil == 1)
            {
                jenisMobil = "Pickup";
                Console.WriteLine("Mobil Tersedia         : 1. Mitsubishi L300");
                Console.WriteLine("                       : 2. Toyota Hilux");
                Console.Write("                       : ");
                indexNamaMobil = int.Parse(Console.ReadLine());
                if (indexNamaMobil == 1) { namaMobil = "Mitsubishi L300"; hargaSewa = 250000; }
                else { namaMobil = "Toyota Hilux"; hargaSewa = 350000; }
            } else if (indexJenisMobil == 2)
            {
                jenisMobil = "Minibus";
                Console.WriteLine("Mobil Tersedia         : 1. Inova");
                Console.WriteLine("                       : 2. Avanza");
                Console.WriteLine("                       : 3. Expander");
                Console.WriteLine("                       : 4. Ertiga");
                Console.Write("                       : ");
                indexNamaMobil = int.Parse(Console.ReadLine());
                if (indexNamaMobil == 1) { namaMobil = "Inova"; hargaSewa = 500000; }
                else if (indexNamaMobil == 2) { namaMobil = "Avanza"; hargaSewa = 300000; }
                else if (indexNamaMobil == 3) { namaMobil = "Expander"; hargaSewa = 400000; }
                else { namaMobil = "Ertiga"; hargaSewa = 350000; }
            } else if (indexJenisMobil == 3)
            {
                Console.WriteLine("Mobil Tersedia         : 1. Toyota Vios");
                Console.WriteLine("                       : 2. Honda City");
                Console.Write("                       : ");
                indexNamaMobil = int.Parse(Console.ReadLine());
                if (indexNamaMobil == 1) { namaMobil = "Toyota Vios"; hargaSewa = 600000; }
                else { namaMobil = "Honda City"; hargaSewa = 650000; }
            }

            Console.Write("Lama Dipinjam (hari)   : ");
            lamaPinjam = int.Parse(Console.ReadLine());

            Console.WriteLine("\nRincian Biaya Sewa");
            Console.WriteLine("==================");
            Console.WriteLine("Nama Peminjam    : " + namaPeminjam);
            Console.WriteLine("Jenis Mobil      : " + jenisMobil);
            Console.WriteLine("Mobil            : " + namaMobil);
            Console.WriteLine("Lama Pinjam      : " + lamaPinjam + " Hari");
            Console.WriteLine($"Biaya Sewa       : {hargaSewa * lamaPinjam:N0}");

            Console.ReadLine();
        }
    }
}
