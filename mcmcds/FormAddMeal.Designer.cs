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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label_calculatedPrice = new System.Windows.Forms.Label();
            this.textBox_calculatedPrice = new System.Windows.Forms.TextBox();
            this.label_dollar2 = new System.Windows.Forms.Label();
            this.label_pickedItems = new System.Windows.Forms.Label();
            this.button_addMeal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_items)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_items
            // 
            this.dataGridView_items.AllowUserToAddRows = false;
            this.dataGridView_items.AllowUserToDeleteRows = false;
            this.dataGridView_items.AllowUserToResizeColumns = false;
            this.dataGridView_items.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_items.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_items.Location = new System.Drawing.Point(12, 25);
            this.dataGridView_items.MultiSelect = false;
            this.dataGridView_items.Name = "dataGridView_items";
            this.dataGridView_items.RowHeadersVisible = false;
            this.dataGridView_items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_items.Size = new System.Drawing.Size(489, 150);
            this.dataGridView_items.TabIndex = 0;
            // 
            // label_itemList
            // 
            this.label_itemList.AutoSize = true;
            this.label_itemList.Location = new System.Drawing.Point(9, 9);
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
            this.button_AddItem.Text = "Add item";
            this.button_AddItem.UseVisualStyleBackColor = true;
            this.button_AddItem.Click += new System.EventHandler(this.button_AddItem_Click);
            // 
            // listView_mealItems
            // 
            this.listView_mealItems.Location = new System.Drawing.Point(507, 25);
            this.listView_mealItems.MultiSelect = false;
            this.listView_mealItems.Name = "listView_mealItems";
            this.listView_mealItems.Size = new System.Drawing.Size(165, 150);
            this.listView_mealItems.TabIndex = 3;
            this.listView_mealItems.UseCompatibleStateImageBehavior = false;
            this.listView_mealItems.View = System.Windows.Forms.View.List;
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(578, 180);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(93, 23);
            this.button_remove.TabIndex = 4;
            this.button_remove.Text = "Remove item";
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
            // label_calculatedPrice
            // 
            this.label_calculatedPrice.AutoSize = true;
            this.label_calculatedPrice.Location = new System.Drawing.Point(15, 294);
            this.label_calculatedPrice.Name = "label_calculatedPrice";
            this.label_calculatedPrice.Size = new System.Drawing.Size(231, 13);
            this.label_calculatedPrice.TabIndex = 10;
            this.label_calculatedPrice.Text = "Calculated price (sum of all picked items\' prices)";
            // 
            // textBox_calculatedPrice
            // 
            this.textBox_calculatedPrice.Location = new System.Drawing.Point(15, 309);
            this.textBox_calculatedPrice.Name = "textBox_calculatedPrice";
            this.textBox_calculatedPrice.ReadOnly = true;
            this.textBox_calculatedPrice.Size = new System.Drawing.Size(77, 20);
            this.textBox_calculatedPrice.TabIndex = 11;
            // 
            // label_dollar2
            // 
            this.label_dollar2.AutoSize = true;
            this.label_dollar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_dollar2.Location = new System.Drawing.Point(98, 311);
            this.label_dollar2.Name = "label_dollar2";
            this.label_dollar2.Size = new System.Drawing.Size(16, 18);
            this.label_dollar2.TabIndex = 12;
            this.label_dollar2.Text = "$";
            // 
            // label_pickedItems
            // 
            this.label_pickedItems.AutoSize = true;
            this.label_pickedItems.Location = new System.Drawing.Point(504, 9);
            this.label_pickedItems.Name = "label_pickedItems";
            this.label_pickedItems.Size = new System.Drawing.Size(70, 13);
            this.label_pickedItems.TabIndex = 13;
            this.label_pickedItems.Text = "Picked items:";
            // 
            // button_addMeal
            // 
            this.button_addMeal.Location = new System.Drawing.Point(597, 307);
            this.button_addMeal.Name = "button_addMeal";
            this.button_addMeal.Size = new System.Drawing.Size(75, 23);
            this.button_addMeal.TabIndex = 14;
            this.button_addMeal.Text = "Add meal";
            this.button_addMeal.UseVisualStyleBackColor = true;
            this.button_addMeal.Click += new System.EventHandler(this.button_addMeal_Click);
            // 
            // FormAddMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 342);
            this.Controls.Add(this.button_addMeal);
            this.Controls.Add(this.label_pickedItems);
            this.Controls.Add(this.label_dollar2);
            this.Controls.Add(this.textBox_calculatedPrice);
            this.Controls.Add(this.label_calculatedPrice);
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
        private System.Windows.Forms.Label label_calculatedPrice;
        private System.Windows.Forms.TextBox textBox_calculatedPrice;
        private System.Windows.Forms.Label label_dollar2;
        private System.Windows.Forms.Label label_pickedItems;
        private System.Windows.Forms.Button button_addMeal;
    }
}