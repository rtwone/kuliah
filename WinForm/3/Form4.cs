using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        double hasil = 0;
        string tombol = "";
        bool op_ditekan = false;

        private void inputAngka(String angka)
        {
            if ((textBox1.Text == "0") || (op_ditekan))
            {
                textBox1.Text = angka;
                op_ditekan = false;
            } else
            {
                textBox1.Text = textBox1.Text + angka;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputAngka("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inputAngka("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inputAngka("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inputAngka("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            inputAngka("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            inputAngka("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            inputAngka("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            inputAngka("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            inputAngka("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            inputAngka("0");
        }

        private void buttonPerkalian_Click(object sender, EventArgs e)
        {
            hasil = Convert.ToDouble(textBox1.Text);
            tombol = "*";
            op_ditekan = true;
        }

        private void buttonPengurangan_Click(object sender, EventArgs e)
        {
            hasil = Convert.ToDouble(textBox1.Text);
            tombol = "-";
            op_ditekan = true;
        }

        private void buttonPenjumlahan_Click(object sender, EventArgs e)
        {
            hasil = Convert.ToDouble(textBox1.Text);
            tombol = "+";
            op_ditekan = true;
        }

        private void buttonPembagian_Click(object sender, EventArgs e)
        {
            hasil = Convert.ToDouble(textBox1.Text);
            tombol = "/";
            op_ditekan = true;
        }

        private void buttonHasil_Click(object sender, EventArgs e)
        {
            switch (tombol)
            {
                case "*":
                    textBox1.Text = (hasil *
                        Convert.ToDouble(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (hasil -
                        Convert.ToDouble(textBox1.Text)).ToString();
                    break;
                case "+":
                    textBox1.Text = (hasil +
                        Convert.ToDouble(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (hasil /
                        Convert.ToDouble(textBox1.Text)).ToString();
                    break;
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
    }
}
