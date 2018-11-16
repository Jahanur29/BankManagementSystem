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
    public partial class employeInfo : Form
    {
        public employeInfo()
        {
            InitializeComponent();
        }

        string gender;
        private void next_Click(object sender, EventArgs e)
        {
            employeInfo2 em = new employeInfo2();
            em.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        public void matchEmployeID()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand("select *from employee where Employee_ID='" + textBox1.Text + "'", con);

            try
            {
                SqlDataReader sdr = sc.ExecuteReader();

                while (sdr.Read())
                {
                   string eid = sdr["Employee_ID"].ToString();
                   if (eid==textBox1.Text)
                   {
                       MessageBox.Show("You enter same id ");
                      
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
            matchEmployeID();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();
            string fullName = textBox4.Text.ToString() +" " + textBox5.Text.ToString();

            string date = comboBox1.Text.ToString() + "-" + comboBox2.Text.ToString() + "-" + comboBox3.Text.ToString();
            SqlCommand sc = new SqlCommand("insert into employee(Employee_ID,NID,joinDate,Dept,FirstName,LastName,FullName,FatherName,MotherName,sex,email,phone,dateOfBirth,Region,bloodGroup,Marital_____Status) values('" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + fullName + "','" + textBox6.Text + "','" + textBox7.Text + "','" + gender + "','" + textBox8.Text + "','" + textBox9.Text + "','" + date + "','" + comboBox4.Text + "','" + comboBox5.Text + "','" + comboBox6.Text + "')",con);


            try
            {
                if (textBox1.Text != " ")
                {
                    sc.ExecuteNonQuery();

                    MessageBox.Show("Successfully Saved.");


                    employeInfo2 obj = new employeInfo2();
                    obj.Show();
                   // textBox1.Text = textBox99.Text;
                }
            }
            catch
            {
                //Error when save data

                MessageBox.Show("Error to save on database");
                con.Close();
            }

            
        }




        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            textBox7.Text = " ";
            textBox8.Text = " ";
           // textBox12.Text = " ";
            comboBox5.Text = " ";
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            comboBox3.Text = " ";
            comboBox4.Text = " ";
            gender = " ";
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            gender = "Female";
        }


        public void checkEmployeId()
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();


            string qry = "select count(Employee_ID) from employee";
            SqlCommand sc = new SqlCommand(qry, con);
            int a = 0 + (Int32)sc.ExecuteScalar();
            a = a++;

            if (a < 10)
            {
                string reg = a.ToString();
                textBox1.Text ="00"+ reg;
            }
            else if (a < 100)
            {
                string reg = a.ToString();
                textBox1.Text = "0" + reg;
            }
            else
            {
                string reg = a.ToString();
                textBox1.Text = reg;
            }
            //  MessageBox.Show(reg);
           // return reg; 

        }

        private void search_Click(object sender, EventArgs e)
        {
            checkEmployeId();
           
        }
    }
}
