using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping_For
{
    class Mahasiswa
    {
        public string Nama { get; set; }
        public string Semester { get; set; }
        public string Alamat { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // For bertingkat
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine(i + " " + j);
                }
            }

            /*** Char ***/
            /*for (char huruf = 'A'; huruf <= 'E'; huruf++)
                Console.WriteLine(huruf);
            Console.WriteLine("\n");
            for (int huruf = 69; huruf >= 65; huruf--)
                Console.WriteLine(Convert.ToChar(huruf));*/

            /*** For Dasar with Array ***/
            /* Mahasiswa[] data = new Mahasiswa[]
            {
                new Mahasiswa { Nama = "Irfan", Semester = "1", Alamat = "Marengan Laok"},
                new Mahasiswa { Nama = "Atun", Semester = "3", Alamat = "Jember" }
            };

            for (int i = 0; i <= data.Length; i++)
            {
                Console.WriteLine($"Nama: {data[i].Nama}\nSemester: {data[i].Semester}\nAlamat: {data[i].Alamat}\n");
            }*/
            Console.ReadLine();
        }
    }
}
