using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul3_1302210009
{
    public partial class Form1 : Form
    {
        int bil1;
        int bilsimpanan;
        Boolean opr_hasil = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text =="0") {
                this.textBox1.Text = "1";
            }
            else
            {
                this.textBox1.Text += "1";
                bilsimpanan += 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                this.textBox1.Text = "2";
            }
            else
            {
                this.textBox1.Text += "2";
                bilsimpanan += 2;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                this.textBox1.Text = "4";
            }
            else
            {
                this.textBox1.Text += "4";
                bilsimpanan += 1;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "+";
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                this.textBox1.Text = "3";
            }
            else
            {
                this.textBox1.Text += "3";
                bilsimpanan += 3;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                this.textBox1.Text = "5";
            }
            else
            {
                this.textBox1.Text += "5";
                bilsimpanan += 5;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                this.textBox1.Text = "6";
            }
            else
            {
                this.textBox1.Text += "6";
                bilsimpanan += 6;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                this.textBox1.Text = "7";
            }
            else
            {
                this.textBox1.Text += "7";
                bilsimpanan += 7;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                this.textBox1.Text = "8";
            }
            else
            {
                this.textBox1.Text += "8";
                bilsimpanan += 8;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                this.textBox1.Text = "9";
            }
            else
            {
                this.textBox1.Text += "9";
                bilsimpanan += 9;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                this.textBox1.Text += "0";
                bilsimpanan += 0;
            }
        }

        private void btnhsil_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = bilsimpanan.ToString();
        }
    }
}
