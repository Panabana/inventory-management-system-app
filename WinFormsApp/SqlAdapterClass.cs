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

        public static SqlDataAdapter EmployeeAdapter(SqlConnection connection)
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

    }
}
