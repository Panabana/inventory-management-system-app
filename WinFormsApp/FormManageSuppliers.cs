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
            try
            {
                int suppId = Convert.ToInt32(textBoxSupplierID.Text);
                string suppName = textBoxSupplierName.Text;
                string suppAddress = textBoxSupplierAddress.Text;
                int phoneNumber = Convert.ToInt32(textBoxSupplierPhone.Text);
                string connectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
                Utility.ClearTextBoxes(this);
                _layer.UpdateSupplier(suppId, suppName, suppAddress, phoneNumber, connectionString);
                Utility.LabelMessageSuccess(labelManageSuppliersMessage, "Supplier edited!");

            }
            catch (Exception ex)
            {
                Utility.LabelMessageFailure(labelManageSuppliersMessage, ex.Message);
            }
        }

        private void buttonRemoveSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                int suppId = Convert.ToInt32(textBoxSupplierID.Text);

                string connectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;

                _layer.DeleteSupplier(suppId, connectionString); //osäker om rätt
                Utility.LabelMessageSuccess(labelManageSuppliersMessage, "Supplier removed!");

            }
            catch (Exception ex)
            {
                Utility.LabelMessageFailure(labelManageSuppliersMessage, ex.Message);
                Console.WriteLine(ex.Message);
            }
        }
        
        private void buttonFindSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                int supplierID = Convert.ToInt32(textBoxSupplierIdFind.Text);
                string connectionString = ConfigurationManager.ConnectionStrings["test"].ConnectionString;

                DataTable findSupplierDataTable = new();
                findSupplierDataTable = _layer.FindSupplier(supplierID, connectionString);

                if (findSupplierDataTable.Rows.Count == 1)
                {
                    textBoxSupplierID.Text = findSupplierDataTable.Rows[0]["SupplierID"].ToString();
                    textBoxSupplierName.Text = findSupplierDataTable.Rows[0]["SupplierName"].ToString();
                    textBoxSupplierAddress.Text = findSupplierDataTable.Rows[0]["SupplierAddress"].ToString();
                    textBoxSupplierPhone.Text = findSupplierDataTable.Rows[0]["PhoneNumber"].ToString();

                    Utility.LabelMessageSuccess(labelManageSuppliersMessage, "Supplier found!");
                }
                else
                {
                    Utility.LabelMessageFailure(labelManageSuppliersMessage, "Supplier not found!");
                }
            }
            catch (NullReferenceException ex)
            {
                Utility.LabelMessageFailure(labelManageSuppliersMessage, "Please enter an ID number!");
            }
            catch (FormatException nbrEx)
            {
                Utility.LabelMessageFailure(labelManageSuppliersMessage, "Please enter a valid number!");
            }
        }
    }
}