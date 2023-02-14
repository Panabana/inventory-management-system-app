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
        // public SqlConnection GetDatabaseConnection()
        // {
        // string connectionString = ConfigurationManager.ConnectionStrings
        //  ["Test"].ConnectionString;

        // SqlConnectionStringBuilder builder = new(connectionString);

        //  SqlConnection connection = new(builder.ConnectionString);

        //  return connection;  
        //   }

        public DataSet PopulatePurchaseGridView()
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = SqlAdapterClass.ViewPurchaseGrid(connection))
                {
                    DataSet dataSet = new DataSet();

                    adapter.Fill(dataSet, "Purchase");

                    return dataSet;
                }
            }
        }

        // - EMPLOYEE -
        public DataSet ViewAllEmployees()//string connectionString)
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
                connection.Open();
                
                using (SqlDataAdapter adapter = SqlAdapterClass.DeleteEmployeeAdapter(empId, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Employee");

                    DataTable empDataTable = new DataTable();
                    empDataTable = ds.Tables["Employee"];

                    DataRow[] rows = empDataTable.Select("EmployeeID =" + empId);
                    if(rows.Length > 0)
                    {
                        rows[0].Delete();
                        adapter.Update(empDataTable);
                    }
                }
            }
        }

        public void UpdateEmployee(int empId, string empName, string empAddress, int phoneNbr, string connectionString)
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = SqlAdapterClass.UpdateEmployeeAdapter(empId, empName, empAddress, phoneNbr, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Employee");

                    DataTable empDataTable = new DataTable();
                    empDataTable = ds.Tables["Employee"];

                    DataRow[] rows = empDataTable.Select("EmployeeID =" + empId);
                    if (rows.Length == 1)
                    {
                        rows[0]["EmployeeName"] = empName;
                        rows[0]["EmployeeAddress"] = empAddress;
                        rows[0]["PhoneNumber"] = phoneNbr;
                    }

                    adapter.Update(empDataTable);
                }
            }
        }

        public DataTable FindEmployee(int empID, string connectionString)
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter findEmpAdapter = SqlAdapterClass.FindEmployeeAdapter(empID, connection))
                {
                    DataTable findEmpDataTable = new();

                    findEmpAdapter.Fill(findEmpDataTable);
                    return findEmpDataTable;
                }
            }
        }
        // - CUSTOMER -
        public DataSet ViewCustomers()
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
                using (SqlDataAdapter customerAdapter = SqlAdapterClass.InsertCustomerAdapter(custId,custName, custAddress,phoneNbr,connection))
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

        /* public void DeleteCustomer(int custId, string connectionString)
         {
             using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
             {
                 connection.Open();
                 using (SqlDataAdapter customerAdapter = SqlAdapterClass.DeleteCustomerAdapter(custId,connection))
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
        */ //}

        public void DeleteCustomer(int custId, string connectionString)
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter customerAdapter = SqlAdapterClass.DeleteCustomerAdapter(custId,connection))
                {
                    DataSet ds = new DataSet();
                    customerAdapter.Fill(ds, "Customer");

                    DataTable customerDataTable = new DataTable();
                    customerDataTable = ds.Tables["Customer"];

                    DataRow[] rows = customerDataTable.Select("CustomerID = " + custId.ToString());
                    if (rows.Length > 0)
                    {
                        rows[0].Delete();
                        customerAdapter.Update(customerDataTable);
                    }
                }
            }
        }


        public void UpdateCustomer(int custId, string custName, string custAddress, int phoneNbr, string connectionString)
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = SqlAdapterClass.UpdateCustomerAdapter(custId, custName, custAddress, phoneNbr,connection))
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

        public DataTable FindCustomer(int customerId, string connectionString)
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = SqlAdapterClass.FindCustomerAdapter(customerId, connection))
                {
                    DataTable findCustomerDataTable = new();

                    adapter.Fill(findCustomerDataTable);
                    return findCustomerDataTable;
                }
            }
        }

        // - SUPPLIER -
        public DataSet ViewSuppliers()
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
                using (SqlDataAdapter AddSupplierAdapter = SqlAdapterClass.InsertSupplierAdapter(suppId, suppName, suppAddress, phoneNbr, connection))
                {
                    DataSet ds = new DataSet();
                    AddSupplierAdapter.Fill(ds, "Supplier");

                    DataTable supplierDataTable = new DataTable();
                    supplierDataTable = ds.Tables["Supplier"];
                    
                    DataRow row = supplierDataTable.NewRow();
                    row["SupplierID"] = suppId;
                    row["SupplierName"] = suppName;
                    row["SupplierAddress"] = suppAddress;
                    row["PhoneNumber"] = phoneNbr;

                    supplierDataTable.Rows.Add(row);
                    AddSupplierAdapter.Update(supplierDataTable);
                }
            }
        }

        public void DeleteSupplier(int suppId, string connectionString)
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter addSupplierAdapter = SqlAdapterClass.DeleteSupplierAdapter(suppId,connection))
                {
                    DataSet ds = new DataSet();
                    addSupplierAdapter.Fill(ds, "Supplier");

                    DataTable supplierDataTable = new DataTable();
                    supplierDataTable = ds.Tables["Supplier"];

                    DataRow[] rows = supplierDataTable.Select("SupplierID = " + suppId.ToString());
                    if (rows.Length > 0)
                    {
                        rows[0].Delete();
                        addSupplierAdapter.Update(supplierDataTable);
                    }
                }
            }
        }

        public void UpdateSupplier(int suppId, string suppName, string suppAddress, int phoneNbr, string connectionString)
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = SqlAdapterClass.UpdateSupplierAdapter(suppId, suppName, suppAddress, phoneNbr,connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Supplier");

                    DataTable suppDataTable = new DataTable();
                    suppDataTable = ds.Tables["Supplier"];

                    DataRow[] rows = suppDataTable.Select("SupplierID =" + suppId);
                    if (rows.Length == 1)
                    {
                        rows[0]["SupplierName"] = suppName;
                        rows[0]["SupplierAddress"] = suppAddress;
                        rows[0]["PhoneNumber"] = phoneNbr;
                    }

                    adapter.Update(suppDataTable);
                }
            }
        }

        public DataTable FindSupplier(int supplierID, string connectionString)
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter findSupplierAdapter = SqlAdapterClass.FindSupplierAdapter(supplierID, connection))
                {
                    DataTable findSupplierDataTable = new();

                    findSupplierAdapter.Fill(findSupplierDataTable);
                    return findSupplierDataTable;
                }
            }
        }

        // - PRODUCT -
        public DataSet ViewProducts()
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

        public void InsertProduct(int productId, string productName, int productPrice, string connectionString)
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                connection.Open();

                using (SqlDataAdapter adapter = SqlAdapterClass.InsertProductAdapter(productId, productName, productPrice, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Product");

                    DataTable productDataTable = new DataTable();
                    productDataTable = ds.Tables["Product"];

                    DataRow row = productDataTable.NewRow();
                    row["ProductID"] = productId;
                    row["ProductName"] = productName;
                    row["Price"] = productPrice;

                    productDataTable.Rows.Add(row);
                    adapter.Update(productDataTable);
                }
            }
        }

        public void UpdateProduct(int productId, string productName, int productPrice, string connectionString)
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = SqlAdapterClass.UpdateProductAdapter(productId, productName, productPrice, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Product");

                    DataTable productDataTable = new DataTable();
                    productDataTable = ds.Tables["Product"];

                    DataRow[] rows = productDataTable.Select("ProductID =" + productId);
                    if (rows.Length == 1)
                    {
                        rows[0]["ProductName"] = productName;
                        rows[0]["Price"] = productPrice;
                    }

                    adapter.Update(productDataTable);
                }
            }
        }

        public void DeleteProduct(int productId, string connectionString)
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {

                using (SqlDataAdapter productAdapter = SqlAdapterClass.DeleteProductAdapter(productId, connection))
                {
                    DataSet ds = new DataSet();
                    productAdapter.Fill(ds, "Product");

                    DataTable productDataTable = new DataTable();
                    productDataTable = ds.Tables["Product"];

                    DataRow[] rows = productDataTable.Select("ProductID = " + productId.ToString());
                    if (rows.Length > 0)
                    {
                        rows[0].Delete();
                        productAdapter.Update(productDataTable);
                    }
                }
            }
        }

        public DataTable FindProduct(int productID, string connectionString)
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter findProductAdapter = SqlAdapterClass.FindProductAdapter(productID, connection))
                {
                    DataTable findProductDataTable = new();

                    findProductAdapter.Fill(findProductDataTable);
                    return findProductDataTable;
                }
            }
        }

        // internal void InsertEmployee(int employeeId, string employeeName, string employeeAddress, int employeePhoneNumber, SqlConnection sqlConnection)
        // {
        //  throw new NotImplementedException();
        //}


        // - Purchase -
        public DataSet ViewPurchase()
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = SqlAdapterClass.ViewAllPurchaseAdapter(connection))
                {
                    DataSet dataSet = new DataSet();

                    adapter.Fill(dataSet, "Purchase");

                    return dataSet;
                }
            }
        }
            
        
        public void InsertPurchase(int purchaseId, int customerId, int employeeId)
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                connection.Open();

                using (SqlDataAdapter adapter = SqlAdapterClass.InsertPurchaseAdapter(purchaseId, customerId, employeeId, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Purchase");

                    DataTable purchaseDataTable = new DataTable();
                    purchaseDataTable = ds.Tables["Purchase"];

                    DataRow row = purchaseDataTable.NewRow();
                    row["PurchaseID"] = purchaseId;
                    row["CustomerID"] = customerId;
                    row["EmployeeID"] = employeeId;

                    purchaseDataTable.Rows.Add(row);
                    adapter.Update(purchaseDataTable);
                }
            }
        }

        public void DeletePurchase(int purchaseID)
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter purchaseAdapter = SqlAdapterClass.DeletePurchaseAdapter(purchaseID, connection))
                {
                    DataSet ds = new DataSet();
                    purchaseAdapter.Fill(ds, "Purchase");

                    DataTable purchaseDataTable = new DataTable();
                    purchaseDataTable = ds.Tables["Purchase"];
                    
                    DataRow[] rows = purchaseDataTable.Select("PurchaseID = " + purchaseID.ToString());
                    if (rows.Length > 0)
                    {
                        rows[0].Delete();
                        purchaseAdapter.Update(purchaseDataTable);
                    }
                }
            }
        }

        // - ProductPurchase -

        public void InsertProductPurchase(int purchaseID, int productID, int quantity)
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                connection.Open();

                using (SqlDataAdapter productPurchaseAdapter = SqlAdapterClass.InsertProductPurchaseAdapter(purchaseID, productID, quantity, connection))
                {
                    DataSet dataSet = new DataSet();

                    productPurchaseAdapter.Fill(dataSet, "ProductPurchase");

                    DataTable productPurchaseDataTable = dataSet.Tables["ProductPurchase"];

                    DataRow row = productPurchaseDataTable.NewRow();
                    row["PurchaseID"] = purchaseID;
                    row["ProductID"] = productID;
                    row["Quantity"] = quantity;

                    productPurchaseDataTable.Rows.Add(row);
                    productPurchaseAdapter.Update(productPurchaseDataTable);

                }
            }
        }

        // - PRODUCT_SUPPLIER -

        public void InsertSupplierProduct(int supplierID, int productID)
        {

            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                connection.Open();

                using (SqlDataAdapter supplierProductAdapter = SqlAdapterClass.InsertSupplierProductAdapter(supplierID, productID, connection))
                {
                    DataSet dataSet = new DataSet();

                    supplierProductAdapter.Fill(dataSet, "ProductSupplier");

                    DataTable supplierProductDataTable = dataSet.Tables["ProductSupplier"];

                    DataRow row = supplierProductDataTable.NewRow();
                    row["SupplierID"] = supplierID;
                    row["ProductID"] = productID;

                    supplierProductDataTable.Rows.Add(row);
                    supplierProductAdapter.Update(supplierProductDataTable);

                }
            }
        }




    }


}