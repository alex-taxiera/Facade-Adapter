using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class PaymentGatewayManager:IPaymentGateway
    {
        public string VerifyCardDetails(string cardNo)
        {
            return string.Format("\nCard# {0} has been verified and is accepted.\n",
                                             cardNo);
        }

        public string ProcessPayment(string cardNo, string cost)
        {
            return string.Format("Card# {0} is used to make a payment of ${1}.\n", cardNo, cost);
        }
    }
}
