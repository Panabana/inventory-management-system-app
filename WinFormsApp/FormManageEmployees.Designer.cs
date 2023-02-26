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
            this.groupBoxEmployeeNew = new System.Windows.Forms.GroupBox();
            this.textBoxEmployeeAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEmployeePhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEmployeeId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxEmployeeFind = new System.Windows.Forms.GroupBox();
            this.buttonFindEmployee = new DevExpress.XtraEditors.SimpleButton();
            this.textBoxEmployeeIdFind = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonRemoveEmployee = new DevExpress.XtraEditors.SimpleButton();
            this.buttonEditEmployee = new DevExpress.XtraEditors.SimpleButton();
            this.buttonAddEmployee = new DevExpress.XtraEditors.SimpleButton();
            this.labelManageEmployeesMessage = new System.Windows.Forms.Label();
            this.DataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.groupBoxEmployeeNew.SuspendLayout();
            this.groupBoxEmployeeFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxEmployeeNew
            // 
            this.groupBoxEmployeeNew.Controls.Add(this.textBoxEmployeeAddress);
            this.groupBoxEmployeeNew.Controls.Add(this.label4);
            this.groupBoxEmployeeNew.Controls.Add(this.textBoxEmployeePhone);
            this.groupBoxEmployeeNew.Controls.Add(this.label3);
            this.groupBoxEmployeeNew.Controls.Add(this.textBoxEmployeeName);
            this.groupBoxEmployeeNew.Controls.Add(this.label2);
            this.groupBoxEmployeeNew.Controls.Add(this.textBoxEmployeeId);
            this.groupBoxEmployeeNew.Controls.Add(this.label1);
            this.groupBoxEmployeeNew.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxEmployeeNew.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBoxEmployeeNew.Location = new System.Drawing.Point(13, 4);
            this.groupBoxEmployeeNew.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxEmployeeNew.Name = "groupBoxEmployeeNew";
            this.groupBoxEmployeeNew.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxEmployeeNew.Size = new System.Drawing.Size(381, 244);
            this.groupBoxEmployeeNew.TabIndex = 3;
            this.groupBoxEmployeeNew.TabStop = false;
            this.groupBoxEmployeeNew.Text = "Change employee details";
            // 
            // textBoxEmployeeAddress
            // 
            this.textBoxEmployeeAddress.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmployeeAddress.Location = new System.Drawing.Point(104, 209);
            this.textBoxEmployeeAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmployeeAddress.Name = "textBoxEmployeeAddress";
            this.textBoxEmployeeAddress.Size = new System.Drawing.Size(200, 26);
            this.textBoxEmployeeAddress.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(177, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address:";
            // 
            // textBoxEmployeePhone
            // 
            this.textBoxEmployeePhone.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmployeePhone.Location = new System.Drawing.Point(104, 109);
            this.textBoxEmployeePhone.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmployeePhone.Name = "textBoxEmployeePhone";
            this.textBoxEmployeePhone.Size = new System.Drawing.Size(200, 26);
            this.textBoxEmployeePhone.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(158, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone number:";
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmployeeName.Location = new System.Drawing.Point(104, 159);
            this.textBoxEmployeeName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.Size = new System.Drawing.Size(200, 26);
            this.textBoxEmployeeName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(155, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee name:";
            // 
            // textBoxEmployeeId
            // 
            this.textBoxEmployeeId.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmployeeId.Location = new System.Drawing.Point(104, 59);
            this.textBoxEmployeeId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmployeeId.Name = "textBoxEmployeeId";
            this.textBoxEmployeeId.Size = new System.Drawing.Size(200, 26);
            this.textBoxEmployeeId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(120, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add/remove an Employee ID:";
            // 
            // groupBoxEmployeeFind
            // 
            this.groupBoxEmployeeFind.Controls.Add(this.buttonFindEmployee);
            this.groupBoxEmployeeFind.Controls.Add(this.textBoxEmployeeIdFind);
            this.groupBoxEmployeeFind.Controls.Add(this.label8);
            this.groupBoxEmployeeFind.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxEmployeeFind.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBoxEmployeeFind.Location = new System.Drawing.Point(400, 4);
            this.groupBoxEmployeeFind.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxEmployeeFind.Name = "groupBoxEmployeeFind";
            this.groupBoxEmployeeFind.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxEmployeeFind.Size = new System.Drawing.Size(381, 244);
            this.groupBoxEmployeeFind.TabIndex = 11;
            this.groupBoxEmployeeFind.TabStop = false;
            this.groupBoxEmployeeFind.Text = "Find an employee";
            // 
            // buttonFindEmployee
            // 
            this.buttonFindEmployee.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFindEmployee.Appearance.Options.UseFont = true;
            this.buttonFindEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFindEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonFindEmployee.ImageOptions.Image")));
            this.buttonFindEmployee.Location = new System.Drawing.Point(174, 99);
            this.buttonFindEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFindEmployee.Name = "buttonFindEmployee";
            this.buttonFindEmployee.Size = new System.Drawing.Size(95, 35);
            this.buttonFindEmployee.TabIndex = 6;
            this.buttonFindEmployee.Text = "Find";
            this.buttonFindEmployee.Click += new System.EventHandler(this.buttonFindEmployee_Click);
            // 
            // textBoxEmployeeIdFind
            // 
            this.textBoxEmployeeIdFind.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmployeeIdFind.Location = new System.Drawing.Point(115, 65);
            this.textBoxEmployeeIdFind.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmployeeIdFind.Name = "textBoxEmployeeIdFind";
            this.textBoxEmployeeIdFind.Size = new System.Drawing.Size(212, 26);
            this.textBoxEmployeeIdFind.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(181, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 14);
            this.label8.TabIndex = 0;
            this.label8.Text = "Employee ID:";
            // 
            // buttonRemoveEmployee
            // 
            this.buttonRemoveEmployee.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveEmployee.Appearance.Options.UseFont = true;
            this.buttonRemoveEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveEmployee.ImageOptions.Image")));
            this.buttonRemoveEmployee.Location = new System.Drawing.Point(597, 484);
            this.buttonRemoveEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoveEmployee.Name = "buttonRemoveEmployee";
            this.buttonRemoveEmployee.Size = new System.Drawing.Size(176, 44);
            this.buttonRemoveEmployee.TabIndex = 22;
            this.buttonRemoveEmployee.Text = "Remove";
            this.buttonRemoveEmployee.Click += new System.EventHandler(this.buttonRemoveEmployee_Click);
            // 
            // buttonEditEmployee
            // 
            this.buttonEditEmployee.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEditEmployee.Appearance.Options.UseFont = true;
            this.buttonEditEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditEmployee.ImageOptions.Image")));
            this.buttonEditEmployee.Location = new System.Drawing.Point(305, 484);
            this.buttonEditEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditEmployee.Name = "buttonEditEmployee";
            this.buttonEditEmployee.Size = new System.Drawing.Size(176, 44);
            this.buttonEditEmployee.TabIndex = 21;
            this.buttonEditEmployee.Text = "Edit";
            this.buttonEditEmployee.Click += new System.EventHandler(this.buttonEditEmployee_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddEmployee.Appearance.Options.UseFont = true;
            this.buttonAddEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddEmployee.ImageOptions.Image")));
            this.buttonAddEmployee.Location = new System.Drawing.Point(13, 484);
            this.buttonAddEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(176, 44);
            this.buttonAddEmployee.TabIndex = 20;
            this.buttonAddEmployee.Tag = "<Null>";
            this.buttonAddEmployee.Text = "Add";
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // labelManageEmployeesMessage
            // 
            this.labelManageEmployeesMessage.AutoSize = true;
            this.labelManageEmployeesMessage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelManageEmployeesMessage.ForeColor = System.Drawing.Color.Red;
            this.labelManageEmployeesMessage.Location = new System.Drawing.Point(12, 541);
            this.labelManageEmployeesMessage.Name = "labelManageEmployeesMessage";
            this.labelManageEmployeesMessage.Size = new System.Drawing.Size(49, 19);
            this.labelManageEmployeesMessage.TabIndex = 24;
            this.labelManageEmployeesMessage.Text = "****";
            this.labelManageEmployeesMessage.Visible = false;
            // 
            // DataGridViewEmployee
            // 
            this.DataGridViewEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewEmployee.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewEmployee.Location = new System.Drawing.Point(169, 254);
            this.DataGridViewEmployee.Name = "DataGridViewEmployee";
            this.DataGridViewEmployee.ReadOnly = true;
            this.DataGridViewEmployee.RowTemplate.Height = 25;
            this.DataGridViewEmployee.Size = new System.Drawing.Size(456, 217);
            this.DataGridViewEmployee.TabIndex = 25;
            this.DataGridViewEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployee_CellContentClick);
            // 
            // FormManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 568);
            this.Controls.Add(this.DataGridViewEmployee);
            this.Controls.Add(this.labelManageEmployeesMessage);
            this.Controls.Add(this.buttonRemoveEmployee);
            this.Controls.Add(this.buttonEditEmployee);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.groupBoxEmployeeFind);
            this.Controls.Add(this.groupBoxEmployeeNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormManageEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Employees";
            this.groupBoxEmployeeNew.ResumeLayout(false);
            this.groupBoxEmployeeNew.PerformLayout();
            this.groupBoxEmployeeFind.ResumeLayout(false);
            this.groupBoxEmployeeFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBoxEmployeeNew;
        private TextBox textBoxEmployeeAddress;
        private Label label4;
        private TextBox textBoxEmployeePhone;
        private Label label3;
        private TextBox textBoxEmployeeName;
        private Label label2;
        private TextBox textBoxEmployeeId;
        private Label label1;
        private GroupBox groupBoxEmployeeFind;
        private DevExpress.XtraEditors.SimpleButton buttonFindEmployee;
        private TextBox textBoxEmployeeIdFind;
        private Label label8;
        private DevExpress.XtraEditors.SimpleButton buttonRemoveEmployee;
        private DevExpress.XtraEditors.SimpleButton buttonEditEmployee;
        private DevExpress.XtraEditors.SimpleButton buttonAddEmployee;
        private Label labelManageEmployeesMessage;
        private DataGridView DataGridViewEmployee;
    }
}