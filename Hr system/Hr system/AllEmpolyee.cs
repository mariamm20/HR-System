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
    public partial class AllEmpolyee : UserControl
    {
        SqlConnection cn;
        public AllEmpolyee()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }
        private void getdata()
        {
            cn = new SqlConnection(@"Data Source=DESKTOP-I3DOUS2\MYSERVER;Initial Catalog=hr-system;Integrated Security=True");
            cn.Open();
            String query = " select Ename from empolyee";
            SqlDataAdapter sda = new SqlDataAdapter(query, cn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            DataTable ds = new DataTable();
            sda.Fill(ds);
            dataGridView1.DataSource = ds;
            
            
            cn.Close();
        }
        private void AllEmpolyee_Load(object sender, EventArgs e)
        {

            getdata();
        }

      
        }
    }

