using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    interface IPaymentGateway
    {
        string VerifyCardDetails(string cardNo);
        string ProcessPayment(string cardNo, int cost);
    }
}
