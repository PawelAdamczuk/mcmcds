using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mcmcds
{
    public partial class FormAddMeal : Form
    {
        private string connectionString;
        private List<string> itemList;

        public FormAddMeal(String _connectionString)
        {
            this.connectionString = _connectionString;
            itemList = new List<string>();
            InitializeComponent();

        }

        public FormAddMeal()
        {
            InitializeComponent();
        }

        private void FormAddMeal_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT name, CAST ( price AS float )/100 AS \"price\", description FROM ITEMS", conn);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);

                DataSet ds = new DataSet();

                da.Fill(ds);

                dataGridView_items.DataSource = ds.Tables[0];

            }
        }

        private void button_AddItem_Click(object sender, EventArgs e)
        {
             listView_mealItems.Items.Add(dataGridView_items.SelectedRows[0].Cells["name"].Value.ToString());
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            try
            {
                listView_mealItems.SelectedItems[0].Remove();
                }
            catch (Exception exception)
            {
                MessageBox.Show("Idiot...");
                MessageBox.Show("There's nothing to delete.");
            }
        }
    }
}
