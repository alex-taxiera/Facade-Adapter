using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {


            //// Using Facade


            //Console.ReadLine();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BookstoreForm());
        }
    }
}
