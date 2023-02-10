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
                int productPrice = Convert.ToInt32(textBoxProductPrice.Text);
                int productStock = Convert.ToInt32(textBoxStock.Text);
                string connectionString = ConfigurationManager.ConnectionStrings["test"].ConnectionString;

                _layer.InsertProduct(productId, productName, productPrice, productStock, connectionString);
                Utility.LabelMessageSuccess(labelManageProductsMessage, "Employee added!");

            }
            catch (Exception ex)
            {
                Utility.LabelMessageFailure(labelManageProductsMessage, ex.Message);
                Console.WriteLine(ex.Message);
            }
        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            Utility.LabelMessageSuccess(labelManageProductsMessage, "test edit button");
        }

        private void buttonRemoveProduct_Click(object sender, EventArgs e)
        {
            Utility.LabelMessageSuccess(labelManageProductsMessage, "test remove button");
        }

        private void buttonExitProduct_Click(object sender, EventArgs e)
        {
            Utility.LabelMessageSuccess(labelManageProductsMessage, "test exit button");
        }

        private void buttonFindProduct_Click(object sender, EventArgs e)
        {
            Utility.LabelMessageSuccess(labelManageProductsMessage, "test find button");
        }
    }
}