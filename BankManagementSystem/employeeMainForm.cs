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
    public partial class employeeMainForm : Form
    {
        public employeeMainForm()
        {
            InitializeComponent();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loanCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loanCalculator l = new loanCalculator();
            l.Show();
        }

        private void depositeCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            depositCalculator d = new depositCalculator();
            d.Show();
        }

        private void sendMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            email em = new email();
            em.Show();
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transaction tr = new transaction();
            tr.Show();
        }

        private void viewCustomerProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customerAccountViewForAdmin vi = new customerAccountViewForAdmin();
            vi.Show();
        }

        private void viewTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerTransactionForAdmin cu = new CustomerTransactionForAdmin();
            cu.Show();
        }

        private void interestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateCustomerAccount up = new updateCustomerAccount();
            up.Show();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addCustomer ad = new addCustomer();
            ad.Show();
        }

        private void viewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewCustomer v = new viewCustomer();
            v.Show();
        }
    }
}
