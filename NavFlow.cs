namespace Pro_Agro_farm
{
    /// <summary>
    /// When Checkout's Place Order succeeds and the user chooses "Yes" on
    /// "Do You Want To Add Something?", we need to skip past the product
    /// page (e.g. frmMilk) that opened Checkout and land straight back on
    /// frmMainManu. This flag lets the in-between product page know it
    /// should close itself immediately instead of showing itself again.
    /// </summary>
    public static class NavFlow
    {
        public static bool ReturnToDashboard = false;
    }
}