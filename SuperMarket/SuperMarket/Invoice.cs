using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    public class Invoice : IPay
    {
        public Invoice() { }
        private List<Product > productsAcc = new List<Product>();
        public decimal ValueToPay()
        {
           decimal Accumulator = 0;
            foreach (Product item in productsAcc)
            {
                Accumulator += item.ValueToPay();
            }
            return Accumulator;
        }
        public override string ToString()
        {
            foreach (Product item in productsAcc)
            {
                Console.WriteLine(item.ToString());
               

            }
            return $"                ==========================" +
                $"\nTOTAL:            {$"{ValueToPay():C2}",15}";
        }
        public void AddProduct(Product product)
        {
            productsAcc.Add(product);
        }
    }
}
