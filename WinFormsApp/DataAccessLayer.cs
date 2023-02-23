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

                    CustomerDataTable.Rows.Add(row);
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

                    employeeDataTable.Rows.Add(row);
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
        public void AddSupplier(
            int supplierId
            , string supplierName
            , string supplierAddress
            , int phoneNumber)
        {
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = AdapterManager.SupplierAdapter(connection))
                {

                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);

                    DataTable dataTableSup = new DataTable();
                    DataTable supplierDataTable = dataSet.Tables["Table"];

                    DataRow row = supplierDataTable.NewRow();

                    row["SupplierID"] = supplierId;
                    row["SupplierName"] = supplierName;
                    row["SupplierAddress"] = supplierAddress;
                    row["PhoneNumber"] = phoneNumber;

                    supplierDataTable.Rows.Add(row);
                    adapter.Update(dataSet);
                }
            }
        }
        public void DeleteSupplier(int supplierId)
        {
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = AdapterManager.SupplierAdapter(connection))
                {
                    adapter.DeleteCommand.Parameters[0].Value = supplierId;

                    connection.Open();
                    adapter.DeleteCommand.ExecuteNonQuery();
                }
            }
        }
        public void UpdateSupplier(
            int supplierId,
            string supplierName,
            string supplierAddress,
            int phoneNumber)
        {
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = AdapterManager.SupplierAdapter(connection))
                {
                    adapter.UpdateCommand.Parameters[0].Value = supplierId;
                    adapter.UpdateCommand.Parameters[1].Value = supplierName;
                    adapter.UpdateCommand.Parameters[2].Value = supplierAddress;
                    adapter.UpdateCommand.Parameters[3].Value = phoneNumber;

                    connection.Open();
                    adapter.UpdateCommand.ExecuteNonQuery();
                }
            }

        }
        public DataSet ReadSupplier()
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
        public void AddProduct(
            int productId
            , string productName
            , decimal price)
            
        {
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = AdapterManager.ProductAdapter(connection))
                {

                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);

                    DataTable dataTableProd = new DataTable();
                    DataTable productDataTable = dataSet.Tables["Table"];

                    DataRow row = productDataTable.NewRow();

                    row["ProductID"] = productId;
                    row["ProductName"] =productName;
                    row["Price"] = price;
                   

                    productDataTable.Rows.Add(row);
                    adapter.Update(dataSet);
                }
            }
        }
        public void DeleteProduct(int productId)
        {
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = AdapterManager.ProductAdapter(connection))
                {
                    adapter.DeleteCommand.Parameters[0].Value = productId;

                    connection.Open();
                    adapter.DeleteCommand.ExecuteNonQuery();
                }
            }
        }
        public void UpdateProduct(
            int productId,
            string productName,
            decimal price)
            
        {
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = AdapterManager.ProductAdapter(connection))
                {
                    adapter.UpdateCommand.Parameters[0].Value = productId;
                    adapter.UpdateCommand.Parameters[1].Value = productName;
                    adapter.UpdateCommand.Parameters[2].Value = price;
                    

                    connection.Open();
                    adapter.UpdateCommand.ExecuteNonQuery();
                }
            }

        }
        public DataSet ReadProduct()
        {
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = AdapterManager.ProductAdapter(connection))
                {
                    DataSet productDataSet = new DataSet();
                    adapter.Fill(productDataSet);
                    return productDataSet;
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

        public int CheckActivePurchases(int purchaseId)
        {
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = AdapterManager.CheckActivePurchaseAdapter(connection))
                {
                    int amount = adapter.SelectCommand;
                    return;
                }
            }
        }

        public void AddPurchase(
              int purchaseId
            , int employeeId
            , int customerId)

        {
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = AdapterManager.PurchaseAdapter(connection))
                {

                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);

                    DataTable dataTablePurchase = new DataTable();
                    DataTable purchaseDataTable = dataSet.Tables["Table"];

                    DataRow row = purchaseDataTable.NewRow();

                    row["PurchaseID"] = purchaseId;
                    row["EmployeeID"] = employeeId;
                    row["CustomerID"] = customerId;


                    purchaseDataTable.Rows.Add(row);
                    adapter.Update(dataSet);
                }
            }
        }
        public void DeletePurchase(int purchaseId)
        {
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = AdapterManager.PurchaseAdapter(connection))
                {
                    adapter.DeleteCommand.Parameters[0].Value = purchaseId;

                    connection.Open();
                    adapter.DeleteCommand.ExecuteNonQuery();
                }
            }
        }
        public void UpdatePurchase(
            int purchaseId,
            int employeeId,
            int customerId)

        {
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = AdapterManager.PurchaseAdapter(connection))
                {
                    adapter.UpdateCommand.Parameters[0].Value = purchaseId;
                    adapter.UpdateCommand.Parameters[1].Value = employeeId;
                    adapter.UpdateCommand.Parameters[2].Value = customerId;


                    connection.Open();
                    adapter.UpdateCommand.ExecuteNonQuery();
                }
            }

        }
        public DataSet ReadPurchase()
        {
            using (SqlConnection connection = AdapterManager.ConnectionHandler.GetDatabaseConnection())
            {
                using (SqlDataAdapter adapter = AdapterManager.PurchaseAdapter(connection))
                {
                    DataSet productDataSet = new DataSet();
                    adapter.Fill(productDataSet);
                    return productDataSet;
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