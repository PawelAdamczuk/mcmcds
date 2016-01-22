namespace mcmcds
{
    partial class FormAddOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridItems = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button_AddItem = new System.Windows.Forms.Button();
            this.label_pickedItems = new System.Windows.Forms.Label();
            this.label_calculatedPrice = new System.Windows.Forms.Label();
            this.textBox_calculatedPrice = new System.Windows.Forms.TextBox();
            this.listView_mealItems = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewMeals = new System.Windows.Forms.DataGridView();
            this.cancelButton = new System.Windows.Forms.Button();
            this.buttonAddMeal = new System.Windows.Forms.Button();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeals)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItems.Location = new System.Drawing.Point(12, 25);
            this.dataGridItems.MultiSelect = false;
            this.dataGridItems.Name = "dataGridItems";
            this.dataGridItems.RowHeadersVisible = false;
            this.dataGridItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridItems.Size = new System.Drawing.Size(380, 150);
            this.dataGridItems.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Available items:";
            // 
            // button_AddItem
            // 
            this.button_AddItem.Location = new System.Drawing.Point(317, 181);
            this.button_AddItem.Name = "button_AddItem";
            this.button_AddItem.Size = new System.Drawing.Size(75, 23);
            this.button_AddItem.TabIndex = 3;
            this.button_AddItem.Text = "Add item";
            this.button_AddItem.UseVisualStyleBackColor = true;
            this.button_AddItem.Click += new System.EventHandler(this.button_AddItem_Click);
            // 
            // label_pickedItems
            // 
            this.label_pickedItems.AutoSize = true;
            this.label_pickedItems.Location = new System.Drawing.Point(396, 9);
            this.label_pickedItems.Name = "label_pickedItems";
            this.label_pickedItems.Size = new System.Drawing.Size(70, 13);
            this.label_pickedItems.TabIndex = 14;
            this.label_pickedItems.Text = "Picked items:";
            // 
            // label_calculatedPrice
            // 
            this.label_calculatedPrice.AutoSize = true;
            this.label_calculatedPrice.Location = new System.Drawing.Point(457, 369);
            this.label_calculatedPrice.Name = "label_calculatedPrice";
            this.label_calculatedPrice.Size = new System.Drawing.Size(34, 13);
            this.label_calculatedPrice.TabIndex = 16;
            this.label_calculatedPrice.Text = "Price:";
            // 
            // textBox_calculatedPrice
            // 
            this.textBox_calculatedPrice.Location = new System.Drawing.Point(497, 366);
            this.textBox_calculatedPrice.Name = "textBox_calculatedPrice";
            this.textBox_calculatedPrice.ReadOnly = true;
            this.textBox_calculatedPrice.Size = new System.Drawing.Size(67, 20);
            this.textBox_calculatedPrice.TabIndex = 17;
            // 
            // listView_mealItems
            // 
            this.listView_mealItems.Location = new System.Drawing.Point(399, 25);
            this.listView_mealItems.MultiSelect = false;
            this.listView_mealItems.Name = "listView_mealItems";
            this.listView_mealItems.Size = new System.Drawing.Size(165, 335);
            this.listView_mealItems.TabIndex = 19;
            this.listView_mealItems.UseCompatibleStateImageBehavior = false;
            this.listView_mealItems.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Available meals:";
            // 
            // dataGridViewMeals
            // 
            this.dataGridViewMeals.AllowUserToAddRows = false;
            this.dataGridViewMeals.AllowUserToDeleteRows = false;
            this.dataGridViewMeals.AllowUserToResizeColumns = false;
            this.dataGridViewMeals.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMeals.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMeals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMeals.Location = new System.Drawing.Point(12, 210);
            this.dataGridViewMeals.MultiSelect = false;
            this.dataGridViewMeals.Name = "dataGridViewMeals";
            this.dataGridViewMeals.RowHeadersVisible = false;
            this.dataGridViewMeals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMeals.Size = new System.Drawing.Size(380, 150);
            this.dataGridViewMeals.TabIndex = 21;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(12, 426);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 22;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // buttonAddMeal
            // 
            this.buttonAddMeal.Location = new System.Drawing.Point(317, 366);
            this.buttonAddMeal.Name = "buttonAddMeal";
            this.buttonAddMeal.Size = new System.Drawing.Size(75, 23);
            this.buttonAddMeal.TabIndex = 23;
            this.buttonAddMeal.Text = "Add meal";
            this.buttonAddMeal.UseVisualStyleBackColor = true;
            this.buttonAddMeal.Click += new System.EventHandler(this.buttonAddMeal_Click);
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.Location = new System.Drawing.Point(497, 426);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonAddOrder.TabIndex = 24;
            this.buttonAddOrder.Text = "Add order";
            this.buttonAddOrder.UseVisualStyleBackColor = true;
            this.buttonAddOrder.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.buttonAddOrder);
            this.Controls.Add(this.buttonAddMeal);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.dataGridViewMeals);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView_mealItems);
            this.Controls.Add(this.textBox_calculatedPrice);
            this.Controls.Add(this.label_calculatedPrice);
            this.Controls.Add(this.label_pickedItems);
            this.Controls.Add(this.button_AddItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridItems);
            this.Name = "FormAddOrder";
            this.Text = "FormAddOrder";
            this.Load += new System.EventHandler(this.FormAddOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_AddItem;
        private System.Windows.Forms.Label label_pickedItems;
        private System.Windows.Forms.Label label_calculatedPrice;
        private System.Windows.Forms.TextBox textBox_calculatedPrice;
        private System.Windows.Forms.ListView listView_mealItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewMeals;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button buttonAddMeal;
        private System.Windows.Forms.Button buttonAddOrder;
    }
}