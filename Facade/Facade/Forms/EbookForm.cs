using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facade_Adapter.Forms
{
    public partial class EbookForm : Form
    {
        private List<string> eBooks = new List<string>() //50 Entries
       {
            "The Da Vinci Code",
            "Pride and Prejudice (Jane Austen)",
            "To Kill A Mockingbird",
            "Gone With The Wind",
            "The Lord of the Rings: Return of the King",
            "The Lord of the Rings: Fellowship of the Ring",
            "The Lord of the Rings: Two Towers",
            "Anne of Green Gables",
            "Outlander",
            "A Fine Balance",
            "Harry Potter and the Goblet of Fire",
            "Angels and Demons",
            "Harry Potter and the Order of the Phoenix",
            "A Prayer for Owen Meany",
            "Memoirs of a Geisha",
            "Harry Potter and the Philosopher’s Stone",
            "Fall on Your Knees",
            "The Stand",
            "Harry Potter and the Prisoner of Azkaban",
            "Jane Eyre",
            "The Hobbit",
            "The Catcher in the Rye",
            "Little Women",
            "The Lovely Bones",
            "Life of Pi",
            "The Hitchhiker’s Guide to the Galaxy",
            "Wuthering Heights",
            "The Lion, The Witch and the Wardrobe",
            "East of Eden",
            "Tuesdays with Morrie",
            "Dune",
            "The Notebook",
            "Atlas Shrugged",
            "1984",
            "The Mists of Avalon",
            "The Pillars of the Earth",
            "The Power of One",
            "I Know This Much is True",
            "The Red Tent",
            "The Alchemist",
            "The Clan of the Cave Bear",
            "The Kite Runner",
            "Confessions of a Shopaholic",
            "The Five People You Meet In Heaven",
            "Bible",
            "Anna Karenina",
            "The Count of Monte Cristo",
            "Angela’s Ashes",
            "The Grapes of Wrath",
            "Ulysses"
        };

        public EbookForm()
        {
            InitializeComponent();
        }

        private void EbookForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                Book_Listbox.Items.Add(eBooks[i]);
            }
        }

        private void Accept_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Book_Listbox.SelectedItem + " is not available for preview in this demo", "Not Available", MessageBoxButtons.OK);
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
