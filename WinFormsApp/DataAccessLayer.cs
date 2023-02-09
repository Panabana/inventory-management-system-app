using DevExpress.PivotGrid.CustomFunctions;
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
        // Används denna?
        public SqlConnection GetDatabaseConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings
                ["test"].ConnectionString;

            SqlConnectionStringBuilder builder = new(connectionString);

            SqlConnection connection = new(builder.ConnectionString);

            return connection;  
        }

        // - EMPLOYEE -
        public DataSet ViewAllEmployees(string connectionString)
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter empAdapter = SqlAdapterClass.ViewAllEmployeeAdapter(connection))
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
                connection.Open();

                using (SqlDataAdapter empAdapter = SqlAdapterClass.InsertEmployeeAdapter(EmployeeID, EmployeeName, EmployeeAddress, PhoneNumber, connection))
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

        public void DeleteEmployee(int empId, string connectionString)
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = SqlAdapterClass.DeleteEmployeeAdapter(connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Employee");

                    DataTable empDataTable = new DataTable();
                    empDataTable = ds.Tables["Employee"];

                    DataRow row = empDataTable.Rows.Find(empId);
                    row.Delete();
                    adapter.Update(empDataTable);
                }
            }
        }

        public void UpdateEmployee(int empId, string empName, string empAddress, int phoneNbr, string connectionString)
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = SqlAdapterClass.UpdateEmployeeAdapter(connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Employee");

                    DataTable empDataTable = new DataTable();
                    empDataTable = ds.Tables["Employee"];

                    DataRow[] rows = empDataTable.Select("EmployeeID =" + empId);
                    if (rows.Length == 1)
                    {
                        rows[0]["EmployeeName"] = empName;
                        rows[0]["CustomerAddress"] = empAddress;
                        rows[0]["PhoneNumber"] = phoneNbr;
                    }

                    adapter.Update(empDataTable);
                }
            }
        }
        
        // - CUSTOMER -
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

        public void DeleteCustomer(int custId, string connectionString)
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter customerAdapter = SqlAdapterClass.DeleteCustomerAdapter(connection))
                {
                    DataSet ds = new DataSet();
                    customerAdapter.Fill(ds, "Customer");

                    DataTable customerDataTable = new DataTable();
                    customerDataTable = ds.Tables["Customer"];

                    DataRow row = customerDataTable.Rows.Find(custId);
                    row.Delete();
                    customerAdapter.Update(customerDataTable);
                }
            }
        }

        public void UpdateCustomer(int custId, string custName, string custAddress, int phoneNbr, string connectionString)
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = SqlAdapterClass.UpdateCustomerAdapter(connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Customer");

                    DataTable customerDataTable = new DataTable();
                    customerDataTable = ds.Tables["Customer"];

                    DataRow[] rows = customerDataTable.Select("CustomerID =" + custId);
                    if (rows.Length == 1)
                    {
                        rows[0]["CustomerName"] = custName;
                        rows[0]["CustomerAddress"] = custAddress;
                        rows[0]["PhoneNumber"] = phoneNbr;
                    }

                    adapter.Update(customerDataTable);
                }
            }
        }
        
        // - SUPPLIER -
        public DataSet ViewSuppliers(string connectionString)
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = SqlAdapterClass.ViewSupplierAdapter(connection))
                {
                    DataSet ds = new DataSet();

                    adapter.Fill(ds, "Supplier");
                    return ds;
                }
            }
        }
        public void InsertSupplier(int suppId, string suppName, string suppAddress, int phoneNbr, string connectionString)
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = SqlAdapterClass.InsertSupplierAdapter(connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Supplier");

                    DataTable supplierDataTable = new DataTable();
                    supplierDataTable = ds.Tables["Supplier"];

                    DataRow row = supplierDataTable.NewRow();
                    row["SupplierID"] = suppId;
                    row["SupplierName"] = suppName;
                    row["SupplierAddress"] = suppAddress;
                    row["PhoneNumber"] = phoneNbr;

                    supplierDataTable.Rows.Add(row);
                    adapter.Update(supplierDataTable);
                }
            }
        }

        public void DeleteSupplier(int suppId, string connectionString)
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = SqlAdapterClass.DeleteSupplierAdapter(connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Supplier");

                    DataTable supplierDataTable = new DataTable();
                    supplierDataTable = ds.Tables["Supplier"];

                    DataRow row = supplierDataTable.Rows.Find(suppId);
                    row.Delete();
                    adapter.Update(supplierDataTable);
                }
            }
        }

        public void UpdateSupplier(int suppId, string suppName, string suppAddress, int phoneNbr, string connectionString)
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = SqlAdapterClass.UpdateSupplierAdapter(connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Supplier");

                    DataTable suppDataTable = new DataTable();
                    suppDataTable = ds.Tables["Supplier"];

                    DataRow[] rows = suppDataTable.Select("SupplierID =" + suppId);
                    if (rows.Length == 1)
                    {
                        rows[0]["EmployeeName"] = suppName;
                        rows[0]["CustomerAddress"] = suppAddress;
                        rows[0]["PhoneNumber"] = phoneNbr;
                    }

                    adapter.Update(suppDataTable);
                }
            }
        }

        // - PRODUCT -
        public DataSet ViewProducts(string connectionString)
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = SqlAdapterClass.ViewAllProductAdapter(connection))
                {
                    DataSet dataSet = new DataSet();

                    adapter.Fill(dataSet, "Product");

                    return dataSet;
                }
            }
        }

        public void InsertProduct(int prodId, string prodName, int price, int stock, string connectionString)
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = SqlAdapterClass.InsertProductAdapter(connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Product");

                    DataTable productDataTable = new DataTable();
                    productDataTable = ds.Tables["Product"];

                    DataRow row = productDataTable.NewRow();
                    row["ProductID"] = prodId;
                    row["ProductName"] = prodName;
                    row["Price"] = price;
                    row["Stock"] = stock;

                    productDataTable.Rows.Add(row);
                    adapter.Update(productDataTable);
                }
            }
        }

        public void UpdateProduct(int prodId, string prodName, string price, int stock, string connectionString)
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = SqlAdapterClass.UpdateProductAdapter(connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Product");

                    DataTable productDataTable = new DataTable();
                    productDataTable = ds.Tables["Product"];

                    DataRow[] rows = productDataTable.Select("ProductID =" + prodId);
                    if (rows.Length == 1)
                    {
                        rows[0]["ProductName"] = prodName;
                        rows[0]["Price"] = price;
                        rows[0]["Stock"] = stock;
                    }

                    adapter.Update(productDataTable);
                }
            }
        }

        public void DeleteProduct(int prodId, string connectionString)
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = SqlAdapterClass.DeleteProductAdapter(connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Product");

                    DataTable productDataTable = new DataTable();
                    productDataTable = ds.Tables["Product"];

                    DataRow row = productDataTable.Rows.Find(prodId);
                    row.Delete();
                    adapter.Update(productDataTable);
                }
            }
        }
    
       // internal void InsertEmployee(int employeeId, string employeeName, string employeeAddress, int employeePhoneNumber, SqlConnection sqlConnection)
       // {
          //  throw new NotImplementedException();
        //}
    
    }

   
}