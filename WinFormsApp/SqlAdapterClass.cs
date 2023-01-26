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

        public void UpdateEmployee(DataSet ds)
        {
            using (SqlConnection connection = ConnectionHandler.GetDatabaseConnection())
            {
                string query = "SELECT * FROM Employee";
                SqlDataAdapter employeeAdapter = new SqlDataAdapter(query, connection);
                employeeAdapter.Update(ds);
            }

        }

        //Hur löser vi user input? Kolla på sida 90!
        public void InsertCustomer(DataSet ds)
        {
            DataSet dataSet = new DataSet("Customer");
            string customerQuery = "SELECT * FROM Customer";

            using (SqlConnection connection = ConnectionHandler.GetDatabaseConnection())
            {
                SqlCommand customerSelectCommand = connection.CreateCommand();
                customerSelectCommand.CommandText = customerQuery;

                SqlDataAdapter customerAdapter = new();
                customerAdapter.SelectCommand = customerSelectCommand;

                SqlCommandBuilder commandBuilder = new();
                commandBuilder.DataAdapter = customerAdapter;

                customerAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                customerAdapter.Fill(dataSet, "Customer");

                DataTable customerDataTable = dataSet.Tables["Employee"];

                DataRow newCustomer = customerDataTable.NewRow();
                newCustomer["CustomerId"] = "User Input";
                newCustomer["CustomerName"] = "-II-";
                newCustomer["CustomerAddress"] = "-II-";
                newCustomer["PhoneNumber"] = "-II-";

                customerDataTable.Rows.Add(newCustomer);
                customerAdapter.Update(customerDataTable);
            }
        }
        //Detta är en alternativ lösning! Fill() är som en listener för förändring
        //kolla o jämför commandBuilder o adapter
        public void AlternateInsertCustomer(DataSet ds)
        {
            DataSet dataSet = new DataSet("Customer");
            string customerSelectQuery = "SELECT * FROM Customer";

            using(SqlConnection connection = ConnectionHandler.GetDatabaseConnection())
            {
                SqlCommand customerSelectCommand = connection.CreateCommand();
                customerSelectCommand.CommandText= customerSelectQuery;

                SqlDataAdapter customerAdapter = new(customerSelectCommand);

                SqlCommandBuilder customerCommandBuilder = new(customerAdapter);

                customerAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                customerAdapter.Fill(dataSet,"Employee");
                customerAdapter.Update(dataSet, "Employee");
            }
        }

    }
}
