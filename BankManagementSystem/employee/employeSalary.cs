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
    public partial class employeSalary : Form
    {
        public employeSalary()
        {
            InitializeComponent();
        }


       
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();
            

          //  string date = comboBox1.Text.ToString() + "-" + comboBox2.Text.ToString() + "-" + comboBox3.Text.ToString();
            SqlCommand sc = new SqlCommand("insert into employeePossition(position,BP,HR,MA,transport,PF,INS,WF) values('" + textBox2.Text + "','" + textBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')", con);

            try
            {
               
                
                    sc.ExecuteNonQuery();

                    MessageBox.Show("Successfully Saved Employee Possition.");
                
            }
            catch(Exception ex)
            {
                //Error when save data

                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void employeSalary_Load(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
           
            con.Open();
            SqlCommand cmd = new SqlCommand("update employeePossition set BP='" + textBox1.Text + "',HR='" + textBox4.Text + "',MA='" + textBox5.Text + "',transport='" + textBox6.Text + "',PF='" + textBox7.Text + "',INS='" + textBox8.Text + "',WF='" + textBox9.Text + "' where position='" + textBox2.Text + "'", con);

            try
            {
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(" update SuccesfullY ");
            }

            catch
            {
                MessageBox.Show("ErrOr");
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {

             SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
           
            con.Open();

            try{
                    // SqlDataAdapter sa = new SqlDataAdapter("delete from IT where Student_ID='" + textBox1.Text + "'", con);
                    SqlCommand sc = new SqlCommand("delete from employeeposition where position='" + textBox2.Text + "'", con);
                    sc.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Delete SuccesFully. ");
                }
        
              catch(Exception ex)  {


                  MessageBox.Show(ex.Message);
                }
        }



        private void search_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");


            con.Open();
            // SqlDataAdapter sa = new SqlDataAdapter("delete from IT where Student_ID='" + textBox1.Text + "'", con);
            SqlCommand sc = new SqlCommand("select *from employeePossition where position='" + textBox2.Text + "'", con);
            try
            {
                SqlDataReader sdr = sc.ExecuteReader();

                while (sdr.Read())
                {
                    textBox1.Text = sdr["BP"].ToString();
                    textBox4.Text = sdr["HR"].ToString();
                    textBox5.Text = sdr["MA"].ToString();
                    textBox6.Text = sdr["transport"].ToString();
                    textBox7.Text = sdr["PF"].ToString();
                    textBox8.Text = sdr["INS"].ToString();
                    textBox9.Text = sdr["WF"].ToString();


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
