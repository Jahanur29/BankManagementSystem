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
    public partial class viewCustomerAcc : Form
    {
        public viewCustomerAcc(string value)
        {
            InitializeComponent();
            label12.Text = value;
        }

    




        public void showBalance()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();
            SqlCommand sca = new SqlCommand("select *from customerAcc where account_no='" + label12.Text + "'", con);

            try
            {
                SqlDataReader sdra = sca.ExecuteReader();

                while (sdra.Read())
                {

                  
                    label10.Text = sdra["amount"].ToString()+" Tk.";
                }

            }
            catch
            {
                MessageBox.Show("error from database");
                con.Close();
            }


        }

        public void search()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand("select *from customerInfo where account_no='" + label12.Text + "'", con);

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

        private void search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand("select *from customerInfo where account_no='" + label12.Text + "'", con);
            
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


        private void clear_Click(object sender, EventArgs e)
        {
            label6.Text = "FullName";
            label7.Text = "email";
            label8.Text = "phone";
            label9.Text = "dateOfBirth";
            label10.Text = "amount";
           // textBox1.Text = " ";
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void viewCustomerAcc_Load(object sender, EventArgs e)
        {
            search();
        }
    }
}
