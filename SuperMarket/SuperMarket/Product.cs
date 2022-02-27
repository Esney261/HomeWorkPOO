using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    public class Product
    {
        private string _Description;
        private int _Id;
        private decimal _Price;
        private decimal _Tax;

        public Product(string Description,int Id,decimal Price,decimal Tax)
        {
            _Description = _Description;
            _Id = Id;
            _Price = Price;
            _Tax = Tax;
        }

        public override string ToString()
        {
            return $"{_Id}\n{_Description}\n{_Price}\n{_Tax}";
        }
    }
}
