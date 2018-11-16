using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace BankManagementSystem
{
    public partial class loanCalculator : Form
    {
        public loanCalculator()
        {
            InitializeComponent();
        }

        private void loanCalculator_Load(object sender, EventArgs e)
        {

        }

        public void calculate()
        {
            int loanAmount = Convert.ToInt32(textBox1.Text);
            double interest = Convert.ToDouble(textBox2.Text);
            int year = Convert.ToInt32(textBox3.Text);

            double monthlyInterestRate = (interest / 1200);
            double multiplyLM = monthlyInterestRate * loanAmount;

            double a = 1 + monthlyInterestRate;
            double b = year * 12;

            double tot = Math.Pow(a, b);

            double monthlyPayment = multiplyLM / (1 - (1 / tot));

            if (comboBox6.Text == "Monthly")
            {
                textBox4.Text = monthlyPayment.ToString();

            }
                

            else if (comboBox6.Text == "Quarterly")
            {
                monthlyPayment=monthlyPayment * 3;
                textBox4.Text = monthlyPayment.ToString();

            }

            else if (comboBox6.Text == "Half-Yearly")
            {
                monthlyPayment = monthlyPayment * 6;
                textBox4.Text = monthlyPayment.ToString();

            }

            else if (comboBox6.Text == "Yearly")
            {
                monthlyPayment = monthlyPayment * 12;
                textBox4.Text = monthlyPayment.ToString();

            }
            else if (comboBox6.Text == "")
            {
                MessageBox.Show("Please Select Payment Type");

            }

   

        }


        private void calculate_Click(object sender, EventArgs e)
        {
            calculate();

        }

        private void reset_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            comboBox6.Text = "          Select ";
            textBox4.Text = " ";        
        }
    }
}
