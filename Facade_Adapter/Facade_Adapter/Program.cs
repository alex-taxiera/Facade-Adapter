using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facade_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating the Order/Product details
            //OrderDetails orderDetails = new OrderDetails("Design Pattern Book",
            //                                             "Simplified book on design patterns",
            //                                             500,
            //                                             10,
            //                                             "Murat Gungor",
            //                                             "163 S Willard St",
            //                                             "Burlington VT 05402",
            //                                             "4156213754"
            //                                             );

            // Using Facade
            //OnlineShoppingFacade facade = new OnlineShoppingFacade();
            //facade.FinalizeOrder(orderDetails);

            //Console.ReadLine();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());

        }
    }
}
