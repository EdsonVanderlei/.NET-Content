using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Desafio_Entities.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double PriceProduct { get; set; }

        public Product Product { get; set; }

        public OrderItem(int quantity, Product product, double priceProduct)
        {
            Quantity = quantity;
            PriceProduct = priceProduct;
            Product = product;
        }


        public double SubTotal()
        {
            return Quantity * PriceProduct;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Product.ProductName},{PriceProduct}, Quantity: {Quantity}, Subtotal: {SubTotal().ToString("F2", CultureInfo.InvariantCulture) } ");

            Console.WriteLine(sb.ToString());

            return sb.ToString();
        }
    }
}
