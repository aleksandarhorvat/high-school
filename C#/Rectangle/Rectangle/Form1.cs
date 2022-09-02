using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rectangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(tbX1.Text);
            double y1 = Convert.ToDouble(tbY1.Text);
            double x2 = Convert.ToDouble(tbX2.Text);
            double y2 = Convert.ToDouble(tbY2.Text);

            double d = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

            double a = d / Math.Sqrt(2);

            lbSurfaceArea.Text = (a * a).ToString("0.00");
            lbCircumference.Text = (4 * a).ToString("0.00");
        }
    }
}
