using System;
using System.Data;

namespace QL_COFFE_KVC
{
    public class UserInfo
    {
        public int Id { get; private set; }
        public string Username { get; private set; }
        public string FullName { get; private set; }
        public bool IsAdmin { get; private set; }
        public bool IsManager { get; private set; }
        public int Status { get; private set; }

        public static UserInfo Instance { get; } = new UserInfo();

        public static void FromRow(DataRow row)
        {
            Instance.FromRow(Convert.ToInt32(row["id"]), row["username"].ToString(), row["full_name"].ToString(), Convert.ToBoolean(row["admin"]), Convert.ToBoolean(row["manager"]), Convert.ToInt32(row["trang_thai"]));
        }

        void FromRow(int id, string username, string fullName, bool isadmin, bool ismanager, int status)
        {
            Id = id;
            Username = username;
            FullName = fullName;
            IsAdmin = isadmin;
            IsManager = ismanager;
            Status = status;
        }

        UserInfo()
        {

        }
    }
}
