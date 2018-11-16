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
    public partial class depositCalculator : Form
    {
        public depositCalculator()
        {
            InitializeComponent();
        }


        public void depositCalculate()
        {

            int depositAmount = Convert.ToInt32(textBox1.Text);
            double interestRate = Convert.ToDouble(textBox2.Text);
            int year = Convert.ToInt32(textBox3.Text);

            double interest = 1+((interestRate / 100) / 12);
            double powerInterest = Math.Pow(interest, 12 * year);

            double finalAmount = depositAmount * powerInterest;

            textBox4.Text = finalAmount.ToString();


        }


        private void calculate_Click(object sender, EventArgs e)
        
        {
            depositCalculate();

        }

        private void reset_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
