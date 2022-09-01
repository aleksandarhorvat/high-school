using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        public int i = 0, number = 0;
        public Form1()
        {
            InitializeComponent();
            lbQuestions.Text = "Question number one";
            rbAnswer1.Text = "A1";
            rbAnswer2.Text = "B1";
            rbAnswer3.Text = "C1";
            rbAnswer4.Text = "D1";
            pbProgress.Increment(1);
        }

        private void rbAnswer1_Click(object sender, EventArgs e)
        {
            if (rbAnswer1.Text == "A2")
            {
                number = number + 1;
                lbBrojBodova.Text = number.ToString();
            }
            if (rbAnswer1.Text == "A5")
            {
                number = number + 1;
                lbBrojBodova.Text = number.ToString();
            }
            i = i + 1;
            next(i);
        }

        private void rbAnswer4_Click(object sender, EventArgs e)
        {
            if (rbAnswer4.Text == "D1")
            {
                number = number + 1;
                lbBrojBodova.Text = number.ToString();
            }
            i = i + 1;
            next(i);
        }

        private void rbAnswer3_Click(object sender, EventArgs e)
        {
            if (rbAnswer3.Text == "C3")
            {
                number = number + 1;
                lbBrojBodova.Text = number.ToString();
            }
            i = i + 1;
            next(i);
        }

        private void rbAnswer2_Click(object sender, EventArgs e)
        {
            if (rbAnswer2.Text == "B4")
            {
                number = number + 1;
                lbBrojBodova.Text = number.ToString();
            }
            i = i + 1;
            next(i);
        }

        private void rbFinish_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void next(int i)
        {
            switch (i)
            {
                case 1:
                    lbQuestions.Text = "Question number two";
                    rbAnswer1.Text = "A2";
                    rbAnswer2.Text = "B2";
                    rbAnswer3.Text = "C2";
                    rbAnswer4.Text = "D2";
                    pbProgress.Increment(1);
                    break;
                case 2:
                    lbQuestions.Text = "Question number three";
                    rbAnswer1.Text = "A3";
                    rbAnswer2.Text = "B3";
                    rbAnswer3.Text = "C3";
                    rbAnswer4.Text = "D3";
                    pbProgress.Increment(1);
                    break;
                case 3:
                    lbQuestions.Text = "Question number four";
                    rbAnswer1.Text = "A4";
                    rbAnswer2.Text = "B4";
                    rbAnswer3.Text = "C4";
                    rbAnswer4.Text = "D4";
                    pbProgress.Increment(1);
                    break;
                case 4:
                    lbQuestions.Text = "Question number five";
                    rbAnswer1.Text = "A5";
                    rbAnswer2.Text = "B5";
                    rbAnswer3.Text = "C5";
                    rbAnswer4.Text = "D5";
                    pbProgress.Increment(1);
                    break;
                case 5:
                    lbQuestions.Text = "You had " + number + " points!";
                    rbAnswer1.Visible = false;
                    rbAnswer2.Visible = false;
                    rbAnswer3.Visible = false;
                    rbAnswer4.Visible = false;
                    rbFinish.Visible = true;
                    break;
            }
        }
    }
}
