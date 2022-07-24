using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hr_system
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            move(button4);
            AllEmpolyee s = new AllEmpolyee();
            usercontrol(s);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();

        }
        private void move(Button btn)
        {
            panelslide.Top = btn.Top;
            panelslide.Height = btn.Height;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            move(button3);
            HomeControl c = new HomeControl();
            usercontrol(c);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            move(button5);
            AllTask t = new AllTask();
            usercontrol(t);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            move(button6);
            settingcontrol s = new settingcontrol();
            usercontrol(s);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panelleft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            
               
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        private void usercontrol(Control uc)
        {
            panel6.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel6.Controls.Clear();
            panel6.Controls.Add(uc);       
        }
        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form2_Load_2(object sender, EventArgs e)
        {
            HomeControl c = new HomeControl();
            usercontrol(c);
        }
    }
}
