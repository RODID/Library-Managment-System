using Library_Managment_System_ASP.NET_API.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Library_Managment_System_ASP.NET_API.Objects;
using System.Collections.Generic;
using Library_Managment_System_ASP.NET_API.Data;

namespace Library_Managment_System_ASP.NET_API.Pages.Book
{
    public class IndexModel : PageModel
    {
        DatabaseContext databaseContext;

        public List<Objects.Book> bookList { get; set; }

        public string PageName { get; } = "Book Page";

        public IndexModel(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

       
       
        public void OnGet()
        {
            bookList = databaseContext.Books.ToList();
        }

        public void OnPost(Objects.Book book)
        {
            if (ModelState.IsValid)
            {
               databaseContext.Books.Add(book);
               databaseContext.SaveChanges();
            }
           
            bookList = databaseContext.Books.ToList();
        }

       

    }
}
