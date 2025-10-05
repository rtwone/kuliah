using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_100425_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soal Percabangan

            int nilai;

            Console.Write("NPM    : ");
            Console.ReadLine();
            Console.Write("NAMA   : ");
            Console.ReadLine();
            Console.Write("KELAS  : ");
            Console.ReadLine();
            Console.Write("NILAI  : ");
            nilai = int.Parse(Console.ReadLine());

            if (nilai > 100 || nilai < 0)
                Console.WriteLine("GRADE  : Nilai Tidak Dapat Dihitung");
            else if (nilai <= 45) // Apakah nilainya dibawah 45?
                Console.WriteLine("GRADE  : E");
            else if (nilai <= 59) // Apakah nilainya dibawah 59?
                Console.WriteLine("GRADE  : D");
            else if (nilai <= 70) // Apakah nilainya dibawah 70?
                Console.WriteLine("GRADE  : C");
            else if (nilai <= 85) // Apakah nilainya dibawah 85?
                Console.WriteLine("GRADE  : B");
            else if (nilai <= 100) // Apakah nilainya dibawah 100?
                Console.WriteLine("GRADE  : A");
            // secara tidak Langsung percabangan menunjukkan seperti "Apakah nilai adalah 0 sampai 45?", dst...

            Console.ReadKey();
        }
    }
}
