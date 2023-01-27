using DevExpress.CodeParser;
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

        public static SqlDataAdapter CustomerAdapter(SqlConnection connection)
        {
            SqlDataAdapter customerAdapter = new SqlDataAdapter();
            SqlCommand command;
            //Read/View all customers
            command = new SqlCommand("SELECT * FROM Customer", connection);

            command.Connection = connection;
            customerAdapter.SelectCommand = command;
            return customerAdapter;

        }
    }
}
