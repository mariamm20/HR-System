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
    
    public partial class AllTask : UserControl
    {
        SqlConnection cn;
        public AllTask()
        {
            InitializeComponent();
        }

        private void getdata()
        {
            cn = new SqlConnection(@"Data Source=DESKTOP-I3DOUS2\MYSERVER;Initial Catalog=hr-system;Integrated Security=True");
            cn.Open();
            String query = " select task from tasks";
            SqlDataAdapter sda = new SqlDataAdapter(query, cn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            DataTable ds = new DataTable();
            sda.Fill(ds);
            dataGridView1.DataSource = ds;


            cn.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AllTask_Load(object sender, EventArgs e)
        {
            getdata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            removetask r = new removetask();
            r.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
