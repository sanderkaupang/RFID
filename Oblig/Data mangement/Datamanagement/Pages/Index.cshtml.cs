using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Datamanagement.Models;

namespace Datamanagement.Pages
{
    public class IndexModel : PageModel
    {
        public string companyName;
        public string website;

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            //string connectionString = " Data Source=localhost\\SQLEXPRESS;Initial Catalog=RFID_Library;Integrated Security=True";
            //SqlConnection con = new SqlConnection(connectionString);
            //con.Open();
            //string sqlQuery = "select CompanyName, WebSite from COMPANY where CompanyId=1";
            //SqlCommand cmd = new SqlCommand(sqlQuery, con);
            //SqlDataReader dr = cmd.ExecuteReader();
            //if (dr.Read())
            //{

            //}
            //con.Close();
        }
    }
}