using Library_Managment_System_ASP.NET_API.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Library_Managment_System_ASP.NET_API.Objects;
using System.Collections.Generic;

namespace Library_Managment_System_ASP.NET_API.Pages.Book
{
    public class IndexModel : PageModel
    {
        private readonly BookService bookService;

        public IndexModel(BookService bookService)
        {
            this.bookService = bookService;
        }

        public List<Objects.Book> bookList { get; set; }
        public string PageName { get; } = "Book Page";

        public void OnGet()
        {
            bookList = bookService.GetBooks();
        }

        public IActionResult OnPost(Objects.Book book)
        {
            if (ModelState.IsValid)
            {
                bookService.AddBook(book);
                return RedirectToPage(); 
            }
            return Page();
        }

        public IActionResult OnPostDelete(int id)
        {
            bookService.DeleteBook(id);
            return RedirectToPage();
        }

    }
}
