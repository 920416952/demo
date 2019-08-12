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
            Form2 f = new Form2();
            f.zh = delegate(string str1, string str)
            {
                if (str1 == "大写")
                {
                    this.label1.Text = str.ToUpper();
                }
                else
                {
                    this.label1.Text = str.ToLower();
                }
            };
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.f = delegate(Test t)
            {
                this.label1.Text = t.A();
                
            };
            f1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.f = delegate(Test t)
            {
                this.label1.Text = Test.B();
            };
            f1.ShowDialog();
        }
    }
}
