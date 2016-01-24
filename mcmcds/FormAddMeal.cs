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
        private int priceSum;

        private bool isValid()
        {
            if (!Utilities.TextValid(textBox_mealName.Text))
                return false;
            if (!Utilities.TextValid(textBox_mealPrice.Text))
                return false;
            return true;
        }

        public FormAddMeal(String _connectionString)
        {
            this.connectionString = _connectionString;
            itemList = new List<string>();
            priceSum = 0;
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
                SqlDataAdapter da = new SqlDataAdapter("SELECT id, name, CAST ( price AS float )/100 AS \"price\", description FROM ITEMS", conn);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);

                DataSet ds = new DataSet();

                da.Fill(ds);

                dataGridView_items.DataSource = ds.Tables[0];

            }
        }

        private void button_AddItem_Click(object sender, EventArgs e)
        {
            listView_mealItems.Items.Add(dataGridView_items.SelectedRows[0].Cells["name"].Value.ToString());
            //MessageBox.Show(dataGridView_items.SelectedRows[0].Cells["price"].ToString());
            priceSum += (Utilities.PriceField(dataGridView_items.SelectedRows[0].Cells["price"].Value.ToString()));

            textBox_calculatedPrice.Text = (((double)priceSum)/100).ToString();
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            try
            {
                for(int i = 0; i < dataGridView_items.RowCount; ++i){
                    if(dataGridView_items.Rows[i].Cells["name"].Value.ToString().Equals(listView_mealItems.SelectedItems[0].Text)) {
                        priceSum -= (Utilities.PriceField(dataGridView_items.Rows[i].Cells["price"].Value.ToString()));
                    }
                }

                textBox_calculatedPrice.Text = (((double)priceSum) / 100).ToString();
                listView_mealItems.SelectedItems[0].Remove();

                
            }
            catch (Exception exception)
            {
                MessageBox.Show("There's nothing to delete.");
            }
        }

        private void button_addMeal_Click(object sender, EventArgs e)
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
                    int priceInt = Utilities.PriceField(textBox_mealPrice.Text);
                    conn.Open();
                    string command = "INSERT into MEALS (name, discount) " +
                                     $"VALUES ('{textBox_mealName.Text}', '{(int)(priceSum)-priceInt}') SET @ID = SCOPE_IDENTITY();";
                    SqlCommand insertQuery = new SqlCommand(command, conn);

                    insertQuery.Parameters.Add("@ID", SqlDbType.Int, 4).Direction = ParameterDirection.Output;
                    insertQuery.ExecuteNonQuery();
                    Utilities.appendToFile(insertQuery.CommandText);

                    int mealId = (int)insertQuery.Parameters["@ID"].Value;

                    foreach (ListViewItem li in listView_mealItems.Items)
                    {

                        int itemId = 190;
                        for (int i = 0; i < dataGridView_items.RowCount; ++i)
                        {
                            if (dataGridView_items.Rows[i].Cells["name"].Value.ToString().Equals(li.Text))
                            {
                                itemId = (int)dataGridView_items.Rows[i].Cells["id"].Value;
                            }
                        }

                        string command2 = "INSERT into MEALS_ITEMS (meal_id, item_id) " +
                                          $"VALUES ({mealId}, {itemId});";
                        SqlCommand insertQuery2 = new SqlCommand(command2, conn);
                        insertQuery2.Parameters.Add("@ID", SqlDbType.Int, 4).Direction = ParameterDirection.Output;
                        insertQuery2.ExecuteNonQuery();
                        Utilities.appendToFile(insertQuery2.CommandText);
                    }
                    
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
