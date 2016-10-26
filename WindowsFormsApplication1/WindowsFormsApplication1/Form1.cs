using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = (textBox1.Text);
            string name2 = (textBox2.Text);
            string name3 = (name.ToString() + " " + name2.ToString() + " ");
            textBox3.Text = name3.ToString(); 
        }
    }
}
