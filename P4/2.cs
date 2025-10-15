using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_3_MataKuliah_Otomatis
{
    class Program
    {
        static void Main(string[] args)
        {
            String namaMahasiswa = null, dosenMatkul = null, matKul = null, jamMatkul = null;
            int indexMatKul = 0, indexJamMatkul = 0;

            Console.Write("Nama Mahasiswa     : ");
            namaMahasiswa = Console.ReadLine();
            Console.WriteLine("Mata Kuliah        : 1. PBO");
            Console.WriteLine("                     2. Etika Profesi");
            Console.WriteLine("                     3. Mobile Programming");
            Console.WriteLine("                     4. Konsep Pemrograman");
            Console.Write("                   : ");
            indexMatKul = Convert.ToInt16(Console.ReadLine()); 

            switch (indexMatKul)
            {
                case 1:
                    dosenMatkul = "Taufik Hidayat";
                    matKul = "PBO";
                    Console.WriteLine("Jam Tersedia       : 1. Senin (09.00 - 11:20)");
                    Console.WriteLine("                     2. Selasa (10.20 - 12.50)");
                    Console.Write("                   : ");
                    indexJamMatkul = Convert.ToInt16(Console.ReadLine());
                    if (indexJamMatkul == 1) jamMatkul = "Senin (09.00 - 11:20)";
                    else if (indexJamMatkul == 2) jamMatkul = "Selasa (10.20 - 12.50)";
                    else jamMatkul = "Error";
                    break;
                case 2:
                    dosenMatkul = "Moh. Akhsan";
                    matKul = "Etika Profesi";
                    Console.WriteLine("Jam Tersedia       : 1. Senin (12.50 - 14:50)");
                    Console.WriteLine("                     2. Selasa (07.00 - 09.50)");
                    Console.WriteLine("                     3. Kamis (08.10 - 10.20)");
                    Console.Write("                   : ");
                    indexJamMatkul = Convert.ToInt16(Console.ReadLine());
                    if (indexJamMatkul == 1) jamMatkul = "Senin (12.50 - 14:50)";
                    else if (indexJamMatkul == 2) jamMatkul = "Selasa (07.00 - 09.50)";
                    else if (indexJamMatkul == 3) jamMatkul = "Kamis (08.10 - 10.20)";
                    else jamMatkul = "Error";
                    break;
                case 3:
                    dosenMatkul = "Taufik Hidayat";
                    matKul = "Mobile Programming";
                    Console.WriteLine("Jam Tersedia       : 1. Rabu (12.50 - 14:50)");
                    Console.WriteLine("                     2. Kamis (07.00 - 09.50)");
                    Console.WriteLine("                     3. Kamis (13.40 - 15.20)");
                    Console.WriteLine("                     4. Jumat (07.00 - 09.50)");
                    Console.Write("                   : ");
                    indexJamMatkul = Convert.ToInt16(Console.ReadLine());
                    if (indexJamMatkul == 1) jamMatkul = "Rabu (12.50 - 14:50)";
                    else if (indexJamMatkul == 2) jamMatkul = "Kamis (07.00 - 09.50)";
                    else if (indexJamMatkul == 3) jamMatkul = "Kamis (13.40 - 15.20)";
                    else if (indexJamMatkul == 4) jamMatkul = "Jumat (07.00 - 09.50)";
                    else jamMatkul = "Error";
                    break;
                case 4:
                    dosenMatkul = "Hendra Setiawan";
                    matKul = "Konsep Pemrograman";
                    Console.WriteLine("Jam Tersedia       : 1. Selasa (09.00 - 11:20)");
                    Console.WriteLine("                     2. Rabu (10.20 - 12.50)");
                    Console.Write("                   : ");
                    indexJamMatkul = Convert.ToInt16(Console.ReadLine());
                    if (indexJamMatkul == 1) jamMatkul = "Selasa (09.00 - 11:20)";
                    else if (indexJamMatkul == 2) jamMatkul = "Rabu (10.20 - 12.50)";
                    else jamMatkul = "Error";
                    break;
                default:
                    Console.WriteLine("Error");
                    Console.ReadLine();
                    break;
            }

            Console.WriteLine("\n\nRincian Jawal Kuliah");
            Console.WriteLine("--------------------");
            Console.WriteLine("Nama Mahasiswa  : " + namaMahasiswa);
            Console.WriteLine("Mata Kuliah     : " + matKul);
            Console.WriteLine("Jadwal          : " + jamMatkul);
            Console.WriteLine("Nama Dosen      : " + dosenMatkul);
            Console.ReadLine();

        }
    }
}