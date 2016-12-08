using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class CostManager:ICosting
    {
        public string ApplyDiscounts(string price)
        {
            //Console.WriteLine(string.Format("A discount of % has been applied on the product's price of ${1}", price));
            Random rnd = new Random();
            // * ( rnd.Next(1, 15)/100) Int32.Parse(price)
            int newPrice = Int32.Parse(price) - 5;
            return newPrice.ToString(); //- ((discountPercent / 100) * price);
        }
    }
}
