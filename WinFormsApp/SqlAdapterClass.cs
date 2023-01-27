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
    }
}
