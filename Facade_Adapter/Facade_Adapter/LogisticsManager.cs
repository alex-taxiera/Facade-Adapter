﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Adapter
{
    class LogisticsManager:ILogistics
    {
        public void ShipProduct(string productName, string name, string shippingAddress)
        {
            Console.WriteLine(string.Format("Congratulations {0}, your product '{1}' has been shipped to the following address:\n{2}", name, productName, shippingAddress));
        }
    }
}
