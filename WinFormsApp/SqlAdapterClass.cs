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

        public void InsertEmployee(DataSet ds)
        {
            using (SqlConnection connection = ConnectionHandler.GetDatabaseConnection())
            {
                // Create INSERT SqlCommand, set query
                SqlCommand insertCommand = connection.CreateCommand();
                insertCommand.CommandText = "INSERT INTO Employee (EmployeeID, EmployeeName, EmployeeAddress, PhoneNumber) VALUES (@EmployeeID, @EmployeeName, @EmployeeAddress, @PhoneNumber)";

                // Create parameters for INSERT SqlCommand
                SqlParameter parameterEmployeeID = new SqlParameter("@EmployeeID", SqlDbType.Int);
                SqlParameter parameterEmployeeName = new SqlParameter("@EmployeeName", SqlDbType.VarChar);
                SqlParameter parameterEmployeeAddress = new SqlParameter("@EmployeeAddress", SqlDbType.VarChar);
                SqlParameter parameterPhoneNumber = new SqlParameter("@PhoneNumber", SqlDbType.Int);
            }

        }
    }
}
