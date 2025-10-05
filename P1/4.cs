using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_130925_4
{
    class Program
    {
        static void Main(string[] args)
        {
            String nama, alamat, jurusan, kelas;
            byte NTG, NTS, NAS;
            Console.Write("Masukkan Nama Anda : ");
            nama = Console.ReadLine();
            Console.Write("Masukkan Alamat Anda : ");
            alamat = Console.ReadLine();
            Console.Write("Masukkan Jurusan Anda : ");
            jurusan = Console.ReadLine();
            Console.Write("Masukkan Kelas Anda : ");
            kelas = Console.ReadLine();
            Console.Write("Masukkan Nilai Tugas Anda : ");
            NTG = Convert.ToByte(Console.ReadLine());
            Console.Write("Masukkan Nilai UTS Anda : ");
            NTS = Convert.ToByte(Console.ReadLine());
            Console.Write("Masukkan Nilai UAS Anda : ");
            NAS = Convert.ToByte(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Nama             : {0}", nama);
            Console.WriteLine("Alamat           : {0}", alamat);
            Console.WriteLine("Jurusan          : {0}", jurusan);
            Console.WriteLine("Kelas            : {0}", kelas);
            Console.WriteLine("Nilai Tugas      : {0}", NTG);
            Console.WriteLine("Nilai UTS        : {0}", NTS);
            Console.WriteLine("Nilai UAS        : {0}\n", NAS);

            Console.WriteLine("Nilai Akhir Anda : {0}", (NTG * 0.2) + (NTS * 0.3) + (NAS * 0.5));
            Console.Read();
        }
    }
}
