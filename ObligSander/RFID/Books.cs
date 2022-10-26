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

        public void DelBook()
        {
            string bookTitle = textBoxDeleteBook.Text;
            DeleteBook deleteBook = new DeleteBook();
            deleteBook.ClassDeleteBook(bookTitle);
        }

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

        private void btnViewBook_Click(object sender, EventArgs e)
        {
            string sqlQuery = @"SELECT* FROM BOOK";
            viewInDataGridView(sqlQuery);
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            var m = new AddBooks();     // Choose form is will open after registration
            m.Show();
            this.Hide();
        }
    }
}
