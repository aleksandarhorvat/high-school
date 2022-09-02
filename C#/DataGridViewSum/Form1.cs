using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewSum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void InitializeDataGridView(DataGridView dgvTable, int n, int m, int w, int h)
        {
            dgvTable.AllowUserToAddRows = false;
            dgvTable.AllowUserToDeleteRows = false;
            dgvTable.AllowUserToOrderColumns = false;
            dgvTable.AllowUserToResizeColumns = false;
            dgvTable.AllowUserToResizeRows = false;
            dgvTable.ColumnHeadersVisible = false;
            dgvTable.RowHeadersVisible = false;
            dgvTable.ScrollBars = ScrollBars.None;
            dgvTable.RowCount = n;
            dgvTable.ColumnCount = m;
            dgvTable.Height = h * n + 3;
            dgvTable.Width = w * m + 3;
            for (int i = 0; i < n; i++)
            {
                dgvTable.Rows[i].Height = h;
            }
            for (int j = 0; j < m; j++)
            {
                dgvTable.Columns[j].Width = w;
            }
        }
        int n = 7, m = 9;
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeDataGridView(dgvTable, n, m, 30, 30);
        }

        Random r = new Random();

        private void btSum_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    sum += Convert.ToInt32(dgvTable[j, i].Value);
            tbResult.Text = sum.ToString();
        }

        private void btFill_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    dgvTable[j, i].Value = r.Next(100);
            tbResult.Clear();
        }
    }
}
