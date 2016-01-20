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
