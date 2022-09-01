using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SailingBoat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x, a, y;
        private void Form1_Load(object sender, EventArgs e)
        {
            a = 30; x = -a; y = ClientRectangle.Height / 2;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 4);
            g.DrawLine(pen, x - 2 * a, y, x - a, y + a);
            g.DrawLine(pen, x - a, y + a, x + a, y + a);
            g.DrawLine(pen, x + a, y + a, x + 2 * a, y);
            g.DrawLine(pen, x + 2 * a, y, x - 2 * a, y);
            g.DrawLine(pen, x, y - 2 * a, x + 2 * a, y - a);
            g.DrawLine(pen, x + 2 * a, y - a, x, y);
            g.DrawLine(pen, x, y, x, y - 2 * a);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            x += 5;
            Refresh();
        }

    }
}
