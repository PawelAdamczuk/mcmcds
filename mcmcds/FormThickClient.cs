﻿using System;
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
        private SqlConnection conn;
        private string connectionString;

        public FormThickClient()
        {
            InitializeComponent();
        }

        public FormThickClient(string _address, string _login, string _password)
        {
            connectionString = String.Format("Data Source={0},1433;Network Library = DBMSSOCN;Initial Catalog = DBANANA;User ID = {1}; Password = {2}", _address, _login, _password);
            conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                connected = true;

            }
            catch (Exception e)
            {
                MessageBox.Show("Connection failed!\n" + connectionString + "\n" + e.Message);
                connected = false;
            }
            InitializeComponent();
        }

        private void AddPage_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form f = null;
            bool inputValid = false;
            switch (comboBox1.Text)
            {
                case "Employee":
                    f = new FormAddEmployee(connectionString);
                    inputValid = true;
                    break;
                case "Ingredient":
                    //Not implemented
                    break;
                default:
                    MessageBox.Show("Input not valid.");
                    break;
            }
            if (inputValid)
            {
                f.Show();
            }
        }
    }
}
