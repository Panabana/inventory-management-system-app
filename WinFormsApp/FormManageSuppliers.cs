using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class FormManageSuppliers : DevExpress.XtraEditors.XtraForm
    {
        private readonly DataAccessLayer _layer;
        public FormManageSuppliers()
        {
            _layer = new();
            InitializeComponent();
        }

        private void buttonAddSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                int suppId = Convert.ToInt32(textBoxSupplierID.Text);
                string suppName = textBoxSupplierName.Text;
                string suppAddress = textBoxSupplierAddress.Text;
                int phoneNbr = Convert.ToInt32(textBoxSupplierPhone.Text);
                string connectionString = ConfigurationManager.ConnectionStrings["test"].ConnectionString;
                
                _layer.InsertSupplier(suppId, suppName, suppAddress, phoneNbr, connectionString); //osäker om rätt
                Utility.LabelMessageSuccess(labelManageSuppliersMessage, "Supplier added!");

            }
            catch (Exception ex)
            {
                Utility.LabelMessageFailure(labelManageSuppliersMessage, ex.Message);
                Console.WriteLine(ex.Message);
            }
        }

        private void buttonEditSupplier_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemoveSupplier_Click(object sender, EventArgs e)
        {

        }

        private void buttonExitSupplier_Click(object sender, EventArgs e)
        {

        }

        private void buttonFindSupplier_Click(object sender, EventArgs e)
        {

        }
    }
}