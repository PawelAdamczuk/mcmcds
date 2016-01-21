using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public FormAddOrder(String connectionString)
        {
            this.connectionString = connectionString;
            InitializeComponent();
        }



    }
}
