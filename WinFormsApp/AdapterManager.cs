using DevExpress.CodeParser;
using DevExpress.DataAccess.Sql;
using DevExpress.DataProcessing.InMemoryDataProcessor;
using DevExpress.Pdf.Native.BouncyCastle.Ocsp;
using DevExpress.Pdf.Xmp;
using DevExpress.Utils.About;
using DevExpress.XtraRichEdit.Commands;
using DevExpress.XtraSpreadsheet.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    class AdapterManager
    {
        internal class ConnectionHandler
        {
            public static SqlConnection GetDatabaseConnection()
            {
                string connectionString = ConfigurationManager.ConnectionStrings
                    ["Test"].ConnectionString;

                SqlConnectionStringBuilder builder = new(connectionString);

                SqlConnection connection = new(builder.ConnectionString);

                return connection;
            }
        }

        public static SqlDataAdapter ViewPurchaseGrid(SqlConnection connection)
        {
            SqlDataAdapter adapter = new();
            SqlCommand command = new SqlCommand("SELECT p.PurchaseID, c.CustomerName, p.CustomerID, pro.ProductName, pp.Quantity,  pp.ProductID, e.EmployeeName, p.EmployeeID FROM Purchase p JOIN ProductPurchase pp ON p.PurchaseID = pp.PurchaseID Join Product pro ON pro.ProductID = pp.ProductID Join Customer c ON c.CustomerID = p.CustomerID Join Employee e ON e.EmployeeID = p.EmployeeID");
            command.Connection = connection;
            adapter.SelectCommand = command;
            return adapter;
        }

        public static SqlDataAdapter ViewPurchaseGridFind(int purchaseId, SqlConnection connection)
        {
            SqlDataAdapter adapter = new();
            SqlCommand command = new SqlCommand("SELECT p.PurchaseID, c.CustomerName, p.CustomerID, pro.ProductName, pp.Quantity,  pp.ProductID, e.EmployeeName, p.EmployeeID FROM Purchase p JOIN ProductPurchase pp ON p.PurchaseID = pp.PurchaseID Join Product pro ON pro.ProductID = pp.ProductID Join Customer c ON c.CustomerID = p.CustomerID Join Employee e ON e.EmployeeID = p.EmployeeID WHERE p.PurchaseID = @PurchaseID");
            command.Connection = connection;
            command.Parameters.AddWithValue("@PurchaseID", purchaseId);
            adapter.SelectCommand = command;
            return adapter;
        }

        public static SqlDataAdapter ViewCustomerGrid(SqlConnection connection)
        {
            SqlDataAdapter adapter = new();
            SqlCommand command = new SqlCommand("SELECT CustomerID, CustomerName, CustomerAddress, PhoneNumber FROM Customer");
            command.Connection = connection;
            adapter.SelectCommand = command;
            return adapter;
        }

        public static SqlDataAdapter ViewCustomerGridFind(int customerId, SqlConnection connection)
        {
            SqlDataAdapter adapter = new();
            SqlCommand command = new SqlCommand("SELECT * FROM Customer WHERE CustomerID = @CustomerID");
            command.Connection = connection;
            command.Parameters.AddWithValue("@CustomerID", customerId);
            adapter.SelectCommand = command;
            return adapter;
        }

        public static SqlDataAdapter ViewEmployeeGrid(SqlConnection connection)
        {
            SqlDataAdapter adapter = new();
            SqlCommand command = new SqlCommand("SELECT * FROM Employee");
            command.Connection = connection;
            adapter.SelectCommand = command;
            return adapter;
        }

        public static SqlDataAdapter ViewEmployeeGridFind(int employeeId, SqlConnection connection)
        {
            SqlDataAdapter adapter = new();
            SqlCommand command = new SqlCommand("SELECT * FROM Employee WHERE EmployeeId = @EmployeeID");
            command.Connection = connection;
            command.Parameters.AddWithValue("@EmployeeID", employeeId);
            adapter.SelectCommand = command;
            return adapter;
        }

        public static SqlDataAdapter ViewProductGrid(SqlConnection connection)
        {
            SqlDataAdapter adapter = new();
            SqlCommand command = new SqlCommand("SELECT * FROM Product");
            command.Connection = connection;
            adapter.SelectCommand = command;
            return adapter;
        }

        public static SqlDataAdapter ViewProductGridFind(int productId, SqlConnection connection)
        {
            SqlDataAdapter adapter = new();
            SqlCommand command = new SqlCommand("SELECT * FROM Product WHERE ProductId = @ProductID");
            command.Connection = connection;
            command.Parameters.AddWithValue("@ProductId", productId);
            adapter.SelectCommand = command;
            return adapter;
        }

        public static SqlDataAdapter ViewSupplierGrid(SqlConnection connection)
        {
            SqlDataAdapter adapter = new();
            SqlCommand command = new SqlCommand("SELECT * FROM Supplier");
            command.Connection = connection;
            adapter.SelectCommand = command;
            return adapter;
        }

        public static SqlDataAdapter ViewSupplierGridFind(int supplierId, SqlConnection connection)
        {
            SqlDataAdapter adapter = new();
            SqlCommand command = new SqlCommand("SELECT * FROM Supplier WHERE SupplierId = @SupplierID");
            command.Connection = connection;
            command.Parameters.AddWithValue("@SupplierId", supplierId);
            adapter.SelectCommand = command;
            return adapter;
        }


       

        // - CUSTOMER -
        public static SqlDataAdapter CustomerAdapter(SqlConnection connection)
        {
            SqlDataAdapter customerAdapter = new SqlDataAdapter();
            SqlCommand command;

            command = new SqlCommand("SELECT * FROM Customer", connection);
            command.Connection = connection;
            customerAdapter.SelectCommand = command;

            command = new SqlCommand(
                "INSERT INTO Customer VALUES (@CustomerID, @CustomerName, @CustomerAddress, @PhoneNumber)",
                connection);

            command.Parameters.Add("@CustomerID", SqlDbType.Int, 10, "CustomerID");
            command.Parameters.Add("@CustomerName", SqlDbType.VarChar, 10, "CustomerName");
            command.Parameters.Add("@CustomerAddress", SqlDbType.VarChar, 10, "CustomerAddress");
            command.Parameters.Add("@PhoneNumber", SqlDbType.Int, 10, "PhoneNumber");
            command.Connection = connection;
            customerAdapter.InsertCommand = command;

            command = new SqlCommand("DELETE FROM Customer WHERE CustomerID = @CustomerID", connection);
            command.Parameters.Add("@CustomerID", SqlDbType.Int, 10, "CustomerID");
            command.Connection = connection;
            customerAdapter.DeleteCommand = command;

            command = new SqlCommand("UPDATE Customer SET CustomerName = @CustomerName, CustomerAddress = @CustomerAddress, PhoneNumber = @PhoneNumber WHERE CustomerID = @CustomerID", connection);

            command.Parameters.Add("@CustomerID", SqlDbType.Int, 10, "CustomerID");
            command.Parameters.Add("@CustomerName", SqlDbType.VarChar, 10, "CustomerName");
            command.Parameters.Add("@CustomerAddress", SqlDbType.VarChar, 10, "CustomerAddress");
            command.Parameters.Add("@PhoneNumber", SqlDbType.Int, 10, "PhoneNumber");

            command.Connection = connection;
            customerAdapter.UpdateCommand = command;


            return customerAdapter;
        }

        public static SqlDataAdapter FindCustomerAdapter(int customerId, SqlConnection connection)
        {
            SqlDataAdapter adapter = new();

            SqlCommand command = new SqlCommand("SELECT CustomerID, CustomerName, CustomerAddress, PhoneNumber FROM Customer WHERE CustomerID = @CustomerID", connection);

            command.Parameters.AddWithValue("@CustomerID", customerId);
            adapter.SelectCommand = command;

            return adapter;
        }

        // - EMPLOYEE -
        public static SqlDataAdapter EmployeeAdapter(SqlConnection connection)
        {
            SqlDataAdapter employeeAdapter = new SqlDataAdapter();
            SqlCommand command;

            command = new SqlCommand("SELECT * FROM Employee", connection);
            command.Connection = connection;
            employeeAdapter.SelectCommand = command;

            command = new SqlCommand(
                "INSERT INTO Employee VALUES (@EmployeeID, @EmployeeName, @EmployeeAddress, @PhoneNumber)",
                connection);

            command.Parameters.Add("@EmployeeID", SqlDbType.Int, 10, "EmployeeID");
            command.Parameters.Add("@EmployeeName", SqlDbType.VarChar, 10, "EmployeeName");
            command.Parameters.Add("@EmployeeAddress", SqlDbType.VarChar, 10, "EmployeeAddress");
            command.Parameters.Add("@PhoneNumber", SqlDbType.Int, 10, "PhoneNumber");
            command.Connection = connection;
            employeeAdapter.InsertCommand = command;

            command = new SqlCommand("DELETE FROM Employee WHERE EmployeeID = @EmployeeID", connection);
            command.Parameters.Add("@EmployeeID", SqlDbType.Int, 10, "EmployeeID");
            command.Connection = connection;
            employeeAdapter.DeleteCommand = command;

            command = new SqlCommand("UPDATE Employee SET EmployeeName = @EmployeeName, EmployeeAddress = @EmployeeAddress, PhoneNumber = @PhoneNumber WHERE EmployeeID = @EmployeeID", connection);

            command.Parameters.Add("@EmployeeID", SqlDbType.Int, 10, "EmployeeID");
            command.Parameters.Add("@EmployeeName", SqlDbType.VarChar, 10, "EmployeeName");
            command.Parameters.Add("@EmployeeAddress", SqlDbType.VarChar, 10, "EmployeeAddress");
            command.Parameters.Add("@PhoneNumber", SqlDbType.Int, 10, "PhoneNumber");

            command.Connection = connection;
            employeeAdapter.UpdateCommand = command;


            return employeeAdapter;
        }

        public static SqlDataAdapter FindEmployeeAdapter(int empId, SqlConnection connection)
        {
            SqlDataAdapter empFindAdapter = new();
            string query = "SELECT EmployeeID, EmployeeName, EmployeeAddress, PhoneNumber FROM Employee WHERE EmployeeID = @EmployeeID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@EmployeeID", empId);
            empFindAdapter.SelectCommand = command;

            return empFindAdapter;
        }

        // - SUPPLIER -
        public static SqlDataAdapter SupplierAdapter(SqlConnection connection)
        {
            SqlDataAdapter supplierAdapter = new SqlDataAdapter();
            SqlCommand command;

            command = new SqlCommand("SELECT * FROM Supplier", connection);
            command.Connection = connection;
            supplierAdapter.SelectCommand = command;

            command = new SqlCommand(
                "INSERT INTO Supplier VALUES (@SupplierID, @SupplierName, @SupplierAddress, @PhoneNumber)",
                connection);

            command.Parameters.Add("@SupplierID", SqlDbType.Int, 10, "SupplierID");
            command.Parameters.Add("@SupplierName", SqlDbType.VarChar, 10, "SupplierName");
            command.Parameters.Add("@SupplierAddress", SqlDbType.VarChar, 10, "SupplierAddress");
            command.Parameters.Add("@PhoneNumber", SqlDbType.Int, 10, "PhoneNumber");
            command.Connection = connection;
            supplierAdapter.InsertCommand = command;

            command = new SqlCommand("DELETE FROM Supplier WHERE SupplierID = @SupplierID", connection);
            command.Parameters.Add("@SupplierID", SqlDbType.Int, 10, "SupplierID");
            command.Connection = connection;
            supplierAdapter.DeleteCommand = command;

            command = new SqlCommand("UPDATE Supplier SET SupplierName = @SupplierName, SupplierAddress = @SupplierAddress, PhoneNumber = @PhoneNumber WHERE SupplierID = @SupplierID", connection);

            command.Parameters.Add("@SupplierID", SqlDbType.Int, 10, "SupplierID");
            command.Parameters.Add("@SupplierName", SqlDbType.VarChar, 10, "SupplierName");
            command.Parameters.Add("@SupplierAddress", SqlDbType.VarChar, 10, "SupplierAddress");
            command.Parameters.Add("@PhoneNumber", SqlDbType.Int, 10, "PhoneNumber");

            command.Connection = connection;
            supplierAdapter.UpdateCommand = command;


            return supplierAdapter;
        }

        public static SqlDataAdapter FindSupplierAdapter(int supplierID, SqlConnection connection)
        {
            SqlDataAdapter empFindAdapter = new();
            string query = "SELECT SupplierID, SupplierName, SupplierAddress, PhoneNumber FROM Supplier WHERE SupplierID = @SupplierID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@SupplierID", supplierID);
            empFindAdapter.SelectCommand = command;

            return empFindAdapter;
        }

        // - PRODUCT -
        public static SqlDataAdapter ProductAdapter(SqlConnection connection)
        {
            SqlDataAdapter productAdapter = new SqlDataAdapter();
            SqlCommand command;

            command = new SqlCommand("SELECT * FROM Product", connection);
            command.Connection = connection;
            productAdapter.SelectCommand = command;

            command = new SqlCommand(
                "INSERT INTO Product VALUES (@ProductID, @ProductName, @Price)",
                connection);

            command.Parameters.Add("@ProductID", SqlDbType.Int, 10, "ProductID");
            command.Parameters.Add("@ProductName", SqlDbType.VarChar, 10, "ProductName");
            command.Parameters.Add("@Price", SqlDbType.Decimal, 10, "Price");
            command.Connection = connection;
            productAdapter.InsertCommand = command;

            command = new SqlCommand("DELETE FROM Product WHERE ProductID = @ProductID", connection);
            command.Parameters.Add("@ProductID", SqlDbType.Int, 10, "ProductID");
            command.Connection = connection;
            productAdapter.DeleteCommand = command;

            command = new SqlCommand("UPDATE Product SET ProductName = @ProductName, Price = @Price WHERE ProductID = @ProductID", connection);

            command.Parameters.Add("@ProductID", SqlDbType.Int, 10, "ProductID");
            command.Parameters.Add("@ProductName", SqlDbType.VarChar, 10, "ProductName");
            command.Parameters.Add("@Price", SqlDbType.Decimal, 10, "Price");

            command.Connection = connection;
            productAdapter.UpdateCommand = command;


            return productAdapter;
        }
        public static SqlDataAdapter FindProductAdapter(int productId, SqlConnection connection)
        {
            SqlDataAdapter adapter = new();
            string query = "SELECT ProductID, ProductName, Price FROM Product WHERE ProductID = @ProductID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ProductID", productId);
            adapter.SelectCommand = command;

            return adapter;
        }
        //- PURCHASE -
        public static SqlDataAdapter PurchaseAdapter(SqlConnection connection)
        {
            SqlDataAdapter purchaseAdapter = new SqlDataAdapter();
            SqlCommand command;

            command = new SqlCommand("SELECT * FROM Purchase", connection);
            command.Connection = connection;
            purchaseAdapter.SelectCommand = command;

            command = new SqlCommand(
                "INSERT INTO Purchase VALUES (@PurchaseID, @EmployeeID, @CustomerID)",
                connection);

            command.Parameters.Add("@PurchaseID", SqlDbType.Int, 10, "PurchaseID");
            command.Parameters.Add("@EmployeeID", SqlDbType.Int, 10, "EmployeeID");
            command.Parameters.Add("@CustomerID", SqlDbType.Int, 10, "CustomerID");
            command.Connection = connection;
            purchaseAdapter.InsertCommand = command;

            command = new SqlCommand("DELETE FROM Purchase WHERE PurchaseID = @PurchaseID", connection);
            command.Parameters.Add("@PurchaseID", SqlDbType.Int, 10, "PurchaseID");
            command.Connection = connection;
            purchaseAdapter.DeleteCommand = command;

            command = new SqlCommand("UPDATE Purchase SET EmployeeID = @EmployeeID, CustomerID = @CustomerID WHERE PurchaseID = @PurchaseID", connection);

            command.Parameters.Add("@PurchaseID", SqlDbType.Int, 10, "PurchaseID");
            command.Parameters.Add("@EmployeeID", SqlDbType.Int, 10, "EmployeeId");
            command.Parameters.Add("@CustomerID", SqlDbType.Decimal, 10, "CustomerID");

            command.Connection = connection;
            purchaseAdapter.UpdateCommand = command;


            return purchaseAdapter;
        }

        public static SqlDataAdapter FindPurchaseAdapter(int purchaseId, SqlConnection connection)
        {
            SqlDataAdapter adapter = new();
            string query = "SELECT PurchaseID, EmployeeID, CustomerID FROM Purchase WHERE PurchaseID = @PurchaseID";
            SqlCommand command = new SqlCommand(query, connection);
            
            command.Parameters.AddWithValue("@PurchaseID", purchaseId);
            adapter.SelectCommand = command;

            return adapter;
        }
        
        public static int CheckActivePurchaseAdapter(int purchaseCustomerId, SqlConnection connection)
        {
            string query = "SELECT COUNT(*) AS row_count FROM Purchase WHERE CustomerID = @CustomerID"; // AND Active = 1
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CustomerID", purchaseCustomerId);

            int result = (int)command.ExecuteScalar();
            return result;
        }

        // - ProductPurchase -

        public static SqlDataAdapter InsertProductPurchaseAdapter(int purchaseID, int productID, int quantity, SqlConnection connection)
        {
            SqlDataAdapter productPurchaseAdapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * " +
                                                "FROM ProductPurchase " +
                                                "WHERE PurchaseID = @PurchaseID " +
                                                "AND ProductID = @ProductID", connection);

            command.Parameters.AddWithValue("@PurchaseID", purchaseID);
            command.Parameters.AddWithValue("@ProductID", productID);

            productPurchaseAdapter.SelectCommand = command;

            command = new SqlCommand("Insert INTO ProductPurchase (PurchaseID, ProductID, Quantity) " +
                                     "VALUES (@PurchaseID, @ProductID, @Quantity)", connection);

            command.Parameters.AddWithValue("@PurchaseID", purchaseID);
            command.Parameters.AddWithValue("@ProductID", productID);
            command.Parameters.AddWithValue("@Quantity", quantity);

            productPurchaseAdapter.InsertCommand = command;
            return productPurchaseAdapter;
        }

        public static SqlDataAdapter DeleteProductPurchaseAdapter(int purchaseID, int productID, SqlConnection connection)
        {
            SqlDataAdapter productPurchaseAdapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * " +
                                                "FROM ProductPurchase " +
                                                "WHERE PurchaseID = @PurchaseID " +
                                                "AND ProductID = @ProductID",
                                                connection);

            command.Parameters.AddWithValue("@PurchaseID", purchaseID);
            command.Parameters.AddWithValue("@ProductID", productID);
            productPurchaseAdapter.SelectCommand = command;

            command = new SqlCommand("DELETE " +
                                     "FROM ProductPurchase " +
                                     "WHERE PurchaseID = @PurchaseID " +
                                     "AND ProductID = @ProductID",
                                     connection);

            command.Parameters.AddWithValue("@PurchaseID", purchaseID);
            command.Parameters.AddWithValue("@ProductID", productID);
            productPurchaseAdapter.DeleteCommand = command;

            return productPurchaseAdapter;
        }

        // - PRODUCT_SUPPLIER -

        public static SqlDataAdapter InsertSupplierProductAdapter(int supplierId, int productId, SqlConnection connection)
        {
            SqlDataAdapter productSupplierAdapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * " +
                                                "FROM ProductSupplier " +
                                                "WHERE SupplierID = @SupplierID " +
                                                "AND ProductID = @ProductID", connection);

            command.Parameters.AddWithValue("@SupplierID", supplierId);
            command.Parameters.AddWithValue("@ProductID", productId);

            productSupplierAdapter.SelectCommand = command;

            command = new SqlCommand("Insert INTO ProductSupplier (SupplierID, ProductID) " +
                                     "VALUES (@SupplierID, @ProductID)", connection);

            command.Parameters.AddWithValue("@SupplierID", supplierId);
            command.Parameters.AddWithValue("@ProductID", productId);

            productSupplierAdapter.InsertCommand = command;
            return productSupplierAdapter;
        }
    }
}
