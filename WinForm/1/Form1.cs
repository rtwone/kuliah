using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double nilai;
            nilai = (byte.Parse(txt_tugas.Text) * 0.2) +
                (byte.Parse(txt_uts.Text) * 0.35) +
                (byte.Parse(txt_uas.Text) * 0.45);

            nilai_akhir.Text = Convert.ToString(nilai);

            if ((nilai < 0) || (nilai > 100))
                labelGrade.Text = "Err";
            else if (nilai <= 45)
                labelGrade.Text = "E";
            else if (nilai <= 55)
                labelGrade.Text = "D";
            else if (nilai <= 69)
                labelGrade.Text = "C";
            else if (nilai <= 84)
                labelGrade.Text = "B";
            else
                labelGrade.Text = "A";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
