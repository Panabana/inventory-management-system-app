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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.buttonAddProductToPurchase = new System.Windows.Forms.Button();
            this.comboBoxSelectPurchaseToAddProduct = new System.Windows.Forms.ComboBox();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.labelProductPrice = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.textBoxProductID = new System.Windows.Forms.TextBox();
            this.labelProductID = new System.Windows.Forms.Label();
            this.buttonRemoveProduct = new DevExpress.XtraEditors.SimpleButton();
            this.buttonEditProduct = new DevExpress.XtraEditors.SimpleButton();
            this.buttonAddProduct = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonFindProduct = new DevExpress.XtraEditors.SimpleButton();
            this.textBoxProductIDFind = new System.Windows.Forms.TextBox();
            this.labelProductIDFind = new System.Windows.Forms.Label();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.labelManageProductsMessage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxQuantity);
            this.groupBox1.Controls.Add(this.buttonAddProductToPurchase);
            this.groupBox1.Controls.Add(this.comboBoxSelectPurchaseToAddProduct);
            this.groupBox1.Controls.Add(this.textBoxProductPrice);
            this.groupBox1.Controls.Add(this.labelProductPrice);
            this.groupBox1.Controls.Add(this.textBoxProductName);
            this.groupBox1.Controls.Add(this.labelProductName);
            this.groupBox1.Controls.Add(this.textBoxProductID);
            this.groupBox1.Controls.Add(this.labelProductID);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(10, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(445, 541);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New product details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(198, 376);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Quantity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(175, 307);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Select Purchase:";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxQuantity.Location = new System.Drawing.Point(174, 404);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(116, 30);
            this.textBoxQuantity.TabIndex = 15;
            // 
            // buttonAddProductToPurchase
            // 
            this.buttonAddProductToPurchase.BackColor = System.Drawing.Color.White;
            this.buttonAddProductToPurchase.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddProductToPurchase.ForeColor = System.Drawing.Color.Black;
            this.buttonAddProductToPurchase.Location = new System.Drawing.Point(158, 444);
            this.buttonAddProductToPurchase.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddProductToPurchase.Name = "buttonAddProductToPurchase";
            this.buttonAddProductToPurchase.Size = new System.Drawing.Size(148, 54);
            this.buttonAddProductToPurchase.TabIndex = 13;
            this.buttonAddProductToPurchase.Text = "Add to Purchase";
            this.buttonAddProductToPurchase.UseVisualStyleBackColor = false;
            this.buttonAddProductToPurchase.Click += new System.EventHandler(this.buttonAddProductToPurchase_Click_1);
            // 
            // comboBoxSelectPurchaseToAddProduct
            // 
            this.comboBoxSelectPurchaseToAddProduct.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSelectPurchaseToAddProduct.FormattingEnabled = true;
            this.comboBoxSelectPurchaseToAddProduct.Location = new System.Drawing.Point(151, 335);
            this.comboBoxSelectPurchaseToAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSelectPurchaseToAddProduct.Name = "comboBoxSelectPurchaseToAddProduct";
            this.comboBoxSelectPurchaseToAddProduct.Size = new System.Drawing.Size(163, 31);
            this.comboBoxSelectPurchaseToAddProduct.TabIndex = 14;
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxProductPrice.Location = new System.Drawing.Point(116, 136);
            this.textBoxProductPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(233, 30);
            this.textBoxProductPrice.TabIndex = 7;
            // 
            // labelProductPrice
            // 
            this.labelProductPrice.AutoSize = true;
            this.labelProductPrice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProductPrice.ForeColor = System.Drawing.Color.Black;
            this.labelProductPrice.Location = new System.Drawing.Point(211, 111);
            this.labelProductPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductPrice.Name = "labelProductPrice";
            this.labelProductPrice.Size = new System.Drawing.Size(43, 18);
            this.labelProductPrice.TabIndex = 6;
            this.labelProductPrice.Text = "Price:";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxProductName.Location = new System.Drawing.Point(116, 198);
            this.textBoxProductName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(233, 30);
            this.textBoxProductName.TabIndex = 3;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProductName.ForeColor = System.Drawing.Color.Black;
            this.labelProductName.Location = new System.Drawing.Point(180, 173);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(104, 18);
            this.labelProductName.TabIndex = 2;
            this.labelProductName.Text = "Product name:";
            // 
            // textBoxProductID
            // 
            this.textBoxProductID.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxProductID.Location = new System.Drawing.Point(116, 74);
            this.textBoxProductID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProductID.Name = "textBoxProductID";
            this.textBoxProductID.Size = new System.Drawing.Size(233, 30);
            this.textBoxProductID.TabIndex = 1;
            // 
            // labelProductID
            // 
            this.labelProductID.AutoSize = true;
            this.labelProductID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProductID.ForeColor = System.Drawing.Color.Black;
            this.labelProductID.Location = new System.Drawing.Point(191, 49);
            this.labelProductID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductID.Name = "labelProductID";
            this.labelProductID.Size = new System.Drawing.Size(83, 18);
            this.labelProductID.TabIndex = 0;
            this.labelProductID.Text = "Product ID:";
            // 
            // buttonRemoveProduct
            // 
            this.buttonRemoveProduct.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveProduct.Appearance.Options.UseFont = true;
            this.buttonRemoveProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveProduct.ImageOptions.Image")));
            this.buttonRemoveProduct.Location = new System.Drawing.Point(731, 596);
            this.buttonRemoveProduct.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoveProduct.Name = "buttonRemoveProduct";
            this.buttonRemoveProduct.Size = new System.Drawing.Size(174, 54);
            this.buttonRemoveProduct.TabIndex = 10;
            this.buttonRemoveProduct.Text = "Remove";
            this.buttonRemoveProduct.Click += new System.EventHandler(this.buttonRemoveProduct_Click);
            // 
            // buttonEditProduct
            // 
            this.buttonEditProduct.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEditProduct.Appearance.Options.UseFont = true;
            this.buttonEditProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditProduct.ImageOptions.Image")));
            this.buttonEditProduct.Location = new System.Drawing.Point(373, 596);
            this.buttonEditProduct.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditProduct.Name = "buttonEditProduct";
            this.buttonEditProduct.Size = new System.Drawing.Size(174, 54);
            this.buttonEditProduct.TabIndex = 9;
            this.buttonEditProduct.Text = "Edit";
            this.buttonEditProduct.Click += new System.EventHandler(this.buttonEditProduct_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddProduct.Appearance.Options.UseFont = true;
            this.buttonAddProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddProduct.ImageOptions.Image")));
            this.buttonAddProduct.Location = new System.Drawing.Point(15, 596);
            this.buttonAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(174, 54);
            this.buttonAddProduct.TabIndex = 7;
            this.buttonAddProduct.Tag = "<Null>";
            this.buttonAddProduct.Text = "Add";
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonFindProduct);
            this.groupBox2.Controls.Add(this.textBoxProductIDFind);
            this.groupBox2.Controls.Add(this.labelProductIDFind);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox2.Location = new System.Drawing.Point(473, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(445, 541);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find by Product ID";
            // 
            // buttonFindProduct
            // 
            this.buttonFindProduct.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFindProduct.Appearance.Options.UseFont = true;
            this.buttonFindProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonFindProduct.ImageOptions.Image")));
            this.buttonFindProduct.Location = new System.Drawing.Point(197, 118);
            this.buttonFindProduct.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFindProduct.Name = "buttonFindProduct";
            this.buttonFindProduct.Size = new System.Drawing.Size(111, 43);
            this.buttonFindProduct.TabIndex = 6;
            this.buttonFindProduct.Text = "Find";
            this.buttonFindProduct.Click += new System.EventHandler(this.buttonFindProduct_Click);
            // 
            // textBoxProductIDFind
            // 
            this.textBoxProductIDFind.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxProductIDFind.Location = new System.Drawing.Point(129, 74);
            this.textBoxProductIDFind.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProductIDFind.Name = "textBoxProductIDFind";
            this.textBoxProductIDFind.Size = new System.Drawing.Size(247, 30);
            this.textBoxProductIDFind.TabIndex = 5;
            // 
            // labelProductIDFind
            // 
            this.labelProductIDFind.AutoSize = true;
            this.labelProductIDFind.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProductIDFind.ForeColor = System.Drawing.Color.Black;
            this.labelProductIDFind.Location = new System.Drawing.Point(211, 49);
            this.labelProductIDFind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductIDFind.Name = "labelProductIDFind";
            this.labelProductIDFind.Size = new System.Drawing.Size(83, 18);
            this.labelProductIDFind.TabIndex = 0;
            this.labelProductIDFind.Text = "Product ID:";
            // 
            // labelManageProductsMessage
            // 
            this.labelManageProductsMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelManageProductsMessage.AutoSize = true;
            this.labelManageProductsMessage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelManageProductsMessage.ForeColor = System.Drawing.Color.Red;
            this.labelManageProductsMessage.Location = new System.Drawing.Point(14, 666);
            this.labelManageProductsMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelManageProductsMessage.Name = "labelManageProductsMessage";
            this.labelManageProductsMessage.Size = new System.Drawing.Size(62, 24);
            this.labelManageProductsMessage.TabIndex = 12;
            this.labelManageProductsMessage.Text = "****";
            this.labelManageProductsMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelManageProductsMessage.Visible = false;
            // 
            // FormManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 699);
            this.Controls.Add(this.labelManageProductsMessage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.buttonEditProduct);
            this.Controls.Add(this.buttonRemoveProduct);
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
        private Label labelProductPrice;
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
        private Label label2;
        private Label label1;
        private TextBox textBoxQuantity;
    }
}