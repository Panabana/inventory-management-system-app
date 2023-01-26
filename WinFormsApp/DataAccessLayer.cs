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
        public SqlConnection GetDatabaseConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings
                ["Test"].ConnectionString;

            SqlConnectionStringBuilder builder = new(connectionString);

            SqlConnection connection = new(builder.ConnectionString);

            return connection;
        }
//
//
        private string connectionString;

        public DataAccessLayer(String connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataSet GetCustomers()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))

            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Customer", connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataSet customers = new DataSet();
                        adapter.Fill(customers);
                    }
                }

            }
        }

        public DataSet ViewAllEmployees()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

            }
        }
    }
}
