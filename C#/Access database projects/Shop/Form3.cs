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
    public partial class Form3 : Form
    {
        public int[] id = Form2.id.ToArray();
        public String[] name = Form2.name.ToArray();
        public int[] price = Form2.price.ToArray();
        public int[] quantity = Form2.quantity.ToArray();
        public int cena = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < id.Length; i++)
            {
                if (id[i].ToString().CompareTo(textBox1.Text) == 0 && quantity[i] >= Int32.Parse(textBox2.Text))
                {
                    lbCart.Items.Add(id[i] + "|" + Int32.Parse(textBox2.Text) + "|" + (Int32.Parse(textBox2.Text) * price[i]));
                    cena += (Int32.Parse(textBox2.Text) * price[i]);
                    quantity[i] -= Int32.Parse(textBox2.Text);
                    Form2.quantity[i] = quantity[i];
                    Form2.conn.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = Form2.conn;
                    command.CommandText = "UPDATE Data SET Quantities=" + Form2.quantity[i] + " WHERE ID=" + Form2.id[i] + "";
                    command.ExecuteNonQuery();
                    Form2.conn.Close();
                }
            }
            textBox3.Text = cena.ToString();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            String[] temp = lbCart.Items[Int32.Parse(textBox4.Text) - 1].ToString().Split('|');
            int tempID = Int32.Parse(temp[0]);
            int tempQuantity = Int32.Parse(temp[1]);
            int tempPrice = Int32.Parse(temp[2]);
            cena -= tempPrice;
            textBox3.Text = cena.ToString();
            Form2.conn.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = Form2.conn;
            command.CommandText = "UPDATE Data SET Quantities=" + (Form2.quantity[Form2.id.IndexOf(tempID)] + tempQuantity) + " WHERE ID=" + tempID + "";
            command.ExecuteNonQuery();
            Form2.conn.Close();
            lbCart.Items.RemoveAt(Int32.Parse(textBox4.Text) - 1);
        }
    }
}
