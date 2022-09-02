using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeleteFirstLastWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btFirst_Click(object sender, EventArgs e)
        {
            try
            {
                string s = textBox1.Text;
                int i = s.IndexOf(" ");
                textBox1.Text = s.Remove(0, i + 1);
            }
            catch
            {
                MessageBox.Show("There is only one word");
            }
        }

        private void btLast_Click(object sender, EventArgs e)
        {
            try
            {
                string s = textBox1.Text;
                int i = s.LastIndexOf(" ");
                textBox1.Text = s.Remove(i);
            }
            catch
            {
                MessageBox.Show("There is only one word");
            }
        }
    }
}
