using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            labels.Text = labels.Text == "label1" ? "Anjay" : "label1";
        }

        private void labels_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Tes";
        }

        private void labels_MouseEnter(object sender, EventArgs e)
        {
            labels.Text = "Tesss";
        }
    }
}
