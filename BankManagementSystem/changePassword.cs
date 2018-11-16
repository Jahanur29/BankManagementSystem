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
    public partial class changePassword : Form
    {
        public changePassword()
        {
            InitializeComponent();
        }

        string user;
        private void change_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();


            //   string date = comboBox1.Text.ToString() + "-" + comboBox2.Text.ToString() + "-" + comboBox3.Text.ToString();
            SqlCommand sc = new SqlCommand("update adminPassword set password='"+textBox2.Text+"' where userName='"+textBox1.Text+"' and userType='"+user+"'", con);

            try
            {
              //  if (textBox1.Text != " ")
              //  {
                    sc.ExecuteNonQuery();

                    MessageBox.Show(" Password change Successfully .");
              //  }
            }
            catch
            {
                //Error when save data

                MessageBox.Show("Error to save on database");
                con.Close();
            }
        }

        private void back_Click(object sender, EventArgs e)
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
