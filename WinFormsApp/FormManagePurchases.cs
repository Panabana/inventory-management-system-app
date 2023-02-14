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
            /*
            dt.Columns.Add("DisplayString", typeof(string));
            
            foreach(DataRow row in dt.Rows)
            {
                int empID = Convert.ToInt32(row["EmployeeID"]);
                string empName = row["EmployeeName"].ToString();
                row["DisplayString"] = empID + " - " + empName;
            }
            */
            comboBoxPurchaseEmployeeName.DataSource = dt;
            comboBoxPurchaseEmployeeName.DisplayMember = "EmployeeID"; //displayString
            comboBoxPurchaseEmployeeName.ValueMember = "EmployeeID";
        }

        private void PopulateCustomerComboBox() //med hjälp av ChatGPT
        {
            DataSet ds = _layer.ViewCustomers();
            DataTable dt = ds.Tables[0];
            /*
            dt.Columns.Add("DisplayString");
            
            foreach(DataRow row in dt.Rows)
            {
                int custID = Convert.ToInt32(row["CustomerID"]);
                string custName = row["CustomerName"].ToString();
                row["DisplayString"] = custID + " - " + custName;
            }
            */
            comboBoxPurchaseCustomerName.DataSource = dt;
            comboBoxPurchaseCustomerName.DisplayMember = "CustomerID"; //displayString
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
                //}
                
                int purchaseId = Convert.ToInt32(textBoxPurchaseID.Text);
                int purchaseCustomerId = Convert.ToInt32(comboBoxPurchaseCustomerName.Text);
                int purchaseEmployeeId = Convert.ToInt32(comboBoxPurchaseEmployeeName.Text);
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
            
        }

        private void buttonRemovePurchasePurchase_Click(object sender, EventArgs e)
        {
            try
            {
                int purchaseId = Convert.ToInt32(textBoxPurchaseID.Text);
                string connectionString = ConfigurationManager.ConnectionStrings["test"].ConnectionString;
                //Utility.ClearTextBoxes(this);
                _layer.DeletePurchase(purchaseId);
                Utility.LabelMessageSuccess(labelManagePurchasesMessage, "Purchase deleted!");
            }
            catch (Exception ex)
            {
                Utility.LabelMessageFailure(labelManagePurchasesMessage, ex.Message);

            }
        }
        
        private void buttonFindPurchase_Click(object sender, EventArgs e)
        {

        }
    }
}