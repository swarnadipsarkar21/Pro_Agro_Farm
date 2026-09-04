using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Pro_Agro_farm.DataAccess
{
    /// <summary>
    /// Central place for all raw SQL Server access.
    /// Every method wraps its work in try/catch and rethrows a clean,
    /// user-friendly exception so calling forms can show a MessageBox.
    /// </summary>
    public static class DatabaseHelper
    {
        private static string ConnectionString
        {
            get { return ConfigurationManager.ConnectionStrings["Agro_Farm_Connection"].ConnectionString; }
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public static DataTable ExecuteQuery(string sql, params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error while reading data: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected error while reading data: " + ex.Message, ex);
            }
        }

        public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error while saving data: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected error while saving data: " + ex.Message, ex);
            }
        }

        public static object ExecuteScalar(string sql, params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected error: " + ex.Message, ex);
            }
        }

        /// <summary>Quick connectivity check used on startup pages if needed.</summary>
        public static bool TestConnection(out string errorMessage)
        {
            errorMessage = null;
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                }
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }
    }
}
