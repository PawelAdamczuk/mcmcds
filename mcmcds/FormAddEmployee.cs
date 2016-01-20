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


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //string command = "INSERT into EMPLOYEES (name, wage, position, login, password) "+
                  //  "VALUES ('"+NameBox.Text+;

            }
        }

        private bool isValid()
        {

            return true;
        }

        private bool textValid(string text)
        {
            if (text.Contains(";"))
                return false;
            if (text.Contains("'"))
                return false;
            if (text.Contains("--"))
                return false;

            return true;

        }
       
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
