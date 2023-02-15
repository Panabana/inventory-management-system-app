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
        }
        private void PopulatePurchaseGridview()
        {
            DataSet ds = _layer.PopulatePurchaseGridView();
            DataTable dt = ds.Tables[0];
            dataGridViewPurchase.DataSource = dt;

        }

        private void PopulateEmpComboBox() //med hjälp av ChatGPT
        {
            DataSet ds = _layer.ViewAllEmployees();
            DataTable dt = ds.Tables[0];
            
            dt.Columns.Add("DisplayString", typeof(string));
            
            foreach(DataRow row in dt.Rows)
            {
                int empID = Convert.ToInt32(row["EmployeeID"]);
                string empName = row["EmployeeName"].ToString();
                row["DisplayString"] = empID + " - " + empName;
            }
            
            comboBoxPurchaseEmployeeName.DataSource = dt;
            comboBoxPurchaseEmployeeName.DisplayMember = "DisplayString"; //displayString
            comboBoxPurchaseEmployeeName.ValueMember = "EmployeeID";
        }

        private void PopulateCustomerComboBox() //med hjälp av ChatGPT
        {
            DataSet ds = _layer.ViewCustomers();
            DataTable dt = ds.Tables[0];
            
            dt.Columns.Add("DisplayString");
            
            foreach(DataRow row in dt.Rows)
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
                //if (string.IsNullOrEmpty(textBoxPurchaseId.Text))
                //{
                //    Utility.LabelMessageFailure(labelManagePurchaseMessage, "Please enter a valid ID!");
                //    return;
                //}
                //if (string.IsNullOrEmpty(textBoxPurchaseCustomerId.Text))
                //{
                //    Utility.LabelMessageFailure(labelManagePurchaseMessage, "Please enter a valid customer ID!");
                //    return;
                //}
                //if (string.IsNullOrEmpty(textBoxPurchaseDate.Text))
                //{
                //    Utility.LabelMessageFailure(labelManagePurchaseMessage, "Please enter a date!");
                //    return;

                //
                

                //}



                int purchaseId = Convert.ToInt32(textBoxPurchaseID.Text);
                int purchaseCustomerId = Convert.ToInt32(comboBoxPurchaseCustomerName.SelectedValue);
                int purchaseEmployeeId = Convert.ToInt32(comboBoxPurchaseEmployeeName.SelectedValue);
                string connectionString = ConfigurationManager.ConnectionStrings["test"].ConnectionString;

                // Utility.ClearTextBoxes(this);
                _layer.InsertPurchase(purchaseId, purchaseCustomerId, purchaseEmployeeId);

                Utility.LabelMessageSuccess(labelManagePurchasesMessage, "New Purchase Created!");

            }
            catch (Exception ex)
            {
                Utility.LabelMessageFailure(labelManagePurchasesMessage, ex.Message);
            }
        }

        private void buttonEditPurchase_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemoveLinePurchase_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRowIndex = dataGridViewPurchase.CurrentRow.Index; //med hjälp av chatGPT
                int purchaseID = Convert.ToInt32(dataGridViewPurchase.Rows[selectedRowIndex].Cells["PurchaseID"].Value); //chatGPT
                int productID = Convert.ToInt32(dataGridViewPurchase.Rows[selectedRowIndex].Cells["ProductID"].Value); //chatGPT

                //chatGPT
                if(dataGridViewPurchase.SelectedRows.Count > 0)
                {
                    dataGridViewPurchase.Rows.Remove(dataGridViewPurchase.SelectedRows[0]);
                    _layer.DeleteProductPurchase(purchaseID, productID);
                }

                Utility.LabelMessageSuccess(labelManagePurchasesMessage, "Product removed from purchase order!");
            }
            catch(Exception ex)
            {
                Utility.LabelMessageFailure(labelManagePurchasesMessage, ex.Message);
            }
        }

        private void buttonRemovePurchasePurchase_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                Utility.LabelMessageFailure(labelManagePurchasesMessage, ex.Message);

            }
        }
        
        private void buttonFindPurchase_Click(object sender, EventArgs e)
        {
            
           try
                {
                    int purchaseId = Convert.ToInt32(textBoxPurchaseIDFind.Text);
                    string connectionString = ConfigurationManager.ConnectionStrings["test"].ConnectionString;
                    DataTable findPurchaseDataTable = new();
                    findPurchaseDataTable = _layer.FindPurchase(purchaseId, connectionString);

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
                    }
                }

                catch (NullReferenceException ex)
                {
                    Utility.LabelMessageFailure(labelManagePurchasesMessage, "Please enter a Purchase ID!");
                }

                catch (FormatException)
                {
                    Utility.LabelMessageFailure(labelManagePurchasesMessage, "Please enter a valid ID to search for!");
                }
            

        }
    }
}