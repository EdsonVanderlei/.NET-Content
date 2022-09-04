using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Herença_e_Polimorfismo___Desafio.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name} $ {Price.ToString("F2", CultureInfo.InvariantCulture)}");

            return sb.ToString();
        }
    }
}
