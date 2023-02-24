namespace WinFormsApp
{
    partial class FormManagePurchases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManagePurchases));
            this.groupBoxPurchaseNew = new System.Windows.Forms.GroupBox();
            this.labelPurchaseEmployeeName = new System.Windows.Forms.Label();
            this.comboBoxPurchaseEmployeeName = new System.Windows.Forms.ComboBox();
            this.comboBoxPurchaseCustomerName = new System.Windows.Forms.ComboBox();
            this.labelPurchaseCustomerName = new System.Windows.Forms.Label();
            this.textBoxPurchaseID = new System.Windows.Forms.TextBox();
            this.labelPurchaseID = new System.Windows.Forms.Label();
            this.groupBoxPurchaseFind = new System.Windows.Forms.GroupBox();
            this.buttonFindPurchase = new DevExpress.XtraEditors.SimpleButton();
            this.textBoxPurchaseIDFind = new System.Windows.Forms.TextBox();
            this.labelPurchaseIDFind = new System.Windows.Forms.Label();
            this.groupBoxPurchaseContents = new System.Windows.Forms.GroupBox();
            this.dataGridViewPurchase = new System.Windows.Forms.DataGridView();
            this.buttonRemovePurchasePurchase = new DevExpress.XtraEditors.SimpleButton();
            this.buttonEditPurchase = new DevExpress.XtraEditors.SimpleButton();
            this.buttonAddPurchase = new DevExpress.XtraEditors.SimpleButton();
            this.labelManagePurchasesMessage = new System.Windows.Forms.Label();
            this.buttonRemoveLinePurchase = new DevExpress.XtraEditors.SimpleButton();
            this.groupBoxPurchaseNew.SuspendLayout();
            this.groupBoxPurchaseFind.SuspendLayout();
            this.groupBoxPurchaseContents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPurchaseNew
            // 
            this.groupBoxPurchaseNew.Controls.Add(this.labelPurchaseEmployeeName);
            this.groupBoxPurchaseNew.Controls.Add(this.comboBoxPurchaseEmployeeName);
            this.groupBoxPurchaseNew.Controls.Add(this.comboBoxPurchaseCustomerName);
            this.groupBoxPurchaseNew.Controls.Add(this.labelPurchaseCustomerName);
            this.groupBoxPurchaseNew.Controls.Add(this.textBoxPurchaseID);
            this.groupBoxPurchaseNew.Controls.Add(this.labelPurchaseID);
            this.groupBoxPurchaseNew.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxPurchaseNew.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBoxPurchaseNew.Location = new System.Drawing.Point(13, 4);
            this.groupBoxPurchaseNew.Name = "groupBoxPurchaseNew";
            this.groupBoxPurchaseNew.Size = new System.Drawing.Size(381, 188);
            this.groupBoxPurchaseNew.TabIndex = 3;
            this.groupBoxPurchaseNew.TabStop = false;
            this.groupBoxPurchaseNew.Text = "New purchase details";
            // 
            // labelPurchaseEmployeeName
            // 
            this.labelPurchaseEmployeeName.AutoSize = true;
            this.labelPurchaseEmployeeName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPurchaseEmployeeName.ForeColor = System.Drawing.Color.Black;
            this.labelPurchaseEmployeeName.Location = new System.Drawing.Point(148, 121);
            this.labelPurchaseEmployeeName.Name = "labelPurchaseEmployeeName";
            this.labelPurchaseEmployeeName.Size = new System.Drawing.Size(98, 14);
            this.labelPurchaseEmployeeName.TabIndex = 8;
            this.labelPurchaseEmployeeName.Text = "Employee name:";
            // 
            // comboBoxPurchaseEmployeeName
            // 
            this.comboBoxPurchaseEmployeeName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxPurchaseEmployeeName.FormattingEnabled = true;
            this.comboBoxPurchaseEmployeeName.Location = new System.Drawing.Point(98, 138);
            this.comboBoxPurchaseEmployeeName.Name = "comboBoxPurchaseEmployeeName";
            this.comboBoxPurchaseEmployeeName.Size = new System.Drawing.Size(204, 25);
            this.comboBoxPurchaseEmployeeName.TabIndex = 7;
            // 
            // comboBoxPurchaseCustomerName
            // 
            this.comboBoxPurchaseCustomerName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxPurchaseCustomerName.FormattingEnabled = true;
            this.comboBoxPurchaseCustomerName.Location = new System.Drawing.Point(98, 94);
            this.comboBoxPurchaseCustomerName.Name = "comboBoxPurchaseCustomerName";
            this.comboBoxPurchaseCustomerName.Size = new System.Drawing.Size(204, 25);
            this.comboBoxPurchaseCustomerName.TabIndex = 6;
            // 
            // labelPurchaseCustomerName
            // 
            this.labelPurchaseCustomerName.AutoSize = true;
            this.labelPurchaseCustomerName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPurchaseCustomerName.ForeColor = System.Drawing.Color.Black;
            this.labelPurchaseCustomerName.Location = new System.Drawing.Point(148, 77);
            this.labelPurchaseCustomerName.Name = "labelPurchaseCustomerName";
            this.labelPurchaseCustomerName.Size = new System.Drawing.Size(97, 14);
            this.labelPurchaseCustomerName.TabIndex = 2;
            this.labelPurchaseCustomerName.Text = "Customer name:";
            // 
            // textBoxPurchaseID
            // 
            this.textBoxPurchaseID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPurchaseID.Location = new System.Drawing.Point(98, 51);
            this.textBoxPurchaseID.Name = "textBoxPurchaseID";
            this.textBoxPurchaseID.Size = new System.Drawing.Size(204, 24);
            this.textBoxPurchaseID.TabIndex = 1;
            // 
            // labelPurchaseID
            // 
            this.labelPurchaseID.AutoSize = true;
            this.labelPurchaseID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPurchaseID.ForeColor = System.Drawing.Color.Black;
            this.labelPurchaseID.Location = new System.Drawing.Point(159, 34);
            this.labelPurchaseID.Name = "labelPurchaseID";
            this.labelPurchaseID.Size = new System.Drawing.Size(76, 14);
            this.labelPurchaseID.TabIndex = 0;
            this.labelPurchaseID.Text = "Purchase ID:";
            // 
            // groupBoxPurchaseFind
            // 
            this.groupBoxPurchaseFind.Controls.Add(this.buttonFindPurchase);
            this.groupBoxPurchaseFind.Controls.Add(this.textBoxPurchaseIDFind);
            this.groupBoxPurchaseFind.Controls.Add(this.labelPurchaseIDFind);
            this.groupBoxPurchaseFind.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxPurchaseFind.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBoxPurchaseFind.Location = new System.Drawing.Point(400, 4);
            this.groupBoxPurchaseFind.Name = "groupBoxPurchaseFind";
            this.groupBoxPurchaseFind.Size = new System.Drawing.Size(381, 188);
            this.groupBoxPurchaseFind.TabIndex = 11;
            this.groupBoxPurchaseFind.TabStop = false;
            this.groupBoxPurchaseFind.Text = "Find by Purchase ID";
            // 
            // buttonFindPurchase
            // 
            this.buttonFindPurchase.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFindPurchase.Appearance.Options.UseFont = true;
            this.buttonFindPurchase.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonFindPurchase.ImageOptions.Image")));
            this.buttonFindPurchase.Location = new System.Drawing.Point(227, 76);
            this.buttonFindPurchase.Name = "buttonFindPurchase";
            this.buttonFindPurchase.Size = new System.Drawing.Size(95, 44);
            this.buttonFindPurchase.TabIndex = 6;
            this.buttonFindPurchase.Text = "Find";
            this.buttonFindPurchase.Click += new System.EventHandler(this.buttonFindPurchase_Click);
            // 
            // textBoxPurchaseIDFind
            // 
            this.textBoxPurchaseIDFind.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPurchaseIDFind.Location = new System.Drawing.Point(83, 102);
            this.textBoxPurchaseIDFind.Name = "textBoxPurchaseIDFind";
            this.textBoxPurchaseIDFind.Size = new System.Drawing.Size(110, 24);
            this.textBoxPurchaseIDFind.TabIndex = 5;
            // 
            // labelPurchaseIDFind
            // 
            this.labelPurchaseIDFind.AutoSize = true;
            this.labelPurchaseIDFind.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPurchaseIDFind.ForeColor = System.Drawing.Color.Black;
            this.labelPurchaseIDFind.Location = new System.Drawing.Point(87, 68);
            this.labelPurchaseIDFind.Name = "labelPurchaseIDFind";
            this.labelPurchaseIDFind.Size = new System.Drawing.Size(103, 42);
            this.labelPurchaseIDFind.TabIndex = 0;
            this.labelPurchaseIDFind.Text = "Select an existing\r\nPurchase ID:\r\n\r\n";
            this.labelPurchaseIDFind.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBoxPurchaseContents
            // 
            this.groupBoxPurchaseContents.Controls.Add(this.dataGridViewPurchase);
            this.groupBoxPurchaseContents.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxPurchaseContents.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBoxPurchaseContents.Location = new System.Drawing.Point(9, 198);
            this.groupBoxPurchaseContents.Name = "groupBoxPurchaseContents";
            this.groupBoxPurchaseContents.Size = new System.Drawing.Size(775, 280);
            this.groupBoxPurchaseContents.TabIndex = 12;
            this.groupBoxPurchaseContents.TabStop = false;
            this.groupBoxPurchaseContents.Text = "Purchase table";
            // 
            // dataGridViewPurchase
            // 
            this.dataGridViewPurchase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPurchase.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPurchase.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPurchase.Location = new System.Drawing.Point(6, 25);
            this.dataGridViewPurchase.Name = "dataGridViewPurchase";
            this.dataGridViewPurchase.ReadOnly = true;
            this.dataGridViewPurchase.RowHeadersWidth = 51;
            this.dataGridViewPurchase.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewPurchase.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridViewPurchase.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            this.dataGridViewPurchase.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridViewPurchase.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue;
            this.dataGridViewPurchase.RowTemplate.Height = 25;
            this.dataGridViewPurchase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPurchase.Size = new System.Drawing.Size(763, 248);
            this.dataGridViewPurchase.TabIndex = 0;
            this.dataGridViewPurchase.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPurchase_CellContentClick);
            // 
            // buttonRemovePurchasePurchase
            // 
            this.buttonRemovePurchasePurchase.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRemovePurchasePurchase.Appearance.Options.UseFont = true;
            this.buttonRemovePurchasePurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemovePurchasePurchase.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemovePurchasePurchase.ImageOptions.Image")));
            this.buttonRemovePurchasePurchase.Location = new System.Drawing.Point(627, 484);
            this.buttonRemovePurchasePurchase.Name = "buttonRemovePurchasePurchase";
            this.buttonRemovePurchasePurchase.Size = new System.Drawing.Size(149, 44);
            this.buttonRemovePurchasePurchase.TabIndex = 22;
            this.buttonRemovePurchasePurchase.Text = "Remove Purchase";
            this.buttonRemovePurchasePurchase.Click += new System.EventHandler(this.buttonRemovePurchasePurchase_Click);
            // 
            // buttonEditPurchase
            // 
            this.buttonEditPurchase.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEditPurchase.Appearance.Options.UseFont = true;
            this.buttonEditPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditPurchase.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditPurchase.ImageOptions.Image")));
            this.buttonEditPurchase.Location = new System.Drawing.Point(218, 484);
            this.buttonEditPurchase.Name = "buttonEditPurchase";
            this.buttonEditPurchase.Size = new System.Drawing.Size(149, 44);
            this.buttonEditPurchase.TabIndex = 21;
            this.buttonEditPurchase.Text = "Edit";
            this.buttonEditPurchase.Click += new System.EventHandler(this.buttonEditPurchase_Click);
            // 
            // buttonAddPurchase
            // 
            this.buttonAddPurchase.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddPurchase.Appearance.Options.UseFont = true;
            this.buttonAddPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddPurchase.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddPurchase.ImageOptions.Image")));
            this.buttonAddPurchase.Location = new System.Drawing.Point(13, 484);
            this.buttonAddPurchase.Name = "buttonAddPurchase";
            this.buttonAddPurchase.Size = new System.Drawing.Size(149, 44);
            this.buttonAddPurchase.TabIndex = 20;
            this.buttonAddPurchase.Text = "Add";
            this.buttonAddPurchase.Click += new System.EventHandler(this.buttonAddPurchase_Click);
            // 
            // labelManagePurchasesMessage
            // 
            this.labelManagePurchasesMessage.AutoSize = true;
            this.labelManagePurchasesMessage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelManagePurchasesMessage.ForeColor = System.Drawing.Color.Red;
            this.labelManagePurchasesMessage.Location = new System.Drawing.Point(12, 541);
            this.labelManagePurchasesMessage.Name = "labelManagePurchasesMessage";
            this.labelManagePurchasesMessage.Size = new System.Drawing.Size(49, 19);
            this.labelManagePurchasesMessage.TabIndex = 24;
            this.labelManagePurchasesMessage.Text = "****";
            this.labelManagePurchasesMessage.Visible = false;
            // 
            // buttonRemoveLinePurchase
            // 
            this.buttonRemoveLinePurchase.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveLinePurchase.Appearance.Options.UseFont = true;
            this.buttonRemoveLinePurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveLinePurchase.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveLinePurchase.ImageOptions.Image")));
            this.buttonRemoveLinePurchase.Location = new System.Drawing.Point(423, 484);
            this.buttonRemoveLinePurchase.Name = "buttonRemoveLinePurchase";
            this.buttonRemoveLinePurchase.Size = new System.Drawing.Size(149, 44);
            this.buttonRemoveLinePurchase.TabIndex = 25;
            this.buttonRemoveLinePurchase.Text = "Remove Line";
            this.buttonRemoveLinePurchase.Click += new System.EventHandler(this.buttonRemoveLinePurchase_Click);
            // 
            // FormManagePurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 568);
            this.Controls.Add(this.buttonRemoveLinePurchase);
            this.Controls.Add(this.labelManagePurchasesMessage);
            this.Controls.Add(this.buttonRemovePurchasePurchase);
            this.Controls.Add(this.buttonEditPurchase);
            this.Controls.Add(this.buttonAddPurchase);
            this.Controls.Add(this.groupBoxPurchaseContents);
            this.Controls.Add(this.groupBoxPurchaseFind);
            this.Controls.Add(this.groupBoxPurchaseNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormManagePurchases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Purchases";
            this.groupBoxPurchaseNew.ResumeLayout(false);
            this.groupBoxPurchaseNew.PerformLayout();
            this.groupBoxPurchaseFind.ResumeLayout(false);
            this.groupBoxPurchaseFind.PerformLayout();
            this.groupBoxPurchaseContents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBoxPurchaseNew;
        private ComboBox comboBoxPurchaseEmployeeName;
        private ComboBox comboBoxPurchaseCustomerName;
        private Label labelPurchaseCustomerName;
        private TextBox textBoxPurchaseID;
        private Label labelPurchaseID;
        private Label labelPurchaseEmployeeName;
        private GroupBox groupBoxPurchaseFind;
        private DevExpress.XtraEditors.SimpleButton buttonFindPurchase;
        private TextBox textBoxPurchaseIDFind;
        private Label labelPurchaseIDFind;
        private GroupBox groupBoxPurchaseContents;
        private DevExpress.XtraEditors.SimpleButton buttonRemovePurchasePurchase;
        private DevExpress.XtraEditors.SimpleButton buttonEditPurchase;
        private DevExpress.XtraEditors.SimpleButton buttonAddPurchase;
        private Label labelManagePurchasesMessage;
        private DevExpress.XtraEditors.SimpleButton buttonRemoveLinePurchase;
        private DataGridView dataGridViewPurchase;
    }
}