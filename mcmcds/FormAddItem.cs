using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace mcmcds
{
    public partial class FormAddItem : Form
    {
        private string connectionString;

        public FormAddItem()
        {
            InitializeComponent();
        }

        public FormAddItem(String _connectionString)
        {
            this.connectionString = _connectionString;
            InitializeComponent();

        }

        private bool isValid()
        {
            if (!Utilities.TextValid(textBox_name.Text))
                return false;
            if (!Utilities.TextValid(textBox_price.Text))
                return false;
            if (!Utilities.TextValid(textBox_description.Text))
                return false;
            if (!Utilities.TextValid(textBoxMaxStock.Text))
                return false;
            return true;
        }

        private void FormAddItem_Load(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (!isValid())
            {
                MessageBox.Show("Input contains illegal characters.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                
                try
                {
                    int priceInt = Utilities.PriceField(textBox_price.Text);
                    conn.Open();
                    string command = "INSERT into ITEMS (name, price, description, stock, max_stock) " +
                                     $"VALUES ('{textBox_name.Text}', '{priceInt}', '{textBox_description.Text}', {textBoxMaxStock.Text}, {textBoxMaxStock.Text});";
                    SqlCommand insertQuery = new SqlCommand(command, conn);
                    insertQuery.ExecuteNonQuery();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error while inserting: " + exception.Message);
                    return;
                }
                MessageBox.Show("Added item.");
            }

        }
    }
}
