using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Layout.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            labelManageProductsMessage.Text = "test add button";
            labelManageProductsMessage.Visible = true;
        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemoveProduct_Click(object sender, EventArgs e)
        {

        }

        private void buttonExitProduct_Click(object sender, EventArgs e)
        {

        }
    }
}