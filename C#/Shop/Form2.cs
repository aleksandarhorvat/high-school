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

namespace Shop
{
    public partial class Form2 : Form
    {
        public bool state = false;
        public static OleDbConnection conn = new OleDbConnection();
        public static List<int> id = new List<int>();
        public static List<int> price = new List<int>();
        public static List<String> name = new List<String>();
        public static List<int> quantity = new List<int>();
        public Form2()
        {
            InitializeComponent();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Database.accdb";
        }

        public static void update()
        {
            conn.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM Data";
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (!id.Contains((int)reader.GetValue(0))) //adding a new one
                {
                    id.Add((int)reader.GetValue(0));
                    name.Add(reader.GetValue(1).ToString());
                    price.Add((int)reader.GetValue(2));
                    quantity.Add((int)reader.GetValue(3));
                }
                else //changing values
                {
                    int temp = id.IndexOf((int)reader.GetValue(0));
                    name[temp] = reader.GetValue(1).ToString();
                    price[temp] = (int)reader.GetValue(2);
                    quantity[temp] = (int)reader.GetValue(3);
                }

            }
            conn.Close();
        }

        public static void remove()
        {
            conn.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = conn;
            command.CommandText = "SELECT * FROM Data";
            OleDbDataReader reader = command.ExecuteReader();
            List<int> temp = new List<int>();
            while (reader.Read())
            {
                if (id.Contains((int)reader.GetValue(0)))
                {
                    temp.Add((int)reader.GetValue(0));
                }
            }
            int temp1 = 0;
            IEnumerable<int> pom = id.Except(temp);
            foreach (int i in pom)
                temp1 = i;
            temp1 = id.IndexOf(temp1);
            Console.Out.Write(temp1);
            id.RemoveAt(temp1);
            name.RemoveAt(temp1);
            price.RemoveAt(temp1);
            quantity.RemoveAt(temp1);
            conn.Close();
        }

        private void btReturn_Click(object sender, EventArgs e) //here, pressing the button switches to the first form
        {
            state = false;
            update();
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void tabelaBindingNavigatorSaveItem_Click(object sender, EventArgs e) //here, by pressing a button, we save the data in the database
        {
            this.Validate();
            this.dataBindingSource.EndEdit();
            this.dataAdapterManager.UpdateAll(this.databaseDataSet);
            if (state)
            {
                remove();
            }
            state = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Data' table. You can move, or remove it, as needed.
            this.dataTableAdapter.Fill(this.databaseDataSet.Data);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            state = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                picturesPictureBox.Image = Image.FromFile(openFileDialog.FileName);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            state = false;
            picturesPictureBox.Image = null;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            state = true;
        }
    }
}
