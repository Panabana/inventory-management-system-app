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

        public DataSet PopulatePurchaseGridView()
        {
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = AdapterManager.ViewPurchaseGrid(connection))
                {
                    DataSet dataSet = new DataSet();

                    adapter.Fill(dataSet);

                    return dataSet;
                }
            }
        }

        public void AddCustomer(
            int customerId
            , string customerName
            , string customerAddress
            , int phoneNumber)
        {
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = AdapterManager.CustomerAdapter(connection))
                {

                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);

                    DataTable dataTableCust = new DataTable();
                    DataTable CustomerDataTable = dataSet.Tables["Table"];

                    DataRow row = CustomerDataTable.NewRow();

                    row["CustomerID"] = customerId;
                    row["CustomerName"] = customerName;
                    row["CustomerAddress"] = customerAddress;
                    row["PhoneNumber"] = phoneNumber;

                    dataTableCust.Rows.Add(row);
                    adapter.Update(dataSet);
                }
            }
        }
        public void DeleteCustomer(int customerId)
        {
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = AdapterManager.CustomerAdapter(connection))
                {
                    adapter.DeleteCommand.Parameters[0].Value = customerId;

                    connection.Open();
                    adapter.DeleteCommand.ExecuteNonQuery();
                }
            }
        }
        public void UpdateCustomer(
            int customerId,
            string customerName,
            string customerAddress,
            int phoneNumber)
        {
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = AdapterManager.CustomerAdapter(connection))
                {
                    adapter.UpdateCommand.Parameters[0].Value = customerId;
                    adapter.UpdateCommand.Parameters[1].Value = customerName;
                    adapter.UpdateCommand.Parameters[2].Value = customerAddress;
                    adapter.UpdateCommand.Parameters[3].Value = phoneNumber;

                    connection.Open();
                    adapter.UpdateCommand.ExecuteNonQuery();
                }
            }

        }
        public DataSet ReadCustomer()
        {
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = AdapterManager.CustomerAdapter(connection))
                {
                    DataSet customerDataSet = new DataSet();
                    adapter.Fill(customerDataSet);
                    return customerDataSet;
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

        // - EMPLOYEE -
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
                    DataTable employeeDataTable = dataSet.Tables["Table"];

                    DataRow row = employeeDataTable.NewRow();

                    row["EmployeeID"] = employeeId;
                    row["EmployeeName"] = employeeName;
                    row["EmployeeAddress"] = employeeAddress;
                    row["PhoneNumber"] = phoneNumber;

                    dataTableEmp.Rows.Add(row);
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
        public DataSet ReadEmployee()
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

        public void UpdatePurchase(int purchaseId, int customerId, int employeeId)
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = SqlAdapterClass.UpdatePurchaseAdapter(purchaseId, customerId, employeeId, connection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Purchase");

                    DataTable purchaseDataTable = new DataTable();
                    purchaseDataTable = ds.Tables["Purchase"];

                    DataRow[] rows = purchaseDataTable.Select("PurchaseID =" + purchaseId);
                    if (rows.Length == 1)
                    {
                        rows[0]["CustomerID"] = customerId;
                        rows[0]["EmployeeID"] = employeeId;
                    }

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

        public void DeleteProductPurchase(int purchaseID, int productID)
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter productPurchaseAdapter = SqlAdapterClass.DeleteProductPurchaseAdapter(purchaseID, productID, connection))
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

        public DataTable FindPurchase(int purchaseId, string connectionString)
        {
            using (SqlConnection connection = SqlAdapterClass.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = SqlAdapterClass.FindPurchaseAdapter(purchaseId, connection))
                {
                    DataTable findPurchaseDataTable = new();

                    adapter.Fill(findPurchaseDataTable);
                    return findPurchaseDataTable;
                }
            }
        }



    }


}