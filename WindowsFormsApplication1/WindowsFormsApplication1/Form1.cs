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
            string text = (textBox1.Text);
            string text1 = (textBox2.Text);
            string text3 = (text.ToString() + " " + text1.ToString() + " ");


            textBox3.Text = text3.Substring(2); 
        }
    }
}
