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
    public partial class FormThickClient : Form
    {
        public bool connected;
        private string connectionString;

        public FormThickClient()
        {
            InitializeComponent();
        }

        public FormThickClient(string _address, string _login, string _password)
        {
            connectionString = String.Format("Data Source={0},1433;Network Library = DBMSSOCN;Initial Catalog = DBANANA;User ID = {1}; Password = {2}", _address, _login, _password);
            var conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                connected = true;
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Connection failed!\n" + connectionString + "\n" + e.Message);
                connected = false;
                return;
            }
            InitializeComponent();
            refresh();
        }

        private void AddPage_Click(object sender, EventArgs e)
        {

        }


        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RefreshDeleteGridView();
        }

        private DataSet delDataSet = new DataSet();

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDeleteGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridItems.SelectedRows[0].Cells["id"].Value.ToString());
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand deleteCommand = new SqlCommand($"DELETE FROM {comboBox2.Text.ToUpper()} WHERE {comboBox2.Text.ToUpper()}.id=@id", conn);
                deleteCommand.Parameters.AddWithValue("@id", id);
                try
                {
                    deleteCommand.ExecuteNonQuery();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Could not delete: " + exc.Message);
                }
            }
            RefreshDeleteGridView();
        }

        private void RefreshDeleteGridView()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM {comboBox2.Text.ToUpper()}", conn);
                delDataSet = new DataSet();
                da.Fill(delDataSet);
                dataGridItems.DataSource = delDataSet.Tables[0];
            }
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            RefreshDeleteGridView();
            FormAddEmployee embEmployee = new FormAddEmployee(connectionString)
            {
                TopLevel = false,
                Visible = true,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            tabControl1.TabPages[0].Controls.Clear();
            tabControl1.TabPages[0].Controls.Add(embEmployee);

            FormAddItem embItem = new FormAddItem((connectionString))
            {
                TopLevel = false,
                Visible = true,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            tabControl1.TabPages[1].Controls.Clear();
            tabControl1.TabPages[1].Controls.Add(embItem);

            FormAddMeal embMeal = new FormAddMeal(connectionString)
            {
                TopLevel = false,
                Visible = true,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            tabControl1.TabPages[2].Controls.Clear();
            tabControl1.TabPages[2].Controls.Add(embMeal);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter item = new SqlDataAdapter("SELECT * FROM itemStats",conn);
                SqlDataAdapter meal = new SqlDataAdapter("SELECT * FROM mealStats", conn);
                SqlDataAdapter empl = new SqlDataAdapter("SELECT * FROM employeeStats",conn);
                DataSet itemSet = new DataSet();
                DataSet mealSet = new DataSet();
                DataSet emplSet = new DataSet();
                item.Fill(itemSet);
                meal.Fill(mealSet);
                empl.Fill(emplSet);
                dataGridViewEmployeeStats.DataSource = emplSet.Tables[0];
                dataGridViewItemStats.DataSource = itemSet.Tables[0];
                dataGridViewMealStats.DataSource = mealSet.Tables[0];
            }
        }
    }
}
