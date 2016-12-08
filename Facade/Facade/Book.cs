using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Book
    {
        public bool inCart { get; set; }
        public string title { get; set; }
        public string summary { get; set; }
        public string price { get; set; }
        public string stock { get; set; }

        public Book()
        {
            inCart = false;
            title = "";
            summary = "";
            price = "";
            stock = "";
        }
    }
}
