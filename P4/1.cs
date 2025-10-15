using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Switch_Case_1
{
    class Program
    {
        static void Main(string[] args)
        {
            String jabatan, status;
            int gaji, anak, tKeluarga, tAnak;

            Console.Write("Nama Pegawai    : ");
            Console.ReadLine();
            Console.Write("Jabatan         : ");
            jabatan = Console.ReadLine();

            if (jabatan.ToLower() == "direktur")
                gaji = 5000000;
            else if (jabatan.ToLower() == "manager")
                gaji = 4000000;
            else if (jabatan.ToLower() == "kabag")
                gaji = 3000000;
            else
                gaji = 2000000;

            Console.WriteLine($"Gaji Pokok      : Rp{gaji:N0}");

            Console.Write("Status          : ");
            status = Console.ReadLine();

            if (status.ToLower() == "janda" || status.ToLower() == "duda")
            {
                Console.WriteLine("Tunj. Keluarga  : Rp0");
                tKeluarga = 0;
                Console.Write("Anak            : ");
                anak = int.Parse(Console.ReadLine());
                if (anak > 2)
                {
                    Console.WriteLine($"Tunj. Anak      : Rp400,000");
                    tAnak = 400000;
                } else
                {
                    tAnak = anak * 200000;
                    Console.WriteLine($"Tunj. Anak      : Rp{tAnak}");
                }
            }
            else if (status.ToLower() == "menikah")
            {
                Console.WriteLine("Tunj. Keluarga  : Rp450,000");
                tKeluarga = 450000;
                Console.Write("Anak            : ");
                anak = int.Parse(Console.ReadLine());
                if (anak > 2)
                {
                    Console.WriteLine($"Tunj. Anak      : Rp400,000");
                    tAnak = 400000;
                }
                else
                {
                    tAnak = anak * 200000;
                    Console.WriteLine($"Tunj. Anak      : Rp{tAnak}");
                }
            }
            else {
                Console.WriteLine("Tunj. Keluarga  : Rp0");
                Console.WriteLine("Anak            : Rp0");
                Console.WriteLine("Tunj. Anak      : Rp0");
                tKeluarga = 0;
                tAnak = 0;
            }

            Double pajakPenghasilan = gaji * 0.015;
            Double gajiBersih = gaji + tKeluarga + tAnak - pajakPenghasilan;

            Console.WriteLine($"PPH             : Rp{gaji * 0.015:N0}");
            Console.WriteLine($"Gaji Bersih     : Rp{gajiBersih:N0}");
            Console.ReadLine();
        }
    }
}
