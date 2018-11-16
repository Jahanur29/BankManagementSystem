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
    public partial class addCustomer : Form
    {
        public addCustomer()
        {
            InitializeComponent();
        }
        string gender;

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        public void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void save_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();
            string fullName = textBox2.Text.ToString() + " " + textBox3.Text.ToString();

            string date = comboBox1.Text.ToString() + "-" + comboBox2.Text.ToString() + "-" + comboBox3.Text.ToString();
            SqlCommand sc = new SqlCommand("insert into customerInfo(account_no,_date,FirstName,LastName,FullName,FatherName,sex,email,phone,city,state,zip,dateOfBirth,region,nationality) values('" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + fullName + "','" + textBox4.Text + "','" + gender + "','" + textBox5.Text + "','" + textBox6.Text + "','" + comboBox4.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + date + "','" + comboBox5.Text + "','" + textBox12.Text + "')", con);
          
            try
            {
                if (textBox1.Text != " ")
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

            textBox9.Text = textBox1.Text;


        }



        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
         //   + textBox1.Text + "','" + dateTimePicker1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + fullName + "','" + textBox4.Text + "','" + gender + "','" + textBox5.Text + "','" + textBox6.Text + "','" + comboBox4.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + date + "','" + comboBox5.Text + "','" + textBox12.Text + 
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            textBox7.Text = " ";
            textBox8.Text = " ";
            textBox12.Text = " ";
            comboBox5.Text = " ";
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            comboBox3.Text = " ";
            comboBox4.Text = " ";
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customerpassword()
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();
           SqlCommand sc = new SqlCommand("insert into customerPassword (account_no,password) values('"+textBox9.Text+"','"+textBox14.Text+"')", con);

            try
            {
                //  if (textBox1.Text != " ")
                //  {
                sc.ExecuteNonQuery();

              //  MessageBox.Show("Successfully Saved.");
                //   }
            }
            catch
            {
                //Error when save data

                MessageBox.Show("Error to save PIN");
                con.Close();
            }


        }



        private void saveAccountDetails_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();
            string fullName = textBox2.Text.ToString() + " " + textBox3.Text.ToString();

            string date = comboBox1.Text.ToString() + "-" + comboBox2.Text.ToString() + "-" + comboBox3.Text.ToString();
            SqlCommand sc = new SqlCommand("insert into customerAcc(account_no,acc_Type,amount,overdraft_amount,overdraft_limit) values('" + textBox9.Text + "','" + comboBox6.Text+ "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox13.Text + "')", con);

            try
            {
              //  if (textBox1.Text != " ")
              //  {
                    sc.ExecuteNonQuery();

                    MessageBox.Show("Successfully Saved.");
             //   }
            }
            catch
            {
                //Error when save data

                MessageBox.Show("Error to save on database");
                con.Close();
            }

            customerpassword();

        }

        private void back_Click(object sender, EventArgs e)
        {
            
        }

        private void backCustomerInfo_Click(object sender, EventArgs e)
        {
            
            
        }

        private void addCustomer_Load(object sender, EventArgs e)
        {



            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand("select * from accountType", con);
            // try
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
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
