using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Helpers
{
    public static class DBHelper
    {
        private static SqlConnection GetSqlConnection()
        {
            var con = new SqlConnectionStringBuilder
            {
                DataSource = "(local)",
                InitialCatalog = "Dota2HelperDB",
                IntegratedSecurity = true
            };
            return new SqlConnection(con.ConnectionString);
        }
       public static IDataReader GetDataReader(string query)
        {
            using (IDbConnection connection = DBHelper.GetSqlConnection())
            {
                try
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = query;
                    command.CommandType = CommandType.Text;
                    IDataReader reader = command.ExecuteReader();
                    return reader;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
