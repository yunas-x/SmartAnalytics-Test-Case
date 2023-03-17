using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Smart_Analytics_TestCase
{

    public static class DBWorker
    {
        private static string ConnectionString
        {
            get => ConfigurationManager.ConnectionStrings["testString"].ConnectionString;
        }

        public static List<object[]> DoQuery(String query)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var rows = new List<object[]>();
                try
                {
                    connection.Open();

                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        object[] obj = new object[sqlDataReader.FieldCount];
                        sqlDataReader.GetValues(obj);
                        rows.Add(obj);
                    }
                }

                finally
                {
                    connection.Close();
                }

                return rows;
            }
        }

        public static List<object[]> DoNonQuery(String statement)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var rows = new List<object[]>();
                try
                {
                    connection.Open();

                    SqlCommand sqlCommand = new SqlCommand(statement, connection);
                    sqlCommand.ExecuteNonQuery();
                }

                finally
                {
                    connection.Close();
                }

                return rows;
            }
        }
    }
}
