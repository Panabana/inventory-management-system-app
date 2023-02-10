using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Layout.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
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
                int productId = Convert.ToInt32(textBoxProductID.Text);
                string productName = textBoxProductName.Text;
                decimal productPrice = Convert.ToDecimal(textBoxProductPrice.Text);
                int productStock = Convert.ToInt32(textBoxStock.Text);
                string connectionString = ConfigurationManager.ConnectionStrings["test"].ConnectionString;

                _layer.InsertProduct(productId, productName, productPrice, productStock, connectionString);
                Utility.LabelMessageSuccess(labelManageProductsMessage, $"Product with new ID {productId} added");
            }
            catch (Exception ex)
            {
                Utility.LabelMessageFailure(labelManageProductsMessage, "Sorry, error: " + ex.Message);
                Console.WriteLine("Sorry, error: " + ex.Message);
            }

            Utility.ClearTextBoxes(this);
        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = Convert.ToInt32(textBoxProductID.Text);
                string productName = textBoxProductName.Text;
                decimal productPrice = Convert.ToDecimal(textBoxProductPrice.Text);
                int productStock = Convert.ToInt32(textBoxStock.Text);
                string connectionString = ConfigurationManager.ConnectionStrings["test"].ConnectionString;

                _layer.UpdateProduct(productId, productName, productPrice, productStock, connectionString);
                Utility.LabelMessageSuccess(labelManageProductsMessage, $"Product with ID {productId} edited");
            }
            catch (Exception ex)
            {
                Utility.LabelMessageFailure(labelManageProductsMessage, "Sorry, error: " + ex.Message);
                Console.WriteLine("Sorry, error: " + ex.Message);
            }

            Utility.ClearTextBoxes(this);
        }

        private void buttonRemoveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = Convert.ToInt32(textBoxProductID.Text);
                string connectionString = ConfigurationManager.ConnectionStrings["test"].ConnectionString;

                _layer.DeleteProduct(productId, connectionString);
                Utility.LabelMessageSuccess(labelManageProductsMessage, $"Product with ID {productId} removed");

            }
            catch (Exception ex)
            {
                Utility.LabelMessageFailure(labelManageProductsMessage, "Sorry, error: " + ex.Message);
                Console.WriteLine("Sorry, error: " + ex.Message);
            }

            Utility.ClearTextBoxes(this);
        }
        
        private void buttonFindProduct_Click(object sender, EventArgs e)
        {
            Utility.LabelMessageSuccess(labelManageProductsMessage, "test find button");
        }
    }
}