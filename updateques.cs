using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam__System
{
    public partial class updateques : Form
    {
        public updateques()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8EPR46S\SQLEXPRESS;Initial Catalog=student;Integrated Security=True;TrustServerCertificate=True");
        private void update_Click(object sender, EventArgs e)
        {
            if (textBoxid.Text == "" || textBoxfristname.Text == "" || textBoxlastnmae.Text == "" || textBoxusername.Text == "" || textBoxDept.Text == "" || textBoxDept.Text == ""  || comboBox1.Text == "")
            {
                MessageBox.Show("Missing Information!!!");
            }
            else
            {
                try
                {
                   
                    con.Open();
                    string query = "update register set fristname='" + textBoxfristname.Text + "',lastname='" + textBoxlastnmae.Text + "',username='" + textBoxusername.Text + "',dept=" + textBoxDept.Text + ",gender='" + comboBox1.Text + "' where id=" + 4419+ ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update   Successfully!!!");
                    con.Close();
                  
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
