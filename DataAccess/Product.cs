namespace Pro_Agro_farm.DataAccess
{
    public class Product
    {
        public int ProductID 
        { 
            get;
            set;
        }
        public string Category
        { 
            get; 
            set; 
        }
        public string SubCategory
        {
            get; 
            set; 
        }
        public string ItemName 
        { 
            get;
            set;
        }
        public string Unit 
        {
            get;
            set; 
        }
        public decimal Price 
        { 
            get;
            set;
        }
        public decimal AvailableQty 
        {
            get; 
            set; 
        }
    }
}
