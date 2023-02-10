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
            this.labelEmployeeAddress = new System.Windows.Forms.Label();
            this.textBoxEmployeePhone = new System.Windows.Forms.TextBox();
            this.labelEmployeePhoneNumber = new System.Windows.Forms.Label();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.labelEmployeeName = new System.Windows.Forms.Label();
            this.textBoxEmployeeId = new System.Windows.Forms.TextBox();
            this.labelEmployeeID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonFindEmployee = new DevExpress.XtraEditors.SimpleButton();
            this.textBoxEmployeeIdFind = new System.Windows.Forms.TextBox();
            this.labelEmployeeIDFind = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.labelEmployeeAddress);
            this.groupBox1.Controls.Add(this.textBoxEmployeePhone);
            this.groupBox1.Controls.Add(this.labelEmployeePhoneNumber);
            this.groupBox1.Controls.Add(this.textBoxEmployeeName);
            this.groupBox1.Controls.Add(this.labelEmployeeName);
            this.groupBox1.Controls.Add(this.textBoxEmployeeId);
            this.groupBox1.Controls.Add(this.labelEmployeeID);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(18, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(780, 170);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New employee details";
            // 
            // textBoxEmployeeAddress
            // 
            this.textBoxEmployeeAddress.Location = new System.Drawing.Point(530, 102);
            this.textBoxEmployeeAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmployeeAddress.Name = "textBoxEmployeeAddress";
            this.textBoxEmployeeAddress.Size = new System.Drawing.Size(233, 30);
            this.textBoxEmployeeAddress.TabIndex = 7;
            // 
            // labelEmployeeAddress
            // 
            this.labelEmployeeAddress.AutoSize = true;
            this.labelEmployeeAddress.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmployeeAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEmployeeAddress.Location = new System.Drawing.Point(453, 110);
            this.labelEmployeeAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmployeeAddress.Name = "labelEmployeeAddress";
            this.labelEmployeeAddress.Size = new System.Drawing.Size(73, 18);
            this.labelEmployeeAddress.TabIndex = 6;
            this.labelEmployeeAddress.Text = "Address:";
            // 
            // textBoxEmployeePhone
            // 
            this.textBoxEmployeePhone.Location = new System.Drawing.Point(128, 102);
            this.textBoxEmployeePhone.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmployeePhone.Name = "textBoxEmployeePhone";
            this.textBoxEmployeePhone.Size = new System.Drawing.Size(233, 30);
            this.textBoxEmployeePhone.TabIndex = 5;
            // 
            // labelEmployeePhoneNumber
            // 
            this.labelEmployeePhoneNumber.AutoSize = true;
            this.labelEmployeePhoneNumber.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmployeePhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEmployeePhoneNumber.Location = new System.Drawing.Point(4, 110);
            this.labelEmployeePhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmployeePhoneNumber.Name = "labelEmployeePhoneNumber";
            this.labelEmployeePhoneNumber.Size = new System.Drawing.Size(119, 18);
            this.labelEmployeePhoneNumber.TabIndex = 4;
            this.labelEmployeePhoneNumber.Text = "Phone number:";
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Location = new System.Drawing.Point(530, 42);
            this.textBoxEmployeeName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.Size = new System.Drawing.Size(233, 30);
            this.textBoxEmployeeName.TabIndex = 3;
            // 
            // labelEmployeeName
            // 
            this.labelEmployeeName.AutoSize = true;
            this.labelEmployeeName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmployeeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEmployeeName.Location = new System.Drawing.Point(398, 49);
            this.labelEmployeeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmployeeName.Name = "labelEmployeeName";
            this.labelEmployeeName.Size = new System.Drawing.Size(129, 18);
            this.labelEmployeeName.TabIndex = 2;
            this.labelEmployeeName.Text = "Employee name:";
            // 
            // textBoxEmployeeId
            // 
            this.textBoxEmployeeId.Location = new System.Drawing.Point(128, 42);
            this.textBoxEmployeeId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmployeeId.Name = "textBoxEmployeeId";
            this.textBoxEmployeeId.Size = new System.Drawing.Size(233, 30);
            this.textBoxEmployeeId.TabIndex = 1;
            // 
            // labelEmployeeID
            // 
            this.labelEmployeeID.AutoSize = true;
            this.labelEmployeeID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmployeeID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEmployeeID.Location = new System.Drawing.Point(19, 49);
            this.labelEmployeeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmployeeID.Name = "labelEmployeeID";
            this.labelEmployeeID.Size = new System.Drawing.Size(107, 18);
            this.labelEmployeeID.TabIndex = 0;
            this.labelEmployeeID.Text = "Employee ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonFindEmployee);
            this.groupBox2.Controls.Add(this.textBoxEmployeeIdFind);
            this.groupBox2.Controls.Add(this.labelEmployeeIDFind);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox2.Location = new System.Drawing.Point(18, 204);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(780, 114);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find an employee";
            // 
            // buttonFindEmployee
            // 
            this.buttonFindEmployee.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFindEmployee.Appearance.Options.UseFont = true;
            this.buttonFindEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonFindEmployee.ImageOptions.Image")));
            this.buttonFindEmployee.Location = new System.Drawing.Point(513, 43);
            this.buttonFindEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFindEmployee.Name = "buttonFindEmployee";
            this.buttonFindEmployee.Size = new System.Drawing.Size(111, 43);
            this.buttonFindEmployee.TabIndex = 6;
            this.buttonFindEmployee.Text = "Find";
            this.buttonFindEmployee.Click += new System.EventHandler(this.buttonFindEmployee_Click);
            // 
            // textBoxEmployeeIdFind
            // 
            this.textBoxEmployeeIdFind.Location = new System.Drawing.Point(253, 48);
            this.textBoxEmployeeIdFind.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmployeeIdFind.Name = "textBoxEmployeeIdFind";
            this.textBoxEmployeeIdFind.Size = new System.Drawing.Size(247, 30);
            this.textBoxEmployeeIdFind.TabIndex = 5;
            // 
            // labelEmployeeIDFind
            // 
            this.labelEmployeeIDFind.AutoSize = true;
            this.labelEmployeeIDFind.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmployeeIDFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEmployeeIDFind.Location = new System.Drawing.Point(144, 55);
            this.labelEmployeeIDFind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmployeeIDFind.Name = "labelEmployeeIDFind";
            this.labelEmployeeIDFind.Size = new System.Drawing.Size(107, 18);
            this.labelEmployeeIDFind.TabIndex = 0;
            this.labelEmployeeIDFind.Text = "Employee ID:";
            // 
            // buttonExitEmployee
            // 
            this.buttonExitEmployee.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExitEmployee.Appearance.Options.UseFont = true;
            this.buttonExitEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonExitEmployee.ImageOptions.Image")));
            this.buttonExitEmployee.Location = new System.Drawing.Point(562, 347);
            this.buttonExitEmployee.Margin = new System.Windows.Forms.Padding(4);
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
            this.buttonRemoveEmployee.Location = new System.Drawing.Point(415, 347);
            this.buttonRemoveEmployee.Margin = new System.Windows.Forms.Padding(4);
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
            this.buttonEditEmployee.Location = new System.Drawing.Point(272, 347);
            this.buttonEditEmployee.Margin = new System.Windows.Forms.Padding(4);
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
            this.buttonAddEmployee.Location = new System.Drawing.Point(128, 347);
            this.buttonAddEmployee.Margin = new System.Windows.Forms.Padding(4);
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
            this.labelManageEmployeesMessage.Location = new System.Drawing.Point(379, 420);
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
            this.ClientSize = new System.Drawing.Size(814, 453);
            this.Controls.Add(this.labelManageEmployeesMessage);
            this.Controls.Add(this.buttonExitEmployee);
            this.Controls.Add(this.buttonRemoveEmployee);
            this.Controls.Add(this.buttonEditEmployee);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private Label labelEmployeeAddress;
        private TextBox textBoxEmployeePhone;
        private Label labelEmployeePhoneNumber;
        private TextBox textBoxEmployeeName;
        private Label labelEmployeeName;
        private TextBox textBoxEmployeeId;
        private Label labelEmployeeID;
        private GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton buttonFindEmployee;
        private TextBox textBoxEmployeeIdFind;
        private Label labelEmployeeIDFind;
        private DevExpress.XtraEditors.SimpleButton buttonExitEmployee;
        private DevExpress.XtraEditors.SimpleButton buttonRemoveEmployee;
        private DevExpress.XtraEditors.SimpleButton buttonEditEmployee;
        private DevExpress.XtraEditors.SimpleButton buttonAddEmployee;
        private Label labelManageEmployeesMessage;
    }
}