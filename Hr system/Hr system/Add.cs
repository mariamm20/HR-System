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
    public partial class Add : Form
    {
        SqlConnection cn;
        public Add()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            label6.Visible = false;
            cn = new SqlConnection(@"Data Source=DESKTOP-I3DOUS2\MYSERVER;Initial Catalog=hr-system;Integrated Security=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    cn.Open();
                    String query = " insert into empolyee Values ( '" + textBox1.Text + "')";
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
}
