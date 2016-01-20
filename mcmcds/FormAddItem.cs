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
                StringBuilder price = new StringBuilder(textBox_price.Text);
                for(int i=0; i<price.Length; ++i){
                    if (price[i] == '.')
                        price[i] = ',';
                }
                
                try
                {
                    int priceInt = (int)(Double.Parse(price.ToString())*100);
                    conn.Open();
                    string command = "INSERT into ITEMS (name, price, description) " +
                                     $"VALUES ('{textBox_name.Text}', '{priceInt}', '{textBox_description.Text}');";
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
