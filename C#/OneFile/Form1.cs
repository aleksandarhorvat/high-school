using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btDisplay_Click(object sender, EventArgs e)
        {
            if (rbBoth.Checked)
            {
                StreamReader f = new StreamReader("../../Files/File.txt");
                int x;
                lbNumbers.Items.Clear();
                while (!f.EndOfStream)
                {
                    x = Convert.ToInt32(f.ReadLine());
                    lbNumbers.Items.Add(Convert.ToString(x));
                }
                f.Close();
            }
            if (rbOdd.Checked)
            {
                StreamReader f = new StreamReader("../../Files/File.txt");
                int x;
                lbNumbers.Items.Clear();
                while (!f.EndOfStream)
                {
                    x = Convert.ToInt32(f.ReadLine());
                    if (x % 2 == 1)
                    {
                        lbNumbers.Items.Add(Convert.ToString(x));
                    }
                }
                f.Close();
            }
            if (rbEven.Checked)
            {
                StreamReader f = new StreamReader("../../Files/File.txt");
                int x;
                lbNumbers.Items.Clear();
                while (!f.EndOfStream)
                {
                    x = Convert.ToInt32(f.ReadLine());
                    if (x % 2 == 0)
                    {
                        lbNumbers.Items.Add(Convert.ToString(x));
                    }
                }
                f.Close();
            }
            tbNumber.Text = lbNumbers.Items.Count.ToString();
            int sum = 0;
            for (int i = 0; i < lbNumbers.Items.Count; i++)
            {
                sum += Convert.ToInt32(lbNumbers.Items[i]);
            }
            tbSum.Text =Convert.ToString(sum);
        }
    }
}
