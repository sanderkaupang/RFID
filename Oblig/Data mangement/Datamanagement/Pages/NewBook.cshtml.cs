using Datamanagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Datamanagement.Pages
{
    public class NewBookModel : PageModel
    {
        readonly IConfiguration _configuration;
        public string connectionString;
        public NewBookModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            connectionString = _configuration.GetConnectionString("MyConnectionString");
            Book book = new Book();
            book.BookId = Convert.ToInt32(Request.Form["bookId"]);
            book.Title = Request.Form["Title"];
            book.TypeName = Request.Form["TypeName"];
            book.Pagecount = Convert.ToInt32(Request.Form["typeId"]);
            book.AutherLastName = Request.Form["AutherLastName"];
       
            book.AutherFirstName = Request.Form["AutherFirstName"];
            book.Pagecount = Convert.ToInt32(Request.Form["Pagecount"]);

            book.CreateBook(connectionString, book);
            Response.Redirect("./Books");
        }
    }
}
