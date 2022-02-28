using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }
        public float Quantity { get; set; }

        public override decimal ValueToPay()
        {
            return Price;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\n Value to pay:{ValueToPay()}";
        }
    }
}
