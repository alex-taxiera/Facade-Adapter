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
using Facade_Adapter.Forms;

namespace Facade_Adapter
{
    public partial class LoginForm : Form
    {
        private string username;
        private string password;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e) { }
        private void Password_Textbox_TextChanged(object sender, EventArgs e) { }
        private void Username_Textbox_TextChanged(object sender, EventArgs e) { }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            StreamReader userData = new StreamReader("userData.txt");
            string line;

            username = Username_Textbox.Text;
            password = Password_Textbox.Text;

            line = userData.ReadLine();

            do
            {
                if (line == username)
                {
                    line = userData.ReadLine();
                    if (line == password)
                    {
                        line = userData.ReadLine();

                        if (line == "A")
                        {
                            AdminForm admin = new AdminForm();
                            admin.Show();
                            this.Hide();
                        }
                        else if (line == "U")
                        {
                            UserDirectoryForm user = new UserDirectoryForm();
                            user.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Error: Account Data Stored Incorrectly", "Account Error", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login", "Login Error", MessageBoxButtons.OK);
                    }
                }
            } while (!userData.EndOfStream);

            MessageBox.Show("Invalid Login", "Login Error", MessageBoxButtons.OK);
        }
    }
}
