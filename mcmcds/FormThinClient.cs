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
    public partial class FormThinClient : Form
    {
        public bool connected;
        private string connectionString;
        private int employeeId;

        public FormThinClient(string _address, string _login, string _password)
        {
            //TODO change connection string, make account for employees
            connectionString = String.Format("Data Source={0},1433;Network Library = DBMSSOCN;Initial Catalog = DBANANA;User ID = {1}; Password = {2}", _address, "sa", "bananek1");
            
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand com = new SqlCommand("SELECT dbo.getEmployeeId (@login, @passwordHash)", conn))
                    {
                        com.Parameters.Add("@login", SqlDbType.VarChar).Value = _login;
                        com.Parameters.Add("@passwordHash", SqlDbType.VarChar).Value = Utilities.StringHash(_password);
                        string s = com.ExecuteScalar().ToString();
                        if (s == "null")
                        {
                            MessageBox.Show("Login data invalid.");
                            connected = false;
                            return;
                        }
                        employeeId = int.Parse(s);

                        string employeeNameCommandString = "SELECT name FROM EMPLOYEES WHERE id=" + s;
                        SqlCommand employeeNameCommand = new SqlCommand(employeeNameCommandString, conn);
                        string employeeName = employeeNameCommand.ExecuteScalar().ToString();

                        this.Text = "Employee panel [" + employeeName + "]";
                    }
                }
                connected = true;

            }
            catch (Exception e)
            {
                MessageBox.Show("Connection failed!\n" + connectionString + "\n" + e.Message);
                connected = false;
            }
            InitializeComponent();
        }

        public FormThinClient()
        {
            InitializeComponent();
        }

        private void FormThinClient_Load(object sender, EventArgs e)
        {
            FormAddOrder embeddedAddOrder = new FormAddOrder(connectionString, employeeId);
            embeddedAddOrder.TopLevel = false;
            embeddedAddOrder.Visible = true;
            embeddedAddOrder.Dock = DockStyle.Fill;
            embeddedAddOrder.FormBorderStyle = FormBorderStyle.None;
            tabControl_thinClientMain.TabPages[0].Controls.Add(embeddedAddOrder);
        }

        private void tabPage_mainControl_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string orderID = dataGridView_pendingOrders.SelectedRows[0].Cells["Order ID"].Value.ToString();
                    string command = "UPDATE ORDERS SET executed=1 WHERE id=" + orderID;

                    SqlCommand update = new SqlCommand(command, conn);
                    update.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM pendingOrders", conn);
                    SqlCommandBuilder cb = new SqlCommandBuilder(da);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView_pendingOrders.DataSource = ds.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tabPage_pendingOrders_Enter(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM pendingOrders", conn);
                    SqlCommandBuilder cb = new SqlCommandBuilder(da);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dataGridView_pendingOrders.DataSource = ds.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
