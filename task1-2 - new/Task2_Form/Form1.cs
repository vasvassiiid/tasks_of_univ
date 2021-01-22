using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2_Form
{
    public partial class Form1 : Form
    {
        private string lines = System.IO.File.ReadAllText(@"C:\Users\HP\RiderProjects\tasks\taskOne\input.txt");
        private int number;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = lines;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextClass answer = new TextClass(lines);
            char[] text = lines.ToCharArray();
            List<char> ans = new List<char>();
            ans = answer.Function1(text);
            string str = answer.ConvertInStr(ans);
            textBox2.Text = str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextClass answer = new TextClass(lines);
            char[] text = lines.ToCharArray();
            List<char> ans = new List<char>();
            ans = answer.Function2(text);
            string str = answer.ConvertInStr(ans);
            textBox2.Text = str;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextClass answer = new TextClass(lines);
            char[] text = lines.ToCharArray();
            List<char> ans = new List<char>();
            ans = answer.Function3(text);
            string str = answer.ConvertInStr(ans);
            textBox2.Text = str;
        }

    }
}
