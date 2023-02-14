using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
                if (string.IsNullOrEmpty(textBoxSupplierID.Text))
                {
                    Utility.LabelMessageFailure(labelManageSuppliersMessage, "Please enter a valid ID!");
                    return;
                }
                if (string.IsNullOrEmpty(textBoxSupplierName.Text))
                {
                    Utility.LabelMessageFailure(labelManageSuppliersMessage, "Please enter a name!");
                    return;
                }
                if (string.IsNullOrEmpty(textBoxSupplierAddress.Text))
                {
                    Utility.LabelMessageFailure(labelManageSuppliersMessage, "Please enter an address!");
                    return;
                }
                if (string.IsNullOrEmpty(textBoxSupplierPhone.Text))
                {
                    Utility.LabelMessageFailure(labelManageSuppliersMessage, "Please enter a phone number!");
                    return;
                }
                int suppId = Convert.ToInt32(textBoxSupplierID.Text);
                string suppName = textBoxSupplierName.Text;
                string suppAddress = textBoxSupplierAddress.Text;
                int phoneNbr = Convert.ToInt32(textBoxSupplierPhone.Text);
                string connectionString = ConfigurationManager.ConnectionStrings["test"].ConnectionString;
                
                _layer.InsertSupplier(suppId, suppName, suppAddress, phoneNbr, connectionString); 
                Utility.LabelMessageSuccess(labelManageSuppliersMessage, "Supplier added!");

            }
            catch (FormatException)
            {
                Utility.LabelMessageFailure(labelManageSuppliersMessage, "Please enter the fields in the correct format!");
            }

            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    Utility.LabelMessageFailure(labelManageSuppliersMessage, "A supplier with this ID already exists!");
                }
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
                if (string.IsNullOrEmpty(textBoxSupplierID.Text))
                {
                    Utility.LabelMessageFailure(labelManageSuppliersMessage, "Please enter a Supplier ID to edit!");
                    return;
                }
                if (string.IsNullOrEmpty(textBoxSupplierName.Text))
                {
                    Utility.LabelMessageFailure(labelManageSuppliersMessage, "Please enter an edited or unedited name!");
                    return;
                }
                if (string.IsNullOrEmpty(textBoxSupplierAddress.Text))
                {
                    Utility.LabelMessageFailure(labelManageSuppliersMessage, "Please enter an edited or unedited address!");
                    return;
                }
                if (string.IsNullOrEmpty(textBoxSupplierPhone.Text))
                {
                    Utility.LabelMessageFailure(labelManageSuppliersMessage, "Please enter an edited or unedited phone number!");
                    return;
                }
                int suppId = Convert.ToInt32(textBoxSupplierID.Text);
                string suppName = textBoxSupplierName.Text;
                string suppAddress = textBoxSupplierAddress.Text;
                int phoneNumber = Convert.ToInt32(textBoxSupplierPhone.Text);
                string connectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
                Utility.ClearTextBoxes(this);
                _layer.UpdateSupplier(suppId, suppName, suppAddress, phoneNumber, connectionString);
                Utility.LabelMessageSuccess(labelManageSuppliersMessage, "Supplier edited!");

            }
            catch (FormatException)
            {
                Utility.LabelMessageFailure(labelManageSuppliersMessage, "Please enter the fields in the correct format!");
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

                _layer.DeleteSupplier(suppId, connectionString);
                Utility.LabelMessageSuccess(labelManageSuppliersMessage, "Supplier removed!");
            }
            catch (FormatException)
            {
                Utility.LabelMessageFailure(labelManageSuppliersMessage, "Please enter the ID of the supplier you want to remove");

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

            catch (FormatException)
            {
                Utility.LabelMessageFailure(labelManageSuppliersMessage, "Please enter a Supplier ID to search for!");

            }
        }

        private void buttonAddSupplierToProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxSupplierID.Text))
                {
                    Utility.LabelMessageFailure(labelManageSuppliersMessage, "Please enter a valid ID!");
                    return;
                }
                if (string.IsNullOrEmpty(comboBoxSelectProductToAddSupplier.Text))
                {
                    Utility.LabelMessageFailure(labelManageSuppliersMessage, "Please select a product to add a supplier to!");
                    return;
                }

                int suppId = Convert.ToInt32(textBoxSupplierID.Text);
                int prodId = Convert.ToInt32(comboBoxSelectProductToAddSupplier.Text);
                string connectionString = ConfigurationManager.ConnectionStrings["test"].ConnectionString;

                _layer.InsertSupplierProduct(suppId, prodId);
                Utility.LabelMessageSuccess(labelManageSuppliersMessage, "Supplier added to product!");

            }
            catch (FormatException)
            {
                Utility.LabelMessageFailure(labelManageSuppliersMessage, "Please enter the fields in the correct format!");
            }

            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    Utility.LabelMessageFailure(labelManageSuppliersMessage, "A supplier with this ID already exists!");
                }
            }
            catch (Exception ex)
            {
                Utility.LabelMessageFailure(labelManageSuppliersMessage, ex.Message);
                Console.WriteLine(ex.Message);
            }
        }
    }
}