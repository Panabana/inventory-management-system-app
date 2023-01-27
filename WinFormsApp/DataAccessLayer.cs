using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    public class DataAccessLayer
    {
        public SqlConnection GetDatabaseConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings
                ["insertDetailsHere"].ConnectionString;

            SqlConnectionStringBuilder builder = new(connectionString);

            SqlConnection connection = new(builder.ConnectionString);

            return connection;
        }

        public DataSet ViewAllEmployees(string connectionString)
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter empAdapter = SqlAdapterClass.EmployeeAdapter(connection))
                {
                    DataSet dataSet = new DataSet();

                    empAdapter.Fill(dataSet, "Employee");

                    return dataSet;
                }
            }
        }

        public void InsertEmployee(int EmployeeID, string EmployeeName, string EmployeeAddress, int PhoneNumber, string connectionString)
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter empAdapter = SqlAdapterClass.InsertEmployeeAdapter(connection))
                {
                    DataSet dataSet = new DataSet();

                    empAdapter.Fill(dataSet, "Employee");

                    DataTable empDataTable = dataSet.Tables["Employee"];

                    DataRow row = empDataTable.NewRow();
                    row["EmployeeID"] = EmployeeID;
                    row["EmployeeName"] = EmployeeName;
                    row["EmployeeAddress"] = EmployeeAddress;
                    row["PhoneNumber"] = PhoneNumber;

                    empDataTable.Rows.Add(row);
                    empAdapter.Update(empDataTable);

                }
            }
        }

        public DataSet ViewCustomers(string connectionString)
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter customerAdapter = SqlAdapterClass.ViewCustomerAdapter(connection))
                {
                    DataSet ds = new DataSet();

                    customerAdapter.Fill(ds, "Customer");
                    return ds;
                }
            }

        }

        public void InsertCustomer(int custId, string custName, string custAddress, int phoneNbr, string connectionString)
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter customerAdapter = SqlAdapterClass.InsertCustomerAdapter(connection))
                {
                    DataSet ds = new DataSet();
                    customerAdapter.Fill(ds, "Customer");

                    DataTable customerDataTable = new DataTable();
                    customerDataTable = ds.Tables["Customer"];

                    DataRow row = customerDataTable.NewRow();
                    row["CustomerID"] = custId;
                    row["CustomerName"] = custName;
                    row["CustomerAddress"] = custAddress;
                    row["PhoneNumber"] = phoneNbr;

                    customerDataTable.Rows.Add(row);
                    customerAdapter.Update(customerDataTable);
                    
                }

            }
        }


    }

   
}

