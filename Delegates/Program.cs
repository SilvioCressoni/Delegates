using System;
using Predicates.Entities;
using System.Collections.Generic;

namespace Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Television", 900.00));
            list.Add(new Product("Laptop", 700.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Webcam", 100.00));
            list.Add(new Product("Wire", 50.00));
            list.Add(new Product("Charger", 250.00));

            // 1 - related 
            //list.RemoveAll(p => p.Price <= 100.0);

            //2 - For use this method ForEach, It needs to inform as argument a method  Product's type
            // and void as return. Per example: UpdatePrice
            //list.ForEach(UpdatedPrice);

            //Another way to use, using Lambda
            list.ForEach(p => p.Price += p.Price * 0.10);

            foreach (Product p in list)
            {
                Console.WriteLine(p.ToString());
            }
        }

        // 1 - commented due being using lambda on the method removeAll.
        //public static bool ProductTest(Product p)
        //{
        //    return p.Price <= 100.00;
        //}

        // 2 - Let´s use Action incresing 10% in the prices
        //
        static void UpdatedPrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
