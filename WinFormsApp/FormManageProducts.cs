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
                if (string.IsNullOrEmpty(textBoxStock.Text))
                {
                    Utility.LabelMessageFailure(labelManageProductsMessage, "Please enter a stock amount!");
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
                int productStock = Convert.ToInt32(textBoxStock.Text);
                string connectionString = ConfigurationManager.ConnectionStrings["test"].ConnectionString;

                Utility.ClearTextBoxes(this);

                _layer.InsertProduct(productId, productName, productPrice, productStock, connectionString);
                Utility.LabelMessageSuccess(labelManageProductsMessage, "Product added!");
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
                if (string.IsNullOrEmpty(textBoxStock.Text))
                {
                    Utility.LabelMessageFailure(labelManageProductsMessage, "Please enter an edited or unedited stock amount!");
                    return;
                }
                if (string.IsNullOrEmpty(textBoxProductPrice.Text))
                {
                    Utility.LabelMessageFailure(labelManageProductsMessage, "Please enter an edited or unedited product price");
                    return;
                }

                int productID = Convert.ToInt32(textBoxProductID.Text);
                string productName = textBoxProductName.Text;
                int stock = Convert.ToInt32(textBoxStock.Text);
                int price = Convert.ToInt32(textBoxProductPrice.Text);
                string connectionString = ConfigurationManager.ConnectionStrings["test"].ConnectionString;

                _layer.UpdateProduct(productID, productName, stock, price, connectionString);
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

                Utility.ClearTextBoxes(this);

                _layer.DeleteProduct(productId, connectionString);
                Utility.LabelMessageSuccess(labelManageProductsMessage, "Product deleted!");

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

                if (findProductDataTable.Rows.Count == 1)
                {
                    textBoxProductID.Text = findProductDataTable.Rows[0]["ProductID"].ToString();
                    textBoxProductName.Text = findProductDataTable.Rows[0]["ProductName"].ToString();
                    textBoxStock.Text = findProductDataTable.Rows[0]["Stock"].ToString();
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
    }
}