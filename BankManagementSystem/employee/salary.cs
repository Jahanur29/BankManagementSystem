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
    public partial class salary : Form
    {
        public salary()
        {
            InitializeComponent();
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
          //  textBox9.Text = "0";
            textBox10.Text = "0";
        }


        void showPosition()
        {


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand("select * from employeePossition", con);
            // try
            {
                SqlDataReader dr = sc.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["position"]);
                    //  MessageBox.Show("New Club Added");

                }
                dr.Close();
                dr.Dispose();
            }
        }


        private void calculate_Click(object sender, EventArgs e)
        {
            int bp = Convert.ToInt32(textBox4.Text);
            int hr = Convert.ToInt32(textBox5.Text);
            int med = Convert.ToInt32(textBox6.Text);
            int ta = Convert.ToInt32(textBox7.Text);
            int da = Convert.ToInt32(textBox8.Text);

           int houseRent =( bp*hr)/100;
            textBox11.Text = houseRent.ToString();

            int medical = (bp * med) / 100;
            textBox12.Text = medical.ToString();

            int TA = (bp * ta) / 100;
            textBox13.Text = TA.ToString();

            int DA = (bp * da) / 100;
            textBox14.Text = DA.ToString();

            int a = Convert.ToInt32(textBox11.Text);
            int b = Convert.ToInt32(textBox12.Text);
            int c = Convert.ToInt32(textBox13.Text);
            int d = Convert.ToInt32(textBox14.Text);
            int f = Convert.ToInt32(textBox15.Text);
            int g = Convert.ToInt32(textBox3.Text);

            int totalSalary = a + b + c - d - f -g+ bp;
            textBox10.Text = totalSalary.ToString();

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand("insert into employeSalary(Employee_ID,possition,basicSalary,HR,medical,TA,DA,others,TotalSalary) values('" + textBox1.Text + "','" +comboBox1.Text + "','" + textBox4.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + textBox10.Text + "')", con);


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
        }

        private void reset_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox4.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            textBox7.Text = " ";
            textBox8.Text = " ";
          
            textBox10.Text = " ";

            textBox11.Text = " ";
            textBox12.Text = " ";
            textBox13.Text = " ";
            textBox14.Text = " ";

            textBox15.Text = " ";



        }

        private void back_Click(object sender, EventArgs e)
        {

        }

        private void salary_Load(object sender, EventArgs e)
        {
            showPosition();
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
                    //textBox3.Text = sdr["FatherName"].ToString();
                    //textBox5.Text = sdr["sex"].ToString();
                    //textBox6.Text = sdr["email"].ToString();
                    //textBox7.Text = sdr["phone"].ToString();
                    //textBox8.Text = sdr["dateOfBirth"].ToString();
                    //textBox9.Text = sdr["joinDate"].ToString();
                    //textBox10.Text = sdr["bloodgroup"].ToString();
                }

            }
            catch
            {
                MessageBox.Show("No Data");
                con.Close();
            }

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void searchPosition_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
           

                con.Open();
                // SqlDataAdapter sa = new SqlDataAdapter("delete from IT where Student_ID='" + textBox1.Text + "'", con);
                SqlCommand sc = new SqlCommand("select *from employeePossition where position='" + comboBox1.Text + "'", con);
                try
                {
                    SqlDataReader sdr = sc.ExecuteReader();

                    while (sdr.Read())
                    {
                        textBox4.Text = sdr["BP"].ToString();
                        textBox5.Text = sdr["HR"].ToString();
                        textBox6.Text = sdr["MA"].ToString();
                        textBox7.Text = sdr["transport"].ToString();
                        textBox8.Text = sdr["PF"].ToString();
                        textBox15.Text = sdr["INS"].ToString();
                        textBox3.Text = sdr["WF"].ToString();
                       

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

