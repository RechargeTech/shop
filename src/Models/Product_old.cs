namespace Shop.Models
{
    public class Product_old
    {
        public string productId { get; set; }
        public string Group { get; set; }
        public string Icon { get; set; }
        public string Category { get; set; }
        public string SubCategory { get ; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string Price { get; set; }
        public string URL { get; set; }
        public string[] Color { get; set; }

        public string productLink
        {
            get
            {
                return "product/" + productId;
            }
        }
    }
}