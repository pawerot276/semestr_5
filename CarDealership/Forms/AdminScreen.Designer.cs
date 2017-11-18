﻿namespace CarDealership
{
    partial class AdminScreen
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.EmployeesTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonResetEmp = new System.Windows.Forms.Button();
            this.buttonFilterEmp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roleSelector1 = new CarDealership.Controls.RoleSelector();
            this.dealershipSelector1 = new CarDealership.Controls.DealershipSelector();
            this.textBoxSurnameEmp = new System.Windows.Forms.TextBox();
            this.textBoxNameEmp = new System.Windows.Forms.TextBox();
            this.buttonAddEmp = new System.Windows.Forms.Button();
            this.buttonDelEmp = new System.Windows.Forms.Button();
            this.buttonEditEmp = new System.Windows.Forms.Button();
            this.employeesView1 = new CarDealership.EmployeesView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DGV_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Dealership = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DealershipsTab = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.buttonAddDeal = new System.Windows.Forms.Button();
            this.dealershipsView1 = new CarDealership.Controls.DealershipsView();
            this.DebugTab = new System.Windows.Forms.TabPage();
            this.ResetButton = new System.Windows.Forms.Button();
            this.buttonEditDeal = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.HomeTab.SuspendLayout();
            this.EmployeesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.DealershipsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.DebugTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.HomeTab);
            this.tabControl.Controls.Add(this.EmployeesTab);
            this.tabControl.Controls.Add(this.DealershipsTab);
            this.tabControl.Controls.Add(this.DebugTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.HotTrack = true;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(855, 516);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // HomeTab
            // 
            this.HomeTab.BackColor = System.Drawing.Color.DarkGray;
            this.HomeTab.Controls.Add(this.ExitButton);
            this.HomeTab.Controls.Add(this.LogoutButton);
            this.HomeTab.Location = new System.Drawing.Point(4, 22);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.HomeTab.Size = new System.Drawing.Size(847, 490);
            this.HomeTab.TabIndex = 0;
            this.HomeTab.Text = "Home";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(127, 363);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(46, 363);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 0;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // EmployeesTab
            // 
            this.EmployeesTab.Controls.Add(this.splitContainer1);
            this.EmployeesTab.Controls.Add(this.dataGridView1);
            this.EmployeesTab.Location = new System.Drawing.Point(4, 22);
            this.EmployeesTab.Name = "EmployeesTab";
            this.EmployeesTab.Size = new System.Drawing.Size(847, 490);
            this.EmployeesTab.TabIndex = 2;
            this.EmployeesTab.Text = "Employees";
            this.EmployeesTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.splitContainer1.Panel1.Controls.Add(this.buttonResetEmp);
            this.splitContainer1.Panel1.Controls.Add(this.buttonFilterEmp);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.roleSelector1);
            this.splitContainer1.Panel1.Controls.Add(this.dealershipSelector1);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxSurnameEmp);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxNameEmp);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAddEmp);
            this.splitContainer1.Panel1.Controls.Add(this.buttonDelEmp);
            this.splitContainer1.Panel1.Controls.Add(this.buttonEditEmp);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.employeesView1);
            this.splitContainer1.Size = new System.Drawing.Size(847, 490);
            this.splitContainer1.SplitterDistance = 195;
            this.splitContainer1.TabIndex = 1;
            // 
            // buttonResetEmp
            // 
            this.buttonResetEmp.Location = new System.Drawing.Point(107, 134);
            this.buttonResetEmp.Name = "buttonResetEmp";
            this.buttonResetEmp.Size = new System.Drawing.Size(75, 23);
            this.buttonResetEmp.TabIndex = 12;
            this.buttonResetEmp.Text = "Reset";
            this.buttonResetEmp.UseVisualStyleBackColor = true;
            this.buttonResetEmp.Click += new System.EventHandler(this.buttonResetEmp_Click);
            // 
            // buttonFilterEmp
            // 
            this.buttonFilterEmp.Location = new System.Drawing.Point(26, 134);
            this.buttonFilterEmp.Name = "buttonFilterEmp";
            this.buttonFilterEmp.Size = new System.Drawing.Size(75, 23);
            this.buttonFilterEmp.TabIndex = 11;
            this.buttonFilterEmp.Text = "Filter";
            this.buttonFilterEmp.UseVisualStyleBackColor = true;
            this.buttonFilterEmp.Click += new System.EventHandler(this.buttonFilerEmp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Role:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dealership:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            // 
            // roleSelector1
            // 
            this.roleSelector1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleSelector1.FormattingEnabled = true;
            this.roleSelector1.Items.AddRange(new object[] {
            "Administrator",
            "Manager",
            "Mechanic",
            "Seller",
            "Administrator",
            "Manager",
            "Mechanic",
            "Seller"});
            this.roleSelector1.Location = new System.Drawing.Point(71, 107);
            this.roleSelector1.Name = "roleSelector1";
            this.roleSelector1.Size = new System.Drawing.Size(121, 21);
            this.roleSelector1.TabIndex = 6;
            // 
            // dealershipSelector1
            // 
            this.dealershipSelector1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dealershipSelector1.FormattingEnabled = true;
            this.dealershipSelector1.Items.AddRange(new object[] {
            "",
            1,
            2,
            3,
            5,
            "",
            1,
            2});
            this.dealershipSelector1.Location = new System.Drawing.Point(71, 80);
            this.dealershipSelector1.Name = "dealershipSelector1";
            this.dealershipSelector1.Size = new System.Drawing.Size(121, 21);
            this.dealershipSelector1.TabIndex = 5;
            // 
            // textBoxSurnameEmp
            // 
            this.textBoxSurnameEmp.Location = new System.Drawing.Point(71, 54);
            this.textBoxSurnameEmp.Name = "textBoxSurnameEmp";
            this.textBoxSurnameEmp.Size = new System.Drawing.Size(121, 20);
            this.textBoxSurnameEmp.TabIndex = 4;
            // 
            // textBoxNameEmp
            // 
            this.textBoxNameEmp.Location = new System.Drawing.Point(71, 28);
            this.textBoxNameEmp.Name = "textBoxNameEmp";
            this.textBoxNameEmp.Size = new System.Drawing.Size(121, 20);
            this.textBoxNameEmp.TabIndex = 3;
            // 
            // buttonAddEmp
            // 
            this.buttonAddEmp.Location = new System.Drawing.Point(21, 384);
            this.buttonAddEmp.Name = "buttonAddEmp";
            this.buttonAddEmp.Size = new System.Drawing.Size(75, 23);
            this.buttonAddEmp.TabIndex = 2;
            this.buttonAddEmp.Text = "Add";
            this.buttonAddEmp.UseVisualStyleBackColor = true;
            this.buttonAddEmp.Click += new System.EventHandler(this.buttonAddEmp_Click);
            // 
            // buttonDelEmp
            // 
            this.buttonDelEmp.Location = new System.Drawing.Point(21, 442);
            this.buttonDelEmp.Name = "buttonDelEmp";
            this.buttonDelEmp.Size = new System.Drawing.Size(75, 23);
            this.buttonDelEmp.TabIndex = 1;
            this.buttonDelEmp.Text = "Delete";
            this.buttonDelEmp.UseVisualStyleBackColor = true;
            this.buttonDelEmp.Click += new System.EventHandler(this.buttonDelEmp_Click);
            // 
            // buttonEditEmp
            // 
            this.buttonEditEmp.Location = new System.Drawing.Point(21, 413);
            this.buttonEditEmp.Name = "buttonEditEmp";
            this.buttonEditEmp.Size = new System.Drawing.Size(75, 23);
            this.buttonEditEmp.TabIndex = 0;
            this.buttonEditEmp.Text = "Edit";
            this.buttonEditEmp.UseVisualStyleBackColor = true;
            this.buttonEditEmp.Click += new System.EventHandler(this.buttonEDIT_Click);
            // 
            // employeesView1
            // 
            this.employeesView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesView1.Location = new System.Drawing.Point(0, 0);
            this.employeesView1.Name = "employeesView1";
            this.employeesView1.Size = new System.Drawing.Size(648, 490);
            this.employeesView1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_ID,
            this.DGV_Name,
            this.DGV_Surname,
            this.DGV_Role,
            this.DGV_Dealership});
            this.dataGridView1.Location = new System.Drawing.Point(545, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(616, 423);
            this.dataGridView1.TabIndex = 0;
            // 
            // DGV_ID
            // 
            this.DGV_ID.HeaderText = "ID";
            this.DGV_ID.Name = "DGV_ID";
            this.DGV_ID.ReadOnly = true;
            // 
            // DGV_Name
            // 
            this.DGV_Name.HeaderText = "Name";
            this.DGV_Name.Name = "DGV_Name";
            this.DGV_Name.ReadOnly = true;
            // 
            // DGV_Surname
            // 
            this.DGV_Surname.HeaderText = "Surname";
            this.DGV_Surname.Name = "DGV_Surname";
            this.DGV_Surname.ReadOnly = true;
            this.DGV_Surname.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DGV_Role
            // 
            this.DGV_Role.HeaderText = "Role";
            this.DGV_Role.Name = "DGV_Role";
            this.DGV_Role.ReadOnly = true;
            // 
            // DGV_Dealership
            // 
            this.DGV_Dealership.HeaderText = "Dealership";
            this.DGV_Dealership.Name = "DGV_Dealership";
            this.DGV_Dealership.ReadOnly = true;
            // 
            // DealershipsTab
            // 
            this.DealershipsTab.Controls.Add(this.splitContainer2);
            this.DealershipsTab.Location = new System.Drawing.Point(4, 22);
            this.DealershipsTab.Name = "DealershipsTab";
            this.DealershipsTab.Size = new System.Drawing.Size(847, 490);
            this.DealershipsTab.TabIndex = 3;
            this.DealershipsTab.Text = "Dealerships";
            this.DealershipsTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.splitContainer2.Panel1.Controls.Add(this.buttonEditDeal);
            this.splitContainer2.Panel1.Controls.Add(this.buttonAddDeal);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.DarkGray;
            this.splitContainer2.Panel2.Controls.Add(this.dealershipsView1);
            this.splitContainer2.Size = new System.Drawing.Size(847, 490);
            this.splitContainer2.SplitterDistance = 206;
            this.splitContainer2.TabIndex = 0;
            // 
            // buttonAddDeal
            // 
            this.buttonAddDeal.Location = new System.Drawing.Point(58, 110);
            this.buttonAddDeal.Name = "buttonAddDeal";
            this.buttonAddDeal.Size = new System.Drawing.Size(75, 23);
            this.buttonAddDeal.TabIndex = 0;
            this.buttonAddDeal.Text = "Add";
            this.buttonAddDeal.UseVisualStyleBackColor = true;
            this.buttonAddDeal.Click += new System.EventHandler(this.buttonAddDeal_Click);
            // 
            // dealershipsView1
            // 
            this.dealershipsView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dealershipsView1.Location = new System.Drawing.Point(0, 0);
            this.dealershipsView1.Name = "dealershipsView1";
            this.dealershipsView1.Size = new System.Drawing.Size(637, 490);
            this.dealershipsView1.TabIndex = 0;
            // 
            // DebugTab
            // 
            this.DebugTab.BackColor = System.Drawing.Color.DarkGray;
            this.DebugTab.Controls.Add(this.ResetButton);
            this.DebugTab.Location = new System.Drawing.Point(4, 22);
            this.DebugTab.Name = "DebugTab";
            this.DebugTab.Padding = new System.Windows.Forms.Padding(3);
            this.DebugTab.Size = new System.Drawing.Size(847, 490);
            this.DebugTab.TabIndex = 1;
            this.DebugTab.Text = "Debug";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(8, 6);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 0;
            this.ResetButton.Text = "Reset DB";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // buttonEditDeal
            // 
            this.buttonEditDeal.Location = new System.Drawing.Point(58, 139);
            this.buttonEditDeal.Name = "buttonEditDeal";
            this.buttonEditDeal.Size = new System.Drawing.Size(75, 23);
            this.buttonEditDeal.TabIndex = 1;
            this.buttonEditDeal.Text = "Edit";
            this.buttonEditDeal.UseVisualStyleBackColor = true;
            this.buttonEditDeal.Click += new System.EventHandler(this.buttonEditDeal_Click);
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 516);
            this.Controls.Add(this.tabControl);
            this.Name = "AdminScreen";
            this.Text = "AdminScreen";
            this.tabControl.ResumeLayout(false);
            this.HomeTab.ResumeLayout(false);
            this.EmployeesTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.DealershipsTab.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.DebugTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage HomeTab;
        private System.Windows.Forms.TabPage DebugTab;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.TabPage EmployeesTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Dealership;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private EmployeesView employeesView1;
        private System.Windows.Forms.Button buttonEditEmp;
        private System.Windows.Forms.Button buttonDelEmp;
        private System.Windows.Forms.Button buttonAddEmp;
        private Controls.RoleSelector roleSelector1;
        private Controls.DealershipSelector dealershipSelector1;
        private System.Windows.Forms.TextBox textBoxSurnameEmp;
        private System.Windows.Forms.TextBox textBoxNameEmp;
        private System.Windows.Forms.Button buttonFilterEmp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonResetEmp;
        private System.Windows.Forms.TabPage DealershipsTab;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Controls.DealershipsView dealershipsView1;
        private System.Windows.Forms.Button buttonAddDeal;
        private System.Windows.Forms.Button buttonEditDeal;
    }
}