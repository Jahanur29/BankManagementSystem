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
    public partial class publicMainForm : Form
    {
        public publicMainForm()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void loanCalculator_Click(object sender, EventArgs e)
        {
            loanCalculator l = new loanCalculator();
            l.Show();
        }

        private void depositeCalculator_Click(object sender, EventArgs e)
        {
            depositCalculator d = new depositCalculator();
            d.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

    }
}
