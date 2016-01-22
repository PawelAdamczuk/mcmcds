namespace mcmcds
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
            this.tabControl_thinClientMain = new System.Windows.Forms.TabControl();
            this.tabPage_mainControl = new System.Windows.Forms.TabPage();
            this.button_updateStockInfo = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl_thinClientMain.SuspendLayout();
            this.tabPage_mainControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_thinClientMain
            // 
            this.tabControl_thinClientMain.Controls.Add(this.tabPage_mainControl);
            this.tabControl_thinClientMain.Controls.Add(this.tabPage2);
            this.tabControl_thinClientMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_thinClientMain.Location = new System.Drawing.Point(0, 0);
            this.tabControl_thinClientMain.Name = "tabControl_thinClientMain";
            this.tabControl_thinClientMain.SelectedIndex = 0;
            this.tabControl_thinClientMain.Size = new System.Drawing.Size(584, 462);
            this.tabControl_thinClientMain.TabIndex = 0;
            // 
            // tabPage_mainControl
            // 
            this.tabPage_mainControl.Controls.Add(this.button_updateStockInfo);
            this.tabPage_mainControl.Location = new System.Drawing.Point(4, 22);
            this.tabPage_mainControl.Name = "tabPage_mainControl";
            this.tabPage_mainControl.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_mainControl.Size = new System.Drawing.Size(576, 436);
            this.tabPage_mainControl.TabIndex = 0;
            this.tabPage_mainControl.Text = "tabPage1";
            this.tabPage_mainControl.UseVisualStyleBackColor = true;
            this.tabPage_mainControl.Click += new System.EventHandler(this.tabPage_mainControl_Click);
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(576, 436);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FormThinClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.tabControl_thinClientMain);
            this.Name = "FormThinClient";
            this.Text = "b";
            this.Load += new System.EventHandler(this.FormThinClient_Load);
            this.tabControl_thinClientMain.ResumeLayout(false);
            this.tabPage_mainControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_thinClientMain;
        private System.Windows.Forms.TabPage tabPage_mainControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_updateStockInfo;
    }
}