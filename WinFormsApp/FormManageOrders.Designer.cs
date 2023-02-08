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
            this.labelOrderEmpName = new System.Windows.Forms.Label();
            this.comboBoxOrderEmpName = new System.Windows.Forms.ComboBox();
            this.comboBoxOrderCustName = new System.Windows.Forms.ComboBox();
            this.labelOrderCustName = new System.Windows.Forms.Label();
            this.textBoxOrderId = new System.Windows.Forms.TextBox();
            this.labelOrderID = new System.Windows.Forms.Label();
            this.groupBoxOrderFind = new System.Windows.Forms.GroupBox();
            this.buttonOrderIdFind = new DevExpress.XtraEditors.SimpleButton();
            this.textBoxOrderIdFind = new System.Windows.Forms.TextBox();
            this.labelOrderIdFind = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonExitOrder = new DevExpress.XtraEditors.SimpleButton();
            this.buttonRemoveOrder = new DevExpress.XtraEditors.SimpleButton();
            this.buttonEditOrder = new DevExpress.XtraEditors.SimpleButton();
            this.buttonAddOrder = new DevExpress.XtraEditors.SimpleButton();
            this.labelManageCustomersMessage = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.groupBoxOrderNew.SuspendLayout();
            this.groupBoxOrderFind.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOrderNew
            // 
            this.groupBoxOrderNew.Controls.Add(this.labelOrderEmpName);
            this.groupBoxOrderNew.Controls.Add(this.comboBoxOrderEmpName);
            this.groupBoxOrderNew.Controls.Add(this.comboBoxOrderCustName);
            this.groupBoxOrderNew.Controls.Add(this.labelOrderCustName);
            this.groupBoxOrderNew.Controls.Add(this.textBoxOrderId);
            this.groupBoxOrderNew.Controls.Add(this.labelOrderID);
            this.groupBoxOrderNew.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxOrderNew.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBoxOrderNew.Location = new System.Drawing.Point(12, 12);
            this.groupBoxOrderNew.Name = "groupBoxOrderNew";
            this.groupBoxOrderNew.Size = new System.Drawing.Size(775, 90);
            this.groupBoxOrderNew.TabIndex = 3;
            this.groupBoxOrderNew.TabStop = false;
            this.groupBoxOrderNew.Text = "New order details";
            // 
            // labelOrderEmpName
            // 
            this.labelOrderEmpName.AutoSize = true;
            this.labelOrderEmpName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOrderEmpName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelOrderEmpName.Location = new System.Drawing.Point(506, 40);
            this.labelOrderEmpName.Name = "labelOrderEmpName";
            this.labelOrderEmpName.Size = new System.Drawing.Size(106, 14);
            this.labelOrderEmpName.TabIndex = 8;
            this.labelOrderEmpName.Text = "Employee name:";
            // 
            // comboBoxOrderEmpName
            // 
            this.comboBoxOrderEmpName.FormattingEnabled = true;
            this.comboBoxOrderEmpName.Location = new System.Drawing.Point(618, 34);
            this.comboBoxOrderEmpName.Name = "comboBoxOrderEmpName";
            this.comboBoxOrderEmpName.Size = new System.Drawing.Size(140, 26);
            this.comboBoxOrderEmpName.TabIndex = 7;
            // 
            // comboBoxOrderCustName
            // 
            this.comboBoxOrderCustName.FormattingEnabled = true;
            this.comboBoxOrderCustName.Location = new System.Drawing.Point(346, 34);
            this.comboBoxOrderCustName.Name = "comboBoxOrderCustName";
            this.comboBoxOrderCustName.Size = new System.Drawing.Size(140, 26);
            this.comboBoxOrderCustName.TabIndex = 6;
            // 
            // labelOrderCustName
            // 
            this.labelOrderCustName.AutoSize = true;
            this.labelOrderCustName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOrderCustName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelOrderCustName.Location = new System.Drawing.Point(233, 40);
            this.labelOrderCustName.Name = "labelOrderCustName";
            this.labelOrderCustName.Size = new System.Drawing.Size(107, 14);
            this.labelOrderCustName.TabIndex = 2;
            this.labelOrderCustName.Text = "Customer name:";
            // 
            // textBoxOrderId
            // 
            this.textBoxOrderId.Location = new System.Drawing.Point(80, 34);
            this.textBoxOrderId.Name = "textBoxOrderId";
            this.textBoxOrderId.Size = new System.Drawing.Size(140, 26);
            this.textBoxOrderId.TabIndex = 1;
            // 
            // labelOrderID
            // 
            this.labelOrderID.AutoSize = true;
            this.labelOrderID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOrderID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelOrderID.Location = new System.Drawing.Point(11, 40);
            this.labelOrderID.Name = "labelOrderID";
            this.labelOrderID.Size = new System.Drawing.Size(63, 14);
            this.labelOrderID.TabIndex = 0;
            this.labelOrderID.Text = "Order ID:";
            // 
            // groupBoxOrderFind
            // 
            this.groupBoxOrderFind.Controls.Add(this.buttonOrderIdFind);
            this.groupBoxOrderFind.Controls.Add(this.textBoxOrderIdFind);
            this.groupBoxOrderFind.Controls.Add(this.labelOrderIdFind);
            this.groupBoxOrderFind.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxOrderFind.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBoxOrderFind.Location = new System.Drawing.Point(12, 116);
            this.groupBoxOrderFind.Name = "groupBoxOrderFind";
            this.groupBoxOrderFind.Size = new System.Drawing.Size(775, 90);
            this.groupBoxOrderFind.TabIndex = 11;
            this.groupBoxOrderFind.TabStop = false;
            this.groupBoxOrderFind.Text = "Find an order";
            // 
            // buttonOrderIdFind
            // 
            this.buttonOrderIdFind.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOrderIdFind.Appearance.Options.UseFont = true;
            this.buttonOrderIdFind.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonOrderIdFind.ImageOptions.Image")));
            this.buttonOrderIdFind.Location = new System.Drawing.Point(483, 35);
            this.buttonOrderIdFind.Name = "buttonOrderIdFind";
            this.buttonOrderIdFind.Size = new System.Drawing.Size(95, 35);
            this.buttonOrderIdFind.TabIndex = 6;
            this.buttonOrderIdFind.Text = "Find";
            // 
            // textBoxOrderIdFind
            // 
            this.textBoxOrderIdFind.Location = new System.Drawing.Point(265, 39);
            this.textBoxOrderIdFind.Name = "textBoxOrderIdFind";
            this.textBoxOrderIdFind.Size = new System.Drawing.Size(212, 26);
            this.textBoxOrderIdFind.TabIndex = 5;
            // 
            // labelOrderIdFind
            // 
            this.labelOrderIdFind.AutoSize = true;
            this.labelOrderIdFind.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOrderIdFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelOrderIdFind.Location = new System.Drawing.Point(196, 45);
            this.labelOrderIdFind.Name = "labelOrderIdFind";
            this.labelOrderIdFind.Size = new System.Drawing.Size(63, 14);
            this.labelOrderIdFind.TabIndex = 0;
            this.labelOrderIdFind.Text = "Order ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewOrder);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox3.Location = new System.Drawing.Point(12, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(775, 251);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order contents";
            // 
            // buttonExitOrder
            // 
            this.buttonExitOrder.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExitOrder.Appearance.Options.UseFont = true;
            this.buttonExitOrder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonExitOrder.ImageOptions.Image")));
            this.buttonExitOrder.Location = new System.Drawing.Point(629, 485);
            this.buttonExitOrder.Name = "buttonExitOrder";
            this.buttonExitOrder.Size = new System.Drawing.Size(141, 44);
            this.buttonExitOrder.TabIndex = 23;
            this.buttonExitOrder.Text = "Exit";
            // 
            // buttonRemoveOrder
            // 
            this.buttonRemoveOrder.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveOrder.Appearance.Options.UseFont = true;
            this.buttonRemoveOrder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveOrder.ImageOptions.Image")));
            this.buttonRemoveOrder.Location = new System.Drawing.Point(479, 485);
            this.buttonRemoveOrder.Name = "buttonRemoveOrder";
            this.buttonRemoveOrder.Size = new System.Drawing.Size(141, 44);
            this.buttonRemoveOrder.TabIndex = 22;
            this.buttonRemoveOrder.Text = "Remove Order";
            // 
            // buttonEditOrder
            // 
            this.buttonEditOrder.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEditOrder.Appearance.Options.UseFont = true;
            this.buttonEditOrder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditOrder.ImageOptions.Image")));
            this.buttonEditOrder.Location = new System.Drawing.Point(179, 485);
            this.buttonEditOrder.Name = "buttonEditOrder";
            this.buttonEditOrder.Size = new System.Drawing.Size(141, 44);
            this.buttonEditOrder.TabIndex = 21;
            this.buttonEditOrder.Text = "Edit";
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddOrder.Appearance.Options.UseFont = true;
            this.buttonAddOrder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddOrder.ImageOptions.Image")));
            this.buttonAddOrder.Location = new System.Drawing.Point(29, 485);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(141, 44);
            this.buttonAddOrder.TabIndex = 20;
            this.buttonAddOrder.Text = "Add";
            // 
            // labelManageCustomersMessage
            // 
            this.labelManageCustomersMessage.AutoSize = true;
            this.labelManageCustomersMessage.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelManageCustomersMessage.ForeColor = System.Drawing.Color.Red;
            this.labelManageCustomersMessage.Location = new System.Drawing.Point(387, 543);
            this.labelManageCustomersMessage.Name = "labelManageCustomersMessage";
            this.labelManageCustomersMessage.Size = new System.Drawing.Size(48, 18);
            this.labelManageCustomersMessage.TabIndex = 24;
            this.labelManageCustomersMessage.Text = "****";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(329, 485);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(141, 44);
            this.simpleButton1.TabIndex = 25;
            this.simpleButton1.Text = "Remove Line";
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewOrder.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(6, 25);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.ReadOnly = true;
            this.dataGridViewOrder.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewOrder.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridViewOrder.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            this.dataGridViewOrder.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridViewOrder.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue;
            this.dataGridViewOrder.RowTemplate.Height = 25;
            this.dataGridViewOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrder.Size = new System.Drawing.Size(763, 220);
            this.dataGridViewOrder.TabIndex = 0;
            // 
            // FormManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 568);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelManageCustomersMessage);
            this.Controls.Add(this.buttonExitOrder);
            this.Controls.Add(this.buttonRemoveOrder);
            this.Controls.Add(this.buttonEditOrder);
            this.Controls.Add(this.buttonAddOrder);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxOrderFind);
            this.Controls.Add(this.groupBoxOrderNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
        private ComboBox comboBoxOrderEmpName;
        private ComboBox comboBoxOrderCustName;
        private Label labelOrderCustName;
        private TextBox textBoxOrderId;
        private Label labelOrderID;
        private Label labelOrderEmpName;
        private GroupBox groupBoxOrderFind;
        private DevExpress.XtraEditors.SimpleButton buttonOrderIdFind;
        private TextBox textBoxOrderIdFind;
        private Label labelOrderIdFind;
        private GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton buttonExitOrder;
        private DevExpress.XtraEditors.SimpleButton buttonRemoveOrder;
        private DevExpress.XtraEditors.SimpleButton buttonEditOrder;
        private DevExpress.XtraEditors.SimpleButton buttonAddOrder;
        private Label labelManageCustomersMessage;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DataGridView dataGridViewOrder;
    }
}