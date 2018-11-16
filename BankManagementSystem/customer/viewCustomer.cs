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
    public partial class viewCustomer : Form
    {
        public viewCustomer()
        {
            InitializeComponent();
        }

        DataTable data1 = new DataTable();


        private void view_Click(object sender, EventArgs e)
        {
           // 
           // 
           // dataGridView1.Refresh();
            dataGridView1.DataSource = " ";
           
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select *from customerInfo", con);

            try
            {
              //  DataTable data1 = new DataTable();
                sa.Fill(data1);
                dataGridView1.DataSource = data1;
            }
            catch
            {
                MessageBox.Show("No Date");
                con.Close();

            }
          //  
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(data1);
            dv.RowFilter = string.Format("FullName LIKE '%{0}%'", textBox1.Text);
            dataGridView1.DataSource = dv;
        }

        private void clear_Click(object sender, EventArgs e)
        {
           // this.dataGridView1.Rows.Clear();
          //  this.dataGridView1.Columns.Clear();
           
        }
    }
}
