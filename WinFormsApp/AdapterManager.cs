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
            SqlCommand command = new SqlCommand("SELECT pp.PurchaseID AS 'Purchase ID' , prod.ProductName AS Product, " +
                                                "prod.ProductID AS 'Product ID', prod.Price AS 'Price per', pp.Quantity FROM ProductPurchase pp " +
                                                "JOIN Product prod ON pp.ProductID = prod.ProductID " +
                                                "JOIN Purchase p ON pp.PurchaseID = p.PurchaseID");
            command.Connection = connection;
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

            command.Parameters.Add("CustomerID", SqlDbType.Int, 10, "CustomerID");
            command.Parameters.Add("CustomerName", SqlDbType.VarChar, 10, "CustomerName");
            command.Parameters.Add("CustomerAddress", SqlDbType.VarChar, 10, "CustomerAddress");
            command.Parameters.Add("PhoneNumber", SqlDbType.Int, 10, "PhoneNumber");
            command.Connection = connection;
            customerAdapter.InsertCommand = command;

            command = new SqlCommand("DELETE FROM Customer WHERE CustomerID = @CustomerID", connection);
            command.Parameters.Add("CustomerID", SqlDbType.Int, 10, "CustomerID");
            command.Connection = connection;
            customerAdapter.DeleteCommand = command;

            command = new SqlCommand("UPDATE Customer SET CustomerName = @CustomerName, CustomerAddress = @CustomerAddress, PhoneNumber = @PhoneNumber WHERE EmployeeID = @EmployeeID", connection);

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

            command.Parameters.Add("EmployeeID", SqlDbType.Int, 10, "EmployeeID");
            command.Parameters.Add("EmployeeName", SqlDbType.VarChar, 10, "EmployeeName");
            command.Parameters.Add("EmployeeAddress", SqlDbType.VarChar, 10, "EmployeeAddress");
            command.Parameters.Add("PhoneNumber", SqlDbType.Int, 10, "PhoneNumber");
            command.Connection = connection;
            employeeAdapter.InsertCommand = command;

            command = new SqlCommand("DELETE FROM Employee WHERE EmployeeID = @EmployeeID", connection);
            command.Parameters.Add("EmployeeID", SqlDbType.Int, 10, "EmployeeID");
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
        public static SqlDataAdapter ViewSupplierAdapter(SqlConnection connection)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command;
            //Read/View all customers
            command = new SqlCommand("SELECT * FROM Supplier", connection);

            command.Connection = connection;
            adapter.SelectCommand = command;
            return adapter;

        }

        public static SqlDataAdapter InsertSupplierAdapter(int SupplierId, string SupplierName, string SupplierAddress, int PhoneNbr, SqlConnection connection)
        {
            SqlDataAdapter addSupplierAdapter = new SqlDataAdapter();
            SqlCommand command;

            //Select Supplier
            command = new SqlCommand(
                "SELECT * " +
                "FROM Supplier " +
                "WHERE SupplierId = @SupplierId " +
                "AND SupplierName = @SupplierName",
                connection);

            addSupplierAdapter.SelectCommand = command;

            command.Parameters.AddWithValue("@SupplierId", SupplierId);
            command.Parameters.AddWithValue("@SupplierName", SupplierName);
            command.Parameters.AddWithValue("@SupplierAddress", SupplierAddress);
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNbr);

            //Insert Supplier
            command = new SqlCommand("INSERT INTO Supplier (SupplierID, SupplierName, SupplierAddress,"
                                    + "PhoneNumber) VALUES (@SupplierID, @SupplierName, @SupplierAddress, @PhoneNumber)", connection);

            //Add parameters with value
            command.Parameters.AddWithValue("@SupplierId", SupplierId);
            command.Parameters.AddWithValue("@SupplierName", SupplierName);
            command.Parameters.AddWithValue("@SupplierAddress", SupplierAddress);
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNbr);

            addSupplierAdapter.InsertCommand = command;

            string deleteSuppQuery = "DELETE FROM Supplier WHERE SupplierID = @SupplierID";
            command = new SqlCommand(deleteSuppQuery, connection);

            command.Parameters.AddWithValue("@SupplierID", SupplierId);
            command.Parameters.AddWithValue("@SupplierName", SupplierName);
            command.Parameters.AddWithValue("@SupplierAddress", SupplierAddress);
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNbr);

            addSupplierAdapter.DeleteCommand = command;

            return addSupplierAdapter;
        }

        public static SqlDataAdapter UpdateSupplierAdapter(int suppId, string suppName, string suppAddress, int phoneNumber, SqlConnection connection)
        {
            SqlDataAdapter suppUpdateAdapter = new SqlDataAdapter();
            string selectQuery = "SELECT * FROM Supplier WHERE SupplierId = @SupplierID";
            SqlCommand command = new SqlCommand(selectQuery, connection);

            command.Parameters.AddWithValue("@SupplierId", suppId);

            suppUpdateAdapter.SelectCommand = command;

            string updateQuery = "UPDATE Supplier SET SupplierName = @SupplierName, SupplierAddress = @SupplierAddress, PhoneNumber = @PhoneNumber WHERE SupplierId = @SupplierId";
            command = new SqlCommand(updateQuery, connection);

            command.Parameters.AddWithValue("@SupplierId", suppId);
            command.Parameters.AddWithValue("@SupplierName", suppName);
            command.Parameters.AddWithValue("@SupplierAddress", suppAddress);
            command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

            suppUpdateAdapter.UpdateCommand = command;

            return suppUpdateAdapter;
        }

        public static SqlDataAdapter DeleteSupplierAdapter(int suppId, SqlConnection connection)
        {
            connection = ConnectionHandler.GetDatabaseConnection();

            SqlDataAdapter deleteSupplierAdapter = new SqlDataAdapter();

            string selectQuery = "SELECT * FROM Supplier WHERE SupplierID = @SupplierID";

            SqlCommand command = new SqlCommand(selectQuery, connection);

            command.Parameters.AddWithValue("@SupplierID", suppId);
            deleteSupplierAdapter.SelectCommand = command;

            string deleteQuery = "DELETE FROM Supplier WHERE SupplierID = @SupplierID";

            command = new SqlCommand(deleteQuery, connection);

            command.Parameters.AddWithValue("@SupplierID", suppId);
            deleteSupplierAdapter.DeleteCommand = command;

            return deleteSupplierAdapter;
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
        public static SqlDataAdapter ViewAllProductAdapter(SqlConnection connection)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command;
            string query = "SELECT * FROM Product";

            command = new(query, connection);

            command.Connection = connection;
            adapter.SelectCommand = command;
            return adapter;
        }

        public static SqlDataAdapter InsertProductAdapter(int productId, string productName, int productPrice, SqlConnection connection)
        {
            SqlDataAdapter productAdapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * " +
                                                "FROM Product " +
                                                "WHERE ProductID = @ProductID", connection);

            command.Parameters.AddWithValue("@ProductID", productId);
            command.Parameters.AddWithValue("@ProductName", productName);
            command.Parameters.AddWithValue("@Price", productPrice);

            productAdapter.SelectCommand = command;

            command = new SqlCommand("Insert INTO Product (ProductID, ProductName, Price) " +
                                     "VALUES (@ProductID, @ProductName, @Price)", connection);

            command.Parameters.AddWithValue("@ProductID", productId);
            command.Parameters.AddWithValue("@ProductName", productName);
            command.Parameters.AddWithValue("@Price", productPrice);

            productAdapter.InsertCommand = command;
            return productAdapter;
 
        }

        public static SqlDataAdapter UpdateProductAdapter(int productID, string productName, int price, SqlConnection connection)
        {
            SqlDataAdapter updateProductAdapter = new();
            string selectQuery = "SELECT * FROM Product WHERE ProductID = @ProductID";
            SqlCommand command = new(selectQuery, connection);

            command.Parameters.AddWithValue("@ProductID", productID);

            updateProductAdapter.SelectCommand = command;

            string updateQuery = "UPDATE Product SET ProductName = @ProductName, Price = @Price WHERE ProductID = @ProductID";
            command = new(updateQuery, connection);

            command.Parameters.AddWithValue("@ProductID", productID);
            command.Parameters.AddWithValue("@ProductName", productName);
            command.Parameters.AddWithValue("@Price", price);

            updateProductAdapter.UpdateCommand = command;

            return updateProductAdapter;
        }

        public static SqlDataAdapter DeleteProductAdapter(int productId, SqlConnection connection)
        {
            SqlDataAdapter productAdapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * " +
                                                "FROM Product " +
                                                "WHERE ProductID = @ProductID",
                                                connection);

            command.Parameters.AddWithValue("@ProductID", productId);
            productAdapter.SelectCommand = command;

            command = new SqlCommand("DELETE " +
                                     "FROM Product " +
                                     "WHERE ProductID = @ProductID",
                                     connection);

            command.Parameters.AddWithValue("@ProductID", productId);
            productAdapter.DeleteCommand = command;

            return productAdapter;

        }

        public static SqlDataAdapter FindProductAdapter(int productID, SqlConnection connection)
        {
            SqlDataAdapter productFindAdapter = new();
            string query = "SELECT ProductID, ProductName, Price FROM Product WHERE ProductID = @ProductID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ProductID", productID);
            productFindAdapter.SelectCommand = command;

            return productFindAdapter;
        }


        // - PURCHASE -

        public static SqlDataAdapter ViewAllPurchaseAdapter(SqlConnection connection)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command;
            string query = "SELECT * FROM Purchase";

            command = new(query, connection);

            command.Connection = connection;
            adapter.SelectCommand = command;
            return adapter;
        }

        public static SqlDataAdapter InsertPurchaseAdapter(int purchaseId, int customerId, int employeeId, SqlConnection connection)
        {
            SqlDataAdapter purchaseAdapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * " +
                                                "FROM Purchase " +
                                                "WHERE PurchaseID = @PurchaseID " +
                                                "AND CustomerID = @CustomerID " +
                                                "AND EmployeeID = @EmployeeID", connection);

            command.Parameters.AddWithValue("@PurchaseID", purchaseId);
            command.Parameters.AddWithValue("@CustomerID", customerId);
            command.Parameters.AddWithValue("@EmployeeID", employeeId);

            purchaseAdapter.SelectCommand = command;

            command = new SqlCommand("Insert INTO Purchase (PurchaseID, CustomerID, EmployeeID) " +
                                     "VALUES (@PurchaseID, @CustomerID, @EmployeeID)", connection);

            command.Parameters.AddWithValue("@PurchaseID", purchaseId);
            command.Parameters.AddWithValue("@CustomerID", customerId);
            command.Parameters.AddWithValue("@EmployeeID", employeeId);

            purchaseAdapter.InsertCommand = command;
            return purchaseAdapter;
        }

        public static SqlDataAdapter UpdatePurchaseAdapter(int purchaseId, int customerId, int employeeId, SqlConnection connection)
        {
            SqlDataAdapter updatePurchaseAdapter = new();
            string selectQuery = "SELECT * FROM Purchase WHERE PurchaseID = @PurchaseID";
            SqlCommand command = new(selectQuery, connection);

            command.Parameters.AddWithValue("@PurchaseID", purchaseId);

            updatePurchaseAdapter.SelectCommand = command;

            string updateQuery = "UPDATE Purchase SET CustomerID = @CustomerID, EmployeeID = @EmployeeID WHERE PurchaseID = @PurchaseID";
            command = new(updateQuery, connection);

            command.Parameters.AddWithValue("@PurchaseID", purchaseId);
            command.Parameters.AddWithValue("@CustomerID", customerId);
            command.Parameters.AddWithValue("@EmployeeID", employeeId);

            updatePurchaseAdapter.UpdateCommand = command;

            return updatePurchaseAdapter;
        }

        public static SqlDataAdapter DeletePurchaseAdapter(int purchaseId, SqlConnection connection)
        {
            SqlDataAdapter purchaseAdapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * " +
                                                "FROM Purchase " +
                                                "WHERE PurchaseID = @PurchaseID",
                                                connection);

            command.Parameters.AddWithValue("@PurchaseID", purchaseId);
            purchaseAdapter.SelectCommand = command;

            command = new SqlCommand("DELETE " +
                                     "FROM Purchase " +
                                     "WHERE PurchaseID = @PurchaseID",
                                     connection);

            command.Parameters.AddWithValue("@PurchaseID", purchaseId);
            purchaseAdapter.DeleteCommand = command;

            return purchaseAdapter;
        }
        public static SqlDataAdapter FindPurchaseAdapter(int purchaseId, SqlConnection connection)
        {
            SqlDataAdapter adapter= new();
            string query = "SELECT PurchaseID, EmployeeID, CustomerID FROM Purchase WHERE PurchaseID = @PurchaseID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PurchaseID", purchaseId);
            adapter.SelectCommand = command;

            return adapter;
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
