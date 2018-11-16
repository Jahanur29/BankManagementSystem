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
    public partial class employeInfo2 : Form
    {
        public employeInfo2()
        {
            InitializeComponent();
        }

       public void textBox99_TextChanged(object sender, EventArgs e)
        {

        }

       private void save_Click(object sender, EventArgs e)
       {

           SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
           con.Open();
           SqlCommand sc = new SqlCommand("insert employeAddress(Employee_ID,p_flatNo,P_houseNo,P_roadNo,P_village,P_thana,P_district,P_postCode,Pr_flatNo,Pr_houseNo,Pr_roadNo,Pr_village,Pr_thana,Pr_district,Pr_postCode) values( '"+textBox99.Text+"','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + comboBox2.Text + "','" + textBox12.Text + "')", con);

           try
           {
               if (textBox99.Text != " ")
               {
                   sc.ExecuteNonQuery();

                   MessageBox.Show("Successfully Saved.");
               }
           }
           catch
           {
               //Error when save data

               MessageBox.Show("Error to save on database");
               con.Close();
           }
       }

       private void textBox5_TextChanged(object sender, EventArgs e)
       {

       }
    }
}
