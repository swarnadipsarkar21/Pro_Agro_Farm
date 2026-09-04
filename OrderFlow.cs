using System;
using System.Windows.Forms;
using Pro_Agro_farm.DataAccess;
using Pro_Agro_farm.Forms;

namespace Pro_Agro_farm
{
    /// <summary>
    /// Shared "Add to Cart" flow for every product page. The user's phone
    /// and address are only collected once per session (via frmCheckout).
    /// Every order after that is placed immediately using the already-known
    /// phone/address, and goes straight to frmAddToCard, skipping Checkout.
    /// </summary>
    public static class OrderFlow
    {
        /// <summary>
        /// Call this from a product page's Add to Cart button, after Hide().
        /// Returns true if the calling form should Close() itself immediately
        /// (the user chose to go back to the dashboard), or false if it
        /// should refresh and Show() itself again.
        /// </summary>
        public static bool HandleAddToCart(int productId, string itemName, decimal quantity, decimal totalPrice)
        {
            bool hasDeliveryInfo = !string.IsNullOrEmpty(SessionCart.Phone) &&
                                    !string.IsNullOrEmpty(SessionCart.Address);

            if (!hasDeliveryInfo)
            {
                // First order this session -> collect phone/address via Checkout as usual.
                using (frmCheckout checkoutForm = new frmCheckout(productId, itemName, quantity, totalPrice))
                {
                    checkoutForm.ShowDialog();
                }
            }
            else
            {
                // Repeat order -> phone/address already known, place immediately, skip Checkout.
                try
                {
                    OrderRepository.InsertOrder(productId, itemName, quantity, totalPrice,
                         SessionCart.Phone, SessionCart.Address, SessionCart.CustomerName, SessionCart.SessionId);
                            ProductRepository.DecrementStock(productId, quantity);

                    SessionCart.Items.Add(new CartItem
                    {
                        ItemName = itemName,
                        Quantity = quantity,
                        TotalPrice = totalPrice
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not place your order: " + ex.Message, "Database Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                using (frmAddToCard cartForm = new frmAddToCard())
                {
                    cartForm.ShowDialog();
                }
            }

            return NavFlow.ReturnToDashboard;
        }
    }
}