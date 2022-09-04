using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Herença_e_Polimorfismo___Desafio.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(DateTime manufactureDate, string name, double price) : base(name, price) 
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Name} (used) $ {Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date: {ManufactureDate.ToShortDateString()})");
            return sb.ToString();   
        }
    }
}
