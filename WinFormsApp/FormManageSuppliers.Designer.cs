namespace WinFormsApp
{
    partial class FormManageSuppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageSuppliers));
            this.groupBoxSupplierNew = new System.Windows.Forms.GroupBox();
            this.textBoxSupplierAddress = new System.Windows.Forms.TextBox();
            this.labelSupplierAddress = new System.Windows.Forms.Label();
            this.textBoxSupplierPhone = new System.Windows.Forms.TextBox();
            this.labelSupplierPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxSupplierName = new System.Windows.Forms.TextBox();
            this.labelSupplierName = new System.Windows.Forms.Label();
            this.textBoxSupplierID = new System.Windows.Forms.TextBox();
            this.labelSupplierID = new System.Windows.Forms.Label();
            this.groupBoxSupplierFind = new System.Windows.Forms.GroupBox();
            this.buttonFindSupplier = new DevExpress.XtraEditors.SimpleButton();
            this.textBoxSupplierIdFind = new System.Windows.Forms.TextBox();
            this.labelSupplierIDFind = new System.Windows.Forms.Label();
            this.buttonRemoveSupplier = new DevExpress.XtraEditors.SimpleButton();
            this.buttonEditSupplier = new DevExpress.XtraEditors.SimpleButton();
            this.buttonAddSupplier = new DevExpress.XtraEditors.SimpleButton();
            this.labelManageSuppliersMessage = new System.Windows.Forms.Label();
            this.comboBoxSelectProductToAddSupplier = new System.Windows.Forms.ComboBox();
            this.buttonAddSupplierToProduct = new DevExpress.XtraEditors.SimpleButton();
            this.groupBoxSupplierNew.SuspendLayout();
            this.groupBoxSupplierFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSupplierNew
            // 
            this.groupBoxSupplierNew.Controls.Add(this.textBoxSupplierAddress);
            this.groupBoxSupplierNew.Controls.Add(this.labelSupplierAddress);
            this.groupBoxSupplierNew.Controls.Add(this.textBoxSupplierPhone);
            this.groupBoxSupplierNew.Controls.Add(this.labelSupplierPhoneNumber);
            this.groupBoxSupplierNew.Controls.Add(this.textBoxSupplierName);
            this.groupBoxSupplierNew.Controls.Add(this.labelSupplierName);
            this.groupBoxSupplierNew.Controls.Add(this.textBoxSupplierID);
            this.groupBoxSupplierNew.Controls.Add(this.labelSupplierID);
            this.groupBoxSupplierNew.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSupplierNew.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBoxSupplierNew.Location = new System.Drawing.Point(18, 15);
            this.groupBoxSupplierNew.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxSupplierNew.Name = "groupBoxSupplierNew";
            this.groupBoxSupplierNew.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxSupplierNew.Size = new System.Drawing.Size(780, 170);
            this.groupBoxSupplierNew.TabIndex = 1;
            this.groupBoxSupplierNew.TabStop = false;
            this.groupBoxSupplierNew.Text = "New supplier details";
            // 
            // textBoxSupplierAddress
            // 
            this.textBoxSupplierAddress.Location = new System.Drawing.Point(530, 102);
            this.textBoxSupplierAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSupplierAddress.Name = "textBoxSupplierAddress";
            this.textBoxSupplierAddress.Size = new System.Drawing.Size(233, 30);
            this.textBoxSupplierAddress.TabIndex = 7;
            // 
            // labelSupplierAddress
            // 
            this.labelSupplierAddress.AutoSize = true;
            this.labelSupplierAddress.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSupplierAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSupplierAddress.Location = new System.Drawing.Point(453, 110);
            this.labelSupplierAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSupplierAddress.Name = "labelSupplierAddress";
            this.labelSupplierAddress.Size = new System.Drawing.Size(73, 18);
            this.labelSupplierAddress.TabIndex = 6;
            this.labelSupplierAddress.Text = "Address:";
            // 
            // textBoxSupplierPhone
            // 
            this.textBoxSupplierPhone.Location = new System.Drawing.Point(128, 102);
            this.textBoxSupplierPhone.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSupplierPhone.Name = "textBoxSupplierPhone";
            this.textBoxSupplierPhone.Size = new System.Drawing.Size(233, 30);
            this.textBoxSupplierPhone.TabIndex = 5;
            // 
            // labelSupplierPhoneNumber
            // 
            this.labelSupplierPhoneNumber.AutoSize = true;
            this.labelSupplierPhoneNumber.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSupplierPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSupplierPhoneNumber.Location = new System.Drawing.Point(4, 110);
            this.labelSupplierPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSupplierPhoneNumber.Name = "labelSupplierPhoneNumber";
            this.labelSupplierPhoneNumber.Size = new System.Drawing.Size(119, 18);
            this.labelSupplierPhoneNumber.TabIndex = 4;
            this.labelSupplierPhoneNumber.Text = "Phone number:";
            // 
            // textBoxSupplierName
            // 
            this.textBoxSupplierName.Location = new System.Drawing.Point(530, 42);
            this.textBoxSupplierName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSupplierName.Name = "textBoxSupplierName";
            this.textBoxSupplierName.Size = new System.Drawing.Size(233, 30);
            this.textBoxSupplierName.TabIndex = 3;
            // 
            // labelSupplierName
            // 
            this.labelSupplierName.AutoSize = true;
            this.labelSupplierName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSupplierName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSupplierName.Location = new System.Drawing.Point(408, 49);
            this.labelSupplierName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSupplierName.Name = "labelSupplierName";
            this.labelSupplierName.Size = new System.Drawing.Size(120, 18);
            this.labelSupplierName.TabIndex = 2;
            this.labelSupplierName.Text = "Supplier name:";
            // 
            // textBoxSupplierID
            // 
            this.textBoxSupplierID.Location = new System.Drawing.Point(128, 42);
            this.textBoxSupplierID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSupplierID.Name = "textBoxSupplierID";
            this.textBoxSupplierID.Size = new System.Drawing.Size(233, 30);
            this.textBoxSupplierID.TabIndex = 1;
            // 
            // labelSupplierID
            // 
            this.labelSupplierID.AutoSize = true;
            this.labelSupplierID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSupplierID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSupplierID.Location = new System.Drawing.Point(29, 49);
            this.labelSupplierID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSupplierID.Name = "labelSupplierID";
            this.labelSupplierID.Size = new System.Drawing.Size(98, 18);
            this.labelSupplierID.TabIndex = 0;
            this.labelSupplierID.Text = "Supplier ID:";
            // 
            // groupBoxSupplierFind
            // 
            this.groupBoxSupplierFind.Controls.Add(this.buttonFindSupplier);
            this.groupBoxSupplierFind.Controls.Add(this.textBoxSupplierIdFind);
            this.groupBoxSupplierFind.Controls.Add(this.labelSupplierIDFind);
            this.groupBoxSupplierFind.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSupplierFind.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBoxSupplierFind.Location = new System.Drawing.Point(18, 206);
            this.groupBoxSupplierFind.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxSupplierFind.Name = "groupBoxSupplierFind";
            this.groupBoxSupplierFind.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxSupplierFind.Size = new System.Drawing.Size(780, 114);
            this.groupBoxSupplierFind.TabIndex = 9;
            this.groupBoxSupplierFind.TabStop = false;
            this.groupBoxSupplierFind.Text = "Find a supplier";
            // 
            // buttonFindSupplier
            // 
            this.buttonFindSupplier.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFindSupplier.Appearance.Options.UseFont = true;
            this.buttonFindSupplier.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonFindSupplier.ImageOptions.Image")));
            this.buttonFindSupplier.Location = new System.Drawing.Point(513, 43);
            this.buttonFindSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFindSupplier.Name = "buttonFindSupplier";
            this.buttonFindSupplier.Size = new System.Drawing.Size(111, 43);
            this.buttonFindSupplier.TabIndex = 6;
            this.buttonFindSupplier.Text = "Find";
            this.buttonFindSupplier.Click += new System.EventHandler(this.buttonFindSupplier_Click);
            // 
            // textBoxSupplierIdFind
            // 
            this.textBoxSupplierIdFind.Location = new System.Drawing.Point(253, 48);
            this.textBoxSupplierIdFind.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSupplierIdFind.Name = "textBoxSupplierIdFind";
            this.textBoxSupplierIdFind.Size = new System.Drawing.Size(247, 30);
            this.textBoxSupplierIdFind.TabIndex = 5;
            // 
            // labelSupplierIDFind
            // 
            this.labelSupplierIDFind.AutoSize = true;
            this.labelSupplierIDFind.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSupplierIDFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSupplierIDFind.Location = new System.Drawing.Point(155, 55);
            this.labelSupplierIDFind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSupplierIDFind.Name = "labelSupplierIDFind";
            this.labelSupplierIDFind.Size = new System.Drawing.Size(98, 18);
            this.labelSupplierIDFind.TabIndex = 0;
            this.labelSupplierIDFind.Text = "Supplier ID:";
            // 
            // buttonRemoveSupplier
            // 
            this.buttonRemoveSupplier.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveSupplier.Appearance.Options.UseFont = true;
            this.buttonRemoveSupplier.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveSupplier.ImageOptions.Image")));
            this.buttonRemoveSupplier.Location = new System.Drawing.Point(415, 347);
            this.buttonRemoveSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoveSupplier.Name = "buttonRemoveSupplier";
            this.buttonRemoveSupplier.Size = new System.Drawing.Size(124, 54);
            this.buttonRemoveSupplier.TabIndex = 14;
            this.buttonRemoveSupplier.Text = "Remove";
            this.buttonRemoveSupplier.Click += new System.EventHandler(this.buttonRemoveSupplier_Click);
            // 
            // buttonEditSupplier
            // 
            this.buttonEditSupplier.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEditSupplier.Appearance.Options.UseFont = true;
            this.buttonEditSupplier.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditSupplier.ImageOptions.Image")));
            this.buttonEditSupplier.Location = new System.Drawing.Point(272, 347);
            this.buttonEditSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditSupplier.Name = "buttonEditSupplier";
            this.buttonEditSupplier.Size = new System.Drawing.Size(124, 54);
            this.buttonEditSupplier.TabIndex = 13;
            this.buttonEditSupplier.Text = "Edit";
            this.buttonEditSupplier.Click += new System.EventHandler(this.buttonEditSupplier_Click);
            // 
            // buttonAddSupplier
            // 
            this.buttonAddSupplier.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddSupplier.Appearance.Options.UseFont = true;
            this.buttonAddSupplier.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddSupplier.ImageOptions.Image")));
            this.buttonAddSupplier.Location = new System.Drawing.Point(128, 347);
            this.buttonAddSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddSupplier.Name = "buttonAddSupplier";
            this.buttonAddSupplier.Size = new System.Drawing.Size(124, 54);
            this.buttonAddSupplier.TabIndex = 12;
            this.buttonAddSupplier.Text = "Add";
            this.buttonAddSupplier.Click += new System.EventHandler(this.buttonAddSupplier_Click);
            // 
            // labelManageSuppliersMessage
            // 
            this.labelManageSuppliersMessage.AutoSize = true;
            this.labelManageSuppliersMessage.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelManageSuppliersMessage.ForeColor = System.Drawing.Color.Red;
            this.labelManageSuppliersMessage.Location = new System.Drawing.Point(21, 404);
            this.labelManageSuppliersMessage.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelManageSuppliersMessage.Name = "labelManageSuppliersMessage";
            this.labelManageSuppliersMessage.Size = new System.Drawing.Size(58, 23);
            this.labelManageSuppliersMessage.TabIndex = 16;
            this.labelManageSuppliersMessage.Text = "****";
            this.labelManageSuppliersMessage.Visible = false;
            // 
            // comboBoxSelectProductToAddSupplier
            // 
            this.comboBoxSelectProductToAddSupplier.FormattingEnabled = true;
            this.comboBoxSelectProductToAddSupplier.Location = new System.Drawing.Point(594, 328);
            this.comboBoxSelectProductToAddSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSelectProductToAddSupplier.Name = "comboBoxSelectProductToAddSupplier";
            this.comboBoxSelectProductToAddSupplier.Size = new System.Drawing.Size(163, 24);
            this.comboBoxSelectProductToAddSupplier.TabIndex = 17;
            // 
            // buttonAddSupplierToProduct
            // 
            this.buttonAddSupplierToProduct.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddSupplierToProduct.Appearance.Options.UseFont = true;
            this.buttonAddSupplierToProduct.Location = new System.Drawing.Point(612, 379);
            this.buttonAddSupplierToProduct.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddSupplierToProduct.Name = "buttonAddSupplierToProduct";
            this.buttonAddSupplierToProduct.Size = new System.Drawing.Size(124, 54);
            this.buttonAddSupplierToProduct.TabIndex = 19;
            this.buttonAddSupplierToProduct.Text = "Add to Product";
            // 
            // FormManageSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 462);
            this.Controls.Add(this.buttonAddSupplierToProduct);
            this.Controls.Add(this.comboBoxSelectProductToAddSupplier);
            this.Controls.Add(this.labelManageSuppliersMessage);
            this.Controls.Add(this.buttonRemoveSupplier);
            this.Controls.Add(this.buttonEditSupplier);
            this.Controls.Add(this.buttonAddSupplier);
            this.Controls.Add(this.groupBoxSupplierFind);
            this.Controls.Add(this.groupBoxSupplierNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormManageSuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Suppliers";
            this.groupBoxSupplierNew.ResumeLayout(false);
            this.groupBoxSupplierNew.PerformLayout();
            this.groupBoxSupplierFind.ResumeLayout(false);
            this.groupBoxSupplierFind.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBoxSupplierNew;
        private TextBox textBoxSupplierAddress;
        private Label labelSupplierAddress;
        private TextBox textBoxSupplierPhone;
        private Label labelSupplierPhoneNumber;
        private TextBox textBoxSupplierName;
        private Label labelSupplierName;
        private TextBox textBoxSupplierID;
        private Label labelSupplierID;
        private GroupBox groupBoxSupplierFind;
        private DevExpress.XtraEditors.SimpleButton buttonFindSupplier;
        private TextBox textBoxSupplierIdFind;
        private Label labelSupplierIDFind;
        private DevExpress.XtraEditors.SimpleButton buttonRemoveSupplier;
        private DevExpress.XtraEditors.SimpleButton buttonEditSupplier;
        private DevExpress.XtraEditors.SimpleButton buttonAddSupplier;
        private Label labelManageSuppliersMessage;
        private ComboBox comboBoxSelectProductToAddSupplier;
        private DevExpress.XtraEditors.SimpleButton buttonAddSupplierToProduct;
    }
}