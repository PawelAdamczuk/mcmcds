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
                        //TODO Hash the password here.
                        com.Parameters.Add("@passwordHash", SqlDbType.VarChar).Value = Utilities.StringHash(_password);
                        //
                        employeeId = int.Parse(com.ExecuteScalar().ToString());
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

        }

        private void tabPage_mainControl_Click(object sender, EventArgs e)
        {

        }
    }
}
