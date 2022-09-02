using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingWords
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.GreenYellow;
            label1.Text = "basics*of*programming*in*the*environment*of*graphic*operating*systems";
            label1.ForeColor = Color.Red;
            timer1.Interval = 500;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            string s = label1.Text;
            int position = s.IndexOf('*');
            string firstWord = s.Substring(0, position);
            s = s.Remove(0, position + 1);
            s += '*' + firstWord;
            label1.Text = s;
        }

    }
}
