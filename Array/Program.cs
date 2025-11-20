using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] harga = new int[5];

            //// Memberi nilai Array
            //harga[0] = 10;
            //harga[1] = 20;
            //harga[2] = 30;
            //harga[3] = 40;
            //harga[4] = 50;

            //// Menampilkan Nilai Array di Layar 1/1
            //Console.WriteLine(harga[0]);
            //Console.WriteLine(harga[1]);
            //Console.WriteLine(harga[2]);
            //Console.WriteLine(harga[3]);
            //Console.WriteLine(harga[4]);

            //for (byte a = 0; a < 5; a++)
            //    Console.WriteLine(harga[a]);

            //byte[] nilai = new byte[5];
            //Console.WriteLine("   Masukkan Nilai");
            //Console.WriteLine("   ==============");
            //Console.WriteLine("Masukkan Nilai :");
            //for (byte i = 0; i < nilai.Length; i++)
            //{
            //    Console.Write("{0}. ", i + 1);
            //    nilai[i] = Convert.ToByte(Console.ReadLine());
            //}
            //Console.WriteLine("\nData Nilai Yang Telah Diinput :");
            //for (byte i = 0; i < nilai.Length; i++)
            //    Console.Write("{0} ", nilai[i]);

            //for (int i = 0; i < nilai.Length; i++)
            //{
            //    for (int a = i + 1; a < nilai.Length; a++)
            //    {
            //        if (nilai[a] < nilai[i])
            //        {
            //            byte temp = nilai[i];
            //            nilai[i] = nilai[a];
            //            nilai[a] = temp;
            //        }
            //    }
            //}
            //Console.WriteLine("\n\nNilai Setelah Di Urutkan :");
            //for (byte i = 0; i < nilai.Length; i++)
            //    Console.Write("{0} ", nilai[i]);

            //string[] name = new string[5];
            //Console.WriteLine("  DAFTAR HADIR");
            //Console.WriteLine("  ============");

            //for (byte a = 0; a < name.Length; a++)
            //{
            //    Console.Write("{0}. ", a + 1);
            //    name[a] = Console.ReadLine();
            //}
            //Console.WriteLine("\nData Nama Yang Telah di Input :");
            //for (byte i = 0; i < name.Length; i++)
            //    Console.WriteLine("{0}. {1}", i + 1, name[i]);

            //for (int i = 0; i < name.Length; i++)
            //{
            //    for (int a = i + 1; a < name.Length; a++)
            //    {
            //        if (string.Compare(name[i], name[a]) > 0)
            //        {
            //            string temp = name[i];
            //            name[i] = name[a];
            //            name[a] = temp;
            //        }
            //    }
            //}
            //Console.WriteLine("\nNama Setelah Di Urutkan :");
            //for (byte i = 0; i < name.Length; i++)
            //    Console.Write("{0}. {1} \n", i + 1, name[i]);

            int totalArray = 10;
            string[] nama = new string[totalArray];
            int[] nilai = new int[totalArray];
            int urut = 0;

            Console.WriteLine(" DAFTAR NAMA & NILAI");
            Console.WriteLine(" ===================");

            do
            {
                Console.Write("{0}.  Nama   : ", urut + 1);
                nama[urut] = Console.ReadLine();
                if (nama[urut] == "") {
                    urut++;
                    break;
                }
                Console.Write("    Nilai  : ");
                nilai[urut] = int.Parse(Console.ReadLine());
                urut++;
            } while ((urut < nama.Length) && (nama[urut - 1] != ""));

            Console.WriteLine("\nData Nama dan Nilai yang di Input :");
            for (int a = 0; a < urut - 1; a++) {
                Console.WriteLine("{0}. {1} ({2})", a + 1, nama[a], nilai[a]);
            }

            Console.WriteLine("\nData Nama dan Nilai yang telah di Sortir :");
            for (int i = 0; i < urut - 1; i++) {
                for (int a = i + 1; a < urut - 1; a++) {
                    if (string.Compare(nama[i], nama[a]) > 0) {
                        string temp = nama[i]; int temp2 = nilai[i];
                        nama[i] = nama[a]; nilai[i] = nilai[a];
                        nama[a] = temp; nilai[a] = temp2;
                    }
                }
            }
            for (int a = 0; a < urut - 1; a++)
                Console.WriteLine("{0}. {1} ({2})", a + 1, nama[a], nilai[a]);

            for (int i = 0; i < urut - 1; i++) {
                for (int a = i + 1; a < urut - 1; a++) {
                    if (nilai[a] < nilai[i]) {
                        int temp = nilai[i]; string temps = nama[i];
                        nilai[i] = nilai[a]; nama[i] = nama[a];
                        nilai[a] = temp; nama[a] = temps;
                    }
                }
            }

            Console.WriteLine("\n- Nilai Tertinggi");
            Console.WriteLine($"       Nama  : {nama[urut - 2]}");
            Console.WriteLine($"       Nilai : {nilai[urut - 2]}");
            Console.WriteLine("\n- Nilai Terendah :");
            Console.WriteLine($"       Nama  : {nama[0]}");
            Console.WriteLine($"       Nilai : {nilai[0]}");

            Console.ReadKey();
        }
    }
}
