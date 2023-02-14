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
    class SqlAdapterClass
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
            SqlCommand command = new SqlCommand("SELECT pp.PurchaseID , prod.ProductName AS Product, " +
                                                "prod.ProductID, prod.Price, pp.Quantity FROM ProductPurchase pp " +
                                                "JOIN Product prod ON pp.ProductID = prod.ProductID " +
                                                "JOIN Purchase p ON pp.PurchaseID = p.PurchaseID");
            command.Connection = connection;
            adapter.SelectCommand = command;
            return adapter;
        }

        // - CUSTOMER -
        public static SqlDataAdapter ViewCustomerAdapter(SqlConnection connection)
        {
            SqlDataAdapter customerAdapter = new SqlDataAdapter();
            SqlCommand command;
            //Read/View all customers
            command = new SqlCommand("SELECT * FROM Customer", connection);

            command.Connection = connection;
            customerAdapter.SelectCommand = command;
            return customerAdapter;

        }

        public static SqlDataAdapter InsertCustomerAdapter(int CustomerID, string CustomerName, string CustomerAddress, int PhoneNumber, SqlConnection connection)
        {
            SqlDataAdapter customerAdapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * " +
                                                "FROM Customer " +
                                                "WHERE CustomerID = @CustomerID " +
                                                "AND CustomerName = CustomerName", connection);

            command.Parameters.AddWithValue("@CustomerID", CustomerID);
            command.Parameters.AddWithValue("@CustomerName", CustomerName);
            command.Parameters.AddWithValue("@CustomerAddress", CustomerAddress);
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);

            customerAdapter.SelectCommand = command;

            command = new SqlCommand("INSERT INTO Customer (CustomerID, CustomerName, CustomerAddress,"
                                    + "PhoneNumber) VALUES (@CustomerID, @CustomerName, @CustomerAddress, @PhoneNumber)", connection);

            command.Parameters.AddWithValue("@CustomerID", CustomerID);
            command.Parameters.AddWithValue("@CustomerName", CustomerName);
            command.Parameters.AddWithValue("@CustomerAddress", CustomerAddress);
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);

            customerAdapter.InsertCommand = command;


            command = new SqlCommand("DELETE FROM Customer WHERE CustomerID = @CustomerID", connection);

            command.Parameters.AddWithValue("@CustomerID", CustomerID);
            customerAdapter.DeleteCommand = command;


            return customerAdapter;

            /*  //Parameters
              SqlParameter parameterCustomerId = new("@CustomerID", SqlDbType.Int);
              SqlParameter parameterCustomerName = new("@CustomerName", SqlDbType.VarChar);
              SqlParameter parameterCustomerAddress = new("@CustomerAddress", SqlDbType.VarChar);
              SqlParameter parameterPhoneNumber = new("@PhoneNumber", SqlDbType.Int);

              //source column mapping
              parameterCustomerId.SourceColumn = "CustomerID";
              parameterCustomerName.SourceColumn = "CustomerName";
              parameterCustomerAddress.SourceColumn = "CustomerAddress";
              parameterPhoneNumber.SourceColumn = "PhoneNumber";

              command.Parameters.Add(parameterCustomerId);
              command.Parameters.Add(parameterCustomerName);
              command.Parameters.Add(parameterCustomerAddress);
              command.Parameters.Add(parameterPhoneNumber);

         */





        }

        public static SqlDataAdapter UpdateCustomerAdapter(int CustomerId, string CustomerName, string CustomerAddress, int CustomerPhoneNbr, SqlConnection connection)
        {
            SqlDataAdapter customerAdapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * " +
                                                "FROM Customer " +
                                                "WHERE CustomerID = @CustomerId", connection);

            command.Parameters.AddWithValue("@CustomerID", CustomerId);

            customerAdapter.SelectCommand = command;

            command = new SqlCommand("UPDATE Customer SET CustomerName = @CustomerName, CustomerAddress = @CustomerAddress,"
                                       + "PhoneNumber = @PhoneNumber WHERE CustomerID = @CustomerID", connection);

            command.Parameters.AddWithValue("@CustomerID", CustomerId);
            command.Parameters.AddWithValue("@CustomerName", CustomerName);
            command.Parameters.AddWithValue("@CustomerAddress", CustomerAddress);
            command.Parameters.AddWithValue("@PhoneNumber", CustomerPhoneNbr);

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





        /* SqlParameter parameterCustomerID = new SqlParameter("@CustomerID", SqlDbType.Int);
         SqlParameter parameterCustomerName = new SqlParameter("@CustomerName", SqlDbType.VarChar);
         SqlParameter parameterCustomerAddress = new SqlParameter("@CustomerAddress", SqlDbType.VarChar);
         SqlParameter parameterPhoneNumber = new SqlParameter("@PhoneNumber", SqlDbType.Int);

         parameterCustomerID.SourceColumn = "CustomerID";
         parameterCustomerName.SourceColumn = "CustomerName";
         parameterCustomerAddress.SourceColumn = "CustomerAddress";
         parameterPhoneNumber.SourceColumn = "PhoneNumber";

         command.Parameters.Add(parameterCustomerID);
         command.Parameters.Add(parameterCustomerName);
         command.Parameters.Add(parameterCustomerAddress);
         command.Parameters.Add(parameterPhoneNumber);

         command.Connection = connection;
         customerAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
         customerAdapter.SelectCommand = command;

           return customerAdapter;
        */

        public static SqlDataAdapter DeleteCustomerAdapter(int CustomerId, SqlConnection connection)
        {
            SqlDataAdapter customerAdapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT * " +
                                               "FROM Customer " +
                                               "WHERE CustomerID = @CustomerID ", connection);

            command.Parameters.AddWithValue("@CustomerID", CustomerId);
            customerAdapter.SelectCommand = command;

            command = new SqlCommand("DELETE FROM Customer WHERE CustomerID = @CustomerID", connection);
            command.Parameters.AddWithValue("@CustomerID", CustomerId);
            customerAdapter.DeleteCommand = command;

            return customerAdapter;
        }

        // - EMPLOYEE -

        public static SqlDataAdapter ViewAllEmployeeAdapter(SqlConnection connection)
        {
            SqlDataAdapter empAdapter = new SqlDataAdapter();
            SqlCommand command;
            string viewEmployeesQuery = "SELECT * FROM Employee";

            //Read all employees
            command = new SqlCommand(viewEmployeesQuery, connection);
            command.Connection = connection;
            empAdapter.SelectCommand = command;

            return empAdapter;
        }

        public static SqlDataAdapter InsertEmployeeAdapter(int EmployeeID, string EmployeeName, string EmployeeAddress, int PhoneNumber, SqlConnection connection)
        {
            SqlDataAdapter addEmpAdapter = new SqlDataAdapter();

            // Creates the SqlCommand for SqlDataAdapters's SelectCommand.
            SqlCommand command = new SqlCommand(
                "SELECT * " +
                "FROM Employee " +
                "WHERE EmployeeID = @EmployeeID " +
                "AND EmployeeName = @EmployeeName",
                connection);

            // Add parameters with value
            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            command.Parameters.AddWithValue("@EmployeeName", EmployeeName);
            command.Parameters.AddWithValue("@EmployeeAddress", EmployeeAddress);
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);

            addEmpAdapter.SelectCommand = command;

            // Creates the SqlCommand for SqlDataAdapters's InsertCommand.
            command = new SqlCommand(
                "INSERT INTO Employee (EmployeeID, EmployeeName, EmployeeAddress, PhoneNumber) " +
                "VALUES (@EmployeeID, @EmployeeName, @EmployeeAddress, @PhoneNumber)",
                connection);

            // Add parameters with value
            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            command.Parameters.AddWithValue("@EmployeeName", EmployeeName);
            command.Parameters.AddWithValue("@EmployeeAddress", EmployeeAddress);
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);

            addEmpAdapter.InsertCommand = command;

            // Create SqlCommand for SqlDataAdapter's DeleteCommand
            string deleteEmpQuery = "DELETE FROM Employee WHERE EmployeeID = @EmployeeID";
            command = new SqlCommand(deleteEmpQuery, connection);

            command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            command.Parameters.AddWithValue("@EmployeeName", EmployeeName);
            command.Parameters.AddWithValue("@EmployeeAddress", EmployeeAddress);
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);

            addEmpAdapter.DeleteCommand = command;

            return addEmpAdapter;

            //-----
            // OLD code
            //command = connection.CreateCommand();
            //command.CommandText = insertEmployeeQuery;            

            //// OLD - Source column mapping
            //parameterEmployeeId.SourceColumn = "EmployeeID";
            //parameterEmployeeName.SourceColumn = "EmployeeName";
            //parameterEmployeeAddress.SourceColumn = "EmployeeAddress";
            //parameterEmployeePhoneNumber.SourceColumn = "PhoneNumber";

            // OLD - Original Version
            //command.Parameters.Add(parameterEmployeeId);
            //command.Parameters.Add(parameterEmployeeName);
            //command.Parameters.Add(parameterEmployeeAddress);
            //command.Parameters.Add(parameterEmployeePhoneNumber);         

            // OLD code
            //addEmpAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            //command.Connection = connection;
            //-----

        }

        public static SqlDataAdapter DeleteEmployeeAdapter(int empID, SqlConnection connection)
        {
            connection = ConnectionHandler.GetDatabaseConnection();

            SqlDataAdapter deleteEmpAdapter = new SqlDataAdapter();

            string selectQuery = "SELECT * FROM Employee WHERE EmployeeID = @EmployeeID";

            SqlCommand command = new SqlCommand(selectQuery, connection);

            command.Parameters.AddWithValue("@EmployeeID", empID);
            deleteEmpAdapter.SelectCommand = command;

            string deleteQuery = "DELETE FROM Employee WHERE EmployeeID = @EmployeeID";

            command = new SqlCommand(deleteQuery, connection);

            command.Parameters.AddWithValue("@EmployeeID", empID);
            deleteEmpAdapter.DeleteCommand = command;

            return deleteEmpAdapter;
        }

        public static SqlDataAdapter UpdateEmployeeAdapter(int empID, string empName, string empAddress, int phoneNumber, SqlConnection connection)
        {

            SqlDataAdapter empUpdateAdapter = new SqlDataAdapter();
            string selectQuery = "SELECT * FROM Employee WHERE EmployeeID = @EmployeeID";
            SqlCommand command = new SqlCommand(selectQuery, connection);

            command.Parameters.AddWithValue("@EmployeeID", empID);

            empUpdateAdapter.SelectCommand = command;

            string updateQuery = "UPDATE Employee SET EmployeeName = @EmployeeName, EmployeeAddress = @EmployeeAddress, PhoneNumber = @PhoneNumber WHERE EmployeeID = @EmployeeID";
            command = new SqlCommand(updateQuery, connection);

            command.Parameters.AddWithValue("@EmployeeID", empID);
            command.Parameters.AddWithValue("@EmployeeName", empName);
            command.Parameters.AddWithValue("@EmployeeAddress", empAddress);
            command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

            empUpdateAdapter.UpdateCommand = command;

            return empUpdateAdapter;
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

        /*
        SqlDataAdapter updateEmpAdapter = new();
        SqlCommand command;
        string query = "UPDATE Employee SET EmployeeName = @EmployeeName, EmployeeAddress = @EmployeeAddress, PhoneNumber = @PhoneNumber WHERE EmployeeID = @EmployeeID";

        command = new(query, connection);

        //Parameters
        SqlParameter parameterEmployeeID = new SqlParameter("@EmployeeID", SqlDbType.Int);
        SqlParameter parameterEmployeeName = new SqlParameter("@EmployeeName", SqlDbType.VarChar);
        SqlParameter parameterEmployeeAddress = new SqlParameter("@EmployeeAddress", SqlDbType.VarChar);
        SqlParameter parameterEmployeePhoneNumber = new SqlParameter("@PhoneNumber", SqlDbType.Int);

        //Source column mapping
        parameterEmployeeID.SourceColumn = "EmployeeID";
        parameterEmployeeName.SourceColumn = "EmployeeName";
        parameterEmployeeAddress.SourceColumn = "EmployeeAddress";
        parameterEmployeePhoneNumber.SourceColumn = "PhoneNumber";

        command.Parameters.Add(parameterEmployeeID);
        command.Parameters.Add(parameterEmployeeName);
        command.Parameters.Add(parameterEmployeeAddress);
        command.Parameters.Add(parameterEmployeePhoneNumber);

        command.Connection = connection;
        updateEmpAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
        updateEmpAdapter.SelectCommand = command;

        return updateEmpAdapter;
    }
        */

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

            /*
            command = new SqlCommand(query, connection);


            SqlParameter parameterProductID = new("@ProductID", SqlDbType.Int);
            SqlParameter parameterProductName = new("@ProductrName", SqlDbType.VarChar);
            SqlParameter parameterPrice = new("@Price", SqlDbType.Int);

            parameterProductID.SourceColumn = "ProductID";
            parameterProductName.SourceColumn = "ProductrName";
            parameterPrice.SourceColumn = "Price";

            command.Parameters.Add(parameterProductID);
            command.Parameters.Add(parameterProductName);
            command.Parameters.Add(parameterPrice);

            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            command.Connection = connection;
            adapter.SelectCommand = command;
            return adapter;
            */
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

            /*
            SqlParameter parameterProductID = new SqlParameter("@ProductID", SqlDbType.);

            command.Parameters.Add(parameterProductID);
            command.Connection = connection;
            adapter.SelectCommand = command;

            return adapter;
            */
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

        // - ProductPurchase -

        public static SqlDataAdapter InsertProductPurchaseAdapter(int purchaseID, int productID, SqlConnection connection)
        {
            SqlDataAdapter productPurchaseAdapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * " +
                                                "FROM ProductPurchase " +
                                                "WHERE PurchaseID = @PurchaseID " +
                                                "AND ProductID = @ProductID", connection);

            command.Parameters.AddWithValue("@PurchaseID", purchaseID);
            command.Parameters.AddWithValue("@ProductID", productID);

            productPurchaseAdapter.SelectCommand = command;

            command = new SqlCommand("Insert INTO ProductPurchase (PurchaseID, ProductID) " +
                                     "VALUES (@PurchaseID, @ProductID)", connection);

            command.Parameters.AddWithValue("@PurchaseID", purchaseID);
            command.Parameters.AddWithValue("@ProductID", productID);

            productPurchaseAdapter.InsertCommand = command;
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
