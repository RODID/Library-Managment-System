using Library_Managment_System_ASP.NET_API.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography.X509Certificates;

namespace Library_Managment_System_ASP.NET_API.Pages
{
    public class IndexModel : PageModel
    {
        BookService bookService;
        public List<BooksDb> books;

        public IndexModel(BookService bookService)
        {
            this.bookService = bookService;
        }

        public void OnGet()
        {

        }
    }
}
