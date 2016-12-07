using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public class AdminManager : IAdmin
{
    public void setInventory(string productId, string stock, string[] books)
    {
        for(int i = 0; i < books.Length; i++)
        {
            if (books[i].Equals(productId))
            {
                i++;
                books[i] = stock;
            }
            i++;
        }
    }
    public void addUser(string id, string password, string userType)
    {
        using (StreamWriter sw = File.AppendText("user_log.txt"))
        {
            sw.WriteLine(id);
            sw.WriteLine(password);
            sw.WriteLine(userType);
        }
    }
}
