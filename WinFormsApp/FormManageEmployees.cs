using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Layout.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class FormManageEmployees : DevExpress.XtraEditors.XtraForm
    {
        private readonly DataAccessLayer _layer;
        public FormManageEmployees()
        {
            _layer = new();
            InitializeComponent();
        }
        
        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            try 
            { 
                int employeeId = Convert.ToInt32(textBoxEmployeeId.Text);
                string employeeName = textBoxEmployeeName.Text;
                string employeeAddress = textBoxEmployeeAddress.Text;
                int employeePhoneNumber = Convert.ToInt32(textBoxEmployeePhone.Text);
                string connectionString = ConfigurationManager.ConnectionStrings["test"].ConnectionString;

                _layer.InsertEmployee(employeeId, employeeName, employeeAddress, employeePhoneNumber, connectionString); //osäker om rätt
                Utility.LabelMessageSuccess(labelManageEmployeesMessage, "Employee added!");
            
            }
            catch (Exception ex)
            {
                Utility.LabelMessageFailure(labelManageEmployeesMessage, ex.Message);
                Console.WriteLine(ex.Message);
            }

        }

        private void buttonEditEmployee_Click(object sender, EventArgs e)
        {
            Utility.LabelMessageSuccess(labelManageEmployeesMessage, "Employee edited!");
        }

        private void buttonRemoveEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                int employeeId = Convert.ToInt32(textBoxEmployeeId.Text);
                
                string connectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;

                _layer.DeleteEmployee(employeeId, connectionString); //osäker om rätt
                Utility.LabelMessageSuccess(labelManageEmployeesMessage, "Employee removed!");

            }
            catch (Exception ex)
            {
                Utility.LabelMessageFailure(labelManageEmployeesMessage, ex.Message);
                Console.WriteLine(ex.Message);
            }
            
        }

        private void buttonFindEmployee_Click(object sender, EventArgs e)
        {

        }
    }
}