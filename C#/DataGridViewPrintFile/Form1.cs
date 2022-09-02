using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewPrintFile
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

        int n = 5, m = 5;

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvTable.Visible = false;
        }

        private void nudNumber1_ValueChanged(object sender, EventArgs e)
        {
            int n = (int)nudNumber1.Value;
            int m = (int)nudNumber2.Value;
            if (n > 0 && m > 0)
            {
                dgvTable.Visible = true;
                InitializeDataGridView(dgvTable, n, m, 35, 20);
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                        dgvTable[j, i].Value = 0;
            }
        }

        private void btWrite_Click(object sender, EventArgs e)
        {
            int n = (int)nudNumber1.Value;
            int m = (int)nudNumber2.Value;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nameFile = saveFileDialog1.FileName;
                StreamWriter f = new StreamWriter(nameFile);
                try
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                            f.Write(Convert.ToInt32(dgvTable[j, i].Value) + "");
                        f.WriteLine();
                    }
                    f.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "ERROR");
                    f.Close();
                    File.Delete(nameFile);
                }
            }
        }

    }
}
