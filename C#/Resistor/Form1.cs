using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resistor
{
    public partial class Form1 : Form
    {
        double a,b,c,m,t,y,x1,x2;
        public Form1()
        {
            InitializeComponent();
        }

        private void rbBand1Black_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBand1Black.Checked == true)
            {
                a = 0;
                pBand1.BackColor = Color.Black;
            }
        }

        private void rbBand1Brown_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBand1Brown.Checked == true)
            {
                a = 10;
                pBand1.BackColor = Color.Sienna;
            }
        }

        private void rbBand1Red_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBand1Red.Checked == true)
            {
                a = 20;
                pBand1.BackColor = Color.Red;
            }
        }

        private void rbBand1Orange_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBand1Orange.Checked == true)
            {
                a = 30;
                pBand1.BackColor = Color.DarkOrange;
            }
        }

        private void rbBand1Yellow_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBand1Yellow.Checked == true)
            {
                a = 40;
                pBand1.BackColor = Color.Yellow;
            }
        }

        private void rbBand1Green_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBand1Green.Checked == true)
            {
                a = 50;
                pBand1.BackColor = Color.Green;
            }
        }

        private void rbBand1Blue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBand1Blue.Checked == true)
            {
                a = 60;
                pBand1.BackColor = Color.RoyalBlue;
            }
        }

        private void rbBand1Pink_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBand1Pink.Checked == true)
            {
                a = 70;
                pBand1.BackColor = Color.Violet;
            }
        }

        private void rbBand1Grey_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBand1Grey.Checked == true)
            {
                a = 80;
                pBand1.BackColor = Color.Gray;
            }
        }

        private void rbBand1White_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBand1White.Checked == true)
            {
                a = 90;
                pBand1.BackColor = Color.White;
            }
        }

        private void rbBand2Black_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBand2Black.Checked == true)
            {
                b = 0;
                pBand2.BackColor = Color.Black;
            }
        }

        private void rbBand2Brown_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBand2Brown.Checked == true)
            {
                b = 1;
                pBand2.BackColor = Color.Sienna;
            }
        }

        private void rbBand2Orange_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBand2Orange.Checked == true)
            {
                b = 3;
                pBand2.BackColor = Color.DarkOrange;
            }
        }

        private void rbBand2Yellow_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBand2Yellow.Checked == true)
            {
                b = 4;
                pBand2.BackColor = Color.Yellow;
            }
        }

        private void rbBand2Green_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBand2Green.Checked == true)
            {
                b = 5;
                pBand2.BackColor = Color.Green;
            }
        }

        private void rbBand2Blue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBand2Blue.Checked == true)
            {
                b = 6;
                pBand2.BackColor = Color.RoyalBlue;
            }
        }

        private void rbMulBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMulBlack.Checked == true)
            {
                m = 1;
                pMul.BackColor = Color.Black;
            }
        }

        private void rbMulBrown_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMulBrown.Checked == true)
            {
                m = 10;
                pMul.BackColor = Color.Sienna;
            }
        }

        private void rbMulRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMulRed.Checked == true)
            {
                m = 100;
                pMul.BackColor = Color.Red;
            }
        }

        private void rbMulOrange_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMulOrange.Checked == true)
            {
                m = 1000;
                pMul.BackColor = Color.DarkOrange;
            }
        }

        private void rbMulYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMulYellow.Checked == true)
            {
                m = 10000;
                pMul.BackColor = Color.Yellow;
            }
        }

        private void rbMulGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMulGreen.Checked == true)
            {
                m = 100000;
                pMul.BackColor = Color.Green;
            }
        }

        private void rbMulBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMulBlue.Checked == true)
            {
                m = 1000000;
                pMul.BackColor = Color.RoyalBlue;
            }
        }

        private void rbMulPink_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMulPink.Checked == true)
            {
                m = 10000000;
                pMul.BackColor = Color.Violet;
            }
        }

        private void rbMulGold_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMulGold.Checked == true)
            {
                m = 0.1;
                pMul.BackColor = Color.Goldenrod;
            }
        }

        private void rbMulSilver_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMulSilver.Checked == true)
            {
                m = 0.01;
                pMul.BackColor = Color.Silver;
            }
        }

        private void rbTolBrown_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTolBrown.Checked == true)
            {
                t = 1;
                pTol.BackColor = Color.Sienna;
            }
        }

        private void rbTolRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTolRed.Checked == true)
            {
                t = 2;
                pTol.BackColor = Color.Red;
            }
        }

        private void rbTolGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTolGreen.Checked == true)
            {
                t = 0.5;
                pTol.BackColor = Color.Green;
            }
        }

        private void rbTolBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTolBlue.Checked == true)
            {
                t = 0.25;
                pTol.BackColor = Color.RoyalBlue;
            }
        }

        private void rbTolPink_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTolPink.Checked == true)
            {
                t = 0.10;
                pTol.BackColor = Color.Violet;
            }
        }

        private void rbTolGrey_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTolGrey.Checked == true)
            {
                t = 0.05;
                pTol.BackColor = Color.Gray;
            }
        }

        private void btSwitch_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

        private void rbTolGold_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTolGold.Checked == true)
            {
                t = 5;
                pTol.BackColor = Color.Goldenrod;
            }
        }

        private void rbTolSilver_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTolSilver.Checked == true)
            {
                t = 10;
                pTol.BackColor = Color.Silver;
            }
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            c = a + b;
            y = c * m;
            x1 = y - t;
            x2 = y + t;
            if(m==0.1 || m==0.01)
            {
                lbMin.Text = Convert.ToString(x1);
                lbMax.Text = Convert.ToString(x2);
            }
            else
            {
                lbMin.Text = Convert.ToString(x1) + "Ω";
                lbMax.Text = Convert.ToString(x2) + "Ω";
            }
        }

        private void rbBand2Pink_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBand2Pink.Checked == true)
            {
                b = 7;
                pBand2.BackColor = Color.Violet;
            }
        }

        private void rbBand2Grey_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBand2Grey.Checked == true)
            {
                b = 8;
                pBand2.BackColor = Color.Gray;
            }
        }

        private void rbBand2White_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBand2White.Checked == true)
            {
                b = 9;
                pBand2.BackColor = Color.White;
            }
        }

        private void rbBand2Red_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBand2Red.Checked == true)
            {
                b = 2;
                pBand2.BackColor = Color.Red;
            }
        }

    }
}
