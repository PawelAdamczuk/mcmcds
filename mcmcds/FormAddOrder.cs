using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mcmcds
{
    public partial class FormAddOrder : Form
    {
        private String connectionString;
        private DataSet dsItems;
        private DataSet dsMeals;
        private int price;
        private int employeeId;
        private List<DataRow> selectedRowList;
        private List<int> itemIdList; 
        public FormAddOrder(String connectionString, int employeeId)
        {
            this.connectionString = connectionString;
            this.employeeId = employeeId;
            selectedRowList = new List<DataRow>();
            itemIdList = new List<int>();
            InitializeComponent();
        }

        private void FormAddOrder_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                dsMeals = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("SELECT id, name, CAST ( price AS float )/100 AS \"price\", description FROM ITEMS", conn);
                new SqlCommandBuilder(da);
                dsItems = new DataSet();
                da.Fill(dsItems);
                da = new SqlDataAdapter("SELECT id, name, CAST ( discount AS float )/100 AS \"discount\", dbo.mealPrice(id) as price FROM MEALS", conn);
                new SqlCommandBuilder(da);
                da.Fill(dsMeals);
                dataGridItems.DataSource = dsItems.Tables[0];
                dataGridViewMeals.DataSource = dsMeals.Tables[0];
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            selectedRowList = new List<DataRow>();
            itemIdList = new List<int>();
            listView_mealItems.Items.Clear();
        }

        private void button_AddItem_Click(object sender, EventArgs e)
        {
            String it = dataGridItems.SelectedRows[0].Cells["name"].Value.ToString();
            listView_mealItems.Items.Add(it);
            price += Utilities.PriceField(dataGridItems.SelectedRows[0].Cells["price"].Value.ToString());
            itemIdList.Add(int.Parse(dataGridItems.SelectedRows[0].Cells["id"].Value.ToString()));
            textBox_calculatedPrice.Text = ((double)price/100).ToString();
        }

        private void buttonAddMeal_Click(object sender, EventArgs e)
        {
            String selectedMealId = dataGridViewMeals.SelectedRows[0].Cells["id"].Value.ToString();
            DataSet itemSet = new DataSet();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter itemAdapter = new SqlDataAdapter($"SELECT * FROM dbo.mealItems ({selectedMealId})", conn);
                itemAdapter.Fill(itemSet);
                foreach (DataRow row in itemSet.Tables[0].Rows)
                {
                    listView_mealItems.Items.Add(row["name"].ToString());
                    selectedRowList.Add(row);
                    price += Utilities.PriceField(row["price"].ToString());
                }
            }
            price -= Utilities.PriceField(dataGridViewMeals.SelectedRows[0].Cells["discount"].Value.ToString());
            textBox_calculatedPrice.Text = ((double)price/100).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (itemIdList.Count == 0 && selectedRowList.Count == 0)
            {
                MessageBox.Show("Order is empty.");
                return;
            }

            string insertOrder = @"INSERT INTO ORDERS (price, employee_id) VALUES (@price, @employeeID)";
            string insertItem = @"INSERT INTO ORDERS_ITEMS (order_id, item_id) VALUES ((SELECT TOP 1 id FROM ORDERS ORDER BY ORDERS.id DESC), @itemID)";
            string updateItemCount = @"UPDATE ITEMS SET stock = (stock - 1) WHERE ITEMS.id = @itemID";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    using (SqlCommand command = new SqlCommand(insertOrder, conn, transaction))
                    {
                        command.Parameters.Add("@price", SqlDbType.Int).Value = price;
                        command.Parameters.Add("@employeeID", SqlDbType.Int).Value = employeeId;
                        command.ExecuteNonQuery();
                        Utilities.appendToFile(command);
                        command.CommandText = insertItem;
                        command.Parameters.Add("@itemID", SqlDbType.Int);
                        foreach (DataRow row in selectedRowList)
                        {
                            command.CommandText = insertItem;
                            command.Parameters["@itemID"].Value = row["item_id"].ToString();
                            command.ExecuteNonQuery();
                            Utilities.appendToFile(command);
                            command.CommandText = updateItemCount;
                            command.ExecuteNonQuery();
                            Utilities.appendToFile(command);
                        }
                        foreach (int id in itemIdList)
                        {
                            command.CommandText = insertItem;
                            command.Parameters["@itemID"].Value = id;
                            command.ExecuteNonQuery();
                            Utilities.appendToFile(command);
                            command.CommandText = updateItemCount;
                            command.ExecuteNonQuery();
                            Utilities.appendToFile(command);
                        }
                        transaction.Commit();
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error when adding order: " + exception.Message);
                reset();
                return;
            }
            MessageBox.Show("Order added");
            reset();
        }
    }
}
