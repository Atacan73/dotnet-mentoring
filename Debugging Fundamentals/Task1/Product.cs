namespace Task1
{
    public class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        // create a func to check if objects equal
        public bool Equals(Product product)
        {
            if (product == null)
                return false;

            return (Name == product.Name) && (Price == product.Price);
        }
    }
}
