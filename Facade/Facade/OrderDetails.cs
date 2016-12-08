using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class OrderDetails
    {
        public string ProductName { get; set; }
        public string Price { get; set; }
        public string DiscountPercent { get;set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string CardNo { get; set; }
        public OrderDetails()
        {
            this.ProductName = "";
            this.Price = "";
            this.DiscountPercent = "";
            this.Name = "";
            this.AddressLine1 = "";
            this.CardNo = "";
        }
        public OrderDetails(string productName, string prodDescription, string price,
                            string discount, string name, string addressLine1,
                            string cardNo)
        {
            this.ProductName = productName;
            this.Price = price;
            this.DiscountPercent = discount;
            this.Name = name;
            this.AddressLine1 = addressLine1;
            this.CardNo = cardNo;
        }
    }
}
