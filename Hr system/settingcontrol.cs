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
    public partial class settingcontrol : UserControl
    {
        SqlConnection cn;
        public settingcontrol()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=DESKTOP-I3DOUS2\MYSERVER;Initial Catalog=hr-system;Integrated Security=True");

            try
            {
                cn.Open();
                String query = "update admin set username ='" + textBox1.Text + "' , pass = '"+textBox2.Text+"'";
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

        private void settingcontrol_Load(object sender, EventArgs e)
        {
            label6.Visible = false;
        }
    }
}
