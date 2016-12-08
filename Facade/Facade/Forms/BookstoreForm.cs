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
    public partial class BookstoreForm : Form
    {
        string[] books = File.ReadAllLines("books.txt");
        

        public BookstoreForm()
        {
            Book[] bookList = new Book[books.Length / 4];
            int i = 0, j = 0;
            for (; i < (bookList.Length); i++)
            {
                Book B = new Book();
                B.inCart = false;
                B.title = books[j];
                j++;
                B.summary = books[j];
                j++;
                B.price = books[j];
                j++;
                B.stock = books[j];
                j++;

                bookList[i] = B;
            }
            InitializeComponent();
            dataGridView1.DataSource = bookList;
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            OrderDetails test =  new OrderDetails();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value))
                {
                    test.ProductName += dataGridView1.Rows[i].Cells[1].Value + ",";
                    test.Price += dataGridView1.Rows[i].Cells[3].Value;
                    test.Name = nameBox.Text;
                    test.AddressLine1 = addressBox.Text;
                    test.CardNo = cardBox.Text;
                }
            }

            OnlineShoppingFacade facade = new OnlineShoppingFacade();
            
            MessageBox.Show(facade.FinalizeOrder(test, books), "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            File.WriteAllLines("books.txt", books, Encoding.UTF8);
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value))
                {
                    dataGridView1.Rows[i].Selected = true;
                    dataGridView1.Rows[i].Visible = true;
                }
                else
                {
                    dataGridView1.Rows[i].Visible = false;
                    dataGridView1.Rows[i].Selected = false;
                }
            }
        }

        private void noCartButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                dataGridView1.Rows[i].Visible = true;
            }
        }
    }
}

