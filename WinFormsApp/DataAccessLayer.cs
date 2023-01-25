using System;
using System.Collections.Generic;
using System.Configuration;
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
                ["insertDetailsHere"].ConnectionString;

            SqlConnectionStringBuilder builder = new(connectionString);

            SqlConnection connection = new(builder.ConnectionString);

            return connection;
        }
    }
}
