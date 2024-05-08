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

        public List<Objects.Book> bookList { get; set; }

        public string PageName { get; } = "Book Page";

        public IndexModel(DatabaseContext databaseContext)
        {
            this.bookService = bookService;

        }

        public List<Objects.Book> bookList { get; set; }
        public string PageName { get; } = "Book Page";

        public bool DisplayBookDetails { get; set; }
        public Objects.Book SelectedBook { get; set; }

        public void OnGet()
        {
            bookList = databaseContext.Books.ToList();
        }

        public void OnPost(Objects.Book book)
        {
            
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
            SelectedBook = bookList.FirstOrDefault(b => b.BookId == searchId);
            if (SelectedBook != null) 
            {
                DisplayBookDetails = true;
                
            }
            else
            {
                DisplayBookDetails=false;
            }
            return Page();
        }

    }
}
