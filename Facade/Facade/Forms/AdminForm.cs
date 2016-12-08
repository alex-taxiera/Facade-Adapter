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

namespace Facade
{
    public partial class AdminForm : Form
    {
        IAdmin admin = new AdminManager();
        string[] books = File.ReadAllLines("books.txt");
        public AdminForm()
        {
            InitializeComponent();
        }
        
        //set stock button
        private void button1_Click(object sender, EventArgs e)
        {
            admin.setInventory(idBox.Text, stockBox.Text, books);
            MessageBox.Show("Stock set", "Admin Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            idBox.Text = "";
            stockBox.Text = "";
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            admin.addUser(userBox.Text, passBox.Text, typeBox.Text);
            MessageBox.Show("User added", "Admin Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            userBox.Text = "";
            passBox.Text = "";
            typeBox.Text = "";
        }

        private void adminExitButton_Click(object sender, EventArgs e)
        {
            File.WriteAllLines("books.txt", books, Encoding.UTF8);
            System.Diagnostics.Process.Start(Application.ExecutablePath); // to start new instance of application
            this.Close(); //to turn off current app
        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
