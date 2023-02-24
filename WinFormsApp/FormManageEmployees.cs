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
            this.PopulateEmployeeGridview();
        }

        private void PopulateEmployeeGridview()
        {
            DataSet ds = _layer.PopulateEmployeeGridView();
            DataTable dt = ds.Tables[0];
            DataGridViewEmployee.DataSource = dt;

        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            try 
            {
                if (string.IsNullOrEmpty(textBoxEmployeeId.Text))
                {
                    Utility.LabelMessageFailure(labelManageEmployeesMessage, "Please enter a valid ID!");
                    return;
                }
                if (string.IsNullOrEmpty(textBoxEmployeeName.Text))
                {
                    Utility.LabelMessageFailure(labelManageEmployeesMessage, "Please enter a name!");
                    return;
                }
                if (string.IsNullOrEmpty(textBoxEmployeeAddress.Text))
                {
                    Utility.LabelMessageFailure(labelManageEmployeesMessage, "Please enter an address!");
                    return;
                }
                if (string.IsNullOrEmpty(textBoxEmployeePhone.Text))
                {
                    Utility.LabelMessageFailure(labelManageEmployeesMessage, "Please enter a phone number!");
                    return;
                }
                int employeeId = Convert.ToInt32(textBoxEmployeeId.Text);
                string employeeName = textBoxEmployeeName.Text;
                string employeeAddress = textBoxEmployeeAddress.Text;
                int employeePhoneNumber = Convert.ToInt32(textBoxEmployeePhone.Text);
                string connectionString = ConfigurationManager.ConnectionStrings["test"].ConnectionString;

                _layer.AddEmployee(employeeId, employeeName, employeeAddress, employeePhoneNumber); //osäker om rätt
                Utility.LabelMessageSuccess(labelManageEmployeesMessage, "Employee added!");
                Utility.ClearTextBoxes(this);
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
                if (ex.Number == 2627)
                {
                    Utility.LabelMessageFailure(labelManageEmployeesMessage, "A customer with this ID already exists");
                }  
            }
            catch (FormatException)
            {
                Utility.LabelMessageFailure(labelManageEmployeesMessage, "Please enter the fields in the correct format");
            }                      
            catch (Exception ex)
            {
                Utility.LabelMessageFailure(labelManageEmployeesMessage, ex.Message);
               
            }

        }

        private void buttonEditEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxEmployeeId.Text))
                {
                    Utility.LabelMessageFailure(labelManageEmployeesMessage, "Choose a employee ID to edit!");
                    return;
                }
                if (string.IsNullOrEmpty(textBoxEmployeeName.Text))
                {
                    Utility.LabelMessageFailure(labelManageEmployeesMessage, "Please enter an edited or unedited name!");
                    return;
                }
                if (string.IsNullOrEmpty(textBoxEmployeeAddress.Text))
                {
                    Utility.LabelMessageFailure(labelManageEmployeesMessage, "Please enter an edited or unedited address!");
                    return;
                }
                if (string.IsNullOrEmpty(textBoxEmployeePhone.Text))
                {
                    Utility.LabelMessageFailure(labelManageEmployeesMessage, "Please enter an edited or unedited phone number");
                    return;
                }
                int empID = Convert.ToInt32(textBoxEmployeeId.Text);
                string empName = textBoxEmployeeName.Text;
                string empAddress = textBoxEmployeeAddress.Text;
                int empPhoneNbr = Convert.ToInt32(textBoxEmployeePhone.Text);
                string connectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;

                _layer.UpdateEmployee(empID, empName, empAddress, empPhoneNbr);
                Utility.LabelMessageSuccess(labelManageEmployeesMessage, "Employee edited!");
                Utility.ClearTextBoxes(this);
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
            catch (FormatException)
            {
                Utility.LabelMessageFailure(labelManageEmployeesMessage, "Please enter the fields in the correct format");
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

                _layer.DeleteEmployee(employeeId); //osäker om rätt
                Utility.LabelMessageSuccess(labelManageEmployeesMessage, "Employee removed!");
                Utility.ClearTextBoxes(this);

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
            catch (FormatException)
            {
                Utility.LabelMessageFailure(labelManageEmployeesMessage, "Please enter the ID of the employee you want to remove!");
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

                DataSet ds = _layer.PopulateEmployeeGridViewFind(empId);
                DataTable dt = ds.Tables[0];
                DataGridViewEmployee.DataSource = dt;

                if (findEmpDataTable.Rows.Count == 1)
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
            catch (FormatException)
            {
                Utility.LabelMessageFailure(labelManageEmployeesMessage, "Please enter a Employee ID to search for!");
            }
            catch (Exception ex)
            {
                Utility.LabelMessageFailure(labelManageEmployeesMessage, ex.Message);

            }

        }

        private void dataGridViewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}