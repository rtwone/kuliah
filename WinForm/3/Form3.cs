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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void mahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frmMHS = new Form1();
            frmMHS.MdiParent = this;
            frmMHS.Show();
        }

        private void dosenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frmDosen = new Form2();
            frmDosen.MdiParent = this;
            frmDosen.Show();
        }

        private void kalkulatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frmKal = new Form4();
            frmKal.MdiParent = this;
            frmKal.Show();
        }
    }
}
