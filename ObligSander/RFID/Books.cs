using Microsoft.Data.SqlClient;
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
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }

        // Use BookTitle to dele book from database
        public void DelBook()
        {
            string bookTitle = textBoxDeleteBook.Text;
            DeleteBook deleteBook = new DeleteBook();
            deleteBook.ClassDeleteBook(bookTitle);
        }

        // method to view somthing in the dataGridView
        void viewInDataGridView(string sqlQuery)
        {
            try
            {
                ClassConnectionSQL classConnection = new ClassConnectionSQL();
                classConnection.ConnectionToDatabase();
                SqlDataAdapter sda;
                DataTable dt;
                sda = new SqlDataAdapter(sqlQuery, ClassConnectionSQL.myCon);
                dt = new DataTable();
                sda.Fill(dt);
                dgvViewBook.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }


        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            DelBook();
        }

        // use the method to view in gridview with an sql query as argument
        private void btnViewBook_Click(object sender, EventArgs e)
        {
            string sqlQuery = @"SELECT* FROM GetBookData";
            viewInDataGridView(sqlQuery);
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            var m = new AddBooks();     // open form to add book
            m.Show();
            this.Hide();
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            var m = new MenuForm();     // Go back to menu form
            m.Show();
            this.Hide();
        }
    }
}
