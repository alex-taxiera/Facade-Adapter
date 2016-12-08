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
            StreamReader userData = new StreamReader("user_log.txt");
            string line;

            username = Username_Textbox.Text;
            password = Password_Textbox.Text;


            bool login = false;
            do
            {
                line = userData.ReadLine();
                if (line == username)
                {
                    line = userData.ReadLine();
                    if (line == password)
                    {
                        line = userData.ReadLine();

                        if (line == "admin")
                        {
                            login = true;
                            userData.Close();
                            AdminForm admin = new AdminForm();
                            this.Hide();
                            admin.ShowDialog();
                        }
                        else if (line == "user")
                        {
                            login = true;
                            userData.Close();
                            UserDirectoryForm user = new UserDirectoryForm();
                            this.Hide();
                            user.Show();
                        }
                        else
                        {
                            MessageBox.Show("Error: Account Data Stored Incorrectly", "Account Error", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login", "Login Error", MessageBoxButtons.OK);
                        line = userData.ReadLine();
                    }
                }
                else
                {
                    line = userData.ReadLine();
                    line = userData.ReadLine();
                }
            } while (!login);

            MessageBox.Show("Invalid Login", "Login Error", MessageBoxButtons.OK);
        }
    }
}
