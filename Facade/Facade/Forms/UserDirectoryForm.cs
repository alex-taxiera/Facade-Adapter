using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facade
{
    public partial class UserDirectoryForm : Form
    {
        public UserDirectoryForm()
        {
            InitializeComponent();
        }

        private void UserDirectoryForm_Load(object sender, EventArgs e)
        {

        }

        private void Accept_Button_Click(object sender, EventArgs e)
        {
            if (eBook_RadioButton.Checked == true)
            {
                EbookForm eBook = new EbookForm();
                eBook.Show();
                this.Hide();
            }
            else if (store_RadioButton.Checked == true)
            {
                BookstoreForm store = new BookstoreForm();
                store.Show();
                this.Hide();
            }
        }
    }
}
