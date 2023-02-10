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
                int customerId = Convert.ToInt32(textBoxCustomerId.Text);
                string customerName = textBoxCustomerName.Text;
                string customerAddress = textBoxCustomerAddress.Text;
                int customerPhoneNumber = Convert.ToInt32(textBoxCustomerPhone.Text);
                string connectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;

                _layer.InsertCustomer(customerId, customerName, customerAddress, customerPhoneNumber, connectionString); //osäker om rätt
                Utility.LabelMessageSuccess(labelManageCustomersMessage, "Customer added!");

            }
            catch (Exception ex)
            {
                Utility.LabelMessageFailure(labelManageCustomersMessage, ex.Message);
                Console.WriteLine(ex.Message);
            }

        }

        private void buttonEditCustomer_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemoveCustomer_Click(object sender, EventArgs e)
        {
            try {
                int customerId = Convert.ToInt32(textBoxCustomerId.Text);
                string connectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
                _layer.DeleteCustomer(customerId, connectionString);
                Utility.LabelMessageSuccess(labelManageCustomersMessage, "Customer deleted!");
            }
            catch (Exception ex)
            {
            Utility.LabelMessageFailure(labelManageCustomersMessage, ex.Message);

            }
        }
    
        private void buttonExitCustomer_Click(object sender, EventArgs e)
        {

        }

        private void buttonCustomerIdFind_Click(object sender, EventArgs e)
        {

        }
    }
}