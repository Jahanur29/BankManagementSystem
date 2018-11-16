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
    public partial class viewemployeeInfo : Form
    {
        public viewemployeeInfo()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand("select *from employee where Employee_ID='" + textBox1.Text + "'", con);
            try
            {
                SqlDataReader sdr = sc.ExecuteReader();

                while (sdr.Read())
                {
                    label12.Text = sdr["FullName"].ToString();
                    label13.Text = sdr["phone"].ToString();
                    label14.Text = sdr["joinDate"].ToString();
                    label15.Text = sdr["FullName"].ToString();  
                }

            }
            catch
            {
                MessageBox.Show("error from database");
                con.Close();
            }

        }
    }
}
