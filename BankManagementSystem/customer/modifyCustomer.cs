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
    public partial class modifyCustomer : Form
    {
        public modifyCustomer()
        {
            InitializeComponent();
        }

        private void modifyCustomer_Load(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void view_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select *from customerInfo", con);

            try
            {
                DataTable data1 = new DataTable();
                sa.Fill(data1);

                dataGridView1.DataSource = data1;
            }
            catch
            {
                MessageBox.Show("No Date");
                con.Close();

            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            comboBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            //textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            //textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            //textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            //textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            //textBox6.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand("select *from customerInfo where account_no='" + textBox1.Text + "'", con);

            try
            {
                SqlDataReader sdr = sc.ExecuteReader();

                while (sdr.Read())
                {
                    textBox2.Text = sdr["FullName"].ToString();
                    textBox3.Text = sdr["email"].ToString();
                    textBox4.Text = sdr["phone"].ToString();
                    textBox5.Text = sdr["state"].ToString();
                    comboBox4.Text = sdr["city"].ToString();
                    textBox6.Text = sdr["zip"].ToString();
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
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();
              SqlCommand sc = new SqlCommand("update customerInfo set email='"+textBox3.Text+"',phone='"+textBox4.Text+"',city='"+comboBox4.Text+"',state='"+textBox5.Text+"',zip='"+textBox6.Text+"' where account_no='"+textBox1.Text+"' ", con);

            try
            {
                
                    sc.ExecuteNonQuery();
                    MessageBox.Show("Successfully uPDATED.");               
            }
            catch
            {
                MessageBox.Show("Error to save on database");
                con.Close();
            }

        }


        public void removeCustomerAcc()
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand("delete from customerAcc where account_no='" + textBox1.Text + "' ", con);

            try
            {

                sc.ExecuteNonQuery();
                MessageBox.Show("Delete Account Successfully.");
            }
            catch
            {
                MessageBox.Show("Error to Remove Customer Info");
                con.Close();
            }
           
            
        }

        private void remove_Click(object sender, EventArgs e)
        {

             
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand("delete from customerInfo where account_no='" + textBox1.Text + "' ", con);

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
            removeCustomerAcc();
            

        }
    }
}
