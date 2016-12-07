using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public interface IAdmin
{
    void setInventory(string productId, string stock, string[] books);
    void addUser(string id, string password, string userType);
}
