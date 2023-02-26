using DevExpress.Pdf.Native.BouncyCastle.Ocsp;
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
            this.PopulateProductSupplierComboBox();
            this.PopulateSupplierGridview();
        }

        private void PopulateSupplierGridview()
        {
            DataSet ds = _layer.PopulateSupplierGridView();
            DataTable dt = ds.Tables[0];
            DataGridViewSupplier.DataSource = dt;

        }

        private void PopulateProductSupplierComboBox() //med hjälp av ChatGPT
        {
            DataSet ds = _layer.ReadProduct();
            DataTable dt = ds.Tables[0];

            dt.Columns.Add("DisplayString", typeof(string));

            foreach (DataRow row in dt.Rows)
            {
                int prodID = Convert.ToInt32(row["ProductID"]);
                string prodName = row["ProductName"].ToString();
                row["DisplayString"] = prodID + " - " + prodName;
            }

            comboBoxSelectProductToAddSupplier.DataSource = dt;
            comboBoxSelectProductToAddSupplier.DisplayMember = "DisplayString"; 
            comboBoxSelectProductToAddSupplier.ValueMember = "ProductID";
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
                
                _layer.AddSupplier(suppId, suppName, suppAddress, phoneNbr); 
                Utility.LabelMessageSuccess(labelManageSuppliersMessage, "Supplier added!");
                Utility.ClearTextBoxes(this);

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
                Utility.LabelMessageFailure(labelManageSuppliersMessage, "Unknown error: " + ex.Message);
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
                _layer.UpdateSupplier(suppId, suppName, suppAddress, phoneNumber);
                Utility.LabelMessageSuccess(labelManageSuppliersMessage, "Supplier edited!");
                Utility.ClearTextBoxes(this);

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

                _layer.DeleteSupplier(suppId);
                Utility.LabelMessageSuccess(labelManageSuppliersMessage, "Supplier removed!");
                Utility.ClearTextBoxes(this);
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

                DataSet ds = _layer.PopulateSupplierGridViewFind(supplierID);
                DataTable dt = ds.Tables[0];
                DataGridViewSupplier.DataSource = dt;

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
                    Utility.ClearTextBoxes(this);
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
                int prodId = Convert.ToInt32(comboBoxSelectProductToAddSupplier.SelectedValue);
                string connectionString = ConfigurationManager.ConnectionStrings["test"].ConnectionString;

                _layer.InsertSupplierProduct(suppId, prodId);
                Utility.LabelMessageSuccess(labelManageSuppliersMessage, "Supplier added to product!");
                Utility.ClearTextBoxes(this);

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
            }
        }
    }
}