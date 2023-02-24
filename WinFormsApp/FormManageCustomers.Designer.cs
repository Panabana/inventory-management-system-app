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
            this.DataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.groupBoxCustomerNew.SuspendLayout();
            this.groupBoxCustomerFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCustomer)).BeginInit();
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
            this.groupBoxCustomerNew.Location = new System.Drawing.Point(13, 4);
            this.groupBoxCustomerNew.Name = "groupBoxCustomerNew";
            this.groupBoxCustomerNew.Size = new System.Drawing.Size(381, 251);
            this.groupBoxCustomerNew.TabIndex = 2;
            this.groupBoxCustomerNew.TabStop = false;
            this.groupBoxCustomerNew.Text = "New customer details";
            // 
            // textBoxCustomerAddress
            // 
            this.textBoxCustomerAddress.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCustomerAddress.Location = new System.Drawing.Point(102, 209);
            this.textBoxCustomerAddress.Name = "textBoxCustomerAddress";
            this.textBoxCustomerAddress.Size = new System.Drawing.Size(200, 26);
            this.textBoxCustomerAddress.TabIndex = 7;
            // 
            // labelCustomerAddress
            // 
            this.labelCustomerAddress.AutoSize = true;
            this.labelCustomerAddress.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCustomerAddress.ForeColor = System.Drawing.Color.Black;
            this.labelCustomerAddress.Location = new System.Drawing.Point(175, 190);
            this.labelCustomerAddress.Name = "labelCustomerAddress";
            this.labelCustomerAddress.Size = new System.Drawing.Size(54, 14);
            this.labelCustomerAddress.TabIndex = 6;
            this.labelCustomerAddress.Text = "Address:";
            // 
            // textBoxCustomerPhone
            // 
            this.textBoxCustomerPhone.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCustomerPhone.Location = new System.Drawing.Point(102, 109);
            this.textBoxCustomerPhone.Name = "textBoxCustomerPhone";
            this.textBoxCustomerPhone.Size = new System.Drawing.Size(200, 26);
            this.textBoxCustomerPhone.TabIndex = 5;
            // 
            // labelCustomerPhoneNumber
            // 
            this.labelCustomerPhoneNumber.AutoSize = true;
            this.labelCustomerPhoneNumber.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCustomerPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.labelCustomerPhoneNumber.Location = new System.Drawing.Point(156, 90);
            this.labelCustomerPhoneNumber.Name = "labelCustomerPhoneNumber";
            this.labelCustomerPhoneNumber.Size = new System.Drawing.Size(92, 14);
            this.labelCustomerPhoneNumber.TabIndex = 4;
            this.labelCustomerPhoneNumber.Text = "Phone number:";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCustomerName.Location = new System.Drawing.Point(102, 159);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(200, 26);
            this.textBoxCustomerName.TabIndex = 3;
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCustomerName.ForeColor = System.Drawing.Color.Black;
            this.labelCustomerName.Location = new System.Drawing.Point(154, 140);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(97, 14);
            this.labelCustomerName.TabIndex = 2;
            this.labelCustomerName.Text = "Customer name:";
            // 
            // textBoxCustomerId
            // 
            this.textBoxCustomerId.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCustomerId.Location = new System.Drawing.Point(102, 59);
            this.textBoxCustomerId.Name = "textBoxCustomerId";
            this.textBoxCustomerId.Size = new System.Drawing.Size(200, 26);
            this.textBoxCustomerId.TabIndex = 1;
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCustomerID.ForeColor = System.Drawing.Color.Black;
            this.labelCustomerID.Location = new System.Drawing.Point(163, 40);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(79, 14);
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
            this.groupBoxCustomerFind.Location = new System.Drawing.Point(400, 4);
            this.groupBoxCustomerFind.Name = "groupBoxCustomerFind";
            this.groupBoxCustomerFind.Size = new System.Drawing.Size(381, 251);
            this.groupBoxCustomerFind.TabIndex = 10;
            this.groupBoxCustomerFind.TabStop = false;
            this.groupBoxCustomerFind.Text = "Find a customer";
            // 
            // buttonFindCustomer
            // 
            this.buttonFindCustomer.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFindCustomer.Appearance.Options.UseFont = true;
            this.buttonFindCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonFindCustomer.ImageOptions.Image")));
            this.buttonFindCustomer.Location = new System.Drawing.Point(173, 91);
            this.buttonFindCustomer.Name = "buttonFindCustomer";
            this.buttonFindCustomer.Size = new System.Drawing.Size(95, 35);
            this.buttonFindCustomer.TabIndex = 6;
            this.buttonFindCustomer.Text = "Find";
            this.buttonFindCustomer.Click += new System.EventHandler(this.buttonFindCustomer_Click);
            // 
            // textBoxCustomerIdFind
            // 
            this.textBoxCustomerIdFind.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCustomerIdFind.Location = new System.Drawing.Point(114, 59);
            this.textBoxCustomerIdFind.Name = "textBoxCustomerIdFind";
            this.textBoxCustomerIdFind.Size = new System.Drawing.Size(212, 26);
            this.textBoxCustomerIdFind.TabIndex = 5;
            // 
            // labelCustomerIDFind
            // 
            this.labelCustomerIDFind.AutoSize = true;
            this.labelCustomerIDFind.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCustomerIDFind.ForeColor = System.Drawing.Color.Black;
            this.labelCustomerIDFind.Location = new System.Drawing.Point(181, 40);
            this.labelCustomerIDFind.Name = "labelCustomerIDFind";
            this.labelCustomerIDFind.Size = new System.Drawing.Size(79, 14);
            this.labelCustomerIDFind.TabIndex = 0;
            this.labelCustomerIDFind.Text = "Customer ID:";
            // 
            // buttonRemoveCustomer
            // 
            this.buttonRemoveCustomer.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveCustomer.Appearance.Options.UseFont = true;
            this.buttonRemoveCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveCustomer.ImageOptions.Image")));
            this.buttonRemoveCustomer.Location = new System.Drawing.Point(597, 484);
            this.buttonRemoveCustomer.Name = "buttonRemoveCustomer";
            this.buttonRemoveCustomer.Size = new System.Drawing.Size(176, 44);
            this.buttonRemoveCustomer.TabIndex = 18;
            this.buttonRemoveCustomer.Text = "Remove";
            this.buttonRemoveCustomer.Click += new System.EventHandler(this.buttonRemoveCustomer_Click);
            // 
            // buttonEditCustomer
            // 
            this.buttonEditCustomer.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEditCustomer.Appearance.Options.UseFont = true;
            this.buttonEditCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditCustomer.ImageOptions.Image")));
            this.buttonEditCustomer.Location = new System.Drawing.Point(305, 484);
            this.buttonEditCustomer.Name = "buttonEditCustomer";
            this.buttonEditCustomer.Size = new System.Drawing.Size(176, 44);
            this.buttonEditCustomer.TabIndex = 17;
            this.buttonEditCustomer.Text = "Edit";
            this.buttonEditCustomer.Click += new System.EventHandler(this.buttonEditCustomer_Click);
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddCustomer.Appearance.Options.UseFont = true;
            this.buttonAddCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddCustomer.ImageOptions.Image")));
            this.buttonAddCustomer.Location = new System.Drawing.Point(13, 484);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(176, 44);
            this.buttonAddCustomer.TabIndex = 16;
            this.buttonAddCustomer.Tag = "<Null>";
            this.buttonAddCustomer.Text = "Add";
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAddCustomer_Click);
            // 
            // labelManageCustomersMessage
            // 
            this.labelManageCustomersMessage.AutoSize = true;
            this.labelManageCustomersMessage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelManageCustomersMessage.ForeColor = System.Drawing.Color.Red;
            this.labelManageCustomersMessage.Location = new System.Drawing.Point(12, 541);
            this.labelManageCustomersMessage.Name = "labelManageCustomersMessage";
            this.labelManageCustomersMessage.Size = new System.Drawing.Size(49, 19);
            this.labelManageCustomersMessage.TabIndex = 20;
            this.labelManageCustomersMessage.Text = "****";
            this.labelManageCustomersMessage.Visible = false;
            // 
            // DataGridViewCustomer
            // 
            this.DataGridViewCustomer.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCustomer.Location = new System.Drawing.Point(176, 261);
            this.DataGridViewCustomer.Name = "DataGridViewCustomer";
            this.DataGridViewCustomer.RowTemplate.Height = 25;
            this.DataGridViewCustomer.Size = new System.Drawing.Size(437, 217);
            this.DataGridViewCustomer.TabIndex = 21;
            this.DataGridViewCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 568);
            this.Controls.Add(this.DataGridViewCustomer);
            this.Controls.Add(this.labelManageCustomersMessage);
            this.Controls.Add(this.buttonRemoveCustomer);
            this.Controls.Add(this.buttonEditCustomer);
            this.Controls.Add(this.buttonAddCustomer);
            this.Controls.Add(this.groupBoxCustomerFind);
            this.Controls.Add(this.groupBoxCustomerNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormManageCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Customers";
            this.Load += new System.EventHandler(this.FormManageCustomers_Load);
            this.groupBoxCustomerNew.ResumeLayout(false);
            this.groupBoxCustomerNew.PerformLayout();
            this.groupBoxCustomerFind.ResumeLayout(false);
            this.groupBoxCustomerFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCustomer)).EndInit();
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
        private DataGridView DataGridViewCustomer;
    }
}