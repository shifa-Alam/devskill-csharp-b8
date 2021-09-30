using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            var customers = new List<(string name, int age)>();
            customers.Add(new("jalaluddin", 40));
            customers.Add(new("hasan", 33));
            customers.Add(new("tareq", 23));
            customers.Add(new("masud", 12));
            customers.Add(new("rashed", 20));
            customers.Add(new("bijon", 47));


            var products = new List<(string name, string customerName, double price)>();
            products.Add(new("camera", "tareq", 3000));
            products.Add(new("laptop", "bijon", 4500.5));
            products.Add(new("camera", "rashed", 2300));
            products.Add(new("headphone", "bijon", 1200));
            products.Add(new("pendrive", "masud", 2000));
            products.Add(new("pendrive", "tareq", 1000));

            var result = Combine(customers, products);

            foreach (var item in result)
            {
                Console.WriteLine($"Customer Name: {item.customerName}, Product Name: {item.productName}, Price: {item.price}");
            }
        }

        public static List<(string customerName, int customerAge, string productName, double price)> Combine(
            List<(string name, int age)> customers,
            List<(string name, string customerName, double price)> products)
        {
            var combineList = new List<(string customerName, int customerAge, string productName, double price)>();

           
            var innerJoin = customers.Join(
                products,
                customer => customer.name,
                product => product.customerName,
                (customer, product) => new
                {
                    customerName = product.customerName,
                    customerAge = customer.age,
                    productName = product.name,
                    price = product.price
                }
                ).ToList();

            foreach (var item in innerJoin)
            {
                combineList.Add(new (item.customerName,item.customerAge,item.productName,item.price));
            }

            return combineList;
        }
    }
}
