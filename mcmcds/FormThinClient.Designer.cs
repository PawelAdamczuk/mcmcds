﻿namespace mcmcds
{
    partial class FormThinClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThinClient));
            this.tabControl_thinClientMain = new System.Windows.Forms.TabControl();
            this.tabPage_mainControl = new System.Windows.Forms.TabPage();
            this.tabPage_pendingOrders = new System.Windows.Forms.TabPage();
            this.button_markAsExecuted = new System.Windows.Forms.Button();
            this.dataGridView_pendingOrders = new System.Windows.Forms.DataGridView();
            this.tabSupply = new System.Windows.Forms.TabPage();
            this.button_printOrder = new System.Windows.Forms.Button();
            this.textBox_printedOrder = new System.Windows.Forms.TextBox();
            this.button_updateStockInfo = new System.Windows.Forms.Button();
            this.tabControl_thinClientMain.SuspendLayout();
            this.tabPage_pendingOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pendingOrders)).BeginInit();
            this.tabSupply.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_thinClientMain
            // 
            this.tabControl_thinClientMain.Controls.Add(this.tabPage_mainControl);
            this.tabControl_thinClientMain.Controls.Add(this.tabPage_pendingOrders);
            this.tabControl_thinClientMain.Controls.Add(this.tabSupply);
            this.tabControl_thinClientMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_thinClientMain.Location = new System.Drawing.Point(0, 0);
            this.tabControl_thinClientMain.Name = "tabControl_thinClientMain";
            this.tabControl_thinClientMain.SelectedIndex = 0;
            this.tabControl_thinClientMain.Size = new System.Drawing.Size(584, 462);
            this.tabControl_thinClientMain.TabIndex = 0;
            // 
            // tabPage_mainControl
            // 
            this.tabPage_mainControl.Location = new System.Drawing.Point(4, 22);
            this.tabPage_mainControl.Name = "tabPage_mainControl";
            this.tabPage_mainControl.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_mainControl.Size = new System.Drawing.Size(576, 436);
            this.tabPage_mainControl.TabIndex = 0;
            this.tabPage_mainControl.Text = "Add order";
            this.tabPage_mainControl.UseVisualStyleBackColor = true;
            this.tabPage_mainControl.Click += new System.EventHandler(this.tabPage_mainControl_Click);
            // 
            // tabPage_pendingOrders
            // 
            this.tabPage_pendingOrders.Controls.Add(this.button_markAsExecuted);
            this.tabPage_pendingOrders.Controls.Add(this.dataGridView_pendingOrders);
            this.tabPage_pendingOrders.Location = new System.Drawing.Point(4, 22);
            this.tabPage_pendingOrders.Name = "tabPage_pendingOrders";
            this.tabPage_pendingOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_pendingOrders.Size = new System.Drawing.Size(576, 436);
            this.tabPage_pendingOrders.TabIndex = 1;
            this.tabPage_pendingOrders.Text = "Pending orders";
            this.tabPage_pendingOrders.UseVisualStyleBackColor = true;
            this.tabPage_pendingOrders.Enter += new System.EventHandler(this.tabPage_pendingOrders_Enter);
            // 
            // button_markAsExecuted
            // 
            this.button_markAsExecuted.Location = new System.Drawing.Point(437, 301);
            this.button_markAsExecuted.Name = "button_markAsExecuted";
            this.button_markAsExecuted.Size = new System.Drawing.Size(131, 23);
            this.button_markAsExecuted.TabIndex = 1;
            this.button_markAsExecuted.Text = "Mark as executed";
            this.button_markAsExecuted.UseVisualStyleBackColor = true;
            this.button_markAsExecuted.Click += new System.EventHandler(this.button_markAsExecuted_Click);
            // 
            // dataGridView_pendingOrders
            // 
            this.dataGridView_pendingOrders.AllowUserToAddRows = false;
            this.dataGridView_pendingOrders.AllowUserToDeleteRows = false;
            this.dataGridView_pendingOrders.AllowUserToResizeColumns = false;
            this.dataGridView_pendingOrders.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_pendingOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_pendingOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_pendingOrders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_pendingOrders.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_pendingOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_pendingOrders.Location = new System.Drawing.Point(9, 7);
            this.dataGridView_pendingOrders.MultiSelect = false;
            this.dataGridView_pendingOrders.Name = "dataGridView_pendingOrders";
            this.dataGridView_pendingOrders.RowHeadersVisible = false;
            this.dataGridView_pendingOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_pendingOrders.Size = new System.Drawing.Size(559, 288);
            this.dataGridView_pendingOrders.TabIndex = 0;
            // 
            // tabSupply
            // 
            this.tabSupply.Controls.Add(this.button_printOrder);
            this.tabSupply.Controls.Add(this.textBox_printedOrder);
            this.tabSupply.Location = new System.Drawing.Point(4, 22);
            this.tabSupply.Name = "tabSupply";
            this.tabSupply.Size = new System.Drawing.Size(576, 436);
            this.tabSupply.TabIndex = 2;
            this.tabSupply.Text = "Supply orders";
            this.tabSupply.UseVisualStyleBackColor = true;
            // 
            // button_printOrder
            // 
            this.button_printOrder.Location = new System.Drawing.Point(493, 12);
            this.button_printOrder.Name = "button_printOrder";
            this.button_printOrder.Size = new System.Drawing.Size(75, 23);
            this.button_printOrder.TabIndex = 1;
            this.button_printOrder.Text = "Print Order";
            this.button_printOrder.UseVisualStyleBackColor = true;
            this.button_printOrder.Click += new System.EventHandler(this.button_printOrder_Click);
            // 
            // textBox_printedOrder
            // 
            this.textBox_printedOrder.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox_printedOrder.Location = new System.Drawing.Point(8, 12);
            this.textBox_printedOrder.Multiline = true;
            this.textBox_printedOrder.Name = "textBox_printedOrder";
            this.textBox_printedOrder.ReadOnly = true;
            this.textBox_printedOrder.Size = new System.Drawing.Size(479, 416);
            this.textBox_printedOrder.TabIndex = 0;
            // 
            // button_updateStockInfo
            // 
            this.button_updateStockInfo.Location = new System.Drawing.Point(6, 6);
            this.button_updateStockInfo.Name = "button_updateStockInfo";
            this.button_updateStockInfo.Size = new System.Drawing.Size(120, 40);
            this.button_updateStockInfo.TabIndex = 0;
            this.button_updateStockInfo.Text = "Update item stock information";
            this.button_updateStockInfo.UseVisualStyleBackColor = true;
            // 
            // FormThinClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.tabControl_thinClientMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormThinClient";
            this.Load += new System.EventHandler(this.FormThinClient_Load);
            this.tabControl_thinClientMain.ResumeLayout(false);
            this.tabPage_pendingOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pendingOrders)).EndInit();
            this.tabSupply.ResumeLayout(false);
            this.tabSupply.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_thinClientMain;
        private System.Windows.Forms.TabPage tabPage_mainControl;
        private System.Windows.Forms.TabPage tabPage_pendingOrders;
        private System.Windows.Forms.Button button_updateStockInfo;
        private System.Windows.Forms.TabPage tabSupply;
        private System.Windows.Forms.Button button_printOrder;
        private System.Windows.Forms.TextBox textBox_printedOrder;
        private System.Windows.Forms.DataGridView dataGridView_pendingOrders;
        private System.Windows.Forms.Button button_markAsExecuted;
    }
}