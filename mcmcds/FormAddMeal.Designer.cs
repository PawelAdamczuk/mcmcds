namespace mcmcds
{
    partial class FormAddMeal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_items = new System.Windows.Forms.DataGridView();
            this.label_itemList = new System.Windows.Forms.Label();
            this.button_AddItem = new System.Windows.Forms.Button();
            this.listView_mealItems = new System.Windows.Forms.ListView();
            this.button_remove = new System.Windows.Forms.Button();
            this.label_mealName = new System.Windows.Forms.Label();
            this.textBox_mealName = new System.Windows.Forms.TextBox();
            this.label_mealPrice = new System.Windows.Forms.Label();
            this.textBox_mealPrice = new System.Windows.Forms.TextBox();
            this.label_dollar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_items)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_items
            // 
            this.dataGridView_items.AllowUserToAddRows = false;
            this.dataGridView_items.AllowUserToDeleteRows = false;
            this.dataGridView_items.AllowUserToResizeColumns = false;
            this.dataGridView_items.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_items.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_items.Location = new System.Drawing.Point(12, 25);
            this.dataGridView_items.MultiSelect = false;
            this.dataGridView_items.Name = "dataGridView_items";
            this.dataGridView_items.RowHeadersVisible = false;
            this.dataGridView_items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_items.Size = new System.Drawing.Size(388, 150);
            this.dataGridView_items.TabIndex = 0;
            // 
            // label_itemList
            // 
            this.label_itemList.AutoSize = true;
            this.label_itemList.Location = new System.Drawing.Point(12, 9);
            this.label_itemList.Name = "label_itemList";
            this.label_itemList.Size = new System.Drawing.Size(80, 13);
            this.label_itemList.TabIndex = 1;
            this.label_itemList.Text = "Available items:";
            // 
            // button_AddItem
            // 
            this.button_AddItem.Location = new System.Drawing.Point(12, 181);
            this.button_AddItem.Name = "button_AddItem";
            this.button_AddItem.Size = new System.Drawing.Size(75, 23);
            this.button_AddItem.TabIndex = 2;
            this.button_AddItem.Text = "Add";
            this.button_AddItem.UseVisualStyleBackColor = true;
            this.button_AddItem.Click += new System.EventHandler(this.button_AddItem_Click);
            // 
            // listView_mealItems
            // 
            this.listView_mealItems.Location = new System.Drawing.Point(407, 25);
            this.listView_mealItems.MultiSelect = false;
            this.listView_mealItems.Name = "listView_mealItems";
            this.listView_mealItems.Size = new System.Drawing.Size(165, 150);
            this.listView_mealItems.TabIndex = 3;
            this.listView_mealItems.UseCompatibleStateImageBehavior = false;
            this.listView_mealItems.View = System.Windows.Forms.View.List;
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(496, 180);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(75, 23);
            this.button_remove.TabIndex = 4;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // label_mealName
            // 
            this.label_mealName.AutoSize = true;
            this.label_mealName.Location = new System.Drawing.Point(12, 211);
            this.label_mealName.Name = "label_mealName";
            this.label_mealName.Size = new System.Drawing.Size(59, 13);
            this.label_mealName.TabIndex = 5;
            this.label_mealName.Text = "Meal name";
            // 
            // textBox_mealName
            // 
            this.textBox_mealName.Location = new System.Drawing.Point(15, 228);
            this.textBox_mealName.Name = "textBox_mealName";
            this.textBox_mealName.Size = new System.Drawing.Size(182, 20);
            this.textBox_mealName.TabIndex = 6;
            // 
            // label_mealPrice
            // 
            this.label_mealPrice.AutoSize = true;
            this.label_mealPrice.Location = new System.Drawing.Point(12, 251);
            this.label_mealPrice.Name = "label_mealPrice";
            this.label_mealPrice.Size = new System.Drawing.Size(56, 13);
            this.label_mealPrice.TabIndex = 7;
            this.label_mealPrice.Text = "Meal price";
            // 
            // textBox_mealPrice
            // 
            this.textBox_mealPrice.Location = new System.Drawing.Point(15, 267);
            this.textBox_mealPrice.Name = "textBox_mealPrice";
            this.textBox_mealPrice.Size = new System.Drawing.Size(77, 20);
            this.textBox_mealPrice.TabIndex = 8;
            // 
            // label_dollar
            // 
            this.label_dollar.AutoSize = true;
            this.label_dollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_dollar.Location = new System.Drawing.Point(98, 267);
            this.label_dollar.Name = "label_dollar";
            this.label_dollar.Size = new System.Drawing.Size(16, 18);
            this.label_dollar.TabIndex = 9;
            this.label_dollar.Text = "$";
            // 
            // FormAddMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.label_dollar);
            this.Controls.Add(this.textBox_mealPrice);
            this.Controls.Add(this.label_mealPrice);
            this.Controls.Add(this.textBox_mealName);
            this.Controls.Add(this.label_mealName);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.listView_mealItems);
            this.Controls.Add(this.button_AddItem);
            this.Controls.Add(this.label_itemList);
            this.Controls.Add(this.dataGridView_items);
            this.Name = "FormAddMeal";
            this.Text = "FormAddMeal";
            this.Load += new System.EventHandler(this.FormAddMeal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_items)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_items;
        private System.Windows.Forms.Label label_itemList;
        private System.Windows.Forms.Button button_AddItem;
        private System.Windows.Forms.ListView listView_mealItems;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Label label_mealName;
        private System.Windows.Forms.TextBox textBox_mealName;
        private System.Windows.Forms.Label label_mealPrice;
        private System.Windows.Forms.TextBox textBox_mealPrice;
        private System.Windows.Forms.Label label_dollar;
    }
}