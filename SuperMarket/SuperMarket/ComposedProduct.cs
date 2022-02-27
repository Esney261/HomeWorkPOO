using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public int MyProperty { get; set; }
        public override decimal ValueToPay()
        {
            return Price;
        }
        public override string ToString()
        {
            return $"{base.ToString()}/n Value to pay:{ValueToPay()}";
        }
    }
}
