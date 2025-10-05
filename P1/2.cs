using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_130925_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String nama; String alamat; String jurusan; String kelas;
            Console.Write("\nMasukkan Nama Anda     : ");
            nama = Console.ReadLine();
            Console.Write("Masukkan Alamat Anda   : ");
            alamat = Console.ReadLine();
            Console.Write("Masukkan Jurusan Anda  : ");
            jurusan = Console.ReadLine();
            Console.Write("Masukkan Kelas Anda    : ");
            kelas = Console.ReadLine();
            Console.WriteLine("\n     Nama     : " + nama);
            Console.WriteLine("     Alamat   : " + alamat);
            Console.WriteLine("     Jurusan  : " + jurusan);
            Console.WriteLine("     Kelas    : " + kelas);
            Console.Write("\nMahasiswa " + nama + " dari " + alamat + " adalah jurusan " + jurusan + " kelas " + kelas);
            Console.Read();
        }
    }
}
