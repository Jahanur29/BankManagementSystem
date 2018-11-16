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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employeInfo ei = new employeInfo();
            ei.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void updateInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employeUpdate m = new employeUpdate();
            m.Show();
        }

        private void seaRchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employeSearch s = new employeSearch();
            s.Show();
        }

        private void addEmpSalarYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employeSalary em = new employeSalary();
            em.Show();
        }

        private void addBonusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employeBonus eb = new employeBonus();
            eb.Show();
        }

        private void aDDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            employePosition em = new employePosition();
            em.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employePosition em = new employePosition();
            em.Show();
        }

        private void adddSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salary s = new salary();
            s.Show();
        }

        private void viewEmPloyeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employeView ev = new employeView();
            ev.Show();
        }

        private void updateEmployeSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            empSalaryUpdate em = new empSalaryUpdate();
            em.Show();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewemployeeInfo v = new viewemployeeInfo();
            v.Show();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addCustomer ad = new addCustomer();
            ad.Show();
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transaction tr = new transaction();
            tr.Show();
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifyCustomer m = new modifyCustomer();
            m.Show();
        }

        private void viewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewCustomer v = new viewCustomer();
            v.Show();
        }

        private void sendMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            email em = new email();
            em.Show();
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

        private void viewCustomerProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customerAccountViewForAdmin ca = new customerAccountViewForAdmin();
            ca.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void custOmerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void interestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateCustomerAccount c = new updateCustomerAccount();
            c.Show();
        }

        private void viewTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerTransactionForAdmin ct = new CustomerTransactionForAdmin();
            ct.Show();
        }

        private void creditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            credit c = new credit();
            c.Show();
        }

        private void userAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            password p = new password();
            p.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changePassword c = new changePassword();
            c.Show();
        }

        private void accountTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accountType ac = new accountType();
            ac.Show();
        }
    }
}

