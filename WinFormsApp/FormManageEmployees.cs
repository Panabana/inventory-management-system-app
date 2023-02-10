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
            try
            {
                int empID = Convert.ToInt32(textBoxEmployeeId.Text);
                string empName = textBoxEmployeeName.Text;
                string empAddress = textBoxEmployeeAddress.Text;
                int empPhoneNbr = Convert.ToInt32(textBoxEmployeePhone.Text);
                string connectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;

                _layer.UpdateEmployee(empID, empName, empAddress, empPhoneNbr, connectionString);
                 Utility.LabelMessageSuccess(labelManageEmployeesMessage, "Employee edited!");
            }
            catch(Exception ex)
            {
                Utility.LabelMessageFailure(labelManageEmployeesMessage, ex.Message);
            }
            
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
            try
            {
                int empId = Convert.ToInt32(textBoxEmployeeIdFind.Text);
                string connectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;

                DataTable findEmpDataTable = new();
                findEmpDataTable = _layer.FindEmployee(empId, connectionString);

                if(findEmpDataTable.Rows.Count == 1)
                {
                    textBoxEmployeeId.Text = findEmpDataTable.Rows[0]["EmployeeID"].ToString();
                    textBoxEmployeeName.Text = findEmpDataTable.Rows[0]["EmployeeName"].ToString();
                    textBoxEmployeeAddress.Text = findEmpDataTable.Rows[0]["EmployeeAddress"].ToString();
                    textBoxEmployeePhone.Text = findEmpDataTable.Rows[0]["PhoneNumber"].ToString();

                    Utility.LabelMessageSuccess(labelManageEmployeesMessage, "Employee found!");
                }
                else
                {
                    Utility.LabelMessageFailure(labelManageEmployeesMessage, "Employee not found!");
                }
            }
            catch(Exception ex)
            {
                Utility.LabelMessageFailure(labelManageEmployeesMessage, ex.Message);
            }

        }
    }
}