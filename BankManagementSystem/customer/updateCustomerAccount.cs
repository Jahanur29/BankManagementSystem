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
    public partial class updateCustomerAccount : Form
    {
        public updateCustomerAccount()
        {
            InitializeComponent();
        }


        public void claculateInterst()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();
            string qry = "select sum(amount) from customerAcc where account_no='" + textBox1.Text + "'";
           
           SqlCommand sc = new SqlCommand(qry, con);
           {
              
              double a = 0 + (Int32)sc.ExecuteScalar();
               //  int a = Convert.ToInt32(z);
             //  int totalAmount = a - withdrawalAmount;

               if(a<50000)
               {
                   a = a + a *0;
                   int zz = Convert.ToInt32(a);
                   SqlConnection cona = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
           
                   cona.Open();
                   SqlCommand sca = new SqlCommand("update customerAcc set amount='" + zz + "' ", cona);
                   try
                   {

                       sca.ExecuteNonQuery();
                       MessageBox.Show("Successfully uPDATED.");
                   }
                   catch
                   {
                       MessageBox.Show("Error to save on database");
                       cona.Close();
                   }

               }
                   else if(a>=50000 && a<500000)
                   
                   {

                       
                       a = a + a * 0.01;
                      
                       int zz = Convert.ToInt32(a);
                       
                   //a = 500;
                   SqlConnection conb = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
           
                   conb.Open();
                   SqlCommand sca = new SqlCommand("update customerAcc set amount='" + zz + "' ", conb);
                   try
                   {

                       sca.ExecuteNonQuery();
                       MessageBox.Show("Successfully uPDATED. bb");
                   }
                   catch
                   {
                       MessageBox.Show("Error to save on database");
                       conb.Close();
                   }

                   }


               else if(a>=500000 && a<2500000)
                   
                   {
                       
                   a = a + a *0.02;
                   int zz = Convert.ToInt32(a);
                   
                   //string zz = a.ToString();
                   SqlConnection conc = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
           
                   conc.Open();
                   SqlCommand sca = new SqlCommand("update customerAcc set amount='" + zz + "' ", conc);
                   try
                   {

                       sca.ExecuteNonQuery();
                       MessageBox.Show("Successfully uPDATED.");
                   }
                   catch
                   {
                       MessageBox.Show("Error to save on database");
                       conc.Close();
                   }

                   }

      

             else if(a>=2500000)
                   
                   {
                       
                   a = a + a *0.04;
                   int zz = Convert.ToInt32(a);
                   
                   //string zz = a.ToString();
                   SqlConnection cond = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
           
                   cond.Open();
                   SqlCommand sca = new SqlCommand("update customerAcc set amount='" + zz + "' ", cond);
                   try
                   {

                       sca.ExecuteNonQuery();
                       MessageBox.Show("Successfully uPDATED.");
                   }
                   catch
                   {
                       MessageBox.Show("Error to save on database");
                       cond.Close();
                   }

                   }
           }
        }

           

        private void button6_Click(object sender, EventArgs e)
        {

             claculateInterst();
        
        }

               }
               
               }

       


        



    

