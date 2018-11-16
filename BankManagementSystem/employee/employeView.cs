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
    public partial class employeView : Form
    {
        public employeView()
        {
            InitializeComponent();
        }
       
         DataTable data1 = new DataTable();
         
        private void button1_Click(object sender, EventArgs e)
        {

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



        private void viewAll_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select  *from employee", con);

            try { 
           // DataTable data1 = new DataTable();
            sa.Fill(data1);

            dataGridView1.DataSource = data1;
            }
            catch {
                MessageBox.Show("No Date");
            con.Close();

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            DataView dv = new DataView(data1);
            dv.RowFilter=string.Format("FullName LIKE '%{0}%'",textBox1.Text);
            dataGridView1.DataSource=dv;

        }

        private void view_Click(object sender, EventArgs e)
        {

        }

        private void employeView_Load(object sender, EventArgs e)
        {
            showPosition();
        }
    }
}
