using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        }

        private void buttonEditCustomer_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemoveCustomer_Click(object sender, EventArgs e)
        {

        }

        private void buttonExitCustomer_Click(object sender, EventArgs e)
        {

        }

        private void buttonCustomerIdFind_Click(object sender, EventArgs e)
        {

        }
    }
}