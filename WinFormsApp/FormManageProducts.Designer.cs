namespace WinFormsApp
{
    partial class FormManageProducts
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.labelProductPrice = new System.Windows.Forms.Label();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.labelProductStock = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.textBoxProductID = new System.Windows.Forms.TextBox();
            this.labelProductID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonFindProduct = new DevExpress.XtraEditors.SimpleButton();
            this.textBoxProductIDFind = new System.Windows.Forms.TextBox();
            this.labelProductIDFind = new System.Windows.Forms.Label();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.buttonAddProduct = new DevExpress.XtraEditors.SimpleButton();
            this.buttonEditProduct = new DevExpress.XtraEditors.SimpleButton();
            this.buttonRemoveProduct = new DevExpress.XtraEditors.SimpleButton();
            this.labelManageProductsMessage = new System.Windows.Forms.Label();
            this.buttonAddProductToPurchase = new System.Windows.Forms.Button();
            this.comboBoxSelectPurchaseToAddProduct = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxProductPrice);
            this.groupBox1.Controls.Add(this.labelProductPrice);
            this.groupBox1.Controls.Add(this.textBoxStock);
            this.groupBox1.Controls.Add(this.labelProductStock);
            this.groupBox1.Controls.Add(this.textBoxProductName);
            this.groupBox1.Controls.Add(this.labelProductName);
            this.groupBox1.Controls.Add(this.textBoxProductID);
            this.groupBox1.Controls.Add(this.labelProductID);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New product details";
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.Location = new System.Drawing.Point(436, 83);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(200, 26);
            this.textBoxProductPrice.TabIndex = 7;
            // 
            // labelProductPrice
            // 
            this.labelProductPrice.AutoSize = true;
            this.labelProductPrice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelProductPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelProductPrice.Location = new System.Drawing.Point(390, 89);
            this.labelProductPrice.Name = "labelProductPrice";
            this.labelProductPrice.Size = new System.Drawing.Size(40, 14);
            this.labelProductPrice.TabIndex = 6;
            this.labelProductPrice.Text = "Price:";
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(90, 83);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(200, 26);
            this.textBoxStock.TabIndex = 5;
            // 
            // labelProductStock
            // 
            this.labelProductStock.AutoSize = true;
            this.labelProductStock.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelProductStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelProductStock.Location = new System.Drawing.Point(38, 89);
            this.labelProductStock.Name = "labelProductStock";
            this.labelProductStock.Size = new System.Drawing.Size(46, 14);
            this.labelProductStock.TabIndex = 4;
            this.labelProductStock.Text = "Stock:";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(436, 34);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(200, 26);
            this.textBoxProductName.TabIndex = 3;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelProductName.Location = new System.Drawing.Point(333, 40);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(97, 14);
            this.labelProductName.TabIndex = 2;
            this.labelProductName.Text = "Product name:";
            // 
            // textBoxProductID
            // 
            this.textBoxProductID.Location = new System.Drawing.Point(90, 34);
            this.textBoxProductID.Name = "textBoxProductID";
            this.textBoxProductID.Size = new System.Drawing.Size(200, 26);
            this.textBoxProductID.TabIndex = 1;
            // 
            // labelProductID
            // 
            this.labelProductID.AutoSize = true;
            this.labelProductID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelProductID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelProductID.Location = new System.Drawing.Point(6, 40);
            this.labelProductID.Name = "labelProductID";
            this.labelProductID.Size = new System.Drawing.Size(78, 14);
            this.labelProductID.TabIndex = 0;
            this.labelProductID.Text = "Product ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonFindProduct);
            this.groupBox2.Controls.Add(this.textBoxProductIDFind);
            this.groupBox2.Controls.Add(this.labelProductIDFind);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox2.Location = new System.Drawing.Point(15, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 93);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find a product";
            // 
            // buttonFindProduct
            // 
            this.buttonFindProduct.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFindProduct.Appearance.Options.UseFont = true;
            this.buttonFindProduct.Location = new System.Drawing.Point(440, 35);
            this.buttonFindProduct.Name = "buttonFindProduct";
            this.buttonFindProduct.Size = new System.Drawing.Size(95, 35);
            this.buttonFindProduct.TabIndex = 6;
            this.buttonFindProduct.Text = "Find";
            this.buttonFindProduct.Click += new System.EventHandler(this.buttonFindProduct_Click);
            // 
            // textBoxProductIDFind
            // 
            this.textBoxProductIDFind.Location = new System.Drawing.Point(217, 39);
            this.textBoxProductIDFind.Name = "textBoxProductIDFind";
            this.textBoxProductIDFind.Size = new System.Drawing.Size(212, 26);
            this.textBoxProductIDFind.TabIndex = 5;
            // 
            // labelProductIDFind
            // 
            this.labelProductIDFind.AutoSize = true;
            this.labelProductIDFind.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelProductIDFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelProductIDFind.Location = new System.Drawing.Point(133, 45);
            this.labelProductIDFind.Name = "labelProductIDFind";
            this.labelProductIDFind.Size = new System.Drawing.Size(78, 14);
            this.labelProductIDFind.TabIndex = 0;
            this.labelProductIDFind.Text = "Product ID:";
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddProduct.Appearance.Options.UseFont = true;
            this.buttonAddProduct.Location = new System.Drawing.Point(110, 277);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(106, 44);
            this.buttonAddProduct.TabIndex = 7;
            this.buttonAddProduct.Tag = "<Null>";
            this.buttonAddProduct.Text = "Add";
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonEditProduct
            // 
            this.buttonEditProduct.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEditProduct.Appearance.Options.UseFont = true;
            this.buttonEditProduct.Location = new System.Drawing.Point(233, 277);
            this.buttonEditProduct.Name = "buttonEditProduct";
            this.buttonEditProduct.Size = new System.Drawing.Size(106, 44);
            this.buttonEditProduct.TabIndex = 9;
            this.buttonEditProduct.Text = "Edit";
            this.buttonEditProduct.Click += new System.EventHandler(this.buttonEditProduct_Click);
            // 
            // buttonRemoveProduct
            // 
            this.buttonRemoveProduct.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveProduct.Appearance.Options.UseFont = true;
            this.buttonRemoveProduct.Location = new System.Drawing.Point(356, 277);
            this.buttonRemoveProduct.Name = "buttonRemoveProduct";
            this.buttonRemoveProduct.Size = new System.Drawing.Size(106, 44);
            this.buttonRemoveProduct.TabIndex = 10;
            this.buttonRemoveProduct.Text = "Remove";
            this.buttonRemoveProduct.Click += new System.EventHandler(this.buttonRemoveProduct_Click);
            // 
            // labelManageProductsMessage
            // 
            this.labelManageProductsMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelManageProductsMessage.AutoSize = true;
            this.labelManageProductsMessage.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelManageProductsMessage.ForeColor = System.Drawing.Color.Red;
            this.labelManageProductsMessage.Location = new System.Drawing.Point(9, 341);
            this.labelManageProductsMessage.Name = "labelManageProductsMessage";
            this.labelManageProductsMessage.Size = new System.Drawing.Size(48, 18);
            this.labelManageProductsMessage.TabIndex = 12;
            this.labelManageProductsMessage.Text = "****";
            this.labelManageProductsMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelManageProductsMessage.Visible = false;
            // 
            // buttonAddProductToPurchase
            // 
            this.buttonAddProductToPurchase.Location = new System.Drawing.Point(521, 307);
            this.buttonAddProductToPurchase.Name = "buttonAddProductToPurchase";
            this.buttonAddProductToPurchase.Size = new System.Drawing.Size(111, 34);
            this.buttonAddProductToPurchase.TabIndex = 13;
            this.buttonAddProductToPurchase.Text = "Add to Purchase";
            this.buttonAddProductToPurchase.UseVisualStyleBackColor = true;
            this.buttonAddProductToPurchase.Click += new System.EventHandler(this.buttonAddProductToPurchase_Click_1);
            // 
            // comboBoxSelectPurchaseToAddProduct
            // 
            this.comboBoxSelectPurchaseToAddProduct.FormattingEnabled = true;
            this.comboBoxSelectPurchaseToAddProduct.Location = new System.Drawing.Point(511, 264);
            this.comboBoxSelectPurchaseToAddProduct.Name = "comboBoxSelectPurchaseToAddProduct";
            this.comboBoxSelectPurchaseToAddProduct.Size = new System.Drawing.Size(140, 21);
            this.comboBoxSelectPurchaseToAddProduct.TabIndex = 14;
            // 
            // FormManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 368);
            this.Controls.Add(this.comboBoxSelectPurchaseToAddProduct);
            this.Controls.Add(this.buttonAddProductToPurchase);
            this.Controls.Add(this.labelManageProductsMessage);
            this.Controls.Add(this.buttonRemoveProduct);
            this.Controls.Add(this.buttonEditProduct);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormManageProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Products";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxProductID;
        private Label labelProductID;
        private TextBox textBoxProductName;
        private Label labelProductName;
        private TextBox textBoxProductPrice;
        private Label labelProductPrice;
        private TextBox textBoxStock;
        private Label labelProductStock;
        private GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton buttonFindProduct;
        private TextBox textBoxProductIDFind;
        private Label labelProductIDFind;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.SimpleButton buttonAddProduct;
        private DevExpress.XtraEditors.SimpleButton buttonEditProduct;
        private DevExpress.XtraEditors.SimpleButton buttonRemoveProduct;
        private Label labelManageProductsMessage;
        private Button buttonAddProductToPurchase;
        private ComboBox comboBoxSelectPurchaseToAddProduct;
    }
}