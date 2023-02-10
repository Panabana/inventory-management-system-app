namespace WinFormsApp
{
    partial class FormManageEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageEmployees));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxEmployeeAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEmployeePhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEmployeeId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonFindEmployee = new DevExpress.XtraEditors.SimpleButton();
            this.textBoxEmployeeIdFind = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonExitEmployee = new DevExpress.XtraEditors.SimpleButton();
            this.buttonRemoveEmployee = new DevExpress.XtraEditors.SimpleButton();
            this.buttonEditEmployee = new DevExpress.XtraEditors.SimpleButton();
            this.buttonAddEmployee = new DevExpress.XtraEditors.SimpleButton();
            this.labelManageEmployeesMessage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxEmployeeAddress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxEmployeePhone);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxEmployeeName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxEmployeeId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(21, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(910, 209);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New employee details";
            // 
            // textBoxEmployeeAddress
            // 
            this.textBoxEmployeeAddress.Location = new System.Drawing.Point(618, 126);
            this.textBoxEmployeeAddress.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxEmployeeAddress.Name = "textBoxEmployeeAddress";
            this.textBoxEmployeeAddress.Size = new System.Drawing.Size(233, 30);
            this.textBoxEmployeeAddress.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(453, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address:";
            // 
            // textBoxEmployeePhone
            // 
            this.textBoxEmployeePhone.Location = new System.Drawing.Point(149, 126);
            this.textBoxEmployeePhone.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxEmployeePhone.Name = "textBoxEmployeePhone";
            this.textBoxEmployeePhone.Size = new System.Drawing.Size(233, 30);
            this.textBoxEmployeePhone.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(4, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone number:";
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Location = new System.Drawing.Point(618, 52);
            this.textBoxEmployeeName.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.Size = new System.Drawing.Size(233, 30);
            this.textBoxEmployeeName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(398, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee name:";
            // 
            // textBoxEmployeeId
            // 
            this.textBoxEmployeeId.Location = new System.Drawing.Point(149, 52);
            this.textBoxEmployeeId.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxEmployeeId.Name = "textBoxEmployeeId";
            this.textBoxEmployeeId.Size = new System.Drawing.Size(233, 30);
            this.textBoxEmployeeId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(19, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonFindEmployee);
            this.groupBox2.Controls.Add(this.textBoxEmployeeIdFind);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox2.Location = new System.Drawing.Point(21, 251);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(910, 140);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find an employee";
            // 
            // buttonFindEmployee
            // 
            this.buttonFindEmployee.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFindEmployee.Appearance.Options.UseFont = true;
            this.buttonFindEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonFindEmployee.ImageOptions.Image")));
            this.buttonFindEmployee.Location = new System.Drawing.Point(598, 53);
            this.buttonFindEmployee.Margin = new System.Windows.Forms.Padding(5);
            this.buttonFindEmployee.Name = "buttonFindEmployee";
            this.buttonFindEmployee.Size = new System.Drawing.Size(111, 43);
            this.buttonFindEmployee.TabIndex = 6;
            this.buttonFindEmployee.Text = "Find";
            this.buttonFindEmployee.Click += new System.EventHandler(this.buttonFindEmployee_Click);
            // 
            // textBoxEmployeeIdFind
            // 
            this.textBoxEmployeeIdFind.Location = new System.Drawing.Point(295, 59);
            this.textBoxEmployeeIdFind.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxEmployeeIdFind.Name = "textBoxEmployeeIdFind";
            this.textBoxEmployeeIdFind.Size = new System.Drawing.Size(247, 30);
            this.textBoxEmployeeIdFind.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(144, 55);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Employee ID:";
            // 
            // buttonExitEmployee
            // 
            this.buttonExitEmployee.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExitEmployee.Appearance.Options.UseFont = true;
            this.buttonExitEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonExitEmployee.ImageOptions.Image")));
            this.buttonExitEmployee.Location = new System.Drawing.Point(656, 427);
            this.buttonExitEmployee.Margin = new System.Windows.Forms.Padding(5);
            this.buttonExitEmployee.Name = "buttonExitEmployee";
            this.buttonExitEmployee.Size = new System.Drawing.Size(124, 54);
            this.buttonExitEmployee.TabIndex = 23;
            this.buttonExitEmployee.Text = "Exit";
            // 
            // buttonRemoveEmployee
            // 
            this.buttonRemoveEmployee.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveEmployee.Appearance.Options.UseFont = true;
            this.buttonRemoveEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveEmployee.ImageOptions.Image")));
            this.buttonRemoveEmployee.Location = new System.Drawing.Point(484, 427);
            this.buttonRemoveEmployee.Margin = new System.Windows.Forms.Padding(5);
            this.buttonRemoveEmployee.Name = "buttonRemoveEmployee";
            this.buttonRemoveEmployee.Size = new System.Drawing.Size(124, 54);
            this.buttonRemoveEmployee.TabIndex = 22;
            this.buttonRemoveEmployee.Text = "Remove";
            this.buttonRemoveEmployee.Click += new System.EventHandler(this.buttonRemoveEmployee_Click);
            // 
            // buttonEditEmployee
            // 
            this.buttonEditEmployee.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEditEmployee.Appearance.Options.UseFont = true;
            this.buttonEditEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditEmployee.ImageOptions.Image")));
            this.buttonEditEmployee.Location = new System.Drawing.Point(317, 427);
            this.buttonEditEmployee.Margin = new System.Windows.Forms.Padding(5);
            this.buttonEditEmployee.Name = "buttonEditEmployee";
            this.buttonEditEmployee.Size = new System.Drawing.Size(124, 54);
            this.buttonEditEmployee.TabIndex = 21;
            this.buttonEditEmployee.Text = "Edit";
            this.buttonEditEmployee.Click += new System.EventHandler(this.buttonEditEmployee_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddEmployee.Appearance.Options.UseFont = true;
            this.buttonAddEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddEmployee.ImageOptions.Image")));
            this.buttonAddEmployee.Location = new System.Drawing.Point(149, 427);
            this.buttonAddEmployee.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(124, 54);
            this.buttonAddEmployee.TabIndex = 20;
            this.buttonAddEmployee.Tag = "<Null>";
            this.buttonAddEmployee.Text = "Add";
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // labelManageEmployeesMessage
            // 
            this.labelManageEmployeesMessage.AutoSize = true;
            this.labelManageEmployeesMessage.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelManageEmployeesMessage.ForeColor = System.Drawing.Color.Red;
            this.labelManageEmployeesMessage.Location = new System.Drawing.Point(435, 500);
            this.labelManageEmployeesMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelManageEmployeesMessage.Name = "labelManageEmployeesMessage";
            this.labelManageEmployeesMessage.Size = new System.Drawing.Size(58, 23);
            this.labelManageEmployeesMessage.TabIndex = 24;
            this.labelManageEmployeesMessage.Text = "****";
            this.labelManageEmployeesMessage.Visible = false;
            // 
            // FormManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 532);
            this.Controls.Add(this.labelManageEmployeesMessage);
            this.Controls.Add(this.buttonExitEmployee);
            this.Controls.Add(this.buttonRemoveEmployee);
            this.Controls.Add(this.buttonEditEmployee);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FormManageEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Employees";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxEmployeeAddress;
        private Label label4;
        private TextBox textBoxEmployeePhone;
        private Label label3;
        private TextBox textBoxEmployeeName;
        private Label label2;
        private TextBox textBoxEmployeeId;
        private Label label1;
        private GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton buttonFindEmployee;
        private TextBox textBoxEmployeeIdFind;
        private Label label8;
        private DevExpress.XtraEditors.SimpleButton buttonExitEmployee;
        private DevExpress.XtraEditors.SimpleButton buttonRemoveEmployee;
        private DevExpress.XtraEditors.SimpleButton buttonEditEmployee;
        private DevExpress.XtraEditors.SimpleButton buttonAddEmployee;
        private Label labelManageEmployeesMessage;
    }
}