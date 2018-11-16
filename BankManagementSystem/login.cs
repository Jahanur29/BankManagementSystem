using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        string user;

        private void exit_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Do you want to exit Program?",
            "EXIT", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
               
            }
           
        }

        private void login_Click(object sender, EventArgs e)
        {


            if (user == "Admin")
            {

                mainForm m = new mainForm();
                m.Show();
            }

            else if (user == "Employee")
            {

                employeeMainForm emp = new employeeMainForm();
                emp.Show();
            }
        }

        private void public_Click(object sender, EventArgs e)
        {
            publicMainForm pc = new publicMainForm();
            pc.Show();
        }

        private void publicLogin_Click(object sender, EventArgs e)
        {
            testForm t = new testForm();
            t.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            user = "Admin";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            user = "Employee";
        }
    }
}
