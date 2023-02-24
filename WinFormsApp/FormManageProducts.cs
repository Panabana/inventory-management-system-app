using DevExpress.CodeParser;
using DevExpress.Pdf.Native.BouncyCastle.Ocsp;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Layout.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class FormManageProducts : DevExpress.XtraEditors.XtraForm
    {
        private readonly DataAccessLayer _layer;
        public FormManageProducts()
        {
            _layer = new();
            InitializeComponent();
            this.PopulatePurchaseComboBox();
            this.PopulateProductGridview();
        }

        private void PopulateProductGridview()
        {
            DataSet ds = _layer.PopulateProductGridView();
            DataTable dt = ds.Tables[0];
            DataGridViewProduct.DataSource = dt;

        }

        private void PopulatePurchaseComboBox() //med hjälp av ChatGPT
        {
            DataSet ds = _layer.ReadPurchase();
            DataTable dt = ds.Tables[0];
            
            comboBoxSelectPurchaseToAddProduct.DataSource = dt;
            comboBoxSelectPurchaseToAddProduct.DisplayMember = "PurchaseID"; 
            comboBoxSelectPurchaseToAddProduct.ValueMember = "PurchaseID";
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxProductID.Text))
                {
                    Utility.LabelMessageFailure(labelManageProductsMessage, "Please enter a valid ID!");
                    return;
                }
                if (string.IsNullOrEmpty(textBoxProductName.Text))
                {
                    Utility.LabelMessageFailure(labelManageProductsMessage, "Please enter a product name!");
                    return;
                }
                if (string.IsNullOrEmpty(textBoxProductPrice.Text))
                {
                    Utility.LabelMessageFailure(labelManageProductsMessage, "Please enter a price for the product!");
                    return;
                }

                int productId = Convert.ToInt32(textBoxProductID.Text);
                string productName = textBoxProductName.Text;
                int productPrice = Convert.ToInt32(textBoxProductPrice.Text);
                string connectionString = ConfigurationManager.ConnectionStrings["test"].ConnectionString;


                _layer.AddProduct(productId, productName, productPrice);
                Utility.LabelMessageSuccess(labelManageProductsMessage, "Product added!");
                Utility.ClearTextBoxes(this);

            }
            catch (FormatException)
            {
                Utility.LabelMessageFailure(labelManageProductsMessage, "Please enter the fields in the correct format");
            }

            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    Utility.LabelMessageFailure(labelManageProductsMessage, "A product with this ID already exists");
                }
            }
        
            catch (Exception ex)
            {
                Utility.LabelMessageFailure(labelManageProductsMessage, "Error: " + ex.Message);
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(textBoxProductID.Text))
                {
                    Utility.LabelMessageFailure(labelManageProductsMessage, "Choose a product ID to edit!");
                    return;
                }
                if (string.IsNullOrEmpty(textBoxProductName.Text))
                {
                    Utility.LabelMessageFailure(labelManageProductsMessage, "Please enter an edited or unedited name!");
                    return;
                }
                if (string.IsNullOrEmpty(textBoxProductPrice.Text))
                {
                    Utility.LabelMessageFailure(labelManageProductsMessage, "Please enter an edited or unedited product price");
                    return;
                }

                int productID = Convert.ToInt32(textBoxProductID.Text);
                string productName = textBoxProductName.Text;
                int price = Convert.ToInt32(textBoxProductPrice.Text);
                string connectionString = ConfigurationManager.ConnectionStrings["test"].ConnectionString;

                _layer.UpdateProduct(productID, productName, price);
                Utility.LabelMessageSuccess(labelManageProductsMessage, "Product edited!");
                Utility.ClearTextBoxes(this);
            }

            catch (FormatException)
            {
                Utility.LabelMessageFailure(labelManageProductsMessage, "Please enter the fields in the correct format");
            }
        

            catch (Exception ex)
            {
                Utility.LabelMessageFailure(labelManageProductsMessage, ex.Message);
            }

        }

        private void buttonRemoveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = Convert.ToInt32(textBoxProductID.Text);
                string connectionString = ConfigurationManager.ConnectionStrings["test"].ConnectionString;


                _layer.DeleteProduct(productId);
                Utility.LabelMessageSuccess(labelManageProductsMessage, "Product deleted!");
                Utility.ClearTextBoxes(this);

            }
            catch (Exception ex)
            {
                Utility.LabelMessageFailure(labelManageProductsMessage, "Error: " + ex.Message);
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void buttonFindProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int productID = Convert.ToInt32(textBoxProductIDFind.Text);
                string connectionString = ConfigurationManager.ConnectionStrings["test"].ConnectionString;

                DataTable findProductDataTable = new();
                findProductDataTable = _layer.FindProduct(productID, connectionString);

                DataSet ds = _layer.PopulateProductGridViewFind(productID);
                DataTable dt = ds.Tables[0];
                DataGridViewProduct.DataSource = dt;

                if (findProductDataTable.Rows.Count == 1)
                {
                    textBoxProductID.Text = findProductDataTable.Rows[0]["ProductID"].ToString();
                    textBoxProductName.Text = findProductDataTable.Rows[0]["ProductName"].ToString();
                    textBoxProductPrice.Text = findProductDataTable.Rows[0]["Price"].ToString();

                    Utility.LabelMessageSuccess(labelManageProductsMessage, "Product found!");
                }
                else
                {
                    Utility.LabelMessageFailure(labelManageProductsMessage, "Product not found!");
                }
            }

            catch (NullReferenceException ex)
            {
                Utility.LabelMessageFailure(labelManageProductsMessage, "Please enter an ID number!");
            }

            catch (FormatException)
            {
                Utility.LabelMessageFailure(labelManageProductsMessage, "Please enter a Product ID to search for!");
            }
        }
        
        private void buttonAddProductToPurchase_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(comboBoxSelectPurchaseToAddProduct.Text))
                {
                    Utility.LabelMessageFailure(labelManageProductsMessage, "Please select a purchase ID!");
                    return;
                }
                if (string.IsNullOrEmpty(textBoxProductID.Text))
                {
                    Utility.LabelMessageFailure(labelManageProductsMessage, "Please enter a product ID!");
                    return;
                }
                if (string.IsNullOrEmpty(textBoxQuantity.Text))
                {
                    Utility.LabelMessageFailure(labelManageProductsMessage, "Please enter the amount of this product!");
                    return;
                }
                int purchaseId = Convert.ToInt32(comboBoxSelectPurchaseToAddProduct.Text);
                int productId = Convert.ToInt32(textBoxProductID.Text);
                int quantity = Convert.ToInt32(textBoxQuantity.Text);

                _layer.InsertProductPurchase(purchaseId, productId, quantity);
                Utility.ClearTextBoxes(this);

                Utility.LabelMessageSuccess(labelManageProductsMessage, "Product added to purchase!");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    Utility.LabelMessageFailure(labelManageProductsMessage, "This product is already in this purchase!");
                }
                if (ex.Number == 547)
                {
                    Utility.LabelMessageFailure(labelManageProductsMessage, "The quantity amount cannot exceed 5");
                }
            }
            catch (FormatException)
            {
                    Utility.LabelMessageFailure(labelManageProductsMessage, "Please insert the quantity in the correct format!");
            }
            catch (Exception ex)
            {
                Utility.LabelMessageFailure(labelManageProductsMessage, "Unknown error:" + ex.Message);
            }
        }
    }
}