using Pro_Agro_farm.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Pro_Agro_farm.DataAccess
{
    public static class ProductRepository
    {
        private static Product MapRow(DataRow row)
        {
            return new Product
            {
                ProductID = Convert.ToInt32(row["ProductID"]),
                Category = row["Category"].ToString(),
                SubCategory = row["SubCategory"] == DBNull.Value ? null : row["SubCategory"].ToString(),
                ItemName = row["ItemName"].ToString(),
                Unit = row["Unit"].ToString(),
                Price = Convert.ToDecimal(row["Price"]),
                AvailableQty = Convert.ToDecimal(row["AvailableQty"])
            };
        }

        /// <summary>Used for single-item categories: Milk, Meat, Butter, BioGas, CowFeed, CowHide.</summary>
        public static Product GetByCategory(string category)
        {
            DataTable dt = DatabaseHelper.ExecuteQuery(
                "SELECT * FROM Products WHERE Category = @Category",
                new SqlParameter("@Category", category));

            if (dt.Rows.Count == 0)
                throw new Exception("Product not found for category: " + category);

            return MapRow(dt.Rows[0]);
        }

        public static Product GetById(int productId)
        {
            DataTable dt = DatabaseHelper.ExecuteQuery(
                "SELECT * FROM Products WHERE ProductID = @Id",
                new SqlParameter("@Id", productId));

            if (dt.Rows.Count == 0)
                throw new Exception("Product not found (ID: " + productId + ")");

            return MapRow(dt.Rows[0]);
        }

        public static List<Product> GetByCategoryAndSub(string category, string subCategory)
        {
            DataTable dt = DatabaseHelper.ExecuteQuery(
                "SELECT * FROM Products WHERE Category = @Category AND SubCategory = @Sub ORDER BY Price",
                new SqlParameter("@Category", category),
                new SqlParameter("@Sub", subCategory));

            List<Product> list = new List<Product>();
            foreach (DataRow row in dt.Rows) list.Add(MapRow(row));
            return list;
        }

        public static List<Product> GetByCategory_Multi(string category)
        {
            DataTable dt = DatabaseHelper.ExecuteQuery(
                "SELECT * FROM Products WHERE Category = @Category ORDER BY Price",
                new SqlParameter("@Category", category));

            List<Product> list = new List<Product>();
            foreach (DataRow row in dt.Rows) list.Add(MapRow(row));
            return list;
        }

        /// <summary>Admin: load every product row for the price/stock editor grid.</summary>
        public static List<Product> GetAllProducts()
        {
            DataTable dt = DatabaseHelper.ExecuteQuery(
                "SELECT * FROM Products ORDER BY Category, SubCategory");

            List<Product> list = new List<Product>();
            foreach (DataRow row in dt.Rows) list.Add(MapRow(row));
            return list;
        }

        /// <summary>Admin: update price and available quantity of a product.</summary>
        public static void UpdatePriceAndStock(int productId, decimal newPrice, decimal newQty)
        {
            DatabaseHelper.ExecuteNonQuery(
                "UPDATE Products SET Price = @Price, AvailableQty = @Qty WHERE ProductID = @Id",
                new SqlParameter("@Price", newPrice),
                new SqlParameter("@Qty", newQty),
                new SqlParameter("@Id", productId));
        }

        /// <summary>Reduce stock after a successful order.</summary>
        public static void DecrementStock(int productId, decimal amount)
        {
            DatabaseHelper.ExecuteNonQuery(
                "UPDATE Products SET AvailableQty = AvailableQty - @Amount WHERE ProductID = @Id",
                new SqlParameter("@Amount", amount),
                new SqlParameter("@Id", productId));
        }
    }
}