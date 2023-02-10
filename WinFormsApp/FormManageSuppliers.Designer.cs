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
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New supplier details";
            // 
            // textBoxSupplierAddress
            // 
            this.textBoxSupplierAddress.Location = new System.Drawing.Point(454, 83);
            this.textBoxSupplierAddress.Name = "textBoxSupplierAddress";
            this.textBoxSupplierAddress.Size = new System.Drawing.Size(200, 26);
            this.textBoxSupplierAddress.TabIndex = 7;
            // 
            // labelSupplierAddress
            // 
            this.labelSupplierAddress.AutoSize = true;
            this.labelSupplierAddress.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSupplierAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSupplierAddress.Location = new System.Drawing.Point(388, 89);
            this.labelSupplierAddress.Name = "labelSupplierAddress";
            this.labelSupplierAddress.Size = new System.Drawing.Size(60, 14);
            this.labelSupplierAddress.TabIndex = 6;
            this.labelSupplierAddress.Text = "Address:";
            // 
            // textBoxSupplierPhone
            // 
            this.textBoxSupplierPhone.Location = new System.Drawing.Point(110, 83);
            this.textBoxSupplierPhone.Name = "textBoxSupplierPhone";
            this.textBoxSupplierPhone.Size = new System.Drawing.Size(200, 26);
            this.textBoxSupplierPhone.TabIndex = 5;
            // 
            // labelSupplierPhoneNumber
            // 
            this.labelSupplierPhoneNumber.AutoSize = true;
            this.labelSupplierPhoneNumber.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSupplierPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSupplierPhoneNumber.Location = new System.Drawing.Point(3, 89);
            this.labelSupplierPhoneNumber.Name = "labelSupplierPhoneNumber";
            this.labelSupplierPhoneNumber.Size = new System.Drawing.Size(101, 14);
            this.labelSupplierPhoneNumber.TabIndex = 4;
            this.labelSupplierPhoneNumber.Text = "Phone number:";
            // 
            // textBoxSupplierName
            // 
            this.textBoxSupplierName.Location = new System.Drawing.Point(454, 34);
            this.textBoxSupplierName.Name = "textBoxSupplierName";
            this.textBoxSupplierName.Size = new System.Drawing.Size(200, 26);
            this.textBoxSupplierName.TabIndex = 3;
            // 
            // labelSupplierName
            // 
            this.labelSupplierName.AutoSize = true;
            this.labelSupplierName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSupplierName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSupplierName.Location = new System.Drawing.Point(350, 40);
            this.labelSupplierName.Name = "labelSupplierName";
            this.labelSupplierName.Size = new System.Drawing.Size(98, 14);
            this.labelSupplierName.TabIndex = 2;
            this.labelSupplierName.Text = "Supplier name:";
            // 
            // textBoxSupplierID
            // 
            this.textBoxSupplierID.Location = new System.Drawing.Point(110, 34);
            this.textBoxSupplierID.Name = "textBoxSupplierID";
            this.textBoxSupplierID.Size = new System.Drawing.Size(200, 26);
            this.textBoxSupplierID.TabIndex = 1;
            // 
            // labelSupplierID
            // 
            this.labelSupplierID.AutoSize = true;
            this.labelSupplierID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSupplierID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSupplierID.Location = new System.Drawing.Point(25, 40);
            this.labelSupplierID.Name = "labelSupplierID";
            this.labelSupplierID.Size = new System.Drawing.Size(79, 14);
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
            this.groupBox2.Location = new System.Drawing.Point(15, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 93);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find a supplier";
            // 
            // buttonFindSupplier
            // 
            this.buttonFindSupplier.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFindSupplier.Appearance.Options.UseFont = true;
            this.buttonFindSupplier.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonFindSupplier.ImageOptions.Image")));
            this.buttonFindSupplier.Location = new System.Drawing.Point(440, 35);
            this.buttonFindSupplier.Name = "buttonFindSupplier";
            this.buttonFindSupplier.Size = new System.Drawing.Size(95, 35);
            this.buttonFindSupplier.TabIndex = 6;
            this.buttonFindSupplier.Text = "Find";
            this.buttonFindSupplier.Click += new System.EventHandler(this.buttonFindSupplier_Click);
            // 
            // textBoxSupplierIdFind
            // 
            this.textBoxSupplierIdFind.Location = new System.Drawing.Point(217, 39);
            this.textBoxSupplierIdFind.Name = "textBoxSupplierIdFind";
            this.textBoxSupplierIdFind.Size = new System.Drawing.Size(212, 26);
            this.textBoxSupplierIdFind.TabIndex = 5;
            // 
            // labelSupplierIDFind
            // 
            this.labelSupplierIDFind.AutoSize = true;
            this.labelSupplierIDFind.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSupplierIDFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSupplierIDFind.Location = new System.Drawing.Point(133, 45);
            this.labelSupplierIDFind.Name = "labelSupplierIDFind";
            this.labelSupplierIDFind.Size = new System.Drawing.Size(79, 14);
            this.labelSupplierIDFind.TabIndex = 0;
            this.labelSupplierIDFind.Text = "Supplier ID:";
           
            // 
            // 
            // 
            // buttonRemoveSupplier
            // 
            this.buttonRemoveSupplier.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveSupplier.Appearance.Options.UseFont = true;
            this.buttonRemoveSupplier.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveSupplier.ImageOptions.Image")));
            this.buttonRemoveSupplier.Location = new System.Drawing.Point(356, 282);
            this.buttonRemoveSupplier.Name = "buttonRemoveSupplier";
            this.buttonRemoveSupplier.Size = new System.Drawing.Size(106, 44);
            this.buttonRemoveSupplier.TabIndex = 14;
            this.buttonRemoveSupplier.Text = "Remove";
            this.buttonRemoveSupplier.Click += new System.EventHandler(this.buttonRemoveSupplier_Click);
            // 
            // buttonEditSupplier
            // 
            this.buttonEditSupplier.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEditSupplier.Appearance.Options.UseFont = true;
            this.buttonEditSupplier.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditSupplier.ImageOptions.Image")));
            this.buttonEditSupplier.Location = new System.Drawing.Point(233, 282);
            this.buttonEditSupplier.Name = "buttonEditSupplier";
            this.buttonEditSupplier.Size = new System.Drawing.Size(106, 44);
            this.buttonEditSupplier.TabIndex = 13;
            this.buttonEditSupplier.Text = "Edit";
            this.buttonEditSupplier.Click += new System.EventHandler(this.buttonEditSupplier_Click);
            // 
            // buttonAddSupplier
            // 
            this.buttonAddSupplier.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddSupplier.Appearance.Options.UseFont = true;
            this.buttonAddSupplier.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddSupplier.ImageOptions.Image")));
            this.buttonAddSupplier.Location = new System.Drawing.Point(110, 282);
            this.buttonAddSupplier.Name = "buttonAddSupplier";
            this.buttonAddSupplier.Size = new System.Drawing.Size(106, 44);
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
            this.labelManageSuppliersMessage.Size = new System.Drawing.Size(48, 18);
            this.labelManageSuppliersMessage.TabIndex = 16;
            this.labelManageSuppliersMessage.Text = "****";
            this.labelManageSuppliersMessage.Visible = false;
            // 
            // FormManageSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 368);
            this.Controls.Add(this.labelManageSuppliersMessage);
            this.Controls.Add(this.buttonRemoveSupplier);
            this.Controls.Add(this.buttonEditSupplier);
            this.Controls.Add(this.buttonAddSupplier);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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