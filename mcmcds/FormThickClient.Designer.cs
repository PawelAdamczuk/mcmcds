namespace mcmcds
{
    partial class FormThickClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThickClient));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAddEmployee = new System.Windows.Forms.TabPage();
            this.tabAddItem = new System.Windows.Forms.TabPage();
            this.tabAddMeal = new System.Windows.Forms.TabPage();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.dataGridItems = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItems)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAddEmployee);
            this.tabControl1.Controls.Add(this.tabAddItem);
            this.tabControl1.Controls.Add(this.tabAddMeal);
            this.tabControl1.Controls.Add(this.tabDelete);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(684, 395);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // tabAddEmployee
            // 
            this.tabAddEmployee.Location = new System.Drawing.Point(4, 22);
            this.tabAddEmployee.Name = "tabAddEmployee";
            this.tabAddEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddEmployee.Size = new System.Drawing.Size(676, 369);
            this.tabAddEmployee.TabIndex = 0;
            this.tabAddEmployee.Text = "Add Employee";
            this.tabAddEmployee.UseVisualStyleBackColor = true;
            this.tabAddEmployee.Click += new System.EventHandler(this.AddPage_Click);
            // 
            // tabAddItem
            // 
            this.tabAddItem.Location = new System.Drawing.Point(4, 22);
            this.tabAddItem.Name = "tabAddItem";
            this.tabAddItem.Size = new System.Drawing.Size(676, 369);
            this.tabAddItem.TabIndex = 2;
            this.tabAddItem.Text = "Add Item";
            this.tabAddItem.UseVisualStyleBackColor = true;
            // 
            // tabAddMeal
            // 
            this.tabAddMeal.Location = new System.Drawing.Point(4, 22);
            this.tabAddMeal.Name = "tabAddMeal";
            this.tabAddMeal.Size = new System.Drawing.Size(676, 369);
            this.tabAddMeal.TabIndex = 3;
            this.tabAddMeal.Text = "Add Meal";
            this.tabAddMeal.UseVisualStyleBackColor = true;
            // 
            // tabDelete
            // 
            this.tabDelete.Controls.Add(this.dataGridItems);
            this.tabDelete.Controls.Add(this.button1);
            this.tabDelete.Controls.Add(this.comboBox2);
            this.tabDelete.Location = new System.Drawing.Point(4, 22);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabDelete.Size = new System.Drawing.Size(676, 369);
            this.tabDelete.TabIndex = 1;
            this.tabDelete.Text = "Delete";
            this.tabDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridItems
            // 
            this.dataGridItems.AllowUserToAddRows = false;
            this.dataGridItems.AllowUserToDeleteRows = false;
            this.dataGridItems.AllowUserToResizeColumns = false;
            this.dataGridItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridItems.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItems.Location = new System.Drawing.Point(9, 35);
            this.dataGridItems.MultiSelect = false;
            this.dataGridItems.Name = "dataGridItems";
            this.dataGridItems.RowHeadersVisible = false;
            this.dataGridItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridItems.Size = new System.Drawing.Size(659, 326);
            this.dataGridItems.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete Row";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Employees",
            "Meals",
            "Items"});
            this.comboBox2.Location = new System.Drawing.Point(9, 8);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.Text = "Employees";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // FormThickClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 395);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormThickClient";
            this.Text = "Administration panel";
            this.tabControl1.ResumeLayout(false);
            this.tabDelete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAddEmployee;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridItems;
        private System.Windows.Forms.TabPage tabAddItem;
        private System.Windows.Forms.TabPage tabAddMeal;
    }
}