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
    public partial class customerAccountViewForAdmin : Form
    {
        public customerAccountViewForAdmin()
        {
            InitializeComponent();
        }

        public void showBalance()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();
            SqlCommand sca = new SqlCommand("select *from customerAcc where account_no='" + textBox1.Text + "'", con);

            try
            {
                SqlDataReader sdra = sca.ExecuteReader();

                while (sdra.Read())
                {

                    //{
                    //    label6.Text = sdr["FullName"].ToString();
                    //    label7.Text = sdr["email"].ToString();
                    //    label8.Text = sdr["phone"].ToString();
                    //    label9.Text = sdr["dateOfBirth"].ToString();
                    label10.Text = sdra["amount"].ToString() + " Tk.";
                }

            }
            catch
            {
                MessageBox.Show("error from database");
                con.Close();
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand("select *from customerInfo where account_no='" +textBox1.Text + "'", con);

            try
            {
                SqlDataReader sdr = sc.ExecuteReader();

                while (sdr.Read())
                {
                    label6.Text = sdr["FullName"].ToString();
                    label7.Text = sdr["email"].ToString();
                    label8.Text = sdr["phone"].ToString();
                    label9.Text = sdr["dateOfBirth"].ToString();
                    //label10.Text = sdra["amount"].ToString();
                }

            }
            catch
            {
                MessageBox.Show("No Data");
                con.Close();
            }

            showBalance(); 
        }

        private void back_Click(object sender, EventArgs e)
        {

        }
    }
}
