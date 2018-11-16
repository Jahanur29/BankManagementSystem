using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankManagementSystem
{
    public partial class testForm : Form
    {
       
        public testForm()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            //public string customerAccountnumber=textBox1.Text;

        }
      
        
        public int customerAccountnumber;   //for get customerAccountnumber
        
        private void testForm_Load(object sender, EventArgs e)
        {

        }

        private void alUToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fghToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

       

        public string getCustomerAccount()
        {
            string customerAccount = textBox1.Text;
           /// MessageBox.Show("Ac  " + customerAccount);
            return customerAccount;
        }
        
        private void loginCustomer_Click(object sender, EventArgs e)
        {

            getCustomerAccount();
            customerAccountnumber = 2;  //get customerAccountnumber
           // MessageBox.Show(customerAccountnumber);
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");        
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from customerPassword where account_no='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                customerMenu cm = new customerMenu(textBox1.Text);  //for passing value
                cm.Show();
              ///  Hide();
            }
            else
            {
                textBox2.Text = " ";
                MessageBox.Show("User Name OR Password Incorrect");
                
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            customerPasswordChange c = new customerPasswordChange();
            c.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void depositeCalculator_Click(object sender, EventArgs e)
        {
            depositCalculator d = new depositCalculator();
            d.Show();
        }

        private void loanCalculatorView_Click(object sender, EventArgs e)
        {
            loanCalculator l = new loanCalculator();
            l.Show();
        }
    }
}
