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
    public partial class removetask : Form
    {
        SqlConnection cn;
        public removetask()
        {
            InitializeComponent();
        }
        private void removetask_Load(object sender, EventArgs e)
        {
            label6.Visible = false;
            cn = new SqlConnection(@"Data Source=DESKTOP-I3DOUS2\MYSERVER;Initial Catalog=hr-system;Integrated Security=True");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    cn.Open();
                    String query = "delete from tasks where task = ( '" + textBox1.Text + "')";
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

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
