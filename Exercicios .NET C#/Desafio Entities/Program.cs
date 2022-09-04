using Desafio_Entities.Entities;
using Desafio_Entities.Entities.Enum;
using System;
using System.Globalization;

namespace Desafio_Entities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDay = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name,email,birthDay);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order ?");
            int orders = int.Parse(Console.ReadLine());

            Order Order = new Order(DateTime.Now, status, client);

            for (int i = 1; i <= orders; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string ProductName = Console.ReadLine();
                Console.Write("Product price: ");
                double ProductPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product p = new Product(ProductName,ProductPrice);

                Console.Write("Quantity: ");
                int Quantity = int.Parse(Console.ReadLine());

                OrderItem Item = new OrderItem(Quantity,p,ProductPrice);

                Order.AddItem(Item);
            }

            Console.WriteLine(Order);

        }
    }
}
