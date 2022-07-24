using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Hr_system
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 

            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-I3DOUS2\MYSERVER;Initial Catalog=hr-system;Integrated Security=True");

            cn.Open();
            string query = "SELECT * FROM admin WHERE username=@username AND pass=@pass";
            SqlCommand cmd;
            cmd = new SqlCommand(query, cn);

            //Adding Parameters
            cmd.Parameters.Add("@username", SqlDbType.VarChar);
            cmd.Parameters["@username"].Value = textBox1.Text;

            cmd.Parameters.Add("@pass", SqlDbType.VarChar);
            cmd.Parameters["@pass"].Value = textBox2.Text;

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Form2 board = new Form2();
                this.Hide();
                board.Show();
            }

            else 
            {
                label4.Visible = true;

                textBox1.Text = "";
                textBox2.Text = "";
                
                textBox1.Focus();

            }


           





            cn.Close();



            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }
    }
}
