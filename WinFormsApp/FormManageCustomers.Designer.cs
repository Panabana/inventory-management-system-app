namespace WinFormsApp
{
    partial class FormManageCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageCustomers));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxCustomerAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCustomerPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCustomerId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCustomerIdFind = new DevExpress.XtraEditors.SimpleButton();
            this.textBoxCustomerIdFind = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonExitCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.buttonRemoveCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.buttonEditCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.buttonAddCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.labelManageCustomersMessage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxCustomerAddress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxCustomerPhone);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxCustomerName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxCustomerId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 138);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New customer details";
            // 
            // textBoxCustomerAddress
            // 
            this.textBoxCustomerAddress.Location = new System.Drawing.Point(454, 83);
            this.textBoxCustomerAddress.Name = "textBoxCustomerAddress";
            this.textBoxCustomerAddress.Size = new System.Drawing.Size(200, 26);
            this.textBoxCustomerAddress.TabIndex = 7;
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
            // textBoxCustomerPhone
            // 
            this.textBoxCustomerPhone.Location = new System.Drawing.Point(110, 83);
            this.textBoxCustomerPhone.Name = "textBoxCustomerPhone";
            this.textBoxCustomerPhone.Size = new System.Drawing.Size(200, 26);
            this.textBoxCustomerPhone.TabIndex = 5;
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
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(454, 34);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(200, 26);
            this.textBoxCustomerName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(341, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer name:";
            // 
            // textBoxCustomerId
            // 
            this.textBoxCustomerId.Location = new System.Drawing.Point(110, 34);
            this.textBoxCustomerId.Name = "textBoxCustomerId";
            this.textBoxCustomerId.Size = new System.Drawing.Size(200, 26);
            this.textBoxCustomerId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonCustomerIdFind);
            this.groupBox2.Controls.Add(this.textBoxCustomerIdFind);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox2.Location = new System.Drawing.Point(15, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 93);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find a customer";
            // 
            // buttonCustomerIdFind
            // 
            this.buttonCustomerIdFind.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCustomerIdFind.Appearance.Options.UseFont = true;
            this.buttonCustomerIdFind.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonCustomerIdFind.ImageOptions.Image")));
            this.buttonCustomerIdFind.Location = new System.Drawing.Point(440, 35);
            this.buttonCustomerIdFind.Name = "buttonCustomerIdFind";
            this.buttonCustomerIdFind.Size = new System.Drawing.Size(95, 35);
            this.buttonCustomerIdFind.TabIndex = 6;
            this.buttonCustomerIdFind.Text = "Find";
            this.buttonCustomerIdFind.Click += new System.EventHandler(this.buttonCustomerIdFind_Click);
            // 
            // textBoxCustomerIdFind
            // 
            this.textBoxCustomerIdFind.Location = new System.Drawing.Point(217, 39);
            this.textBoxCustomerIdFind.Name = "textBoxCustomerIdFind";
            this.textBoxCustomerIdFind.Size = new System.Drawing.Size(212, 26);
            this.textBoxCustomerIdFind.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(123, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 14);
            this.label8.TabIndex = 0;
            this.label8.Text = "Customer ID:";
            // 
            // buttonExitCustomer
            // 
            this.buttonExitCustomer.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExitCustomer.Appearance.Options.UseFont = true;
            this.buttonExitCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonExitCustomer.ImageOptions.Image")));
            this.buttonExitCustomer.Location = new System.Drawing.Point(482, 282);
            this.buttonExitCustomer.Name = "buttonExitCustomer";
            this.buttonExitCustomer.Size = new System.Drawing.Size(106, 44);
            this.buttonExitCustomer.TabIndex = 19;
            this.buttonExitCustomer.Text = "Exit";
            // 
            // buttonRemoveCustomer
            // 
            this.buttonRemoveCustomer.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveCustomer.Appearance.Options.UseFont = true;
            this.buttonRemoveCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveCustomer.ImageOptions.Image")));
            this.buttonRemoveCustomer.Location = new System.Drawing.Point(356, 282);
            this.buttonRemoveCustomer.Name = "buttonRemoveCustomer";
            this.buttonRemoveCustomer.Size = new System.Drawing.Size(106, 44);
            this.buttonRemoveCustomer.TabIndex = 18;
            this.buttonRemoveCustomer.Text = "Remove";
            // 
            // buttonEditCustomer
            // 
            this.buttonEditCustomer.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEditCustomer.Appearance.Options.UseFont = true;
            this.buttonEditCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditCustomer.ImageOptions.Image")));
            this.buttonEditCustomer.Location = new System.Drawing.Point(233, 282);
            this.buttonEditCustomer.Name = "buttonEditCustomer";
            this.buttonEditCustomer.Size = new System.Drawing.Size(106, 44);
            this.buttonEditCustomer.TabIndex = 17;
            this.buttonEditCustomer.Text = "Edit";
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddCustomer.Appearance.Options.UseFont = true;
            this.buttonAddCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddCustomer.ImageOptions.Image")));
            this.buttonAddCustomer.Location = new System.Drawing.Point(110, 282);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(106, 44);
            this.buttonAddCustomer.TabIndex = 16;
            this.buttonAddCustomer.Text = "Add";
            // 
            // labelManageCustomersMessage
            // 
            this.labelManageCustomersMessage.AutoSize = true;
            this.labelManageCustomersMessage.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelManageCustomersMessage.ForeColor = System.Drawing.Color.Red;
            this.labelManageCustomersMessage.Location = new System.Drawing.Point(325, 341);
            this.labelManageCustomersMessage.Name = "labelManageCustomersMessage";
            this.labelManageCustomersMessage.Size = new System.Drawing.Size(48, 18);
            this.labelManageCustomersMessage.TabIndex = 20;
            this.labelManageCustomersMessage.Text = "****";
            // 
            // FormManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 368);
            this.Controls.Add(this.labelManageCustomersMessage);
            this.Controls.Add(this.buttonExitCustomer);
            this.Controls.Add(this.buttonRemoveCustomer);
            this.Controls.Add(this.buttonEditCustomer);
            this.Controls.Add(this.buttonAddCustomer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormManageCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Customers";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxCustomerAddress;
        private Label label4;
        private TextBox textBoxCustomerPhone;
        private Label label3;
        private TextBox textBoxCustomerName;
        private Label label2;
        private TextBox textBoxCustomerId;
        private Label label1;
        private GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton buttonCustomerIdFind;
        private TextBox textBoxCustomerIdFind;
        private Label label8;
        private DevExpress.XtraEditors.SimpleButton buttonExitCustomer;
        private DevExpress.XtraEditors.SimpleButton buttonRemoveCustomer;
        private DevExpress.XtraEditors.SimpleButton buttonEditCustomer;
        private DevExpress.XtraEditors.SimpleButton buttonAddCustomer;
        private Label labelManageCustomersMessage;
    }
}