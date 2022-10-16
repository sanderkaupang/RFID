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
            book.Title = Request.Form["Title"];
            book.TypeName = Request.Form["Type"];
            book.AutherLastName = Request.Form["AutherLastName"];
            book.AutherFirstName = Request.Form["AutherFirstName"];
            book.Pagecount = Convert.ToInt32(Request.Form["Pagecount"]);
            connectionString = _configuration.GetConnectionString("ConnectionString");
            book.CreateBook(connectionString, book);
            Response.Redirect("./Books");
        }
    }
}
