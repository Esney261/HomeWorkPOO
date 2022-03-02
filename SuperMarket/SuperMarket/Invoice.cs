using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    public class Invoice : IPay

    {
        public Invoice()
        { }
        public List<Product> products = new List<Product>();

        public decimal ValueToPay()
        {
            decimal Accumulator = 0;

            foreach (Product item in products)
            {
                Accumulator += item.ValueToPay();
            }
            return Accumulator;
        }
        public override string ToString()
        {
            foreach (Product item in products)
            {
                Console.WriteLine(item.ToString());


            }
            return $"                ==========================" +
                $"\nTOTAL:            {$"{ValueToPay():C2}",15}";
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }
    } 
    
   
}
