using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Zalfa_Converter
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage5);
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPages1_SelectedIndexChanged(object sender, EventArgs e)
        {


             
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            string value1 = comboBox1.SelectedItem.ToString();
            string value2 = comboBox2.SelectedItem.ToString();

            double num = double.Parse(textBox1.Text);
            double hasil = 0;

            string[] units2 = { "KILOMETER", "HEKTOMETER", "DEKAMETER", "METER", "DESIMETER", "CENTIMETER", "MILIMETER" };
            double[] multipliers = { 1, 10, 100, 1000, 10000, 100000, 1000000 };

            int indexValue1 = Array.IndexOf(units2, value1);
            int indexValue2= Array.IndexOf(units2, value2);

            if (indexValue1 >= 0 && indexValue2 >= 0)
            {
                hasil = num * (multipliers[indexValue2] / multipliers[indexValue1]);
            }

            textBox2.Text = $"{hasil} {value2}";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string value3 = comboBox3.SelectedItem.ToString();
            string value4 = comboBox4.SelectedItem.ToString();

            double num = double.Parse(textBox4.Text);
            double hasil = 0;

            string[] units2 = { "KILOGRAM", "HEKTOGRAM", "DEKAGRAM", "GRAM", "DESIGRAM", "CENTIGRAM", "MILIGRAM" };
            double[] multipliers = { 1, 10, 100, 1000, 10000, 100000, 1000000 };

            int indexValue3 = Array.IndexOf(units2, value3);
            int indexValue4 = Array.IndexOf(units2, value4);

            if (indexValue3 >= 0 && indexValue4 >= 0)
            {
                hasil = num * (multipliers[indexValue4] / multipliers[indexValue3]);
            }

            textBox3.Text = $"{hasil} {value4}";
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string value5 = comboBox5.SelectedItem.ToString();
            string value6 = comboBox6.SelectedItem.ToString();

            double num = double.Parse(textBox6.Text);
            double hasil2 = 0;

            string[] unitsTime = { "Jam", "Menit", "Detik" };
            double[] multipliersTime = { 1, 60, 3600 };

            int indexValue5 = Array.IndexOf(unitsTime, value5);
            int indexValue6 = Array.IndexOf(unitsTime, value6);

            if (indexValue5 >= 0 && indexValue6 >= 0)
            {
                hasil2 = num * (multipliersTime[indexValue6] / multipliersTime[indexValue5]);
            }

            textBox5.Text = $"{hasil2} {value6}";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string value7 = comboBox7.SelectedItem.ToString();
            string value8 = comboBox8.SelectedItem.ToString();

            double angka = double.Parse(textBox8.Text);

            double hasil = 0;

            if (value7 == "Celcius")
            {
                if (value8 == "Celcius")
                {
                    hasil = angka * 1;
                }
                else if (value8 == "Fahrenheit")
                {
                    hasil = angka * 9 / 5 + 32;
                }
                else if (value8 == "Reamur")
                {
                    hasil = angka * 4 / 5;
                }
                else if (value8 == "Kelvin")
                {
                    hasil = angka + 273;
                }
            }

            if (value7 == "Fahrenheit")
            {
                if (value8 == "Celcius")
                {
                    hasil = (angka - 32) * 5 / 9;
                }
                else if (value8 == "Fahrenheit")
                {
                    hasil = angka * 1;
                }
                else if (value8 == "Reamur")
                {
                    hasil = (angka - 32) * 4 / 9;
                }
                else if (value8 == "Kelvin")
                {
                    hasil = (angka - 32) * 5 / 9 + 273;
                }
            }

            if (value7 == "Reamur")
            {
                if (value8 == "Celcius")
                {
                    hasil = angka * 5 / 4;
                }
                else if (value8 == "Fahrenheit")
                {
                    hasil = (angka + 32) * 9 / 4;
                }
                else if (value8 == "Reamur")
                {
                    hasil = angka * 1;
                }
                else if (value8 == "Kelvin")
                {
                    hasil = (angka + 273) * 5 / 4;
                }
            }

            if (value7 == "Kelvin")
            {
                if (value8 == "Celcius")
                {
                    hasil = angka - 273;
                }
                else if (value8 == "Fahrenheit")
                {
                    hasil = (angka - 273) * 9 / 5 + 32;
                }
                else if (value8 == "Reamur")
                {
                    hasil = (angka - 273) * 4 / 5;
                }
                else if (value8 == "Kelvin")
                {
                    hasil = angka * 1;
                }
            }
            textBox7.Text = $"{hasil} {value8}";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string value5 = comboBox10.SelectedItem.ToString();
            string value6 = comboBox9.SelectedItem.ToString();

            double num = double.Parse(textBox10.Text);
            double hasil2 = 0;

            string[] unitsTime = { "Petabyte", "Terabyte", "Gigabyte", "Megabyte", "Kilobyte", "Byte" };
            double[] multipliersTime = { 1, 1000, 1000000, 1000000000, 1000000000000, 1000000000000000 };

            int indexValue5 = Array.IndexOf(unitsTime, value5);
            int indexValue6 = Array.IndexOf(unitsTime, value6);

            if (indexValue5 >= 0 && indexValue6 >= 0)
            {
                hasil2 = num * (multipliersTime[indexValue6] / multipliersTime[indexValue5]);
            }

            textBox9.Text = $"{hasil2} {value6}";
        }
    }
    
}
