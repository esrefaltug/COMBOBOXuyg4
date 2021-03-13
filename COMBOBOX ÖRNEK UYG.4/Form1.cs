using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMBOBOX_ÖRNEK_UYG._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("BMW");
            comboBox1.Items.Add("RENAULT");

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "BMW")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("5.20D");
                comboBox2.Items.Add("3.20D");
                comboBox2.Items.Add("5.20İ");
                comboBox2.Items.Add("1.18İ");
            }
            else if (comboBox1.Text == "RENAULT")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("MEGANE1");
                comboBox2.Items.Add("MEGANE2");
                comboBox2.Items.Add("CLİO");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "5.20D") 
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("M60");
                comboBox3.Items.Add("F30");
            }
            else if (comboBox2.Text == "3.20D")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("M60");
                comboBox3.Items.Add("F30");
            }
            else if (comboBox2.Text == "5.20İ")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("M60");
                comboBox3.Items.Add("F30");
            }
            else if (comboBox2.Text == "1.18İ")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("M60");
                comboBox3.Items.Add("F30");
            }
            else if (comboBox2.Text == "MEGANE1")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("1.5DCİ");
                comboBox3.Items.Add("1.4");
            }
            else if (comboBox2.Text == "MEGANE2")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("1.5DCİ(06 GTY 70)");
                comboBox3.Items.Add("1.6");
            }
            else if (comboBox2.Text == "CLİO")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("Sport");
                comboBox3.Items.Add("1.6");
                comboBox3.Items.Add("makyajlı");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("MARKA: " + comboBox1.Text + " | "+"MODEL: "+comboBox2.Text+" | "+"VERSİYON: "+comboBox3.Text);
        }
    }
}
