using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void barButtonManageProducts_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                FormManageProducts form = new FormManageProducts();
                form.ShowDialog();
            }
            catch (SqlException ex)
            {

                if (ex.Number == 0)
                {
                    MessageBox.Show("No connection ...");
                }
                if (ex.Number == 18456)
                {
                    MessageBox.Show("Failed to login ...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong...");
            }
        }

        private void barButtonManageEmployees_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManageEmployees form = new FormManageEmployees();
            form.ShowDialog();
        }

        private void barButtonManageCustomers_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManageCustomers form = new FormManageCustomers();
            form.ShowDialog();
        }

        private void barButtonManagePurchase_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                FormManagePurchases form = new FormManagePurchases();
                form.ShowDialog();
            }
            catch (SqlException ex)
            {

                if (ex.Number == 0)
                {
                    MessageBox.Show("No connection ...");
                }
                if (ex.Number == 18456)
                {
                    MessageBox.Show("Failed to login ...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong...");
            }

        }

        private void barButtonManageSuppliers_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                FormManageSuppliers form = new FormManageSuppliers();
                form.ShowDialog();
            }
            catch (SqlException ex)
            {

                if (ex.Number == 0)
                {
                    MessageBox.Show("No connection ...");
                }
                if (ex.Number == 18456)
                {
                    MessageBox.Show("Failed to login ...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong...");
            }

        }
    }
}