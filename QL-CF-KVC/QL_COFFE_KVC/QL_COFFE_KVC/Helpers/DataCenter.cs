using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace QL_COFFE_KVC
{
    public sealed class DataCenter
    {
        public static DataCenter Instance { get; } = new DataCenter();

        readonly string ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        const int EXECUTE_TIMEOUT = 30;

        public DataSet ExecuteDataSet(string controller, string commandName, DataSet dsParams = null, params int[] declare)
        {
            var build = new StringBuilder();
            build.AppendLine(Utils.DataSetToScript(dsParams, declare));
            build.AppendLine(QueryManager.Instance.GetQuery(controller, commandName));
            return SqlUtils.SQLRetrieve(new SqlConnection(ConnectionString), ReplaceUserInfo(build.ToString()), "EXECUTE", new DataSet(), EXECUTE_TIMEOUT);
        }

        public DataTable ExecuteDataTable(string controller, string commandName, DataSet dsParams = null, params int[] declare)
        {
            var ds = ExecuteDataSet(controller, commandName, dsParams, declare);
            return ds.Tables.Count > 0 ? ds.Tables[0] : null;
        }

        public DataRow ExecuteDataRow(string controller, string commandName, DataSet dsParams = null, params int[] declare)
        {
            var tb = ExecuteDataTable(controller, commandName, dsParams, declare);
            if (tb == null) return null;
            return tb.Rows.Count > 0 ? tb.Rows[0] : null;
        }

        public T ExecuteValue<T>(string controller, string commandName, DataSet dsParams = null, params int[] declare)
        {
            var build = new StringBuilder();
            build.AppendLine(Utils.DataSetToScript(dsParams, declare));
            build.AppendLine(QueryManager.Instance.GetQuery(controller, commandName));
            return (T)SqlUtils.SQLGetValue(new SqlConnection(ConnectionString), ReplaceUserInfo(build.ToString()), EXECUTE_TIMEOUT);
        }

        public void Execute(string controller, string commandName, DataSet dsParams = null, params int[] declare)
        {
            var build = new StringBuilder();
            build.AppendLine(Utils.DataSetToScript(dsParams, declare));
            build.AppendLine(QueryManager.Instance.GetQuery(controller, commandName));
            SqlUtils.SQLExecute(new SqlConnection(ConnectionString), ReplaceUserInfo(build.ToString()), EXECUTE_TIMEOUT);
        }

        public DataRow Login(string username, string password)
        {
            return Instance.ExecuteDataRow("System", "Login", new DataSet().AddTable(new DataTable().AddRowValue("username", username).AddRowValue("password", password)), 0);
        }

        string ReplaceUserInfo(string query)
        {
            return query.Replace("@@userID", UserInfo.Instance.Id.ToString())
                .Replace("@@username", UserInfo.Instance.Username)
                .Replace("@@fullName", UserInfo.Instance.FullName)
                .Replace("@@admin", UserInfo.Instance.IsAdmin ? "1" : "0")
                .Replace("@@manager", UserInfo.Instance.IsManager ? "1" : "0");
        }
    }
}
