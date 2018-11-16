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
    public partial class employeSearch : Form
    {
        public employeSearch()
        {
            InitializeComponent();
        }

        private void showemployeAdddress()
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand("select *from employeAddress where Employee_ID='" + textBox1.Text + "'", con);

            try
            {
                SqlDataReader sdr = sc.ExecuteReader();

                while (sdr.Read())
                {
                    textBox13.Text = sdr["Pr_flatno"].ToString();
                    textBox14.Text = sdr["Pr_houseNo"].ToString();
                    textBox4.Text = sdr["Pr_roadNo"].ToString();
                    textBox12.Text = sdr["Pr_village"].ToString();
                    textBox15.Text = sdr["Pr_thana"].ToString();
                    textBox16.Text = sdr["Pr_district"].ToString();
                    textBox17.Text = sdr["Pr_postCode"].ToString();
                  //  textBox10.Text = sdr["bloodgroup"].ToString();
                }

            }
            catch
            {
                MessageBox.Show("No Data");
                con.Close();
            }


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
                    textBox2.Text = sdr["FullName"].ToString();
                    textBox3.Text = sdr["FatherName"].ToString();
                    textBox5.Text = sdr["sex"].ToString();
                    textBox6.Text = sdr["email"].ToString();
                    textBox7.Text = sdr["phone"].ToString();
                    textBox8.Text = sdr["dateOfBirth"].ToString();
                    textBox9.Text = sdr["joinDate"].ToString();
                    textBox10.Text = sdr["bloodgroup"].ToString();
                }

            }
            catch
            {
                MessageBox.Show("No Data");
                con.Close();
            }

            showemployeAdddress();
        }
    }
}
