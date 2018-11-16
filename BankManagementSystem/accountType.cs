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
    public partial class accountType : Form
    {
        public accountType()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\BankManagementSystem\BankManagementSystem\BankManagement.mdf;Integrated Security=True");
            con.Open();
            
            SqlCommand sc = new SqlCommand("insert into accountType(name) values('"+textBox4.Text+"')", con);

            try
            {
              
                    sc.ExecuteNonQuery();

                    MessageBox.Show("Successfully Saved.");
                
            }
            catch(Exception ex)
            {
                //Error when save data

                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
    }
}
