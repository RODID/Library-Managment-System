using Library_Managment_System_ASP.NET_API.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Library_Managment_System_ASP.NET_API.Objects;
using System.Collections.Generic;
using System.Linq;

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

        public bool DisplayBookDetails { get; set; }
        public Objects.Book SelectedBook { get; set; }

        public void OnGet()
        {
            bookList = bookService.GetBooks();
        }

        public IActionResult OnPost(Objects.Book book)
        {
            book.BookId = 0;
            bookService.AddBook(book);
            return RedirectToPage();

        }

        public IActionResult OnPostDelete(int id)
        {
            bookService.DeleteBook(id);
            return RedirectToPage();
        }

        public IActionResult OnPostSearchBook(int searchId)
        {
            SelectedBook = bookService.GetBookById(searchId);
            if (SelectedBook != null)
            {
                DisplayBookDetails = true;

            }
            else
            {
                DisplayBookDetails = false;
            }
            return Page();
        }

        public IActionResult OnPostEditBook (Objects.Book book)
        {
            bookService.UpdateBook(book);
            return RedirectToPage();
        }

    }
}
