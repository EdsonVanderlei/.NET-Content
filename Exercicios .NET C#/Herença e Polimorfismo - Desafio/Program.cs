using System;
using System.Collections.Generic;
using System.Globalization;
using Herença_e_Polimorfismo___Desafio.Entities;

namespace Herença_e_Polimorfismo___Desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int times = int.Parse(Console.ReadLine());
            List<Product> Products = new List<Product>();
            for (int i = 1; i <= times; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char choose = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                switch (choose)
                {
                    case 'c':
                        Product product = new Product(name, price);
                        Products.Add(product);

                        break;
                    case 'u':
                        Console.Write("Manufacture date (DD/MM/YYYY) ");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        Product product1 = new UsedProduct(date, name, price);
                        Products.Add(product1);

                        break;
                    case 'i':
                        Console.Write("Customs fee: ");
                        double customsFee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                        Product product2 = new ImportedProduct(customsFee, name, price);
                        Products.Add(product2);
                        break;


                    default:
                        break;
                }
               

                



            }
            Console.WriteLine();
            Console.WriteLine("PRICETAGS: ");
            Console.WriteLine();
            foreach (Product product in Products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
