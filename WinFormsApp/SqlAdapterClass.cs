using DevExpress.CodeParser;
using DevExpress.XtraRichEdit.Commands;
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
                    ["insertDetailsHere"].ConnectionString;

                SqlConnectionStringBuilder builder = new(connectionString);

                SqlConnection connection = new(builder.ConnectionString);

                return connection;
            }
        }

        public static SqlDataAdapter ViewAllEmployeeAdapter(SqlConnection connection)
        {
            SqlDataAdapter empAdapter = new SqlDataAdapter();
            SqlCommand command;
            string viewEmployeesQuery = "SELECT * FROM Employee";

            //Read all employees
            command = new SqlCommand(viewEmployeesQuery, connection);
            command.Connection= connection;
            empAdapter.SelectCommand= command;

          return empAdapter;
        }

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

        public static SqlDataAdapter InsertCustomerAdapter(SqlConnection connection)
        {
            SqlDataAdapter customerAdapter = new SqlDataAdapter();
            SqlCommand command;
            //Insert customer
            command = new SqlCommand("INSERT INTO Customer (CustomerID, CustomerName, CustomerAddress," 
                                    +"PhoneNumber) VALUES (@CustomerId, @CustomerName, @CustomerAddress, @PhoneNbr)", connection);
       
              //Parameters
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

            customerAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            command.Connection = connection;
            customerAdapter.SelectCommand = command;
            return customerAdapter;
            

        }

        public static SqlDataAdapter UpdateCustomerAdapter(SqlConnection connection)
        {
            SqlDataAdapter customerAdapter = new SqlDataAdapter();
            SqlCommand command;

            command = new SqlCommand("UPDATE Customer SET CustomerName = @CustomerName, CustomerAddress = @CustomerAddress," 
                                       +"PhoneNumber = @PhoneNumber WHERE CustomerID = @CustomerID", connection);
            //Parameters
            SqlParameter parameterCustomerID = new SqlParameter("@CustomerID", SqlDbType.Int);
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
        }

        public static SqlDataAdapter DeleteCustomerAdapter(SqlConnection connection)
        {
            SqlDataAdapter customerAdapter = new SqlDataAdapter();
            SqlCommand command;

            command = new SqlCommand("DELETE FROM Customer WHERE CustomerID = @CustomerID", connection);

            SqlParameter parameterCustomerID = new SqlParameter("@CustomerID", SqlDbType.Int);

            command.Parameters.Add(parameterCustomerID);
            command.Connection = connection;
            customerAdapter.SelectCommand = command;

            return customerAdapter;
        }

        public static SqlDataAdapter InsertEmployeeAdapter(SqlConnection connection)
        {
            SqlDataAdapter addEmpAdapter = new SqlDataAdapter();
            SqlCommand command;
            string insertEmployeeQuery = "INSERT INTO Employee (EmployeeID, EmployeeName, EmployeeAddress, PhoneNumber) VALUES (@EmployeeID, @EmployeeName, @EmployeeAddress, @PhoneNumber)";

            //Add new employee
            command = new SqlCommand(insertEmployeeQuery, connection);

            //Parameters
            SqlParameter parameterEmployeeId = new SqlParameter("@EmployeeID", SqlDbType.Int);
            SqlParameter parameterEmployeeName = new SqlParameter("@EmployeeName", SqlDbType.VarChar);
            SqlParameter parameterEmployeeAddress = new SqlParameter("@EmployeeAddress", SqlDbType.VarChar);
            SqlParameter parameterEmployeePhoneNumber = new SqlParameter("@PhoneNumber", SqlDbType.Int);

            //Source column mapping
            parameterEmployeeId.SourceColumn = "EmployeeID";
            parameterEmployeeName.SourceColumn = "EmployeeName";
            parameterEmployeeAddress.SourceColumn = "EmployeeAddress";
            parameterEmployeePhoneNumber.SourceColumn = "PhoneNumber";

            command.Parameters.Add(parameterEmployeeId);
            command.Parameters.Add(parameterEmployeeName);
            command.Parameters.Add(parameterEmployeeAddress);
            command.Parameters.Add(parameterEmployeePhoneNumber);

            command.Connection = connection;
            addEmpAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            addEmpAdapter.SelectCommand = command;

            return addEmpAdapter;
        }

        public static SqlDataAdapter DeleteEmployeeAdapter (SqlConnection connection)
        {
            SqlDataAdapter deleteEmpAdapter = new SqlDataAdapter();
            SqlCommand command;
            string query = "DELETE FROM Employee WHERE EmployeeID = @EmployeeID";

            command = new SqlCommand(query, connection);

            SqlParameter parameterEmployeeID = new SqlParameter("@EmployeeID", SqlDbType.Int);

            command.Parameters.Add(parameterEmployeeID);
            command.Connection = connection;
            deleteEmpAdapter.SelectCommand = command;

            return deleteEmpAdapter;
        }

        public static SqlDataAdapter UpdateEmployeeAdapter(SqlConnection connection)
        {
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

        public static SqlDataAdapter InsertSupplierAdapter(SqlConnection connection)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command;

            command = new SqlCommand("INSERT INTO Supplier (SupplierID, SupplierName, SupplierAddress,"
                                    + "PhoneNumber) VALUES (@SupplierID, @SupplierName, @SupplierAddress, @PhoneNbr)", connection);


            SqlParameter parameterSupplierID = new("@SupplierID", SqlDbType.Int);
            SqlParameter parameterSupplierName = new("@SupplierName", SqlDbType.VarChar);
            SqlParameter parameterSupplierAddress = new("@SupplierAddress", SqlDbType.VarChar);
            SqlParameter parameterPhoneNumber = new("@PhoneNbr", SqlDbType.Int);

            parameterSupplierID.SourceColumn = "SupplierID";
            parameterSupplierName.SourceColumn = "SupplierName";
            parameterSupplierAddress.SourceColumn = "SupplierAddress";
            parameterPhoneNumber.SourceColumn = "PhoneNumber";

            command.Parameters.Add(parameterSupplierID);
            command.Parameters.Add(parameterSupplierName);
            command.Parameters.Add(parameterSupplierAddress);
            command.Parameters.Add(parameterPhoneNumber);

            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            command.Connection = connection;
            adapter.SelectCommand = command;
            return adapter;
        }

        public static SqlDataAdapter UpdateSupplierAdapter(SqlConnection connection)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command;

            command = new SqlCommand("UPDATE Supplier SET SupplierName = @SupplierName, SupplierAddress = @SupplierAddress,"
                                       + "PhoneNumber = @PhoneNumber WHERE SupplierID = @SupplierID", connection);
            //Parameters
            SqlParameter parameterSupplierID = new SqlParameter("@SupplierID", SqlDbType.Int);
            SqlParameter parameterSupplierName = new SqlParameter("@SupplierName", SqlDbType.VarChar);
            SqlParameter parameterSupplierAddress = new SqlParameter("@SupplierAddress", SqlDbType.VarChar);
            SqlParameter parameterPhoneNumber = new SqlParameter("@PhoneNumber", SqlDbType.Int);

            parameterSupplierID.SourceColumn = "SupplierID";
            parameterSupplierName.SourceColumn = "SupplierName";
            parameterSupplierAddress.SourceColumn = "SupplierAddress";
            parameterPhoneNumber.SourceColumn = "PhoneNumber";

            command.Parameters.Add(parameterSupplierID);
            command.Parameters.Add(parameterSupplierName);
            command.Parameters.Add(parameterSupplierAddress);
            command.Parameters.Add(parameterPhoneNumber);

            command.Connection = connection;
            //Don't know if AddWithKey is necesseray here
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adapter.SelectCommand = command;

            return adapter;
        }

        public static SqlDataAdapter DeleteSupplierAdapter(SqlConnection connection)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command;

            command = new SqlCommand("DELETE FROM Supplier WHERE SupplierID = @SupplierID", connection);

            SqlParameter parameterSupplierID = new SqlParameter("@SupplierID", SqlDbType.Int);

            command.Parameters.Add(parameterSupplierID);
            command.Connection = connection;
            adapter.SelectCommand = command;

            return adapter;
        }

    }
}
