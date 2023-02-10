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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageProducts));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.labelStock = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.textBoxProductID = new System.Windows.Forms.TextBox();
            this.labelProductID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonFindProduct = new DevExpress.XtraEditors.SimpleButton();
            this.textBoxProductIDFInd = new System.Windows.Forms.TextBox();
            this.labelProductIDFind = new System.Windows.Forms.Label();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.buttonAddProduct = new DevExpress.XtraEditors.SimpleButton();
            this.buttonEditProduct = new DevExpress.XtraEditors.SimpleButton();
            this.buttonRemoveProduct = new DevExpress.XtraEditors.SimpleButton();
            this.buttonExitProduct = new DevExpress.XtraEditors.SimpleButton();
            this.labelManageProductsMessage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxProductPrice);
            this.groupBox1.Controls.Add(this.labelPrice);
            this.groupBox1.Controls.Add(this.textBoxStock);
            this.groupBox1.Controls.Add(this.labelStock);
            this.groupBox1.Controls.Add(this.textBoxProductName);
            this.groupBox1.Controls.Add(this.labelProductName);
            this.groupBox1.Controls.Add(this.textBoxProductID);
            this.groupBox1.Controls.Add(this.labelProductID);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(18, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(780, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New product details";
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.Location = new System.Drawing.Point(509, 102);
            this.textBoxProductPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(233, 30);
            this.textBoxProductPrice.TabIndex = 7;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPrice.Location = new System.Drawing.Point(455, 110);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(52, 18);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "Price:";
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(105, 102);
            this.textBoxStock.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(233, 30);
            this.textBoxStock.TabIndex = 5;
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelStock.Location = new System.Drawing.Point(44, 110);
            this.labelStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(55, 18);
            this.labelStock.TabIndex = 4;
            this.labelStock.Text = "Stock:";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(509, 42);
            this.textBoxProductName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(233, 30);
            this.textBoxProductName.TabIndex = 3;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelProductName.Location = new System.Drawing.Point(388, 49);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(115, 18);
            this.labelProductName.TabIndex = 2;
            this.labelProductName.Text = "Product name:";
            // 
            // textBoxProductID
            // 
            this.textBoxProductID.Location = new System.Drawing.Point(105, 42);
            this.textBoxProductID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProductID.Name = "textBoxProductID";
            this.textBoxProductID.Size = new System.Drawing.Size(233, 30);
            this.textBoxProductID.TabIndex = 1;
            this.textBoxProductID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelProductID
            // 
            this.labelProductID.AutoSize = true;
            this.labelProductID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelProductID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelProductID.Location = new System.Drawing.Point(7, 49);
            this.labelProductID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductID.Name = "labelProductID";
            this.labelProductID.Size = new System.Drawing.Size(93, 18);
            this.labelProductID.TabIndex = 0;
            this.labelProductID.Text = "Product ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonFindProduct);
            this.groupBox2.Controls.Add(this.textBoxProductIDFInd);
            this.groupBox2.Controls.Add(this.labelProductIDFind);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox2.Location = new System.Drawing.Point(18, 203);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(780, 114);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find a product";
            // 
            // buttonFindProduct
            // 
            this.buttonFindProduct.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFindProduct.Appearance.Options.UseFont = true;
            this.buttonFindProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonFindProduct.ImageOptions.Image")));
            this.buttonFindProduct.Location = new System.Drawing.Point(513, 43);
            this.buttonFindProduct.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFindProduct.Name = "buttonFindProduct";
            this.buttonFindProduct.Size = new System.Drawing.Size(111, 43);
            this.buttonFindProduct.TabIndex = 6;
            this.buttonFindProduct.Text = "Find";
            // 
            // textBoxProductIDFInd
            // 
            this.textBoxProductIDFInd.Location = new System.Drawing.Point(253, 48);
            this.textBoxProductIDFInd.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProductIDFInd.Name = "textBoxProductIDFInd";
            this.textBoxProductIDFInd.Size = new System.Drawing.Size(247, 30);
            this.textBoxProductIDFInd.TabIndex = 5;
            // 
            // labelProductIDFind
            // 
            this.labelProductIDFind.AutoSize = true;
            this.labelProductIDFind.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelProductIDFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelProductIDFind.Location = new System.Drawing.Point(155, 55);
            this.labelProductIDFind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductIDFind.Name = "labelProductIDFind";
            this.labelProductIDFind.Size = new System.Drawing.Size(93, 18);
            this.labelProductIDFind.TabIndex = 0;
            this.labelProductIDFind.Text = "Product ID:";
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddProduct.Appearance.Options.UseFont = true;
            this.buttonAddProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddProduct.ImageOptions.Image")));
            this.buttonAddProduct.Location = new System.Drawing.Point(128, 341);
            this.buttonAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(124, 54);
            this.buttonAddProduct.TabIndex = 7;
            this.buttonAddProduct.Tag = "<Null>";
            this.buttonAddProduct.Text = "Add";
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonEditProduct
            // 
            this.buttonEditProduct.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEditProduct.Appearance.Options.UseFont = true;
            this.buttonEditProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditProduct.ImageOptions.Image")));
            this.buttonEditProduct.Location = new System.Drawing.Point(272, 341);
            this.buttonEditProduct.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditProduct.Name = "buttonEditProduct";
            this.buttonEditProduct.Size = new System.Drawing.Size(124, 54);
            this.buttonEditProduct.TabIndex = 9;
            this.buttonEditProduct.Text = "Edit";
            this.buttonEditProduct.Click += new System.EventHandler(this.buttonEditProduct_Click);
            // 
            // buttonRemoveProduct
            // 
            this.buttonRemoveProduct.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveProduct.Appearance.Options.UseFont = true;
            this.buttonRemoveProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveProduct.ImageOptions.Image")));
            this.buttonRemoveProduct.Location = new System.Drawing.Point(415, 341);
            this.buttonRemoveProduct.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoveProduct.Name = "buttonRemoveProduct";
            this.buttonRemoveProduct.Size = new System.Drawing.Size(124, 54);
            this.buttonRemoveProduct.TabIndex = 10;
            this.buttonRemoveProduct.Text = "Remove";
            this.buttonRemoveProduct.Click += new System.EventHandler(this.buttonRemoveProduct_Click);
            // 
            // buttonExitProduct
            // 
            this.buttonExitProduct.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExitProduct.Appearance.Options.UseFont = true;
            this.buttonExitProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonExitProduct.ImageOptions.Image")));
            this.buttonExitProduct.Location = new System.Drawing.Point(562, 341);
            this.buttonExitProduct.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExitProduct.Name = "buttonExitProduct";
            this.buttonExitProduct.Size = new System.Drawing.Size(124, 54);
            this.buttonExitProduct.TabIndex = 11;
            this.buttonExitProduct.Text = "Exit";
            this.buttonExitProduct.Click += new System.EventHandler(this.buttonExitProduct_Click);
            // 
            // labelManageProductsMessage
            // 
            this.labelManageProductsMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelManageProductsMessage.AutoSize = true;
            this.labelManageProductsMessage.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelManageProductsMessage.ForeColor = System.Drawing.Color.Red;
            this.labelManageProductsMessage.Location = new System.Drawing.Point(376, 420);
            this.labelManageProductsMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelManageProductsMessage.Name = "labelManageProductsMessage";
            this.labelManageProductsMessage.Size = new System.Drawing.Size(58, 23);
            this.labelManageProductsMessage.TabIndex = 12;
            this.labelManageProductsMessage.Text = "****";
            this.labelManageProductsMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelManageProductsMessage.Visible = false;
            // 
            // FormManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 453);
            this.Controls.Add(this.labelManageProductsMessage);
            this.Controls.Add(this.buttonExitProduct);
            this.Controls.Add(this.buttonRemoveProduct);
            this.Controls.Add(this.buttonEditProduct);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private Label labelPrice;
        private TextBox textBoxStock;
        private Label labelStock;
        private GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton buttonFindProduct;
        private TextBox textBoxProductIDFInd;
        private Label labelProductIDFind;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.SimpleButton buttonAddProduct;
        private DevExpress.XtraEditors.SimpleButton buttonEditProduct;
        private DevExpress.XtraEditors.SimpleButton buttonRemoveProduct;
        private DevExpress.XtraEditors.SimpleButton buttonExitProduct;
        private Label labelManageProductsMessage;
    }
}