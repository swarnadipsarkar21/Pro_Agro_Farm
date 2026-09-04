using System;
using System.Data;
using System.Data.SqlClient;

namespace Pro_Agro_farm.DataAccess
{
    public class UserRecord
    {
        public string Username;
        public string Password;
        public string Role;
    }

    public static class UserRepository
    {
        /// <summary>Checks the Users table for a matching Admin username/password.</summary>
        public static bool ValidateAdmin(string username, string password)
        {
            DataTable dt = DatabaseHelper.ExecuteQuery(
                "SELECT * FROM Users WHERE Username = @U AND Password = @P AND Role = 'Admin'",
                new SqlParameter("@U", username),
                new SqlParameter("@P", password));

            return dt.Rows.Count > 0;
        }

        /// <summary>Returns the user's stored record, or null if the username doesn't exist yet.</summary>
        public static UserRecord GetUserByUsername(string username)
        {
            DataTable dt = DatabaseHelper.ExecuteQuery(
                "SELECT * FROM Users WHERE Username = @U",
                new SqlParameter("@U", username));

            if (dt.Rows.Count == 0) return null;

            DataRow row = dt.Rows[0];
            return new UserRecord
            {
                Username = row["Username"].ToString(),
                Password = row["Password"].ToString(),
                Role = row["Role"].ToString()
            };
        }

        /// <summary>First-time login for a username: save it to the Users table.</summary>
        public static void RegisterUser(string username, string password, string role)
        {
            DatabaseHelper.ExecuteNonQuery(
                "INSERT INTO Users (Username, Password, Role) VALUES (@U, @P, @R)",
                new SqlParameter("@U", username),
                new SqlParameter("@P", password),
                new SqlParameter("@R", role));
        }

        /// <summary>Used by Forgot Password after phone verification succeeds.</summary>
        public static void UpdatePassword(string username, string newPassword)
        {
            DatabaseHelper.ExecuteNonQuery(
                "UPDATE Users SET Password = @P WHERE Username = @U",
                new SqlParameter("@P", newPassword),
                new SqlParameter("@U", username));
        }

        /// <summary>True if this phone number matches one of this username's past orders.</summary>
        public static bool VerifyPhoneForUser(string username, string phone)
        {
            DataTable dt = DatabaseHelper.ExecuteQuery(
                "SELECT COUNT(*) AS Cnt FROM Orders WHERE CustomerName = @U AND CustomerPhone = @Phone",
                new SqlParameter("@U", username),
                new SqlParameter("@Phone", phone));

            if (dt.Rows.Count == 0) return false;
            return Convert.ToInt32(dt.Rows[0]["Cnt"]) > 0;
        }
    }
}