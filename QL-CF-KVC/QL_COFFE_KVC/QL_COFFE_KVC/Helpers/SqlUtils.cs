using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QL_COFFE_KVC
{
    public static class SqlUtils
    {
        public static object SQLGetValue(this SqlConnection connection, string command, int secondTimeout, bool close = true)
        {
            return SQLRetrieve(connection, command, "GETVALUE", new DataSet(), secondTimeout, close).Tables[0].Rows[0][0];
        }

        public static DataSet SQLRetrieve(this SqlConnection connection, string command, string alias, DataSet ds, int secondTimeout, bool close = true)
        {
            if (connection.State != ConnectionState.Open) connection.Open();
            new SqlDataAdapter(new SqlCommand(command, connection) { CommandTimeout = secondTimeout }).Fill(ds, alias);
            if (close) connection.Close();
            return ds;
        }

        public static void SQLExecute(this SqlConnection connection, string command, int secondTimeout, bool force = true)
        {
            if (connection.State != ConnectionState.Open) connection.Open();
            new SqlCommand(command, connection) { CommandTimeout = secondTimeout }.ExecuteNonQuery();
            if (force) connection.Close();
        }

        public static string SafeCode(this string value, int length = 0)
        {
            return Safe(value, length, "");
        }

        public static string Safe(this string value, int length = 0, string target = "''")
        {
            if (string.IsNullOrEmpty(value))
                return value;
            if (length == 0 || value.Length < length)
                return value.Replace("'", target).Trim();
            return value.Substring(0, length).Replace("'", target).Trim();
        }

        public static string SafeNotTrim(this string value, int length = 0)
        {
            if (string.IsNullOrEmpty(value))
                return value;
            if (length == 0 || value.Length < length)
                return value.Replace("'", "''");
            return value.Substring(0, length).Replace("'", "''");
        }

        public static string SafeColumnName(this string value)
        {
            return Regex.Replace(value, "[^a-z|A-Z|0-9|_|$]", "");
        }
    }
}
