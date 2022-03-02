﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    public class ComposedProduct : Product
    {
        private string  _ListProduc { get; set; }
        public float Discount { get; set; }
        public  ICollection Products { get; set; }
        public decimal Value { get; set; }
        public override decimal ValueToPay()
        {
            foreach (Product Names in Products)
            {
                float desc = 0;
                decimal ListNam;
                ListNam = Names.ValueToPay();
                desc = (float)ListNam * Discount;
                Value += ListNam - (decimal)desc;
            }
            return Value;
        }
        public override string ToString()
        {
           foreach (Product Discount in Products)
            {
                _ListProduc += Discount.Description + ", ";
            }
            return $"{base.ToString()}" +                
                 $"\n\tProducts...: {$"{_ListProduc}",9}"+
                  $"\n\tDiscount...: {$"{Discount:P2}",9}"+
                 $"\n\tValue...: {$"{ValueToPay():C2}",9}";
        }
    }
}
