using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Adapter
{
    interface ILogistics
    {
        void ShipProduct(string productName, string name, string shippingAddress);
    }
}
