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
    public partial class FormManageOrders : DevExpress.XtraEditors.XtraForm
    {
        private readonly DataAccessLayer _layer;
        public FormManageOrders()
        {
            _layer = new();
            InitializeComponent();
            this.PopulateEmpComboBox();
            this.PopulateCustomerComboBox();
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
            comboBoxOrderEmployeeName.DataSource = dt;
            comboBoxOrderEmployeeName.DisplayMember = "EmployeeID"; //displayString
            comboBoxOrderEmployeeName.ValueMember = "EmployeeID";
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
            comboBoxOrderCustomerName.DataSource = dt;
            comboBoxOrderCustomerName.DisplayMember = "CustomerID"; //displayString
            comboBoxOrderCustomerName.ValueMember = "CustomerID";
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                //if (string.IsNullOrEmpty(textBoxOrderId.Text))
                //{
                //    Utility.LabelMessageFailure(labelManageOrdersMessage, "Please enter a valid ID!");
                //    return;
                //}
                //if (string.IsNullOrEmpty(textBoxOrderCustomerId.Text))
                //{
                //    Utility.LabelMessageFailure(labelManageOrdersMessage, "Please enter a valid customer ID!");
                //    return;
                //}
                //if (string.IsNullOrEmpty(textBoxOrderDate.Text))
                //{
                //    Utility.LabelMessageFailure(labelManageOrdersMessage, "Please enter a date!");
                //    return;
                //}
                //if (string.IsNullOrEmpty(textBoxOrderTotal.Text))
                //{
                //    Utility.LabelMessageFailure(labelManageOrdersMessage, "Please enter a total!");
                //    return;
                //}
                int orderId = Convert.ToInt32(textBoxOrderID.Text);
                int orderCustomerId = Convert.ToInt32(comboBoxOrderCustomerName.Text);
                int orderEmployeeId = Convert.ToInt32(comboBoxOrderEmployeeName.Text);
                string connectionString = ConfigurationManager.ConnectionStrings["test"].ConnectionString;

                // Utility.ClearTextBoxes(this);
                _layer.InsertOrder(orderId, orderCustomerId, orderEmployeeId);

                Utility.LabelMessageSuccess(labelManageOrdersMessage, "New Order Created!");

            }
            catch (Exception ex)
            {
                Utility.LabelMessageFailure(labelManageOrdersMessage, ex.Message);
            }
        }

        private void buttonEditOrder_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemoveLineOrder_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonRemoveOrderOrder_Click(object sender, EventArgs e)
        {
            try
            {
                int orderID = Convert.ToInt32(textBoxOrderID.Text);
                string connectionString = ConfigurationManager.ConnectionStrings["test"].ConnectionString;
                //Utility.ClearTextBoxes(this);
                _layer.DeleteOrder(orderID);
                Utility.LabelMessageSuccess(labelManageOrdersMessage, "Order deleted!");
            }
            catch (Exception ex)
            {
                Utility.LabelMessageFailure(labelManageOrdersMessage, ex.Message);

            }
        }
        
        private void buttonFindOrder_Click(object sender, EventArgs e)
        {

        }
    }
}