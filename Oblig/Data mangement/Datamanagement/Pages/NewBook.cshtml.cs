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
            Book book = new Book();
            book.BookId = Convert.ToInt32(Request.Form["bookId"]);
            book.typeId = Convert.ToInt32(Request.Form["typeId"]);
            book.authorId = Convert.ToInt32(Request.Form["authorId"]);
            book.Title = Request.Form["Title"];
            book.TypeName = Request.Form["TypeName"];
            book.AutherLastName = Request.Form["AutherLastName"];
            book.AutherFirstName = Request.Form["AutherFirstName"];
            book.Pagecount = Convert.ToInt32(Request.Form["Pagecount"]);
            
            connectionString = _configuration.GetConnectionString("MyConnectionString");
            book.CreateBook(connectionString, book);
            Response.Redirect("./Books");
        }
    }
}
