using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x, y, a;

        private void Form1_Load(object sender, EventArgs e)
        {
            a = 30; x = -a; y = ClientRectangle.Height / 2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x += 5; y -= 2;
            Refresh();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 4);
            g.DrawLine(pen, x, y - a, x, y + a);
            g.DrawLine(pen, x - a, y, x + a, y);
            g.DrawLine(pen, x - a, y, x, y - a);
            g.DrawLine(pen, x, y - a, x + a, y);
            g.DrawLine(pen, x - a, y, x, y + a);
            g.DrawLine(pen, x, y + a, x + a, y);
        }
    }
}
