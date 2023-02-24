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
            this.labelSupplierProduct = new System.Windows.Forms.Label();
            this.buttonAddSupplierToProduct = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxSelectProductToAddSupplier = new System.Windows.Forms.ComboBox();
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
            this.DataGridViewSupplier = new System.Windows.Forms.DataGridView();
            this.groupBoxSupplierNew.SuspendLayout();
            this.groupBoxSupplierFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSupplierNew
            // 
            this.groupBoxSupplierNew.Controls.Add(this.labelSupplierProduct);
            this.groupBoxSupplierNew.Controls.Add(this.buttonAddSupplierToProduct);
            this.groupBoxSupplierNew.Controls.Add(this.comboBoxSelectProductToAddSupplier);
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
            this.groupBoxSupplierNew.Location = new System.Drawing.Point(13, 4);
            this.groupBoxSupplierNew.Name = "groupBoxSupplierNew";
            this.groupBoxSupplierNew.Size = new System.Drawing.Size(381, 440);
            this.groupBoxSupplierNew.TabIndex = 1;
            this.groupBoxSupplierNew.TabStop = false;
            this.groupBoxSupplierNew.Text = "New supplier details";
            // 
            // labelSupplierProduct
            // 
            this.labelSupplierProduct.AutoSize = true;
            this.labelSupplierProduct.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSupplierProduct.ForeColor = System.Drawing.Color.Black;
            this.labelSupplierProduct.Location = new System.Drawing.Point(153, 308);
            this.labelSupplierProduct.Name = "labelSupplierProduct";
            this.labelSupplierProduct.Size = new System.Drawing.Size(92, 14);
            this.labelSupplierProduct.TabIndex = 20;
            this.labelSupplierProduct.Text = "Select Product:";
            // 
            // buttonAddSupplierToProduct
            // 
            this.buttonAddSupplierToProduct.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddSupplierToProduct.Appearance.Options.UseFont = true;
            this.buttonAddSupplierToProduct.Location = new System.Drawing.Point(136, 361);
            this.buttonAddSupplierToProduct.Name = "buttonAddSupplierToProduct";
            this.buttonAddSupplierToProduct.Size = new System.Drawing.Size(127, 44);
            this.buttonAddSupplierToProduct.TabIndex = 19;
            this.buttonAddSupplierToProduct.Text = "Add to Product";
            this.buttonAddSupplierToProduct.Click += new System.EventHandler(this.buttonAddSupplierToProduct_Click);
            // 
            // comboBoxSelectProductToAddSupplier
            // 
            this.comboBoxSelectProductToAddSupplier.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSelectProductToAddSupplier.FormattingEnabled = true;
            this.comboBoxSelectProductToAddSupplier.Location = new System.Drawing.Point(129, 329);
            this.comboBoxSelectProductToAddSupplier.Name = "comboBoxSelectProductToAddSupplier";
            this.comboBoxSelectProductToAddSupplier.Size = new System.Drawing.Size(140, 26);
            this.comboBoxSelectProductToAddSupplier.TabIndex = 17;
            // 
            // textBoxSupplierAddress
            // 
            this.textBoxSupplierAddress.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSupplierAddress.Location = new System.Drawing.Point(99, 209);
            this.textBoxSupplierAddress.Name = "textBoxSupplierAddress";
            this.textBoxSupplierAddress.Size = new System.Drawing.Size(200, 26);
            this.textBoxSupplierAddress.TabIndex = 7;
            // 
            // labelSupplierAddress
            // 
            this.labelSupplierAddress.AutoSize = true;
            this.labelSupplierAddress.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSupplierAddress.ForeColor = System.Drawing.Color.Black;
            this.labelSupplierAddress.Location = new System.Drawing.Point(172, 190);
            this.labelSupplierAddress.Name = "labelSupplierAddress";
            this.labelSupplierAddress.Size = new System.Drawing.Size(54, 14);
            this.labelSupplierAddress.TabIndex = 6;
            this.labelSupplierAddress.Text = "Address:";
            // 
            // textBoxSupplierPhone
            // 
            this.textBoxSupplierPhone.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSupplierPhone.Location = new System.Drawing.Point(99, 109);
            this.textBoxSupplierPhone.Name = "textBoxSupplierPhone";
            this.textBoxSupplierPhone.Size = new System.Drawing.Size(200, 26);
            this.textBoxSupplierPhone.TabIndex = 5;
            // 
            // labelSupplierPhoneNumber
            // 
            this.labelSupplierPhoneNumber.AutoSize = true;
            this.labelSupplierPhoneNumber.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSupplierPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.labelSupplierPhoneNumber.Location = new System.Drawing.Point(153, 90);
            this.labelSupplierPhoneNumber.Name = "labelSupplierPhoneNumber";
            this.labelSupplierPhoneNumber.Size = new System.Drawing.Size(92, 14);
            this.labelSupplierPhoneNumber.TabIndex = 4;
            this.labelSupplierPhoneNumber.Text = "Phone number:";
            // 
            // textBoxSupplierName
            // 
            this.textBoxSupplierName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSupplierName.Location = new System.Drawing.Point(99, 159);
            this.textBoxSupplierName.Name = "textBoxSupplierName";
            this.textBoxSupplierName.Size = new System.Drawing.Size(200, 26);
            this.textBoxSupplierName.TabIndex = 3;
            // 
            // labelSupplierName
            // 
            this.labelSupplierName.AutoSize = true;
            this.labelSupplierName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSupplierName.ForeColor = System.Drawing.Color.Black;
            this.labelSupplierName.Location = new System.Drawing.Point(155, 140);
            this.labelSupplierName.Name = "labelSupplierName";
            this.labelSupplierName.Size = new System.Drawing.Size(88, 14);
            this.labelSupplierName.TabIndex = 2;
            this.labelSupplierName.Text = "Supplier name:";
            // 
            // textBoxSupplierID
            // 
            this.textBoxSupplierID.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSupplierID.Location = new System.Drawing.Point(99, 59);
            this.textBoxSupplierID.Name = "textBoxSupplierID";
            this.textBoxSupplierID.Size = new System.Drawing.Size(200, 26);
            this.textBoxSupplierID.TabIndex = 1;
            // 
            // labelSupplierID
            // 
            this.labelSupplierID.AutoSize = true;
            this.labelSupplierID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSupplierID.ForeColor = System.Drawing.Color.Black;
            this.labelSupplierID.Location = new System.Drawing.Point(164, 40);
            this.labelSupplierID.Name = "labelSupplierID";
            this.labelSupplierID.Size = new System.Drawing.Size(70, 14);
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
            this.groupBoxSupplierFind.Location = new System.Drawing.Point(400, 4);
            this.groupBoxSupplierFind.Name = "groupBoxSupplierFind";
            this.groupBoxSupplierFind.Size = new System.Drawing.Size(381, 135);
            this.groupBoxSupplierFind.TabIndex = 9;
            this.groupBoxSupplierFind.TabStop = false;
            this.groupBoxSupplierFind.Text = "Find a supplier";
            // 
            // buttonFindSupplier
            // 
            this.buttonFindSupplier.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFindSupplier.Appearance.Options.UseFont = true;
            this.buttonFindSupplier.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonFindSupplier.ImageOptions.Image")));
            this.buttonFindSupplier.Location = new System.Drawing.Point(173, 89);
            this.buttonFindSupplier.Name = "buttonFindSupplier";
            this.buttonFindSupplier.Size = new System.Drawing.Size(95, 35);
            this.buttonFindSupplier.TabIndex = 6;
            this.buttonFindSupplier.Text = "Find";
            this.buttonFindSupplier.Click += new System.EventHandler(this.buttonFindSupplier_Click);
            // 
            // textBoxSupplierIdFind
            // 
            this.textBoxSupplierIdFind.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSupplierIdFind.Location = new System.Drawing.Point(114, 57);
            this.textBoxSupplierIdFind.Name = "textBoxSupplierIdFind";
            this.textBoxSupplierIdFind.Size = new System.Drawing.Size(212, 26);
            this.textBoxSupplierIdFind.TabIndex = 5;
            // 
            // labelSupplierIDFind
            // 
            this.labelSupplierIDFind.AutoSize = true;
            this.labelSupplierIDFind.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSupplierIDFind.ForeColor = System.Drawing.Color.Black;
            this.labelSupplierIDFind.Location = new System.Drawing.Point(181, 40);
            this.labelSupplierIDFind.Name = "labelSupplierIDFind";
            this.labelSupplierIDFind.Size = new System.Drawing.Size(70, 14);
            this.labelSupplierIDFind.TabIndex = 0;
            this.labelSupplierIDFind.Text = "Supplier ID:";
            // 
            // buttonRemoveSupplier
            // 
            this.buttonRemoveSupplier.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveSupplier.Appearance.Options.UseFont = true;
            this.buttonRemoveSupplier.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveSupplier.ImageOptions.Image")));
            this.buttonRemoveSupplier.Location = new System.Drawing.Point(597, 484);
            this.buttonRemoveSupplier.Name = "buttonRemoveSupplier";
            this.buttonRemoveSupplier.Size = new System.Drawing.Size(176, 44);
            this.buttonRemoveSupplier.TabIndex = 14;
            this.buttonRemoveSupplier.Text = "Remove";
            this.buttonRemoveSupplier.Click += new System.EventHandler(this.buttonRemoveSupplier_Click);
            // 
            // buttonEditSupplier
            // 
            this.buttonEditSupplier.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEditSupplier.Appearance.Options.UseFont = true;
            this.buttonEditSupplier.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditSupplier.ImageOptions.Image")));
            this.buttonEditSupplier.Location = new System.Drawing.Point(305, 484);
            this.buttonEditSupplier.Name = "buttonEditSupplier";
            this.buttonEditSupplier.Size = new System.Drawing.Size(176, 44);
            this.buttonEditSupplier.TabIndex = 13;
            this.buttonEditSupplier.Text = "Edit";
            this.buttonEditSupplier.Click += new System.EventHandler(this.buttonEditSupplier_Click);
            // 
            // buttonAddSupplier
            // 
            this.buttonAddSupplier.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddSupplier.Appearance.Options.UseFont = true;
            this.buttonAddSupplier.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddSupplier.ImageOptions.Image")));
            this.buttonAddSupplier.Location = new System.Drawing.Point(13, 484);
            this.buttonAddSupplier.Name = "buttonAddSupplier";
            this.buttonAddSupplier.Size = new System.Drawing.Size(176, 44);
            this.buttonAddSupplier.TabIndex = 12;
            this.buttonAddSupplier.Text = "Add";
            this.buttonAddSupplier.Click += new System.EventHandler(this.buttonAddSupplier_Click);
            // 
            // labelManageSuppliersMessage
            // 
            this.labelManageSuppliersMessage.AutoSize = true;
            this.labelManageSuppliersMessage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelManageSuppliersMessage.ForeColor = System.Drawing.Color.Red;
            this.labelManageSuppliersMessage.Location = new System.Drawing.Point(12, 541);
            this.labelManageSuppliersMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelManageSuppliersMessage.Name = "labelManageSuppliersMessage";
            this.labelManageSuppliersMessage.Size = new System.Drawing.Size(49, 19);
            this.labelManageSuppliersMessage.TabIndex = 16;
            this.labelManageSuppliersMessage.Text = "****";
            this.labelManageSuppliersMessage.Visible = false;
            // 
            // DataGridViewSupplier
            // 
            this.DataGridViewSupplier.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridViewSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewSupplier.Location = new System.Drawing.Point(400, 145);
            this.DataGridViewSupplier.Name = "DataGridViewSupplier";
            this.DataGridViewSupplier.RowTemplate.Height = 25;
            this.DataGridViewSupplier.Size = new System.Drawing.Size(381, 299);
            this.DataGridViewSupplier.TabIndex = 17;
            // 
            // FormManageSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 568);
            this.Controls.Add(this.DataGridViewSupplier);
            this.Controls.Add(this.labelManageSuppliersMessage);
            this.Controls.Add(this.buttonRemoveSupplier);
            this.Controls.Add(this.buttonEditSupplier);
            this.Controls.Add(this.buttonAddSupplier);
            this.Controls.Add(this.groupBoxSupplierNew);
            this.Controls.Add(this.groupBoxSupplierFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormManageSuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Suppliers";
            this.groupBoxSupplierNew.ResumeLayout(false);
            this.groupBoxSupplierNew.PerformLayout();
            this.groupBoxSupplierFind.ResumeLayout(false);
            this.groupBoxSupplierFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSupplier)).EndInit();
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
        private Label labelSupplierProduct;
        private DataGridView DataGridViewSupplier;
    }
}