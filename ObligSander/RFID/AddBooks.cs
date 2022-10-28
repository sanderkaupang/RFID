using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID
{
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void RegistrateBook()
        {

            string bookTitle = textBoxBookTitle.Text;
            int pagecount = Convert.ToInt32(textBoxPagecount.Text);
            string bookType = textBoxBookType.Text;
            string autherFirstname = textBoxAutherFirstname.Text;
            string autherLastname = textBoxAutherLastname.Text;


            AddBook addBook = new AddBook();
            addBook.RegistrateBook(bookTitle, pagecount, bookType, autherFirstname, autherLastname);

        }
        //private void ChangeBookDetails()
        //{

        //    string bookTitle = textBoxBookTitle.Text;
        //    int pagecount = Convert.ToInt32(textBoxPagecount.Text);
        //    string bookType = textBoxBookType.Text;
        //    string autherFirstname = textBoxAutherFirstname.Text;
        //    string autherLastname = textBoxAutherLastname.Text;


        //    ChangeBook changeBook = new ChangeBook();   
        //    changeBook.ChangeBookDetails(bookTitle, pagecount, bookType, autherFirstname, autherLastname);

        //}


        private void btnAddBook_Click(object sender, EventArgs e)
        {
            RegistrateBook();

            var m = new Books();     // Choose form is will open after registration
            m.Show();
            this.Hide();
        }

        private void buttonBackToBooks_Click(object sender, EventArgs e)
        {
            var m = new Books();     // Choose form is will open after registration
            m.Show();
            this.Hide();
        }
    }
}
