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
            this.groupBoxCustomerNew = new System.Windows.Forms.GroupBox();
            this.textBoxCustomerAddress = new System.Windows.Forms.TextBox();
            this.labelCustomerAddress = new System.Windows.Forms.Label();
            this.textBoxCustomerPhone = new System.Windows.Forms.TextBox();
            this.labelCustomerPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.textBoxCustomerId = new System.Windows.Forms.TextBox();
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.groupBoxCustomerFind = new System.Windows.Forms.GroupBox();
            this.buttonFindCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.textBoxCustomerIdFind = new System.Windows.Forms.TextBox();
            this.labelCustomerIDFind = new System.Windows.Forms.Label();
            this.buttonRemoveCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.buttonEditCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.buttonAddCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.labelManageCustomersMessage = new System.Windows.Forms.Label();
            this.groupBoxCustomerNew.SuspendLayout();
            this.groupBoxCustomerFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCustomerNew
            // 
            this.groupBoxCustomerNew.Controls.Add(this.textBoxCustomerAddress);
            this.groupBoxCustomerNew.Controls.Add(this.labelCustomerAddress);
            this.groupBoxCustomerNew.Controls.Add(this.textBoxCustomerPhone);
            this.groupBoxCustomerNew.Controls.Add(this.labelCustomerPhoneNumber);
            this.groupBoxCustomerNew.Controls.Add(this.textBoxCustomerName);
            this.groupBoxCustomerNew.Controls.Add(this.labelCustomerName);
            this.groupBoxCustomerNew.Controls.Add(this.textBoxCustomerId);
            this.groupBoxCustomerNew.Controls.Add(this.labelCustomerID);
            this.groupBoxCustomerNew.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxCustomerNew.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBoxCustomerNew.Location = new System.Drawing.Point(18, 15);
            this.groupBoxCustomerNew.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCustomerNew.Name = "groupBoxCustomerNew";
            this.groupBoxCustomerNew.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCustomerNew.Size = new System.Drawing.Size(780, 170);
            this.groupBoxCustomerNew.TabIndex = 2;
            this.groupBoxCustomerNew.TabStop = false;
            this.groupBoxCustomerNew.Text = "New customer details";
            // 
            // textBoxCustomerAddress
            // 
            this.textBoxCustomerAddress.Location = new System.Drawing.Point(530, 102);
            this.textBoxCustomerAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCustomerAddress.Name = "textBoxCustomerAddress";
            this.textBoxCustomerAddress.Size = new System.Drawing.Size(233, 30);
            this.textBoxCustomerAddress.TabIndex = 7;
            // 
            // labelCustomerAddress
            // 
            this.labelCustomerAddress.AutoSize = true;
            this.labelCustomerAddress.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCustomerAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCustomerAddress.Location = new System.Drawing.Point(453, 110);
            this.labelCustomerAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustomerAddress.Name = "labelCustomerAddress";
            this.labelCustomerAddress.Size = new System.Drawing.Size(73, 18);
            this.labelCustomerAddress.TabIndex = 6;
            this.labelCustomerAddress.Text = "Address:";
            // 
            // textBoxCustomerPhone
            // 
            this.textBoxCustomerPhone.Location = new System.Drawing.Point(128, 102);
            this.textBoxCustomerPhone.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCustomerPhone.Name = "textBoxCustomerPhone";
            this.textBoxCustomerPhone.Size = new System.Drawing.Size(233, 30);
            this.textBoxCustomerPhone.TabIndex = 5;
            // 
            // labelCustomerPhoneNumber
            // 
            this.labelCustomerPhoneNumber.AutoSize = true;
            this.labelCustomerPhoneNumber.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCustomerPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCustomerPhoneNumber.Location = new System.Drawing.Point(4, 110);
            this.labelCustomerPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustomerPhoneNumber.Name = "labelCustomerPhoneNumber";
            this.labelCustomerPhoneNumber.Size = new System.Drawing.Size(119, 18);
            this.labelCustomerPhoneNumber.TabIndex = 4;
            this.labelCustomerPhoneNumber.Text = "Phone number:";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(530, 42);
            this.textBoxCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(233, 30);
            this.textBoxCustomerName.TabIndex = 3;
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCustomerName.Location = new System.Drawing.Point(398, 49);
            this.labelCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(128, 18);
            this.labelCustomerName.TabIndex = 2;
            this.labelCustomerName.Text = "Customer name:";
            // 
            // textBoxCustomerId
            // 
            this.textBoxCustomerId.Location = new System.Drawing.Point(128, 42);
            this.textBoxCustomerId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCustomerId.Name = "textBoxCustomerId";
            this.textBoxCustomerId.Size = new System.Drawing.Size(233, 30);
            this.textBoxCustomerId.TabIndex = 1;
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCustomerID.Location = new System.Drawing.Point(19, 49);
            this.labelCustomerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(106, 18);
            this.labelCustomerID.TabIndex = 0;
            this.labelCustomerID.Text = "Customer ID:";
            // 
            // groupBoxCustomerFind
            // 
            this.groupBoxCustomerFind.Controls.Add(this.buttonFindCustomer);
            this.groupBoxCustomerFind.Controls.Add(this.textBoxCustomerIdFind);
            this.groupBoxCustomerFind.Controls.Add(this.labelCustomerIDFind);
            this.groupBoxCustomerFind.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxCustomerFind.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBoxCustomerFind.Location = new System.Drawing.Point(18, 206);
            this.groupBoxCustomerFind.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCustomerFind.Name = "groupBoxCustomerFind";
            this.groupBoxCustomerFind.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCustomerFind.Size = new System.Drawing.Size(780, 114);
            this.groupBoxCustomerFind.TabIndex = 10;
            this.groupBoxCustomerFind.TabStop = false;
            this.groupBoxCustomerFind.Text = "Find a customer";
            // 
            // buttonFindCustomer
            // 
            this.buttonFindCustomer.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFindCustomer.Appearance.Options.UseFont = true;
            this.buttonFindCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonFindCustomer.ImageOptions.Image")));
            this.buttonFindCustomer.Location = new System.Drawing.Point(513, 43);
            this.buttonFindCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFindCustomer.Name = "buttonFindCustomer";
            this.buttonFindCustomer.Size = new System.Drawing.Size(111, 43);
            this.buttonFindCustomer.TabIndex = 6;
            this.buttonFindCustomer.Text = "Find";
            this.buttonFindCustomer.Click += new System.EventHandler(this.buttonFindCustomer_Click);
            // 
            // textBoxCustomerIdFind
            // 
            this.textBoxCustomerIdFind.Location = new System.Drawing.Point(253, 48);
            this.textBoxCustomerIdFind.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCustomerIdFind.Name = "textBoxCustomerIdFind";
            this.textBoxCustomerIdFind.Size = new System.Drawing.Size(247, 30);
            this.textBoxCustomerIdFind.TabIndex = 5;
            // 
            // labelCustomerIDFind
            // 
            this.labelCustomerIDFind.AutoSize = true;
            this.labelCustomerIDFind.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCustomerIDFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCustomerIDFind.Location = new System.Drawing.Point(144, 55);
            this.labelCustomerIDFind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustomerIDFind.Name = "labelCustomerIDFind";
            this.labelCustomerIDFind.Size = new System.Drawing.Size(106, 18);
            this.labelCustomerIDFind.TabIndex = 0;
            this.labelCustomerIDFind.Text = "Customer ID:";
            // 
            // buttonRemoveCustomer
            // 
            this.buttonRemoveCustomer.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveCustomer.Appearance.Options.UseFont = true;
            this.buttonRemoveCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveCustomer.ImageOptions.Image")));
            this.buttonRemoveCustomer.Location = new System.Drawing.Point(415, 347);
            this.buttonRemoveCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoveCustomer.Name = "buttonRemoveCustomer";
            this.buttonRemoveCustomer.Size = new System.Drawing.Size(124, 54);
            this.buttonRemoveCustomer.TabIndex = 18;
            this.buttonRemoveCustomer.Text = "Remove";
            this.buttonRemoveCustomer.Click += new System.EventHandler(this.buttonRemoveCustomer_Click);
            // 
            // buttonEditCustomer
            // 
            this.buttonEditCustomer.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEditCustomer.Appearance.Options.UseFont = true;
            this.buttonEditCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditCustomer.ImageOptions.Image")));
            this.buttonEditCustomer.Location = new System.Drawing.Point(272, 347);
            this.buttonEditCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditCustomer.Name = "buttonEditCustomer";
            this.buttonEditCustomer.Size = new System.Drawing.Size(124, 54);
            this.buttonEditCustomer.TabIndex = 17;
            this.buttonEditCustomer.Text = "Edit";
            this.buttonEditCustomer.Click += new System.EventHandler(this.buttonEditCustomer_Click);
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddCustomer.Appearance.Options.UseFont = true;
            this.buttonAddCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddCustomer.ImageOptions.Image")));
            this.buttonAddCustomer.Location = new System.Drawing.Point(128, 347);
            this.buttonAddCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(124, 54);
            this.buttonAddCustomer.TabIndex = 16;
            this.buttonAddCustomer.Tag = "<Null>";
            this.buttonAddCustomer.Text = "Add";
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAddCustomer_Click);
            // 
            // labelManageCustomersMessage
            // 
            this.labelManageCustomersMessage.AutoSize = true;
            this.labelManageCustomersMessage.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelManageCustomersMessage.ForeColor = System.Drawing.Color.Red;
            this.labelManageCustomersMessage.Location = new System.Drawing.Point(10, 420);
            this.labelManageCustomersMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelManageCustomersMessage.Name = "labelManageCustomersMessage";
            this.labelManageCustomersMessage.Size = new System.Drawing.Size(58, 23);
            this.labelManageCustomersMessage.TabIndex = 20;
            this.labelManageCustomersMessage.Text = "****";
            this.labelManageCustomersMessage.Visible = false;
            // 
            // FormManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 453);
            this.Controls.Add(this.labelManageCustomersMessage);
            this.Controls.Add(this.buttonRemoveCustomer);
            this.Controls.Add(this.buttonEditCustomer);
            this.Controls.Add(this.buttonAddCustomer);
            this.Controls.Add(this.groupBoxCustomerFind);
            this.Controls.Add(this.groupBoxCustomerNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormManageCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Customers";
            this.groupBoxCustomerNew.ResumeLayout(false);
            this.groupBoxCustomerNew.PerformLayout();
            this.groupBoxCustomerFind.ResumeLayout(false);
            this.groupBoxCustomerFind.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBoxCustomerNew;
        private TextBox textBoxCustomerAddress;
        private Label labelCustomerAddress;
        private TextBox textBoxCustomerPhone;
        private Label labelCustomerPhoneNumber;
        private TextBox textBoxCustomerName;
        private Label labelCustomerName;
        private TextBox textBoxCustomerId;
        private Label labelCustomerID;
        private GroupBox groupBoxCustomerFind;
        private DevExpress.XtraEditors.SimpleButton buttonFindCustomer;
        private TextBox textBoxCustomerIdFind;
        private Label labelCustomerIDFind;
        private DevExpress.XtraEditors.SimpleButton buttonRemoveCustomer;
        private DevExpress.XtraEditors.SimpleButton buttonEditCustomer;
        private DevExpress.XtraEditors.SimpleButton buttonAddCustomer;
        private Label labelManageCustomersMessage;
    }
}