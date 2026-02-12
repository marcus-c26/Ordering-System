using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Ordering_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Form2 da=new Form2 ())
            {
                da.ShowDialog(); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Application.Exit();

           
           







        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent(); 
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
