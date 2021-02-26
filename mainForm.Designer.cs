namespace phonebook
{
    partial class mainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.telTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.خروجToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(404, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.خروجToolStripMenuItem.Text = "خروج";
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // phoneListView
            // 
            this.phoneListView.Dock = System.Windows.Forms.DockStyle.Right;
            this.phoneListView.HideSelection = false;
            this.phoneListView.Location = new System.Drawing.Point(221, 24);
            this.phoneListView.MultiSelect = false;
            this.phoneListView.Name = "phoneListView";
            this.phoneListView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.phoneListView.RightToLeftLayout = true;
            this.phoneListView.Size = new System.Drawing.Size(183, 237);
            this.phoneListView.TabIndex = 1;
            this.phoneListView.UseCompatibleStateImageBehavior = false;
            this.phoneListView.View = System.Windows.Forms.View.List;
            this.phoneListView.SelectedIndexChanged += new System.EventHandler(this.phoneListView_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "نام";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "موبایل";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(34, 27);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nameTextBox.Size = new System.Drawing.Size(118, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.Location = new System.Drawing.Point(34, 53);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mobileTextBox.Size = new System.Drawing.Size(118, 20);
            this.mobileTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "تلفن";
            // 
            // telTextBox
            // 
            this.telTextBox.Location = new System.Drawing.Point(34, 83);
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.telTextBox.Size = new System.Drawing.Size(118, 20);
            this.telTextBox.TabIndex = 9;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(34, 159);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(136, 28);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "درج";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(34, 193);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(136, 28);
            this.delButton.TabIndex = 11;
            this.delButton.Text = "حذف";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(34, 227);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(136, 28);
            this.updateButton.TabIndex = 12;
            this.updateButton.Text = "بروزرسانی";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(34, 125);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(136, 28);
            this.searchButton.TabIndex = 13;
            this.searchButton.Text = "جستجو";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.ControlBox = false;
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.telTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mobileTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phoneListView);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "دفترچه تلفن";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        private System.Windows.Forms.ListView phoneListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox telTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button searchButton;
    }
}

