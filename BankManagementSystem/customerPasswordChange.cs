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
    public partial class customerPasswordChange : Form
    {
        public customerPasswordChange()
        {
            InitializeComponent();
        }


        public void matchAccount()
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand("select *from customerPassword ", con);

            try
            {
                SqlDataReader sdr = sc.ExecuteReader();

                while (sdr.Read())
                {
                    string acNo = sdr["account_no"].ToString();
                    if (acNo == textBox1.Text)
                    {
                        MessageBox.Show("You are customer In this Bank !!");
                        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
                        cn.Open();
                        SqlCommand sca = new SqlCommand("update customerPassword set password='" + textBox2.Text + "' where account_no='" + textBox1.Text + "'", cn);

                        try
                        {
                            //  if (textBox1.Text != " ")
                            //  {
                            sca.ExecuteNonQuery();

                            MessageBox.Show(" Update PIN");
                            //   }
                        }
                        catch
                        {
                            //Error when save data

                            MessageBox.Show("Error to save PIN");
                            cn.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Create your Account :D");
                    }
                   
                }

            }
            catch
            {
                MessageBox.Show("No Data");
                con.Close();
            }

           

        }



        private void save_Click(object sender, EventArgs e)
        {
            matchAccount();

            /*

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand("update customerPassword set password='"+textBox2.Text+"' where account_no='"+textBox1.Text+"'", con);

            try
            {
                //  if (textBox1.Text != " ")
                //  {
                sc.ExecuteNonQuery();

                  MessageBox.Show(" Update PIN");
                //   }
            }
            catch
            {
                //Error when save data

                MessageBox.Show("Error to save PIN");
                con.Close();
            }

            */

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
