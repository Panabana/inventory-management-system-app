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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSupplierAddress = new System.Windows.Forms.TextBox();
            this.labelSupplierAddress = new System.Windows.Forms.Label();
            this.textBoxSupplierPhone = new System.Windows.Forms.TextBox();
            this.labelSupplierPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxSupplierName = new System.Windows.Forms.TextBox();
            this.labelSupplierName = new System.Windows.Forms.Label();
            this.textBoxSupplierID = new System.Windows.Forms.TextBox();
            this.labelSupplierID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonFindSupplier = new DevExpress.XtraEditors.SimpleButton();
            this.textBoxSupplierIdFind = new System.Windows.Forms.TextBox();
            this.labelSupplierIDFind = new System.Windows.Forms.Label();
            this.buttonRemoveSupplier = new DevExpress.XtraEditors.SimpleButton();
            this.buttonEditSupplier = new DevExpress.XtraEditors.SimpleButton();
            this.buttonAddSupplier = new DevExpress.XtraEditors.SimpleButton();
            this.labelManageSuppliersMessage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxSupplierAddress);
            this.groupBox1.Controls.Add(this.labelSupplierAddress);
            this.groupBox1.Controls.Add(this.textBoxSupplierPhone);
            this.groupBox1.Controls.Add(this.labelSupplierPhoneNumber);
            this.groupBox1.Controls.Add(this.textBoxSupplierName);
            this.groupBox1.Controls.Add(this.labelSupplierName);
            this.groupBox1.Controls.Add(this.textBoxSupplierID);
            this.groupBox1.Controls.Add(this.labelSupplierID);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(18, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(780, 170);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New supplier details";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonFindSupplier);
            this.groupBox2.Controls.Add(this.textBoxSupplierIdFind);
            this.groupBox2.Controls.Add(this.labelSupplierIDFind);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox2.Location = new System.Drawing.Point(18, 206);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(780, 114);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find a supplier";
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
            this.labelManageSuppliersMessage.Location = new System.Drawing.Point(10, 420);
            this.labelManageSuppliersMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelManageSuppliersMessage.Name = "labelManageSuppliersMessage";
            this.labelManageSuppliersMessage.Size = new System.Drawing.Size(58, 23);
            this.labelManageSuppliersMessage.TabIndex = 16;
            this.labelManageSuppliersMessage.Text = "****";
            this.labelManageSuppliersMessage.Visible = false;
            // 
            // FormManageSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 453);
            this.Controls.Add(this.labelManageSuppliersMessage);
            this.Controls.Add(this.buttonRemoveSupplier);
            this.Controls.Add(this.buttonEditSupplier);
            this.Controls.Add(this.buttonAddSupplier);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormManageSuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Suppliers";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxSupplierAddress;
        private Label labelSupplierAddress;
        private TextBox textBoxSupplierPhone;
        private Label labelSupplierPhoneNumber;
        private TextBox textBoxSupplierName;
        private Label labelSupplierName;
        private TextBox textBoxSupplierID;
        private Label labelSupplierID;
        private GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton buttonFindSupplier;
        private TextBox textBoxSupplierIdFind;
        private Label labelSupplierIDFind;
        private DevExpress.XtraEditors.SimpleButton buttonRemoveSupplier;
        private DevExpress.XtraEditors.SimpleButton buttonEditSupplier;
        private DevExpress.XtraEditors.SimpleButton buttonAddSupplier;
        private Label labelManageSuppliersMessage;
    }
}