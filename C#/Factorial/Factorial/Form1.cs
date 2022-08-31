using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            double s = 1, i;
            double a = Convert.ToDouble(tbFirst.Text);
            for (i = 1; i <= a; i++)
            {
                s = s * i;
            }
            lbResult.Text = Convert.ToString(s);
        }
    }
}
