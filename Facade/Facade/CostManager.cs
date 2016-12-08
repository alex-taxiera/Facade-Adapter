using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class CostManager:ICosting
    {
        public int ApplyDiscounts(int price)
        {
            //Console.WriteLine(string.Format("A discount of % has been applied on the product's price of ${1}", price));
            Random rnd = new Random();
            // * ( rnd.Next(1, 15)/100) Int32.Parse(price)
            int newPrice = price - 5;
            return newPrice; //- ((discountPercent / 100) * price);
        }
    }
}
