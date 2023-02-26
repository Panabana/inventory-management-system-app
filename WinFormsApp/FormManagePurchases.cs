using DevExpress.CodeParser;
using DevExpress.Mvvm.Native;
using DevExpress.Utils.About;
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
    public partial class FormManagePurchases : DevExpress.XtraEditors.XtraForm
    {
        private readonly DataAccessLayer _layer;
        public FormManagePurchases()
        {
            _layer = new();
            InitializeComponent();
            this.PopulateEmpComboBox();
            this.PopulateCustomerComboBox();
            this.PopulatePurchaseGridview();
            this.PopulatePurchaseComboBox();
            this.PopulateProductComboBox();
        }
        
        private void PopulatePurchaseGridview()
        {
            DataSet ds = _layer.PopulatePurchaseGridView();
            DataTable dt = ds.Tables[0];
            dataGridViewPurchase.DataSource = dt;
        }

        private void PopulateEmpComboBox() // With help from ChatGPT
        {
            DataSet ds = _layer.ReadEmployee();
            DataTable dt = ds.Tables[0];

            dt.Columns.Add("DisplayString", typeof(string));

            foreach (DataRow row in dt.Rows)
            {
                int empID = Convert.ToInt32(row["EmployeeID"]);
                string empName = row["EmployeeName"].ToString();
                row["DisplayString"] = empID + " - " + empName;
            }

            comboBoxPurchaseEmployeeName.DataSource = dt;
            comboBoxPurchaseEmployeeName.DisplayMember = "DisplayString"; //displayString
            comboBoxPurchaseEmployeeName.ValueMember = "EmployeeID";
        }

        private void PopulatePurchaseComboBox() // With help from ChatGPT
        {
            DataSet ds = _layer.ReadPurchase();
            DataTable dt = ds.Tables[0];

            comboBoxPurchaseId.DataSource = dt;
            comboBoxPurchaseId.DisplayMember = "PurchaseID";
            comboBoxPurchaseId.ValueMember = "PurchaseID";
        }

        private void PopulateProductComboBox() // With help from ChatGPT
        {
            DataSet ds = _layer.ReadProduct();
            DataTable dt = ds.Tables[0];

            comboBoxProduct.DataSource = dt;
            comboBoxProduct.DisplayMember = "ProductID";
            comboBoxProduct.ValueMember = "ProductID";
        }

        private void PopulateCustomerComboBox() // With help from ChatGPT
        {
            DataSet ds = _layer.ReadCustomer();
            DataTable dt = ds.Tables[0];

            dt.Columns.Add("DisplayString");

            foreach (DataRow row in dt.Rows)
            {
                int custID = Convert.ToInt32(row["CustomerID"]);
                string custName = row["CustomerName"].ToString();
                row["DisplayString"] = custID + " - " + custName;
            }

            comboBoxPurchaseCustomerName.DataSource = dt;
            comboBoxPurchaseCustomerName.DisplayMember = "DisplayString"; //displayString
            comboBoxPurchaseCustomerName.ValueMember = "CustomerID";
        }
        
        private void buttonAddPurchase_Click(object sender, EventArgs e)
        {
            try
            {
                int purchaseId = Convert.ToInt32(textBoxPurchaseID.Text);
                int purchaseCustomerId = Convert.ToInt32(comboBoxPurchaseCustomerName.SelectedValue);

                // BUSINESS RULE #2 CHECK - No more than 5 active purchase orders
                int amountActive = _layer.CheckActivePurchases(purchaseCustomerId);
                if (amountActive >= 5)
                {
                    Utility.LabelMessageFailure(labelManagePurchasesMessage, "Customer has too many active purchase orders!");
                    return;
                }

                int purchaseEmployeeId = Convert.ToInt32(comboBoxPurchaseEmployeeName.SelectedValue);
                
                // COMMENTED OUT - connection is established in the 1st using inside .AddPurchase?
                //string connectionString = ConfigurationManager.ConnectionStrings["test"].ConnectionString;

                // Utility.ClearTextBoxes(this);
                _layer.AddPurchase(purchaseId, purchaseEmployeeId, purchaseCustomerId);

                Utility.LabelMessageSuccess(labelManagePurchasesMessage, "New Purchase Created!");
            }


            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    Utility.LabelMessageFailure(labelManagePurchasesMessage, "Please select the correct Customer and Employee");
                }
            
                else if (ex.Number == 2627)
                {
                    Utility.LabelMessageFailure(labelManagePurchasesMessage, "This Purchase already exists!");
                }
                else
                {
                    Utility.LabelMessageFailure(labelManagePurchasesMessage, "Unknown error with database");
                }
            }
            catch (FormatException ex)
            {
                Utility.LabelMessageFailure(labelManagePurchasesMessage, "Please enter a valid ID!");
            }
            catch (Exception)
            {
                Utility.LabelMessageFailure(labelManagePurchasesMessage, "Something went wrong!");
            }
            
            this.PopulatePurchaseGridview();
        }

        private void buttonEditPurchase_Click(object sender, EventArgs e)
        {
            try
            {
                int purchaseId = Convert.ToInt32(textBoxPurchaseID.Text);
                int customerId = Convert.ToInt32(comboBoxPurchaseCustomerName.SelectedValue);
                int empId = Convert.ToInt32(comboBoxPurchaseEmployeeName.SelectedValue);

                _layer.UpdatePurchase(purchaseId, customerId, empId);

                Utility.LabelMessageSuccess(labelManagePurchasesMessage, "Purchase updated!");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    Utility.LabelMessageFailure(labelManagePurchasesMessage, "Please select the correct Customer and Employee");
                }
            }
            catch (FormatException)
            {
                Utility.LabelMessageFailure(labelManagePurchasesMessage, "Please enter a valid ID!");
            }
            catch (Exception)
            {
                Utility.LabelMessageFailure(labelManagePurchasesMessage, "Something went wrong!");
            }
            
            this.PopulatePurchaseGridview();
        }

        private void buttonRemoveLinePurchase_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRowIndex = dataGridViewPurchase.CurrentRow.Index; //med hjälp av chatGPT
                int purchaseID = Convert.ToInt32(dataGridViewPurchase.Rows[selectedRowIndex].Cells["PurchaseID"].Value); //chatGPT
                int productID = Convert.ToInt32(dataGridViewPurchase.Rows[selectedRowIndex].Cells["ProductID"].Value); //chatGPT

                // chatGPT
                if(dataGridViewPurchase.SelectedRows.Count > 0)
                {
                    dataGridViewPurchase.Rows.Remove(dataGridViewPurchase.SelectedRows[0]);
                    _layer.DeleteProductPurchase(purchaseID, productID);
                }

                Utility.LabelMessageSuccess(labelManagePurchasesMessage, "Product removed from purchase order!");
            }
            catch(Exception)
            {
                Utility.LabelMessageFailure(labelManagePurchasesMessage, "Something went wrong...");
            }
            
            this.PopulatePurchaseGridview();
        }

        private void buttonRemovePurchasePurchase_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(textBoxPurchaseID.Text))
                {
                    int selectedRowIndex = dataGridViewPurchase.CurrentRow.Index; //med hjälp av chatGPT
                    int purchaseID = Convert.ToInt32(dataGridViewPurchase.Rows[selectedRowIndex].Cells["PurchaseID"].Value);
                    //Utility.ClearTextBoxes(this);

                    //ChatGPT
                    if (dataGridViewPurchase.SelectedRows.Count > 0)
                    {
                        dataGridViewPurchase.Rows.Remove(dataGridViewPurchase.SelectedRows[0]);
                        _layer.DeletePurchase(purchaseID);
                    }

                    Utility.LabelMessageSuccess(labelManagePurchasesMessage, "Purchase deleted!");
                }
                if (!string.IsNullOrEmpty(textBoxPurchaseID.Text))
                {
                    int purchaseID = Convert.ToInt32(textBoxPurchaseID.Text);
                    _layer.DeletePurchase(purchaseID);
                    Utility.LabelMessageSuccess(labelManagePurchasesMessage, "Purchase deleted!");
                }
            }
            catch (FormatException)
            {
                Utility.LabelMessageFailure(labelManagePurchasesMessage, "Please enter a valid ID!");
            }
            catch (Exception)
            {
                Utility.LabelMessageFailure(labelManagePurchasesMessage, "Something went wrong!");
            }

            this.PopulatePurchaseGridview();
        }
        
        private void buttonFindPurchase_Click(object sender, EventArgs e)
        {
           try
           {
                int purchaseId = Convert.ToInt32(textBoxPurchaseIDFind.Text);
                string connectionString = ConfigurationManager.ConnectionStrings["test"].ConnectionString;
                DataTable findPurchaseDataTable = new();
                findPurchaseDataTable = _layer.FindPurchase(purchaseId, connectionString);

                DataSet ds = _layer.PopulatePurchaseGridViewFind(purchaseId);
                DataTable dt = ds.Tables[0];
                dataGridViewPurchase.DataSource = dt;
                

                if (findPurchaseDataTable.Rows.Count == 1)
                {
                    textBoxPurchaseID.Text = findPurchaseDataTable.Rows[0]["PurchaseID"].ToString();
                    comboBoxPurchaseCustomerName.Text = findPurchaseDataTable.Rows[0]["CustomerID"].ToString();
                    comboBoxPurchaseEmployeeName.Text = findPurchaseDataTable.Rows[0]["EmployeeID"].ToString();

                    Utility.LabelMessageSuccess(labelManagePurchasesMessage, "Purchase found!");
                }
                else
                {
                    Utility.LabelMessageFailure(labelManagePurchasesMessage, "Purchase does not exist!");
                    this.PopulatePurchaseGridview();
                }
            }

            catch (NullReferenceException)
            {
                Utility.LabelMessageFailure(labelManagePurchasesMessage, "Please enter a Purchase ID!");
                this.PopulatePurchaseGridview();
            }
            catch (FormatException)
            {
                Utility.LabelMessageFailure(labelManagePurchasesMessage, "Please enter a valid ID to search for!");
                this.PopulatePurchaseGridview();
            }
            catch (Exception)
            {
                Utility.LabelMessageFailure(labelManagePurchasesMessage, "Unknown error, something went wrong!");
                this.PopulatePurchaseGridview();
            }

        }
        private void buttonAddProdcut_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(comboBoxPurchaseId.Text))
                {
                    Utility.LabelMessageFailure(labelManagePurchasesMessage, "Please select a purchase ID!");
                    return;
                }
                if (string.IsNullOrEmpty(comboBoxProduct.Text))
                {
                    Utility.LabelMessageFailure(labelManagePurchasesMessage, "Please enter a product ID!");
                    return;
                }
                if (string.IsNullOrEmpty(textBoxProductQuantity.Text))
                {
                    Utility.LabelMessageFailure(labelManagePurchasesMessage, "Please enter the amount of this product!");
                    return;
                }
                int purchaseId = Convert.ToInt32(comboBoxPurchaseId.Text);
                int productId = Convert.ToInt32(comboBoxProduct.Text);
                int quantity = Convert.ToInt32(textBoxProductQuantity.Text);

                _layer.InsertProductPurchase(purchaseId, productId, quantity);
                Utility.ClearTextBoxes(this);

                Utility.LabelMessageSuccess(labelManagePurchasesMessage, "Product added to purchase!");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    Utility.LabelMessageFailure(labelManagePurchasesMessage, "This product is already in this purchase!");
                }
                if (ex.Number == 547)
                {
                    Utility.LabelMessageFailure(labelManagePurchasesMessage, "The quantity amount cannot exceed 5");
                }
            }
            catch (FormatException)
            {
                Utility.LabelMessageFailure(labelManagePurchasesMessage, "Please insert the quantity in the correct format!");
            }
            catch (Exception ex)
            {
                Utility.LabelMessageFailure(labelManagePurchasesMessage, "Unknown error:" + ex.Message);
            }

            this.PopulatePurchaseGridview();
        }
    }
}