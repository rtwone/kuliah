using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan
{
    public partial class Form3 : Form
    {
        static string[] dataBarang = new string[100];
        static int[] dataHarga = new int[100];
        static int[] dataJumlah = new int[100];
        static int[] dataTotal = new int[100];
        static int index = 0;

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBarang[index] = namaBarang.Text;
            dataHarga[index] = int.Parse(harga.Text);
            dataJumlah[index] = int.Parse(jumlah.Text);
            dataTotal[index] = dataHarga[index] * dataJumlah[index];
            total.Text = Convert.ToString(dataHarga[index] * dataJumlah[index]);
            index++;

            namaBarang.Text = "";
            harga.Text = "";
            jumlah.Text = "";
        }
    }
}
