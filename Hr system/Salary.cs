using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hr_system
{
    public partial class Salary : Form
    {
        SqlConnection cn;
        public Salary()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            int res;
            
                int sal = int.Parse(label3.Text);

                bool ans = int.TryParse(textBox1.Text,out res);
                if (ans)
                {
                    sal += int.Parse(textBox1.Text);
                
                }
                label3.Text = sal.ToString();
            
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            int res;

            int sal = int.Parse(label3.Text);

            bool ans = int.TryParse(textBox2.Text, out res);
            if (ans)
            {
                sal -= int.Parse(textBox2.Text);
                
            }
            label3.Text = sal.ToString();

        }

        private void Salary_Load(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=DESKTOP-I3DOUS2\MYSERVER;Initial Catalog=hr-system;Integrated Security=True");

            try
            {
                cn.Open();
                String query = "update salaries set salary ='" + label3.Text + "'";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.ExecuteNonQuery();

                label6.Visible = true;
                
                
                
                cn.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }
        }
    }
}
