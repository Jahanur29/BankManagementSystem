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
    public partial class customerMenu : Form
    {
        public customerMenu(string value)
        {
            InitializeComponent();
           // testForm obj = new testForm();
           //string acc= obj.getCustomerAccount();
           customerAccountnumber = value;
           // MessageBox.Show(customerAccountnumber);
        }

        string customerAccountnumber;


        private void customerBalanceInfoClick(object sender, EventArgs e)
        {
           
           // MessageBox.Show()
            viewCustomerAcc v = new viewCustomerAcc(customerAccountnumber);
            v.Show();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void transactionInfoClick(object sender, EventArgs e)
        {
            viewCustomerTransaction v = new viewCustomerTransaction(customerAccountnumber);
            v.Show();
        }
    }
}
