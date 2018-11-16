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
    public partial class CustomerTransactionForAdmin : Form
    {
        public CustomerTransactionForAdmin()
        {
            InitializeComponent();
        }

        private void view_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select *from trans where account_no='" +textBox1.Text + "'", con);

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
    }
}
