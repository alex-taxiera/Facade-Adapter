using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class OnlineShoppingFacade
    {
        IInventory inventory = new InventoryManager();
        ICosting costManager = new CostManager();
        IPaymentGateway paymentGateWay = new PaymentGatewayManager();
        ILogistics logistics = new LogisticsManager();

        public string FinalizeOrder(OrderDetails orderDetails, string[] books)
        {
            string message = "";
            inventory.Update(orderDetails.ProductName, books);
            orderDetails.Price = costManager.ApplyDiscounts(orderDetails.Price);
            message += "Total after discounts: " + orderDetails.Price;
            message += paymentGateWay.VerifyCardDetails(orderDetails.CardNo);
            message += paymentGateWay.ProcessPayment(orderDetails.CardNo, orderDetails.Price);
            message += logistics.ShipProduct(orderDetails.ProductName, orderDetails.Name, string.Format("{0}", orderDetails.AddressLine1));
            return message;
        }
    }
}
