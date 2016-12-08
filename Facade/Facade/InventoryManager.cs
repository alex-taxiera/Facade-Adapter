using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class InventoryManager:IInventory
    {
        public void Update(string productId, string[] books)
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            string[] items = productId.Split(delimiterChars);
            for (int i = 0; i < items.Length; i++)
            {
                for(int j = 0; j < books.Length; j++)
                {
                    if (items[i] == books[j])
                    {
                        int stock = Int32.Parse(books[j + 3]) - 1;
                        books[j + 3] = (stock.ToString());
                    }
                }
            }
       }
    }
}
