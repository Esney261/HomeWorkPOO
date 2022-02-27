﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    public abstract class Product
    {
        public string Description { get; set; }
        public int Id { get; set; }
        public decimal Price { get; set; }
        public double Tax { get; set; }

        public abstract decimal ValueToPay();

        public override string ToString()
        {
            return $"codigo:{Id}/nDescription:{Description}/n{Price}/n{Tax}";
        }
    }
}
