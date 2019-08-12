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
    public delegate void zdxx(string str1, string str);
    public delegate void ff(Test t);
    public partial class Form2 : Form
    {
        public zdxx zh;
        public ff f;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var str1 = comboBox1.Text;
            var str = textBox1.Text;
            if (str1 == "大写")
            {
                textBox1.Text = str.ToUpper();
            }
            else {
                textBox1.Text = str.ToLower();
            }
            zh(str1, str);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Test t = new Test();
            
            f(t);
        }
        
    }
}
