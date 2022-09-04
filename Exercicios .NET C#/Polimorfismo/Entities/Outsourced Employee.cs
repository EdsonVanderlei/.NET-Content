using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo.Entities
{
    internal class Outsourced_Employee : Employee
    {

        public double AdditionalCharge { get; set; }

        public Outsourced_Employee(string name, int hours, double valuePerHour,double addtionalCharge) : base(name,hours,valuePerHour)
        {
            AdditionalCharge = addtionalCharge;
        }


        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
