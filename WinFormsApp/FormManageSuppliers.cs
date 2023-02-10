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
    public partial class FormManageSuppliers : DevExpress.XtraEditors.XtraForm
    {
        private readonly DataAccessLayer _layer;
        public FormManageSuppliers()
        {
            _layer = new();
            InitializeComponent();
        }

        private void buttonAddSupplier_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditSupplier_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemoveSupplier_Click(object sender, EventArgs e)
        {

        }

        private void buttonExitSupplier_Click(object sender, EventArgs e)
        {

        }

        private void buttonFindSupplier_Click(object sender, EventArgs e)
        {

        }
    }
}