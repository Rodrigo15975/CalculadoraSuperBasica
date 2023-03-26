using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{

    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        double n1 = 0;
        double n2 = 0;
       private string ope = "";


        private void button16_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text += "9";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtScreen.Text = (txtScreen.TextLength == 1) ? "0" 
            : txtScreen.Text.Substring(0, txtScreen.Text.Length - 1);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtScreen.Text = "0"; 
            n1 = 0;
            n2 = 0;
            ope = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                n2 = Convert.ToDouble(txtScreen.Text);

                if (ope == "+")
                {
                    txtScreen.Text = $"{n1 + n2}";
                }
                else if (ope == "-")
                {
                    txtScreen.Text = $"{n1 - n2}";
                }
                else if (ope == "*")
                {
                    txtScreen.Text = $"{n1 * n2}";
                }
                else if (ope == "/")
                {
                    txtScreen.Text = $"{n1 / n2}";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Realice un operación por favor");
            }
        
        }

        private void txtScreen_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0" ) txtScreen.Text = "";
            txtScreen.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text += "2";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text += "4";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text += "5";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text += "6";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text += "7";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text += "8";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtScreen.Text += "0"; 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtScreen.Text += ".";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ope = "+";
            n1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ope = "-";
            n1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ope = "*";
            n1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ope = "/";
            n1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
        }
    }
}
