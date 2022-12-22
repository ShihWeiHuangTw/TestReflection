using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestLib
{
    public partial class FormCal : Form
    {
        public FormCal()
        {
            InitializeComponent();
        }

        public void SetValue(int x, int y)
        {
            textBox1.Text = x.ToString();
            textBox2.Text = y.ToString();
            Console.WriteLine($"x = {textBox1.Text},y = {textBox2.Text}");
        }

        public void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToInt32(textBox1.Text.Trim()) + Convert.ToInt32(textBox2.Text.Trim())).ToString();
            Console.WriteLine($"x = {textBox1.Text}");
            Console.WriteLine($"y = {textBox2.Text}");
            Console.WriteLine($"sum = {textBox3.Text}");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
