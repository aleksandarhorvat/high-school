using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathOperations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            double a, c = 0;
            a = Convert.ToInt32(tbA.Text);
            bool ok = true;
            switch (cmbChoice.SelectedIndex)
            {
                case 0:
                    if (a != 0)
                        c = 1 / a;
                    else
                        ok = false;
                    break;

                case 1:
                    if (a >= 0)
                        c = Math.Sqrt(a);
                    else
                        ok = false;
                    break;

                case 2: c = a * a; break;
                case 3: c = a * a * a; break;
            }
            if (ok)
                lbResult.Text = c.ToString();
            else
                lbResult.Text = "Erorr!";
        }

        private void cmbChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbResult.Text = "";
        }
    }
}
