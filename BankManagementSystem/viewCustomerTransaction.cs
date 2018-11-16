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
    public partial class viewCustomerTransaction : Form
    {
        public viewCustomerTransaction(string value)
        {
            InitializeComponent();
            label12.Text = value;
            showw();
        }

        DataTable data1 = new DataTable();

        void showw()
        {


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select *from trans where account_no='"+label12.Text+"'", con);

            try
            {
              //    DataTable data1 = new DataTable();
                sa.Fill(data1);

                dataGridView1.DataSource = data1;
            }
            catch
            {
                MessageBox.Show("No Date");
                con.Close();

            }
        }

        private void viewCustomerTransaction_Load(object sender, EventArgs e)
        {
          //  showw();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }
    }
}
