using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hr_system
{
    public partial class HomeControl : UserControl
    {
        public HomeControl()
        {
            InitializeComponent();
        }
        //private void usercontrol(Control uc)
        //    {
        //    HomeControl c = new HomeControl();
        //        c.Controls.Clear();
        //        uc.Dock = DockStyle.Fill;
        //        c.Controls.Clear();
        //       c.Controls.Add(uc);
            

        //}
        private void button2_Click(object sender, EventArgs e)
        {
            using (Add a = new Add())
            {
                a.ShowDialog();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(Remove r = new Remove())
            {
                r.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using(Add_task t = new Add_task())
            {
                t.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Salary s = new Salary())
            {
                s.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HomeControl_Load(object sender, EventArgs e)
        {
            
        }
    }
}
