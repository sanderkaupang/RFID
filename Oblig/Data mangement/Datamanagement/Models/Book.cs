﻿using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace Datamanagement.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public int Pagecount { get; set; }
        public string Title { get; set; }
        public string TypeName { get; set; }
        public string AutherFirstName { get; set; }
        public string AutherLastName { get; set; }



        public List<Book> GetBooks(string connectionString)
        {
            List<Book> bookList = new List<Book>();
            SqlConnection con = new SqlConnection (connectionString);
            string selectSQL = "select BookId, Title, Isbn, PublisherName, AuthorName, CategoryName from GetBookData";
            con.Open();
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    Book book = new Book();
                    book.BookId = Convert.ToInt32(dr["BookId"]);
                    book.Pagecount = Convert.ToInt32(dr["pagecount"]);
                    book.Title = dr["Title"].ToString();
                    book.TypeName = dr["TypeName"].ToString();
                    book.AutherLastName = dr["AutherLastName"].ToString();
                    book.AutherFirstName = dr["AutherFirstName"].ToString();
                }
            }
            return bookList;
        }

        public Book GetBookData(string connectionString, int bookId)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "select BookId, Title, Isbn, PublisherName, AuthorName, CategoryNamefrom GetBookData where BookId = " + bookId;
            con.Open();
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            SqlDataReader dr = cmd.ExecuteReader();
            Book book = new Book();
            if (dr != null)
            {
                while (dr.Read())
                {
                    book.BookId = Convert.ToInt32(dr["BookId"]);
                    book.Pagecount = Convert.ToInt32(dr["pagecount"]);
                    book.Title = dr["Title"].ToString();
                    book.AutherLastName = dr["AutherLastName"].ToString();
                    book.AutherFirstName = dr["AutherFirstName"].ToString();
                    book.TypeName = dr["TypeName"].ToString();
                }
            }
            return book;
        }
        public void CreateBook(string connectionString, Book book)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("CreateBook", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Title", book.Title));
                    cmd.Parameters.Add(new SqlParameter("@pagecount", book.Pagecount));
                    cmd.Parameters.Add(new SqlParameter("@AutherLastName", book.AutherLastName));
                    cmd.Parameters.Add(new SqlParameter("@AutherFirstName", book.AutherFirstName));
                    cmd.Parameters.Add(new SqlParameter("@TypeName", book.TypeName));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EditeBook(string connectionString, Book book)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("UpdateBook", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@BookId", book.BookId));
                    cmd.Parameters.Add(new SqlParameter("@Title", book.Title));
                    cmd.Parameters.Add(new SqlParameter("@pagecount", book.Pagecount));
                    cmd.Parameters.Add(new SqlParameter("@AutherLastName", book.AutherLastName));
                    cmd.Parameters.Add(new SqlParameter("@AutherFirstName", book.AutherFirstName));
                    cmd.Parameters.Add(new SqlParameter("@TypeName", book.TypeName));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteBook(string connectionString, int bookId) 
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("DeleteBook", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@BookId", bookId));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




    }

}
