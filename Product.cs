namespace Coursework_Console
{
    class Product // Class "Product"
    {
        public string Name { get; private set; }
        public double Price { get; private set; }

        public Product(string name, double price) // Constructor
        {
            Name = name;
            Price = price;
        }
    }
}
