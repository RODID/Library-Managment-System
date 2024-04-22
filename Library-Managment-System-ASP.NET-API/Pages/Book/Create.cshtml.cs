using Library_Managment_System_ASP.NET_API.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library_Managment_System_ASP.NET_API.Pages.Book
{
    public class CreateModel : PageModel
    {
        BookService bookService;
        public string message = "";

        public CreateModel(BookService bookService)
        {
            this.bookService = bookService;
        }

       
        public void OnGet()
        {
        }

        public void OnAddBook(objects.Book book)
        {
            if(ModelState.IsValid)
            {
                bookService.AddBook(book);
                message = book.Title + " added to the library!";
            }
            else
            {
                message = "Adding Book Failed!";
            }
        }
    }
}
