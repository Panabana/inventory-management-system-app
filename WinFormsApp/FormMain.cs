using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*CONTROLLER
 Added read only DAL object.
 */

namespace WinFormsApp
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly DataAccessLayer _layer;
        public FormMain()
        {
            _layer = new();
            InitializeComponent();
        }

        private void RibbonForm2_Load(object sender, EventArgs e)
        {

        }

        private void barButtonManageProducts_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManageProducts form = new FormManageProducts();
            form.ShowDialog();
        }
    }
}