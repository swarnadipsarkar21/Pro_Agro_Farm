using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Pro_Agro_farm.DataAccess
{
    /// <summary>One raw row from the Orders table.</summary>
    public class OrderRow
    {
        public int OrderID { get; set; }
        public string SessionId { get; set; }
        public string CustomerName { get; set; }
        public string ItemName { get; set; }
        public decimal QuantityOrdered { get; set; }
        public decimal TotalPrice { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }
        public bool Delivered { get; set; }
    }

    public static class OrderRepository
    {
        public static void InsertOrder(int productId, string itemName, decimal quantity,
            decimal totalPrice, string phone, string address, string customerName, string sessionId)
        {
            DatabaseHelper.ExecuteNonQuery(
                @"INSERT INTO Orders (ProductID, ItemName, QuantityOrdered, TotalPrice, CustomerPhone, CustomerAddress, CustomerName, OrderSessionID, Delivered, OrderDate)
                  VALUES (@ProductID, @ItemName, @Qty, @Total, @Phone, @Address, @CustomerName, @SessionId, 0, GETDATE())",
                new SqlParameter("@ProductID", productId),
                new SqlParameter("@ItemName", itemName),
                new SqlParameter("@Qty", quantity),
                new SqlParameter("@Total", totalPrice),
                new SqlParameter("@Phone", phone),
                new SqlParameter("@Address", address),
                new SqlParameter("@CustomerName", (object)customerName ?? DBNull.Value),
                new SqlParameter("@SessionId", (object)sessionId ?? DBNull.Value));
        }

        /// <summary>Admin: load every order row, to be grouped per customer session in frmOrders.</summary>
        public static List<OrderRow> GetAllOrders()
        {
            DataTable dt = DatabaseHelper.ExecuteQuery(
                "SELECT * FROM Orders ORDER BY OrderDate DESC");

            List<OrderRow> list = new List<OrderRow>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new OrderRow
                {
                    OrderID = Convert.ToInt32(row["OrderID"]),
                    SessionId = row["OrderSessionID"] == DBNull.Value ? "" : row["OrderSessionID"].ToString(),
                    CustomerName = row["CustomerName"] == DBNull.Value ? "" : row["CustomerName"].ToString(),
                    ItemName = row["ItemName"].ToString(),
                    QuantityOrdered = Convert.ToDecimal(row["QuantityOrdered"]),
                    TotalPrice = Convert.ToDecimal(row["TotalPrice"]),
                    CustomerPhone = row["CustomerPhone"].ToString(),
                    CustomerAddress = row["CustomerAddress"].ToString(),
                    Delivered = row["Delivered"] != DBNull.Value && Convert.ToBoolean(row["Delivered"])
                });
            }
            return list;
        }

        /// <summary>Admin: mark every order belonging to this customer session as delivered/not delivered.</summary>
        public static void UpdateDeliveryStatusForSession(string sessionId, bool delivered)
        {
            DatabaseHelper.ExecuteNonQuery(
                "UPDATE Orders SET Delivered = @Delivered WHERE OrderSessionID = @SessionId",
                new SqlParameter("@Delivered", delivered),
                new SqlParameter("@SessionId", sessionId));
        }
    }
}