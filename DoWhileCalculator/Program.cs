using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanKalkulatorDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int pilihan;
            double angka1, angka2, hasil;

            do
            {
                Console.Clear();
                Console.WriteLine("=================");
                Console.WriteLine("KALKULATOR USE C#");
                Console.WriteLine("=================");
                Console.WriteLine("1. Penjumlahan");
                Console.WriteLine("2. Perkalian");
                Console.WriteLine("3. Pengurangan");
                Console.WriteLine("4. Pembagian");
                Console.WriteLine("5. Keluar");
                Console.WriteLine("=================");
                Console.Write("Silahkan pilih menu : ");

                // Coba baca input, jika bukan angka, ulangi
                if (!int.TryParse(Console.ReadLine(), out pilihan))
                {
                    pilihan = 0;
                }

                Console.WriteLine("=================");

                if (pilihan >= 1 && pilihan <= 4)
                {
                    Console.Write("Angka Ke-1 : ");
                    angka1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Angka Ke-2 : ");
                    angka2 = Convert.ToDouble(Console.ReadLine());

                    switch (pilihan)
                    {
                        case 1:
                            hasil = angka1 + angka2;
                            Console.WriteLine("Hasil : " + hasil);
                            break;
                        case 2:
                            hasil = angka1 * angka2;
                            Console.WriteLine("Hasil : " + hasil);
                            break;
                        case 3:
                            hasil = angka1 - angka2;
                            Console.WriteLine("Hasil : " + hasil);
                            break;
                        case 4:
                            if (angka2 != 0)
                            {
                                hasil = angka1 / angka2;
                                Console.WriteLine("Hasil : " + hasil);
                            }
                            else
                            {
                                Console.WriteLine("Error: Tidak bisa dibagi dengan nol!");
                            }
                            break;
                    }

                    Console.WriteLine("=================");
                    Console.WriteLine("Tekan Enter untuk kembali ke menu...");
                    Console.ReadLine();
                }
                else if (pilihan == 5)
                {
                    Console.WriteLine("Terima kasih telah menggunakan kalkulator ini!");
                }
                else
                {
                    Console.WriteLine("Pilihan tidak valid! Silahkan pilih 1-5.");
                    Console.WriteLine("Tekan Enter untuk ulang...");
                    Console.ReadLine();
                }

            } while (pilihan != 5);
        }
    }
}
