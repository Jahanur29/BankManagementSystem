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
    public partial class transaction : Form
    {
        public transaction()
        {
            InitializeComponent();
        }

        private void transaction_Load(object sender, EventArgs e)
        {
                label2.Text = (DateTime.Now.ToLongTimeString().ToString());



                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
                con.Open();
                SqlCommand sc = new SqlCommand("select * from accountType", con);
                 try
                {
                    SqlDataReader dr = sc.ExecuteReader();
                    while (dr.Read())
                    {
                        comboBox1.Items.Add(dr["name"]);
                        //  MessageBox.Show("New Club Added");

                    }
                    dr.Close();
                    dr.Dispose();
                }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }
         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       private int  depositeAmount()
        {


            try
            {


                int depositAmount = Convert.ToInt32(textBox3.Text);

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
                con.Open();

                string qry = "select sum(amount) from customerAcc where account_no='" + textBox1.Text + "'";
                SqlCommand sc = new SqlCommand(qry, con);
                {
                    //object result = sc.ExecuteScalar();
                    //string z = Convert.ToString(result); ;
                    int a = 0 + (Int32)sc.ExecuteScalar();
                    //  int a = Convert.ToInt32(z);

                    int totalAmount = depositAmount + a;
                    return totalAmount;
                    string showamount = totalAmount.ToString();
                    MessageBox.Show(showamount);
                }
            }
            catch
            {
                textBox3.Text = "GIve Amount";
                return 0;
            }



        }

       private int withdrawalAmount()
       {
           int withdrawalAmount = Convert.ToInt32(textBox3.Text);

           SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
           con.Open();

           string qry = "select sum(amount) from customerAcc where account_no='" + textBox1.Text + "'";
           SqlCommand sc = new SqlCommand(qry, con);
           {
               //object result = sc.ExecuteScalar();
               //string z = Convert.ToString(result); ;
               int a = 0 + (Int32)sc.ExecuteScalar();
               //  int a = Convert.ToInt32(z);

               int totalAmount = a - withdrawalAmount;
               if (totalAmount >= 500)
               {
                   return totalAmount;
                   string showamount = totalAmount.ToString();
                   MessageBox.Show(showamount);
               }
               else
               {
                   int canWithdrawal = a - 500;
                   MessageBox.Show("Please Check Your Balance !"+"You can withdrawal TK."+canWithdrawal);
                   return a;
               }
           }
       }



        public void updateAccount()
        {
            if (comboBox1.Text == "Deposit")
            {
                int a = depositeAmount();
                string finalAmount = a.ToString();

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
                con.Open();

                SqlCommand sc = new SqlCommand("update customerAcc set amount='" + finalAmount + "' where account_no='" + textBox1.Text + "'", con);

                try
                {
                    sc.ExecuteNonQuery();
                    MessageBox.Show("Transaction Successfully ");
                }
                catch
                {
                    //Error when save data

                    MessageBox.Show("Error to Update on database");
                    con.Close();
                }
            }



            else if (comboBox1.Text == "withdrawal")
            {
                int a = withdrawalAmount();
                string finalAmount = a.ToString();

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
                con.Open();

                SqlCommand sc = new SqlCommand("update customerAcc set amount='" + finalAmount + "'where account_no='" + textBox1.Text + "'", con);

                try
                {

                    sc.ExecuteNonQuery();
                    MessageBox.Show("Transaction Successfully.");

                }
                catch
                {
                    //Error when save data
                    MessageBox.Show("Error to Update on database");
                    con.Close();
                }
            }

            else
            {
                MessageBox.Show("Please Select Transaction Type.");
            }
        }



        public void saveTransaction()
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();
        
            SqlCommand sc = new SqlCommand("insert into trans(account_no,_date,transactiontype,amount) values('" + textBox1.Text + "','"+dateTimePicker1.Text+"','"+comboBox1.Text+"','"+textBox3.Text+"')", con);

            try
            {
              
                    sc.ExecuteNonQuery();

                    MessageBox.Show("Successfully Saved.");
              
            }
            catch
            {
                //Error when save data

                MessageBox.Show("Error to save on database");
                con.Close();
            }
        }



        private void ok_Click(object sender, EventArgs e)
        {
            updateAccount();
            saveTransaction();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
           // textBox2.Text = " ";
            textBox3.Text = " ";

        }

        private void checkBalance_Click(object sender, EventArgs e)
        {
            
              

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
                con.Open();

                string qry = "select sum(amount) from customerAcc where account_no='" + textBox1.Text + "'";
                try {   
            
            SqlCommand sc = new SqlCommand(qry, con);
                {
                    //object result = sc.ExecuteScalar();
                    //string z = Convert.ToString(result); ;
                    int a = 0 + (Int32)sc.ExecuteScalar();
                    //  int a = Convert.ToInt32(z); 
                  
                    
                    MessageBox.Show(a.ToString());
                }
                }

            catch(Exception ex)
                {
                MessageBox.Show(ex.Message);

            }
            }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           // Bitmap bmp = Properties.Resources.jambu_icon;

          //  Image newImage = bmp;
            e.Graphics.DrawString("_date :  " + DateTime.Now, new Font("Arial", 30, FontStyle.Regular), Brushes.SeaGreen, new Point(25, 640));
          //  e.Graphics.DrawImage(newImage, 25, 55, newImage.Width, newImage.Height);
            e.Graphics.DrawString("account_no :  " + textBox1.Text, new Font("Arial", 30, FontStyle.Regular), Brushes.Tomato, new Point(25, 400));
            e.Graphics.DrawString("transactionType :  " + comboBox1.Text, new Font("Arial", 30, FontStyle.Regular), Brushes.Tomato, new Point(25, 470));
            e.Graphics.DrawString("transactionAmount :  " + textBox3.Text, new Font("Arial", 30, FontStyle.Regular), Brushes.Tomato, new Point(25, 540));

        }

        private void print_Click(object sender, EventArgs e)
        {
           // printDocument1.Print();
           
         
            //printPreviewDialog.Document = printDocument1;
            //printPreviewDialog.Show();
        }
            

        }
    }

