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
using System.Runtime.Remoting.Messaging;
using System.Media;



namespace mcmcds
{
    public partial class FormThinClient : Form
    {
        public bool connected;
        private string connectionString;
        private int employeeId;

        public FormThinClient(string _address, string _login, string _password)
        {
            
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

                        if(employeeName.Equals("JOHN CENA"))
                        {
                            SoundPlayer player = new SoundPlayer();
                            player.SoundLocation = "qre.wav";
                            player.Play();
                            this.Text = "Employee panel [AND HIS NAME IS... " + employeeName + "!]";
                        }
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


        private void button_markAsExecuted_Click(object sender, EventArgs e)
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

        private void button_printOrder_Click(object sender, EventArgs e)
        {
            string insertOrder = "INSERT INTO SUPPLY_ORDERS_ITEMS (item_id, supply_order_id, amount)" +
                                 "VALUES (@itemId,(SELECT TOP 1 id FROM SUPPLY_ORDERS ORDER BY SUPPLY_ORDERS.id DESC), @amount);";
            StringBuilder sb = new StringBuilder();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT id, (ITEMS.max_stock-ITEMS.stock) as amount, name FROM ITEMS WHERE ITEMS.stock<ITEMS.max_stock", conn);
                    DataSet ds = new DataSet();
                    da.SelectCommand.Transaction = transaction;
                    da.Fill(ds);
                    new SqlCommand("INSERT INTO SUPPLY_ORDERS DEFAULT VALUES",conn,transaction).ExecuteNonQuery();
                    string date = new SqlCommand("SELECT TOP 1 date FROM SUPPLY_ORDERS ORDER BY id DESC",conn,transaction).ExecuteScalar().ToString();
                    string orderId = new SqlCommand("SELECT TOP 1 id FROM SUPPLY_ORDERS ORDER BY id DESC", conn,transaction).ExecuteScalar().ToString();
                    sb.AppendLine("OrderID: " + orderId);
                    sb.AppendLine("Date: " + date);
                    sb.AppendLine("------");
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        SqlCommand com = new SqlCommand(insertOrder,conn,transaction);
                        com.Parameters.AddWithValue("@itemId", int.Parse(row["id"].ToString()));
                        com.Parameters.AddWithValue("@amount", int.Parse(row["amount"].ToString()));
                        com.ExecuteNonQuery();
                        sb.AppendLine($"{row["name"].ToString()}:\t{row["amount"].ToString()}");
                    }
                    new SqlCommand("EXECUTE resupply", conn, transaction).ExecuteNonQuery();
                    transaction.Commit();
                }
            }
            textBox_printedOrder.Text = sb.ToString();
        }
        
    }
}
