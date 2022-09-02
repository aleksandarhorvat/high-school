using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitWords
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string s = textBox1.Text, firstWord, secondWord;
                int a = s.IndexOf(" ");
                firstWord = s.Substring(0, a);
                secondWord = s.Substring(a + 1);
                listBox1.Items.Add(firstWord);
                listBox2.Items.Add(secondWord);
                textBox1.Text = "";
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    string s = textBox1.Text, firstWord, secondWord;
                    int a = s.IndexOf(" ");
                    firstWord = s.Substring(0, a);
                    secondWord = s.Substring(a + 1);
                    listBox1.Items.Add(firstWord);
                    listBox2.Items.Add(secondWord);
                    textBox1.Text = "";
                }
        }
    }
}
