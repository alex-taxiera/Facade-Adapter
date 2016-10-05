﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Adapter
{
    interface IPaymentGateway
    {
        bool VerifyCardDetails(string cardNo);
        bool ProcessPayment(string cardNo, float cost);
    }
}
