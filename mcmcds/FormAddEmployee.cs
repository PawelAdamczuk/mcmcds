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

    public partial class FormAddEmployee : Form
    {
        private string connectionString;

        public FormAddEmployee(String connectionString)
        {
            this.connectionString = connectionString;
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isValid())
            {
                MessageBox.Show("Input contains illegal characters.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string command = "INSERT into EMPLOYEES (name, wage, position, login, password_hash) " +
                                 $"VALUES ('{NameBox.Text}', '{wageBox.Text}', '{positionBox.Text}', '{loginBox.Text}', '{Utilities.StringHash(passwordBox.Text)}');";
                Utilities.appendToFile(command);
                SqlCommand insertQuery = new SqlCommand(command,conn);
                try
                {
                    insertQuery.ExecuteNonQuery();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error while inserting: "+exception);
                    return;
                }
                MessageBox.Show("Added employee.");
            }
        }

        private bool isValid()
        {
            if (!Utilities.TextValid(NameBox.Text))
                return false;
            if (!Utilities.TextValid(wageBox.Text))
                return false;
            if (!Utilities.TextValid(positionBox.Text))
                return false;
            if (!Utilities.TextValid((loginBox.Text)))
                return false;
            if (!Utilities.TextValid(passwordBox.Text))
                return false;
            return true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
