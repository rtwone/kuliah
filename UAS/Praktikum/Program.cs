using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string golongan = golonganComboBox.Text;
            string wilayah = wilayahComboBox.Text;
            int penggunaanAir = int.Parse(penggunaanAirBox.Text);
            int tarif = 0;
            int biayaMaterai = 3000;
            int biayaAdmin = 10000;
            double PPN = 0.015; // pajak 1,5%
            int biayaPemeliharaan = 0;
            int biayaPemakaian = 0;

            if (golongan.ToLower() == "rumah tangga")
            {
                if (penggunaanAir >= 1 && penggunaanAir <= 10)
                    tarif = 1600;
                else if (penggunaanAir >= 11 && penggunaanAir <= 20)
                    tarif = 2300;
                else if (penggunaanAir >= 21 && penggunaanAir <= 30)
                    tarif = 5500;
                else
                    tarif = 6000;
            } else if (golongan.ToLower() == "industri")
            {
                if (penggunaanAir >= 1 && penggunaanAir <= 10)
                    tarif = 2600;
                else if (penggunaanAir >= 11 && penggunaanAir <= 20)
                    tarif = 4600;
                else if (penggunaanAir >= 21 && penggunaanAir <= 30)
                    tarif = 7400;
                else
                    tarif = 10700;
            } else
            {
                if (penggunaanAir >= 1 && penggunaanAir <= 10)
                    tarif = 1000;
                else if (penggunaanAir >= 11 && penggunaanAir <= 20)
                    tarif = 1400;
                else if (penggunaanAir >= 21 && penggunaanAir <= 30)
                    tarif = 2500;
                else
                    tarif = 3800;
            }

            if (wilayah.ToLower() == "kota")
                biayaPemeliharaan = 4400;
            else if (wilayah.ToLower() == "kalianget")
                biayaPemeliharaan = 5000;
            else if (wilayah.ToLower() == "saronggi")
                biayaPemeliharaan = 5200;
            else
                biayaPemeliharaan = 5200;

            biayaPemakaian = penggunaanAir * tarif;
            biayaPemakaianBox.Text = $"{biayaPemakaian:N0}";
            biayaMateraiBox.Text = $"{biayaMaterai:N0}";
            biayaAdminBox.Text = $"{biayaAdmin:N0}";
            ppnBox.Text = $"{biayaPemakaian * PPN:N0}";
            biayaPemeliharaanBox.Text = $"{biayaPemeliharaan:N0}";
            totalTagihanBox.Text = $"{biayaPemakaian + (biayaPemakaian * PPN) + biayaMaterai + biayaPemeliharaan + biayaAdmin:N0}";
        }
    }
}
