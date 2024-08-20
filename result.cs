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
    public partial class result : Form
    {
        public result()
        {
            InitializeComponent();
            RadioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            radioButton10.Visible = false;
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8EPR46S\SQLEXPRESS;Initial Catalog=student;Integrated Security=True;TrustServerCertificate=True");
        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (RadioButton1.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("SELECT question,choseA,choseB,choseC,choseD,answr FROM answer WHERE id =1", con);
                    SqlDataReader red = cmd.ExecuteReader();
                    while (red.Read())
                    {

                        label2.Text = red.GetValue(5).ToString();
                       
                    }
                    red.Close();
                    cmd.ExecuteNonQuery();

                    con.Close();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (radioButton8.Text != "")
                {
                    SqlCommand cmmd = new SqlCommand("SELECT question,choseA,choseB,choseC,choseD,answr FROM answer WHERE id =8", con);
                    SqlDataReader red = cmmd.ExecuteReader();
                    while (red.Read())
                    {
                        label2.Text = red.GetValue(5).ToString();



                    }
                    red.Close();
                    cmmd.ExecuteNonQuery();

                    con.Close();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (radioButton2.Text != "")
                {
                    SqlCommand cmmd = new SqlCommand("SELECT question,choseA,choseB,choseC,choseD,answr FROM answer WHERE id =2", con);
                    SqlDataReader red = cmmd.ExecuteReader();
                    while (red.Read())
                    {
                        label2.Text = red.GetValue(5).ToString();
                      


                    }
                    red.Close();
                    cmmd.ExecuteNonQuery();

                    con.Close();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (guna2ComboBox1.SelectedIndex == 0)
            {

                RadioButton1.Visible = true;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                radioButton9.Visible = false;
                radioButton10.Visible = false;
            }
            else if ((guna2ComboBox1.SelectedIndex == 1))
            {
                RadioButton1.Visible = false;
                radioButton2.Visible = true;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                radioButton9.Visible = false;
                radioButton10.Visible = false;
            }
            else if ((guna2ComboBox1.SelectedIndex == 2))
            {
                RadioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = true;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                radioButton9.Visible = false;
                radioButton10.Visible = false;
            }
            else if ((guna2ComboBox1.SelectedIndex == 3))
            {
                RadioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = true;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                radioButton9.Visible = false;
                radioButton10.Visible = false;
            }
            else if ((guna2ComboBox1.SelectedIndex == 4))
            {
                RadioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = true;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                radioButton9.Visible = false;
                radioButton10.Visible = false;
            }
            else if ((guna2ComboBox1.SelectedIndex == 5))
            {
                RadioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = true;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                radioButton9.Visible = false;
                radioButton10.Visible = false;
            }
            else if ((guna2ComboBox1.SelectedIndex == 6))
            {
                RadioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = true;
                radioButton8.Visible = false;
                radioButton9.Visible = false;
                radioButton10.Visible = false;
            }
            else if ((guna2ComboBox1.SelectedIndex == 7))
            {
                RadioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                radioButton8.Visible = true;
                radioButton9.Visible = false;
                radioButton10.Visible = false;
            }
            else if ((guna2ComboBox1.SelectedIndex == 8))
            {
                RadioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                radioButton9.Visible = true;
                radioButton10.Visible = false;
            }
            else if ((guna2ComboBox1.SelectedIndex == 9))
            {
                RadioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                radioButton9.Visible = false;
                radioButton10.Visible = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (radioButton3.Text != "")
                {
                    SqlCommand cmmd = new SqlCommand("SELECT question,choseA,choseB,choseC,choseD,answr FROM answer WHERE id =3", con);
                    SqlDataReader red = cmmd.ExecuteReader();
                    while (red.Read())
                    {
                        label2.Text = red.GetValue(5).ToString();



                    }
                    red.Close();
                    cmmd.ExecuteNonQuery();

                    con.Close();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (radioButton4.Text != "")
                {
                    SqlCommand cmmd = new SqlCommand("SELECT question,choseA,choseB,choseC,choseD,answr FROM answer WHERE id =4", con);
                    SqlDataReader red = cmmd.ExecuteReader();
                    while (red.Read())
                    {
                        label2.Text = red.GetValue(5).ToString();



                    }
                    red.Close();
                    cmmd.ExecuteNonQuery();

                    con.Close();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (radioButton5.Text != "")
                {
                    SqlCommand cmmd = new SqlCommand("SELECT question,choseA,choseB,choseC,choseD,answr FROM answer WHERE id =5", con);
                    SqlDataReader red = cmmd.ExecuteReader();
                    while (red.Read())
                    {
                        label2.Text = red.GetValue(5).ToString();



                    }
                    red.Close();
                    cmmd.ExecuteNonQuery();

                    con.Close();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (radioButton6.Text != "")
                {
                    SqlCommand cmmd = new SqlCommand("SELECT question,choseA,choseB,choseC,choseD,answr FROM answer WHERE id =6", con);
                    SqlDataReader red = cmmd.ExecuteReader();
                    while (red.Read())
                    {
                        label2.Text = red.GetValue(5).ToString();



                    }
                    red.Close();
                    cmmd.ExecuteNonQuery();

                    con.Close();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void result_Load(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (radioButton7.Text != "")
                {
                    SqlCommand cmmd = new SqlCommand("SELECT question,choseA,choseB,choseC,choseD,answr FROM answer WHERE id =7", con);
                    SqlDataReader red = cmmd.ExecuteReader();
                    while (red.Read())
                    {
                        label2.Text = red.GetValue(5).ToString();



                    }
                    red.Close();
                    cmmd.ExecuteNonQuery();

                    con.Close();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (radioButton9.Text != "")
                {
                    SqlCommand cmmd = new SqlCommand("SELECT question,choseA,choseB,choseC,choseD,answr FROM answer WHERE id =9", con);
                    SqlDataReader red = cmmd.ExecuteReader();
                    while (red.Read())
                    {
                        label2.Text = red.GetValue(5).ToString();



                    }
                    red.Close();
                    cmmd.ExecuteNonQuery();

                    con.Close();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (radioButton10.Text != "")
                {
                    SqlCommand cmmd = new SqlCommand("SELECT question,choseA,choseB,choseC,choseD,answr FROM answer WHERE id =10", con);
                    SqlDataReader red = cmmd.ExecuteReader();
                    while (red.Read())
                    {
                        label2.Text = red.GetValue(5).ToString();



                    }
                    red.Close();
                    cmmd.ExecuteNonQuery();

                    con.Close();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
