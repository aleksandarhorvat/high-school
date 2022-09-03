using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        private OleDbConnection conn = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Database.accdb";
            dates_of_birthDateTimePicker.CustomFormat = "dd/MM/yyyy";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Data' table. You can move, or remove it, as needed.
            this.dataTableAdapter.Fill(this.databaseDataSet.Data);

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);
        }

        private void btAddPicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                picturesPictureBox.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void btDeletePicture_Click(object sender, EventArgs e)
        {
            picturesPictureBox.Image = null;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "select * from Data where Names like('%" + tbSearch.Text + "%') or Surnames like('%" +
            tbSearch.Text + "%') ";
            OleDbCommand command = new OleDbCommand(query, conn);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            da.Fill(dt);
            dataDataGridView.DataSource = dt;
            conn.Close();
        }
    }
}
