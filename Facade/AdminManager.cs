using System;

public class AdminManager:IAdmin
{
    public void setInventory(string productId, string stock, string[] books)
    {
        for(int i = 0; i < books.Length; i + 2)
        {
            if (books[i].Equals(productId))
            {
                i++;
                books[i] = stock;
            }
        }
    }
    public void addUser(int id, string password, string userType)
    {
        using (StreamWriter sw = File.AppendText(user_log.txt))
        {
            sw.WriteLine(id);
            sw.WriteLine(password);
            sw.WriteLine(userType);
        }
    }
}
