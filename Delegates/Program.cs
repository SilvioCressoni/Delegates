using System;
using Predicates.Entities;
using System.Collections.Generic;
using System.Linq;

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

            Console.WriteLine("------------------------------");
            Console.WriteLine("adding FUNC and Lambda for change all to Upper");

            //Func<Product, string> func = ChangeToUpper;
            Func<Product, string> func = p => p.Name.ToUpper(); //another to do using Lambda

            List<string> result = list.Select(func).ToList();
            foreach (string r in result)
            {
                Console.WriteLine(r);
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("------   ADDING LINQ ----------");

            int[] number = new int[] { 1, 2, 3, 4, 5 };

            var count = number.Where(x => x % 2 == 0).Select(x => x * 2);

            foreach (int n in count)
            {
                Console.WriteLine(n);
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

        static string ChangeToUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
