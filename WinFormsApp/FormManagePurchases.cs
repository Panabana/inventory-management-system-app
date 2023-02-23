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
        }
        private void PopulatePurchaseGridview()
        {
            DataSet ds = _layer.PopulatePurchaseGridView();
            DataTable dt = ds.Tables[0];
            dataGridViewPurchase.DataSource = dt;

        }

        private void PopulateEmpComboBox() //med hjälp av ChatGPT
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

        private void PopulateCustomerComboBox() //med hjälp av ChatGPT
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

        private int CheckActivePurchases(int purchaseId)
        {
            // SELECT COUNT(*) AS row_count FROM Purchase WHERE CustomerID = '2'
            int amount = Convert.ToInt32(_layer.CheckActivePurchases(purchaseId));
            return amount;
        }

        private void buttonAddPurchase_Click(object sender, EventArgs e)
        {
            try
            {
                int purchaseId = Convert.ToInt32(textBoxPurchaseID.Text);
                // Checking business rule two first
                int amountActive = CheckActivePurchases(purchaseId);
                if (amountActive > 5)
                {
                    Utility.LabelMessageFailure(labelManagePurchasesMessage, "Customer has too many active purchase orders!");
                    return;
                }

                int purchaseCustomerId = Convert.ToInt32(comboBoxPurchaseCustomerName.SelectedValue);
                int purchaseEmployeeId = Convert.ToInt32(comboBoxPurchaseEmployeeName.SelectedValue);
                string connectionString = ConfigurationManager.ConnectionStrings["test"].ConnectionString;

                // Utility.ClearTextBoxes(this);
                _layer.AddPurchase(purchaseId, purchaseCustomerId, purchaseEmployeeId);

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
                //else if (amountActive >= 5)
                //{
                //    Utility.LabelMessageFailure(labelManagePurchasesMessage, "Customer has too many active purchase orders");
                //}
                else
                {
                    Utility.LabelMessageFailure(labelManagePurchasesMessage, "Unknown error with database");
                }
            }
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
            catch (Exception ex)
            {
                Utility.LabelMessageFailure(labelManagePurchasesMessage, ex.Message);
            }
        }

        private void buttonRemoveLinePurchase_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRowIndex = dataGridViewPurchase.CurrentRow.Index; //med hjälp av chatGPT
                int purchaseID = Convert.ToInt32(dataGridViewPurchase.Rows[selectedRowIndex].Cells["Purchase ID"].Value); //chatGPT
                int productID = Convert.ToInt32(dataGridViewPurchase.Rows[selectedRowIndex].Cells["Product ID"].Value); //chatGPT

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
                int purchaseID = Convert.ToInt32(dataGridViewPurchase.Rows[selectedRowIndex].Cells["Purchase ID"].Value);
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
                    }
                }

                catch (NullReferenceException ex)
                {
                    Utility.LabelMessageFailure(labelManagePurchasesMessage, "Please enter a Purchase ID!");
                }

                catch (FormatException)
                {
                DataSet ds = _layer.PopulatePurchaseGridView();
                DataTable dt = ds.Tables[0];
                dataGridViewPurchase.DataSource = dt;
                Utility.LabelMessageFailure(labelManagePurchasesMessage, "Please enter a valid ID to search for!");
                }
            

        }
    }
}