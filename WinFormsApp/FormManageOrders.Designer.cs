namespace WinFormsApp
{
    partial class FormManageOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageOrders));
            this.groupBoxOrderNew = new System.Windows.Forms.GroupBox();
            this.labelOrderEmployeeName = new System.Windows.Forms.Label();
            this.comboBoxOrderEmployeeName = new System.Windows.Forms.ComboBox();
            this.comboBoxOrderCustomerName = new System.Windows.Forms.ComboBox();
            this.labelOrderCustomerName = new System.Windows.Forms.Label();
            this.textBoxOrderID = new System.Windows.Forms.TextBox();
            this.labelOrderID = new System.Windows.Forms.Label();
            this.groupBoxOrderFind = new System.Windows.Forms.GroupBox();
            this.buttonFindOrder = new DevExpress.XtraEditors.SimpleButton();
            this.textBoxOrderIDFind = new System.Windows.Forms.TextBox();
            this.labelOrderIDFind = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.buttonExitOrder = new DevExpress.XtraEditors.SimpleButton();
            this.buttonRemoveOrderOrder = new DevExpress.XtraEditors.SimpleButton();
            this.buttonEditOrder = new DevExpress.XtraEditors.SimpleButton();
            this.buttonAddOrder = new DevExpress.XtraEditors.SimpleButton();
            this.labelManageOrdersMessage = new System.Windows.Forms.Label();
            this.buttonRemoveLineOrder = new DevExpress.XtraEditors.SimpleButton();
            this.groupBoxOrderNew.SuspendLayout();
            this.groupBoxOrderFind.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOrderNew
            // 
            this.groupBoxOrderNew.Controls.Add(this.labelOrderEmployeeName);
            this.groupBoxOrderNew.Controls.Add(this.comboBoxOrderEmployeeName);
            this.groupBoxOrderNew.Controls.Add(this.comboBoxOrderCustomerName);
            this.groupBoxOrderNew.Controls.Add(this.labelOrderCustomerName);
            this.groupBoxOrderNew.Controls.Add(this.textBoxOrderID);
            this.groupBoxOrderNew.Controls.Add(this.labelOrderID);
            this.groupBoxOrderNew.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxOrderNew.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBoxOrderNew.Location = new System.Drawing.Point(14, 15);
            this.groupBoxOrderNew.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxOrderNew.Name = "groupBoxOrderNew";
            this.groupBoxOrderNew.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxOrderNew.Size = new System.Drawing.Size(904, 111);
            this.groupBoxOrderNew.TabIndex = 3;
            this.groupBoxOrderNew.TabStop = false;
            this.groupBoxOrderNew.Text = "New order details";
            // 
            // labelOrderEmployeeName
            // 
            this.labelOrderEmployeeName.AutoSize = true;
            this.labelOrderEmployeeName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOrderEmployeeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelOrderEmployeeName.Location = new System.Drawing.Point(590, 49);
            this.labelOrderEmployeeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrderEmployeeName.Name = "labelOrderEmployeeName";
            this.labelOrderEmployeeName.Size = new System.Drawing.Size(129, 18);
            this.labelOrderEmployeeName.TabIndex = 8;
            this.labelOrderEmployeeName.Text = "Employee name:";
            // 
            // comboBoxOrderEmployeeName
            // 
            this.comboBoxOrderEmployeeName.FormattingEnabled = true;
            this.comboBoxOrderEmployeeName.Location = new System.Drawing.Point(721, 42);
            this.comboBoxOrderEmployeeName.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxOrderEmployeeName.Name = "comboBoxOrderEmployeeName";
            this.comboBoxOrderEmployeeName.Size = new System.Drawing.Size(163, 31);
            this.comboBoxOrderEmployeeName.TabIndex = 7;
            // 
            // comboBoxOrderCustomerName
            // 
            this.comboBoxOrderCustomerName.FormattingEnabled = true;
            this.comboBoxOrderCustomerName.Location = new System.Drawing.Point(404, 42);
            this.comboBoxOrderCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxOrderCustomerName.Name = "comboBoxOrderCustomerName";
            this.comboBoxOrderCustomerName.Size = new System.Drawing.Size(163, 31);
            this.comboBoxOrderCustomerName.TabIndex = 6;
            // 
            // labelOrderCustomerName
            // 
            this.labelOrderCustomerName.AutoSize = true;
            this.labelOrderCustomerName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOrderCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelOrderCustomerName.Location = new System.Drawing.Point(272, 49);
            this.labelOrderCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrderCustomerName.Name = "labelOrderCustomerName";
            this.labelOrderCustomerName.Size = new System.Drawing.Size(128, 18);
            this.labelOrderCustomerName.TabIndex = 2;
            this.labelOrderCustomerName.Text = "Customer name:";
            // 
            // textBoxOrderID
            // 
            this.textBoxOrderID.Location = new System.Drawing.Point(93, 42);
            this.textBoxOrderID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOrderID.Name = "textBoxOrderID";
            this.textBoxOrderID.Size = new System.Drawing.Size(163, 30);
            this.textBoxOrderID.TabIndex = 1;
            // 
            // labelOrderID
            // 
            this.labelOrderID.AutoSize = true;
            this.labelOrderID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOrderID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelOrderID.Location = new System.Drawing.Point(13, 49);
            this.labelOrderID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrderID.Name = "labelOrderID";
            this.labelOrderID.Size = new System.Drawing.Size(79, 18);
            this.labelOrderID.TabIndex = 0;
            this.labelOrderID.Text = "Order ID:";
            // 
            // groupBoxOrderFind
            // 
            this.groupBoxOrderFind.Controls.Add(this.buttonFindOrder);
            this.groupBoxOrderFind.Controls.Add(this.textBoxOrderIDFind);
            this.groupBoxOrderFind.Controls.Add(this.labelOrderIDFind);
            this.groupBoxOrderFind.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxOrderFind.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBoxOrderFind.Location = new System.Drawing.Point(14, 143);
            this.groupBoxOrderFind.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxOrderFind.Name = "groupBoxOrderFind";
            this.groupBoxOrderFind.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxOrderFind.Size = new System.Drawing.Size(904, 111);
            this.groupBoxOrderFind.TabIndex = 11;
            this.groupBoxOrderFind.TabStop = false;
            this.groupBoxOrderFind.Text = "Find an order";
            // 
            // buttonFindOrder
            // 
            this.buttonFindOrder.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFindOrder.Appearance.Options.UseFont = true;
            this.buttonFindOrder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonFindOrder.ImageOptions.Image")));
            this.buttonFindOrder.Location = new System.Drawing.Point(564, 43);
            this.buttonFindOrder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFindOrder.Name = "buttonFindOrder";
            this.buttonFindOrder.Size = new System.Drawing.Size(111, 43);
            this.buttonFindOrder.TabIndex = 6;
            this.buttonFindOrder.Text = "Find";
            // 
            // textBoxOrderIDFind
            // 
            this.textBoxOrderIDFind.Location = new System.Drawing.Point(309, 48);
            this.textBoxOrderIDFind.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOrderIDFind.Name = "textBoxOrderIDFind";
            this.textBoxOrderIDFind.Size = new System.Drawing.Size(247, 30);
            this.textBoxOrderIDFind.TabIndex = 5;
            // 
            // labelOrderIDFind
            // 
            this.labelOrderIDFind.AutoSize = true;
            this.labelOrderIDFind.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOrderIDFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelOrderIDFind.Location = new System.Drawing.Point(229, 55);
            this.labelOrderIDFind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrderIDFind.Name = "labelOrderIDFind";
            this.labelOrderIDFind.Size = new System.Drawing.Size(79, 18);
            this.labelOrderIDFind.TabIndex = 0;
            this.labelOrderIDFind.Text = "Order ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewOrder);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox3.Location = new System.Drawing.Point(14, 267);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(904, 309);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order contents";
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewOrder.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(7, 31);
            this.dataGridViewOrder.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.ReadOnly = true;
            this.dataGridViewOrder.RowHeadersWidth = 51;
            this.dataGridViewOrder.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewOrder.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridViewOrder.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            this.dataGridViewOrder.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridViewOrder.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue;
            this.dataGridViewOrder.RowTemplate.Height = 25;
            this.dataGridViewOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrder.Size = new System.Drawing.Size(890, 271);
            this.dataGridViewOrder.TabIndex = 0;
            // 
            // buttonExitOrder
            // 
            this.buttonExitOrder.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExitOrder.Appearance.Options.UseFont = true;
            this.buttonExitOrder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonExitOrder.ImageOptions.Image")));
            this.buttonExitOrder.Location = new System.Drawing.Point(734, 597);
            this.buttonExitOrder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExitOrder.Name = "buttonExitOrder";
            this.buttonExitOrder.Size = new System.Drawing.Size(164, 54);
            this.buttonExitOrder.TabIndex = 23;
            this.buttonExitOrder.Text = "Exit";
            // 
            // buttonRemoveOrderOrder
            // 
            this.buttonRemoveOrderOrder.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveOrderOrder.Appearance.Options.UseFont = true;
            this.buttonRemoveOrderOrder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveOrderOrder.ImageOptions.Image")));
            this.buttonRemoveOrderOrder.Location = new System.Drawing.Point(559, 597);
            this.buttonRemoveOrderOrder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoveOrderOrder.Name = "buttonRemoveOrderOrder";
            this.buttonRemoveOrderOrder.Size = new System.Drawing.Size(164, 54);
            this.buttonRemoveOrderOrder.TabIndex = 22;
            this.buttonRemoveOrderOrder.Text = "Remove Order";
            // 
            // buttonEditOrder
            // 
            this.buttonEditOrder.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEditOrder.Appearance.Options.UseFont = true;
            this.buttonEditOrder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditOrder.ImageOptions.Image")));
            this.buttonEditOrder.Location = new System.Drawing.Point(209, 597);
            this.buttonEditOrder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditOrder.Name = "buttonEditOrder";
            this.buttonEditOrder.Size = new System.Drawing.Size(164, 54);
            this.buttonEditOrder.TabIndex = 21;
            this.buttonEditOrder.Text = "Edit";
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddOrder.Appearance.Options.UseFont = true;
            this.buttonAddOrder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddOrder.ImageOptions.Image")));
            this.buttonAddOrder.Location = new System.Drawing.Point(34, 597);
            this.buttonAddOrder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(164, 54);
            this.buttonAddOrder.TabIndex = 20;
            this.buttonAddOrder.Text = "Add";
            // 
            // labelManageOrdersMessage
            // 
            this.labelManageOrdersMessage.AutoSize = true;
            this.labelManageOrdersMessage.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelManageOrdersMessage.ForeColor = System.Drawing.Color.Red;
            this.labelManageOrdersMessage.Location = new System.Drawing.Point(451, 668);
            this.labelManageOrdersMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelManageOrdersMessage.Name = "labelManageOrdersMessage";
            this.labelManageOrdersMessage.Size = new System.Drawing.Size(58, 23);
            this.labelManageOrdersMessage.TabIndex = 24;
            this.labelManageOrdersMessage.Text = "****";
            // 
            // buttonRemoveLineOrder
            // 
            this.buttonRemoveLineOrder.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveLineOrder.Appearance.Options.UseFont = true;
            this.buttonRemoveLineOrder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveLineOrder.ImageOptions.Image")));
            this.buttonRemoveLineOrder.Location = new System.Drawing.Point(384, 597);
            this.buttonRemoveLineOrder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoveLineOrder.Name = "buttonRemoveLineOrder";
            this.buttonRemoveLineOrder.Size = new System.Drawing.Size(164, 54);
            this.buttonRemoveLineOrder.TabIndex = 25;
            this.buttonRemoveLineOrder.Text = "Remove Line";
            // 
            // FormManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 699);
            this.Controls.Add(this.buttonRemoveLineOrder);
            this.Controls.Add(this.labelManageOrdersMessage);
            this.Controls.Add(this.buttonExitOrder);
            this.Controls.Add(this.buttonRemoveOrderOrder);
            this.Controls.Add(this.buttonEditOrder);
            this.Controls.Add(this.buttonAddOrder);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxOrderFind);
            this.Controls.Add(this.groupBoxOrderNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormManageOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Orders";
            this.groupBoxOrderNew.ResumeLayout(false);
            this.groupBoxOrderNew.PerformLayout();
            this.groupBoxOrderFind.ResumeLayout(false);
            this.groupBoxOrderFind.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBoxOrderNew;
        private ComboBox comboBoxOrderEmployeeName;
        private ComboBox comboBoxOrderCustomerName;
        private Label labelOrderCustomerName;
        private TextBox textBoxOrderID;
        private Label labelOrderID;
        private Label labelOrderEmployeeName;
        private GroupBox groupBoxOrderFind;
        private DevExpress.XtraEditors.SimpleButton buttonFindOrder;
        private TextBox textBoxOrderIDFind;
        private Label labelOrderIDFind;
        private GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton buttonExitOrder;
        private DevExpress.XtraEditors.SimpleButton buttonRemoveOrderOrder;
        private DevExpress.XtraEditors.SimpleButton buttonEditOrder;
        private DevExpress.XtraEditors.SimpleButton buttonAddOrder;
        private Label labelManageOrdersMessage;
        private DevExpress.XtraEditors.SimpleButton buttonRemoveLineOrder;
        private DataGridView dataGridViewOrder;
    }
}