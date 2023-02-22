using DevExpress.PivotGrid.CustomFunctions;
using DevExpress.XtraCharts.Designer.Native;
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
        public DataSet PopulatePurchaseGridView()
        {
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = AdapterManager.ViewPurchaseGrid(connection))
                {
                    DataSet dataSet = new DataSet();

                    adapter.Fill(dataSet, "Purchase");

                    return dataSet;
                }
            }
        }

        // - EMPLOYEE -
        public DataSet ViewAllEmployees()
        {

            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter empAdapter = AdapterManager.ViewAllEmployeeAdapter(connection))
                {
                    DataSet dataSet = new DataSet();

                    empAdapter.Fill(dataSet, "Employee");

                    return dataSet;
                }
            }
        }

        public void AddEmployee(
            int employeeId
            , string employeeName
            , string employeeAddress
            , int phoneNumber)
        {
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = AdapterManager.EmployeeAdapter(connection))
                {

                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);

                    DataTable dataTableEmp = new DataTable();
                    DataTable empDataTable = dataSet.Tables["Table"];

                    DataRow row = empDataTable.NewRow();

                    row["EmployeeID"] = employeeId;
                    row["EmployeeName"] = employeeName;
                    row["EmployeeAddress"] = employeeAddress;
                    row["PhoneNumber"] = phoneNumber;

                    empDataTable.Rows.Add(row);
                    adapter.Update(dataSet);
                }
            }
        }
        public void DeleteEmployee(int employeeId)
        {
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = AdapterManager.EmployeeAdapter(connection))
                {
                    adapter.DeleteCommand.Parameters[0].Value = employeeId;

                    connection.Open();
                    adapter.DeleteCommand.ExecuteNonQuery();
                }
            }
        }
        public void UpdateEmployee(
            int employeeId,
            string employeeName,
            string employeeAddress,
            int phoneNumber)
        {
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = AdapterManager.EmployeeAdapter(connection))
                {
                    adapter.UpdateCommand.Parameters[0].Value = employeeId;
                    adapter.UpdateCommand.Parameters[1].Value = employeeName;
                    adapter.UpdateCommand.Parameters[2].Value = employeeAddress;
                    adapter.UpdateCommand.Parameters[3].Value = phoneNumber;

                    connection.Open();
                    adapter.UpdateCommand.ExecuteNonQuery();
                }
            }

        }

        public DataSet ReadEmployees()
        {
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = AdapterManager.EmployeeAdapter(connection))
                {
                    DataSet employeeDataSet = new DataSet();
                    adapter.Fill(employeeDataSet);
                    return employeeDataSet;
                }
            }
        }

       

        public void InsertEmployee(int EmployeeID, string EmployeeName, string EmployeeAddress, int PhoneNumber, string connectionString)
        {
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                connection.Open();

                using (SqlDataAdapter empAdapter = AdapterManager.InsertEmployeeAdapter(EmployeeID, EmployeeName, EmployeeAddress, PhoneNumber, connection))
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

        public void RemoveEmployee(int empId, string connectionString)
        {
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                connection.Open();

                using (SqlDataAdapter adapter = AdapterManager.DeleteEmployeeAdapter(empId, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Employee");

                    DataTable empDataTable = new DataTable();
                    empDataTable = ds.Tables["Employee"];

                    DataRow[] rows = empDataTable.Select("EmployeeID =" + empId);
                    if (rows.Length > 0)
                    {
                        rows[0].Delete();
                        adapter.Update(empDataTable);
                    }
                }
            }
        }

        public void EditEmployee(int empId, string empName, string empAddress, int phoneNbr, string connectionString)
        {
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = AdapterManager.UpdateEmployeeAdapter(empId, empName, empAddress, phoneNbr, connection))
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
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter findEmpAdapter = AdapterManager.FindEmployeeAdapter(empID, connection))
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
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter customerAdapter = AdapterManager.ViewCustomerAdapter(connection))
                {
                    DataSet ds = new DataSet();

                    customerAdapter.Fill(ds, "Customer");
                    return ds;
                }
            }

        }

        public void InsertCustomer(int custId, string custName, string custAddress, int phoneNbr, string connectionString)
        {
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter customerAdapter = AdapterManager.InsertCustomerAdapter(custId, custName, custAddress, phoneNbr, connection))
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
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter customerAdapter = AdapterManager.DeleteCustomerAdapter(custId, connection))
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
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = AdapterManager.UpdateCustomerAdapter(custId, custName, custAddress, phoneNbr, connection))
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
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = AdapterManager.FindCustomerAdapter(customerId, connection))
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
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = AdapterManager.ViewSupplierAdapter(connection))
                {
                    DataSet ds = new DataSet();

                    adapter.Fill(ds, "Supplier");
                    return ds;
                }
            }
        }
        public void InsertSupplier(int suppId, string suppName, string suppAddress, int phoneNbr, string connectionString)
        {
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter AddSupplierAdapter = AdapterManager.InsertSupplierAdapter(suppId, suppName, suppAddress, phoneNbr, connection))
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
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter addSupplierAdapter = AdapterManager.DeleteSupplierAdapter(suppId, connection))
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
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = AdapterManager.UpdateSupplierAdapter(suppId, suppName, suppAddress, phoneNbr, connection))
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
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter findSupplierAdapter = AdapterManager.FindSupplierAdapter(supplierID, connection))
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
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = AdapterManager.ViewAllProductAdapter(connection))
                {
                    DataSet dataSet = new DataSet();

                    adapter.Fill(dataSet, "Product");

                    return dataSet;
                }
            }
        }

        public void InsertProduct(int productId, string productName, int productPrice, string connectionString)
        {
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                connection.Open();

                using (SqlDataAdapter adapter = AdapterManager.InsertProductAdapter(productId, productName, productPrice, connection))
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
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = AdapterManager.UpdateProductAdapter(productId, productName, productPrice, connection))
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
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {

                using (SqlDataAdapter productAdapter = AdapterManager.DeleteProductAdapter(productId, connection))
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
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter findProductAdapter = AdapterManager.FindProductAdapter(productID, connection))
                {
                    DataTable findProductDataTable = new();

                    findProductAdapter.Fill(findProductDataTable);
                    return findProductDataTable;
                }
            }
        }


        // - Purchase -
        public DataSet ViewPurchase()
        {
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = AdapterManager.ViewAllPurchaseAdapter(connection))
                {
                    DataSet dataSet = new DataSet();

                    adapter.Fill(dataSet, "Purchase");

                    return dataSet;
                }
            }
        }


        public void InsertPurchase(int purchaseId, int customerId, int employeeId)
        {
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                connection.Open();

                using (SqlDataAdapter adapter = AdapterManager.InsertPurchaseAdapter(purchaseId, customerId, employeeId, connection))
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
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter purchaseAdapter = AdapterManager.DeletePurchaseAdapter(purchaseID, connection))
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
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                connection.Open();

                using (SqlDataAdapter productPurchaseAdapter = AdapterManager.InsertProductPurchaseAdapter(purchaseID, productID, quantity, connection))
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

        public void DeleteProductPurchase(int purchaseID, int productID)
        {
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter productPurchaseAdapter = AdapterManager.DeleteProductPurchaseAdapter(purchaseID, productID, connection))
                {
                    DataSet ds = new DataSet();
                    productPurchaseAdapter.Fill(ds, "ProductPurchase");

                    DataTable productPurchaseDataTable = new DataTable();
                    productPurchaseDataTable = ds.Tables["ProductPurchase"];

                    DataRow[] rows = productPurchaseDataTable.Select("PurchaseID = " + purchaseID.ToString() + " AND ProductID = " + productID.ToString());
                    if (rows.Length > 0)
                    {
                        rows[0].Delete();
                        productPurchaseAdapter.Update(productPurchaseDataTable);
                    }
                }
            }
        }

        // - PRODUCT_SUPPLIER -

        public void InsertSupplierProduct(int supplierID, int productID)
        {

            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                connection.Open();

                using (SqlDataAdapter supplierProductAdapter = AdapterManager.InsertSupplierProductAdapter(supplierID, productID, connection))
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

        public DataTable FindPurchase(int purchaseId, string connectionString)
        {
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = AdapterManager.FindPurchaseAdapter(purchaseId, connection))
                {
                    DataTable findPurchaseDataTable = new();

                    adapter.Fill(findPurchaseDataTable);
                    return findPurchaseDataTable;
                }
            }
        }



    }


}