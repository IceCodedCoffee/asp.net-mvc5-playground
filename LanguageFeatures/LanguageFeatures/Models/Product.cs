namespace LanguageFeatures.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        private string name;
        public string Name
        {
            get
            {
                return ProductID + " " + name;
            }
            set
            {
                name = value;
            }
        }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string Category { set; get; }
    }
}