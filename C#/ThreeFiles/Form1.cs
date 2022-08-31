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

namespace ThreeFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbSelectFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbSelectFile.Text!= "Select a file")
            {
                StreamReader f = new StreamReader("../../Files/" + cbSelectFile.Text + ".txt");
                lbNumbers.Items.Clear();
                while(!f.EndOfStream)
                {
                    lbNumbers.Items.Add(f.ReadLine());
                }
                f.Close();
                gbChoice.Enabled = true;
                lRezultat.Text = "";
                rbMax.Checked = rbMaxNumberOfAppearances.Checked = rbAverage.Checked = false;
            }
        }

        private void rbMax_CheckedChanged(object sender, EventArgs e)
        {
            if(rbMax.Checked)
            {
                StreamReader f = new StreamReader("../../Files/" + cbSelectFile.Text + ".txt");
                int max, x;
                max = Convert.ToInt32(f.ReadLine());
                while(!f.EndOfStream)
                {
                    x = Convert.ToInt32(f.ReadLine());
                    if (x > max) max = x;
                }
                f.Close();
                lRezultat.Text = "Max number is " + max;
            }
        }

        private void rbMaxNumberOfAppearances_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMaxNumberOfAppearances.Checked)
            {
                StreamReader f = new StreamReader("../../Files/" + cbSelectFile.Text + ".txt");
                int max, x,bp;
                max = Convert.ToInt32(f.ReadLine());
                bp = 1;
                while (!f.EndOfStream)
                {
                    x = Convert.ToInt32(f.ReadLine());
                    if (x == max) bp++;
                    else if(x>max)
                    {
                        max = x;
                        bp = 1;
                    }
                }
                f.Close();
                lRezultat.Text = "The maximum number is " + max + " it appears " + bp +" time";
            }
        }

        private void rbAverage_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAverage.Checked)
            {
                StreamReader f = new StreamReader("../../Files/" + cbSelectFile.Text + ".txt");
                int x, sum=0,number=0;
                while (!f.EndOfStream)
                {
                    x = Convert.ToInt32(f.ReadLine());
                    sum += x;
                    number++;
                }
                f.Close();
                double p = sum * 1.0 / number;
                lRezultat.Text = "Average is " + p.ToString("0.00");
            }
        }
    }
}
