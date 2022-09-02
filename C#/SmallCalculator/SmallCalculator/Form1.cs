using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAddition_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(tbEnterFirst.Text);
            b = Convert.ToDouble(tbEnterSecond.Text);
            c = a + b;
            lbResult.Text = c.ToString("F"); // "F" rounds to two decimal places
        }

        private void btSubstraction_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(tbEnterFirst.Text);
            b = Convert.ToDouble(tbEnterSecond.Text);
            c = a - b;
            lbResult.Text = c.ToString("F"); // "F" rounds to two decimal places
        }

        private void btMultiplication_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(tbEnterFirst.Text);
            b = Convert.ToDouble(tbEnterSecond.Text);
            c = a * b;
            lbResult.Text = c.ToString("F"); // "F" rounds to two decimal places
        }

        private void btDivision_Click(object sender, EventArgs e)
        {
                double a, b, c;
                a = Convert.ToDouble(tbEnterFirst.Text);
                b = Convert.ToDouble(tbEnterSecond.Text);
                if(b==0)
                {
                    MessageBox.Show("Nije moguce deljenje sa nulom!");
                }
                else
                {
                    c = a / b;
                    lbResult.Text = c.ToString("F"); // "F" rounds to two decimal places
            }

        }
    }
}
