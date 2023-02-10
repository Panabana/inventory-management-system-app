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
    public partial class FormManageOrders : DevExpress.XtraEditors.XtraForm
    {
        private readonly DataAccessLayer _layer;
        public FormManageOrders()
        {
            _layer = new();
            InitializeComponent();
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditOrder_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemoveLineOrder_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemoveOrderOrder_Click(object sender, EventArgs e)
        {

        }

        private void buttonExitOrder_Click(object sender, EventArgs e)
        {

        }

        private void buttonFindOrder_Click(object sender, EventArgs e)
        {

        }
    }
}