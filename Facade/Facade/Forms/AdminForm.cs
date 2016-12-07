using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Facade_Adapter.Forms
{
    public partial class AdminForm : Form
    {
        IAdmin admin = new AdminManager();
        string[] books = System.IO.File.ReadAllLines("books.txt");
        public AdminForm()
        {
            InitializeComponent();
        }
        
        //set stock button
        private void button1_Click(object sender, EventArgs e)
        {
            admin.setInventory(idBox.Text, stockBox.Text, books);
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            admin.addUser(userBox.Text, passBox.Text, typeBox.Text);
        }

        private void adminExitButton_Click(object sender, EventArgs e)
        {
            File.WriteAllLines("books.txt", books, Encoding.UTF8);
            //something to switch forms
        }
    }
}
