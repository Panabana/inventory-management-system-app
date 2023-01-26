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
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 138);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New employee details";
            // 
            // textBoxEmployeeAddress
            // 
            this.textBoxEmployeeAddress.Location = new System.Drawing.Point(454, 83);
            this.textBoxEmployeeAddress.Name = "textBoxEmployeeAddress";
            this.textBoxEmployeeAddress.Size = new System.Drawing.Size(200, 26);
            this.textBoxEmployeeAddress.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(388, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address:";
            // 
            // textBoxEmployeePhone
            // 
            this.textBoxEmployeePhone.Location = new System.Drawing.Point(110, 83);
            this.textBoxEmployeePhone.Name = "textBoxEmployeePhone";
            this.textBoxEmployeePhone.Size = new System.Drawing.Size(200, 26);
            this.textBoxEmployeePhone.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(3, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone number:";
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Location = new System.Drawing.Point(454, 34);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.Size = new System.Drawing.Size(200, 26);
            this.textBoxEmployeeName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(341, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee name:";
            // 
            // textBoxEmployeeId
            // 
            this.textBoxEmployeeId.Location = new System.Drawing.Point(110, 34);
            this.textBoxEmployeeId.Name = "textBoxEmployeeId";
            this.textBoxEmployeeId.Size = new System.Drawing.Size(200, 26);
            this.textBoxEmployeeId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 14);
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
            this.groupBox2.Location = new System.Drawing.Point(15, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 93);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find an employee:";
            // 
            // buttonFindEmployee
            // 
            this.buttonFindEmployee.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFindEmployee.Appearance.Options.UseFont = true;
            this.buttonFindEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonFindEmployee.ImageOptions.Image")));
            this.buttonFindEmployee.Location = new System.Drawing.Point(440, 35);
            this.buttonFindEmployee.Name = "buttonFindEmployee";
            this.buttonFindEmployee.Size = new System.Drawing.Size(95, 35);
            this.buttonFindEmployee.TabIndex = 6;
            this.buttonFindEmployee.Text = "Find";
            // 
            // textBoxEmployeeIdFind
            // 
            this.textBoxEmployeeIdFind.Location = new System.Drawing.Point(217, 39);
            this.textBoxEmployeeIdFind.Name = "textBoxEmployeeIdFind";
            this.textBoxEmployeeIdFind.Size = new System.Drawing.Size(212, 26);
            this.textBoxEmployeeIdFind.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(123, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 14);
            this.label8.TabIndex = 0;
            this.label8.Text = "Employee ID:";
            // 
            // buttonExitEmployee
            // 
            this.buttonExitEmployee.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExitEmployee.Appearance.Options.UseFont = true;
            this.buttonExitEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonExitEmployee.ImageOptions.Image")));
            this.buttonExitEmployee.Location = new System.Drawing.Point(482, 282);
            this.buttonExitEmployee.Name = "buttonExitEmployee";
            this.buttonExitEmployee.Size = new System.Drawing.Size(106, 44);
            this.buttonExitEmployee.TabIndex = 23;
            this.buttonExitEmployee.Text = "Exit";
            // 
            // buttonRemoveEmployee
            // 
            this.buttonRemoveEmployee.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveEmployee.Appearance.Options.UseFont = true;
            this.buttonRemoveEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveEmployee.ImageOptions.Image")));
            this.buttonRemoveEmployee.Location = new System.Drawing.Point(356, 282);
            this.buttonRemoveEmployee.Name = "buttonRemoveEmployee";
            this.buttonRemoveEmployee.Size = new System.Drawing.Size(106, 44);
            this.buttonRemoveEmployee.TabIndex = 22;
            this.buttonRemoveEmployee.Text = "Remove";
            // 
            // buttonEditEmployee
            // 
            this.buttonEditEmployee.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEditEmployee.Appearance.Options.UseFont = true;
            this.buttonEditEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditEmployee.ImageOptions.Image")));
            this.buttonEditEmployee.Location = new System.Drawing.Point(233, 282);
            this.buttonEditEmployee.Name = "buttonEditEmployee";
            this.buttonEditEmployee.Size = new System.Drawing.Size(106, 44);
            this.buttonEditEmployee.TabIndex = 21;
            this.buttonEditEmployee.Text = "Edit";
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddEmployee.Appearance.Options.UseFont = true;
            this.buttonAddEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddEmployee.ImageOptions.Image")));
            this.buttonAddEmployee.Location = new System.Drawing.Point(110, 282);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(106, 44);
            this.buttonAddEmployee.TabIndex = 20;
            this.buttonAddEmployee.Text = "Add";
            // 
            // labelManageEmployeesMessage
            // 
            this.labelManageEmployeesMessage.AutoSize = true;
            this.labelManageEmployeesMessage.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelManageEmployeesMessage.ForeColor = System.Drawing.Color.Red;
            this.labelManageEmployeesMessage.Location = new System.Drawing.Point(325, 341);
            this.labelManageEmployeesMessage.Name = "labelManageEmployeesMessage";
            this.labelManageEmployeesMessage.Size = new System.Drawing.Size(48, 18);
            this.labelManageEmployeesMessage.TabIndex = 24;
            this.labelManageEmployeesMessage.Text = "****";
            // 
            // FormManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 368);
            this.Controls.Add(this.labelManageEmployeesMessage);
            this.Controls.Add(this.buttonExitEmployee);
            this.Controls.Add(this.buttonRemoveEmployee);
            this.Controls.Add(this.buttonEditEmployee);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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