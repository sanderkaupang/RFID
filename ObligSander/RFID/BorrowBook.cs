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
    public partial class BorrowBook : Form
    {
        public BorrowBook()
        {
            InitializeComponent();
            string sqlQuery = @"SELECT* FROM GetBookData";
            try
            {
                ClassConnectionSQL classConnection = new ClassConnectionSQL();
                classConnection.ConnectionToDatabase();
                SqlDataAdapter sda;
                DataTable dt;
                sda = new SqlDataAdapter(sqlQuery, ClassConnectionSQL.myCon);
                dt = new DataTable();
                sda.Fill(dt);
                dgvBooks.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }


        }

        public void BorrowBookMethod()
        {

            string fromDate = textBoxFromDate.Text;
            string toDate = textBoxToDate.Text;
            string rfidId = textBoxRfidTag.Text;
            int bookId = Convert.ToInt32(textBoxBookId.Text);

            Borrow borrow = new Borrow();
            borrow.BorrowBoks(fromDate, toDate, rfidId, bookId);



        }





        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            var m = new MenuForm();     // Choose form is will open after registration
            m.Show();
            this.Hide();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            BorrowBookMethod();

            string sqlQuery2 = @"SELECT* FROM Borrow WHERE BORROW.rfidId ='" + textBoxRfidTag.Text + "'";
            try
            {
                ClassConnectionSQL classConnection = new ClassConnectionSQL();
                classConnection.ConnectionToDatabase();
                SqlDataAdapter sda;
                DataTable dt;
                sda = new SqlDataAdapter(sqlQuery2, ClassConnectionSQL.myCon);
                dt = new DataTable();
                sda.Fill(dt);
                dgvBorrowedBooks.DataSource = dt;
                textBoxBookId.Clear();
                textBoxFromDate.Clear();
                textBoxToDate.Clear();
                textBoxRfidTag.Clear();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void brnReturn_Click(object sender, EventArgs e)
        {
            if (true)
            {
                string sqlQuery2 = @"DELETE FROM Borrow WHERE BORROW.bookId ='" + Convert.ToInt32(textBoxReturnBook.Text) + "'";
                try
                {
                    ClassConnectionSQL classConnection = new ClassConnectionSQL();
                    classConnection.ConnectionToDatabase();
                    SqlDataAdapter sda;
                    DataTable dt;
                    sda = new SqlDataAdapter(sqlQuery2, ClassConnectionSQL.myCon);
                    dt = new DataTable();
                    sda.Fill(dt);
                    dgvBorrowedBooks.DataSource = dt;
                    textBoxReturnBook.Clear();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }

                MessageBox.Show("you have Returned a book");
            }
            else
            {
                MessageBox.Show("This book is not registrated on you");
            }

        }

        private void btnViewBorrowedBooks_Click(object sender, EventArgs e)
        {
            string sqlQuery2 = @"SELECT* FROM Borrow WHERE BORROW.rfidId ='" + textBoxViewBooksBorrowed.Text + "'";
            try
            {
                ClassConnectionSQL classConnection = new ClassConnectionSQL();
                classConnection.ConnectionToDatabase();
                SqlDataAdapter sda;
                DataTable dt;
                sda = new SqlDataAdapter(sqlQuery2, ClassConnectionSQL.myCon);
                dt = new DataTable();
                sda.Fill(dt);
                dgvBorrowedBooks.DataSource = dt;
                textBoxBookId.Clear();
                textBoxFromDate.Clear();
                textBoxToDate.Clear();
                textBoxRfidTag.Clear();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
