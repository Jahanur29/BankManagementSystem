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
    public partial class employeUpdate : Form
    {
        public employeUpdate()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void view_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select *from employee", con);

            try
            {
                 DataTable data1 = new DataTable();
                dataGridView1.DataSource = data1;
                sa.Fill(data1);
               // sa.Fill()

                
            }
            catch
            {
                MessageBox.Show("No Date");
                con.Close();

            }
        }

        void showAddress()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand("select *from employeAddress where Employee_ID='" + textBox15.Text + "'", con);

            try
            {
                SqlDataReader sdr = sc.ExecuteReader();

                while (sdr.Read())
                {
                    textBox8.Text = sdr["Pr_flatNo"].ToString();


                    textBox9.Text = sdr["Pr_houseNo"].ToString();
                    textBox10.Text = sdr["Pr_flatNo"].ToString();

                    textBox11.Text = sdr["Pr_village"].ToString();
                    textBox12.Text = sdr["Pr_thana"].ToString();
                    textBox13.Text = sdr["Pr_district"].ToString();

                    textBox14.Text = sdr["Pr_postCode"].ToString();
                    // textBox10.Text = sdr["bloodgroup"].ToString();
                }

            }
            catch
            {
                MessageBox.Show("No Data");
                con.Close();
            }

        }



        private void search_Click(object sender, EventArgs e)
        {
            showAddress();


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand("select *from employee where Employee_ID='" + textBox15.Text + "'", con);

            try
            {
                SqlDataReader sdr = sc.ExecuteReader();

                while (sdr.Read())
                {
                    textBox1.Text = sdr["FullName"].ToString();
                    
                    
                    textBox5.Text = sdr["email"].ToString();
                    textBox6.Text = sdr["phone"].ToString();

                    textBox2.Text = sdr["Marital_____Status"].ToString();
                   // textBox10.Text = sdr["bloodgroup"].ToString();
                }

            }
            catch
            {
                MessageBox.Show("No Data");
                con.Close();
            }

        }

        private void update_Click(object sender, EventArgs e)
        {




        }

        public void removeEmployeeAddress()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand("delete from employeAddress where Employee_ID='" + textBox15.Text + "' ", con);

            try
            {

                sc.ExecuteNonQuery();
                MessageBox.Show("Delete Successfully.");
            }
            catch
            {
                MessageBox.Show("Error to Remove Customer Info");
                con.Close();
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you Delete Employee Information?",
           "Delete", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
             
                //Application.Exit();


                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
                con.Open();
                SqlCommand sc = new SqlCommand("delete from employee where Employee_ID='" + textBox15.Text + "' ", con);

                try
                {

                    sc.ExecuteNonQuery();
                    MessageBox.Show("Delete Successfully.");
                }
                catch
                {
                    MessageBox.Show("Error to Remove Customer Info");
                    con.Close();
                }
                removeEmployeeAddress();

            }
            else if (dialog == DialogResult.No)
            {

            }

           
        }

        private void clar_Click(object sender, EventArgs e)
        {

        }
    }
}
