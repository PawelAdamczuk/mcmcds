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
        public FormAddOrder(String connectionString)
        {
            this.connectionString = connectionString;
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
            this.Close();
        }

        private void button_AddItem_Click(object sender, EventArgs e)
        {
            String it = dataGridItems.SelectedRows[0].Cells["name"].Value.ToString();
            listView_mealItems.Items.Add(it);
            price += Utilities.PriceField(dataGridItems.SelectedRows[0].Cells["price"].Value.ToString());
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
                    price += Utilities.PriceField(row["price"].ToString());
                }
            }
            price -= Utilities.PriceField(dataGridViewMeals.SelectedRows[0].Cells["discount"].Value.ToString());
            textBox_calculatedPrice.Text = ((double)price/100).ToString();
        }
    }
}
