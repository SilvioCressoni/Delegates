using System;
namespace Predicates.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return "Product´s Name : " + Name + " Value of Product : " + Price;
        }
    }
}
