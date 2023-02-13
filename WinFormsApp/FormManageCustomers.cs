using DevExpress.CodeParser;
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
    public partial class FormManageCustomers : DevExpress.XtraEditors.XtraForm
    {
        private readonly DataAccessLayer _layer;
        public FormManageCustomers()
        {
            _layer = new();
            InitializeComponent();
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxCustomerId.Text))
                {
                    Utility.LabelMessageFailure(labelManageCustomersMessage, "Please enter a valid ID!");
                    return;
                }
                if (string.IsNullOrEmpty(textBoxCustomerName.Text))
                {
                    Utility.LabelMessageFailure(labelManageCustomersMessage, "Please enter a name!");
                    return;
                }
                if (string.IsNullOrEmpty(textBoxCustomerAddress.Text))
                {
                    Utility.LabelMessageFailure(labelManageCustomersMessage, "Please enter an address!");
                    return;
                }
                if (string.IsNullOrEmpty(textBoxCustomerPhone.Text))
                {
                    Utility.LabelMessageFailure(labelManageCustomersMessage, "Please enter a phone number!");
                    return;
                }
                int customerId = Convert.ToInt32(textBoxCustomerId.Text);
                string customerName = textBoxCustomerName.Text;
                string customerAddress = textBoxCustomerAddress.Text;
                int customerPhoneNumber = Convert.ToInt32(textBoxCustomerPhone.Text);
                string connectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
                Utility.ClearTextBoxes(this);
                _layer.InsertCustomer(customerId, customerName, customerAddress, customerPhoneNumber, connectionString); //osäker om rätt

                Utility.LabelMessageSuccess(labelManageCustomersMessage, "Customer added!");


            }
            catch (FormatException)
            {
                Utility.LabelMessageFailure(labelManageCustomersMessage, "Please enter the fields in the correct format");
            }

            catch(SqlException ex)
            {
                if(ex.Number == 2627)
                {
                    Utility.LabelMessageFailure(labelManageCustomersMessage, "A customer with this ID already exists");
                }
            }

            catch (Exception ex)
            {
                Utility.LabelMessageFailure(labelManageCustomersMessage, ex.Message);
                Console.WriteLine(ex.Message);
            }

        }

        private void buttonEditCustomer_Click(object sender, EventArgs e)
        {
            try{
                int customerId = Convert.ToInt32(textBoxCustomerId.Text);
                string customerName = textBoxCustomerName.Text;
                string customerAddress = textBoxCustomerAddress.Text;
                int customerPhoneNumber = Convert.ToInt32(textBoxCustomerPhone.Text);
                string connectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
                Utility.ClearTextBoxes(this);
                _layer.UpdateCustomer(customerId, customerName, customerAddress, customerPhoneNumber, connectionString);
                Utility.LabelMessageSuccess(labelManageCustomersMessage, "Customer edited!");

             }
            catch (Exception ex)
            {
                Utility.LabelMessageFailure(labelManageCustomersMessage, ex.Message);
            }
        }
        private void buttonRemoveCustomer_Click(object sender, EventArgs e)
        {
            try {
                int customerId = Convert.ToInt32(textBoxCustomerId.Text);
                string connectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
                Utility.ClearTextBoxes(this);
                _layer.DeleteCustomer(customerId, connectionString);
                Utility.LabelMessageSuccess(labelManageCustomersMessage, "Customer deleted!");
            }
            catch (Exception ex)
            {
            Utility.LabelMessageFailure(labelManageCustomersMessage, ex.Message);

            }
        }

        private void buttonFindCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                int customerId = Convert.ToInt32(textBoxCustomerIdFind.Text);
                string connectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;

                DataTable findCustomerDataTable = new();
                findCustomerDataTable = _layer.FindCustomer(customerId, connectionString);

                if (findCustomerDataTable.Rows.Count == 1)
                {
                    textBoxCustomerId.Text = findCustomerDataTable.Rows[0]["CustomerID"].ToString();
                    textBoxCustomerName.Text = findCustomerDataTable.Rows[0]["CustomerName"].ToString();
                    textBoxCustomerAddress.Text = findCustomerDataTable.Rows[0]["CustomerAddress"].ToString();
                    textBoxCustomerPhone.Text = findCustomerDataTable.Rows[0]["PhoneNumber"].ToString();

                    Utility.LabelMessageSuccess(labelManageCustomersMessage, "Customer found!");
                }
                else
                {
                    Utility.LabelMessageFailure(labelManageCustomersMessage, "Customer not found!");
                }
            }
            catch (Exception ex)
            {
                Utility.LabelMessageFailure(labelManageCustomersMessage, ex.Message);
            }

        }
    }
}