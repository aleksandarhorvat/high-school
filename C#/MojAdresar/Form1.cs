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

namespace MojAdresar
{
    public partial class Form1 : Form
    {
        private OleDbConnection conn = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = AdresarBaza.accdb";
        }

        private void podaciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.podaciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.adresarBazaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adresarBazaDataSet.Podaci' table. You can move, or remove it, as needed.
            this.podaciTableAdapter.Fill(this.adresarBazaDataSet.Podaci);

        }

        private void btDodajSliku_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                slikaPictureBox.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void btObrisiSliku_Click(object sender, EventArgs e)
        {
            slikaPictureBox.Image = null;
        }

        private void btPronadji_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "select * from Podaci where Ime like('%" + tbPretraga.Text + "%') or Prezime like('%" +
            tbPretraga.Text + "%') ";
            OleDbCommand command = new OleDbCommand(query, conn);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            da.Fill(dt);
            podaciDataGridView.DataSource = dt;
            conn.Close();
        }
    }
}
