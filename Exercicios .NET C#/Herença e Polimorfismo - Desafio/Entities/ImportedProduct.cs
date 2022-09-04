using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Herença_e_Polimorfismo___Desafio.Entities
{
    internal class ImportedProduct : Product
    {

        public double CustomsFee { get; set; }

        public ImportedProduct(double customsFee, string name, double price) : base(name, price)
        {
            CustomsFee = customsFee;
        }


        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"" +
                $"{Name} $ {TotalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Customs fee: $ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})");
            return sb.ToString();
        }


    }
}
