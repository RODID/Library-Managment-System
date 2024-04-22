using Library_Managment_System_ASP.NET_API.objects;
using Library_Managment_System_ASP.NET_API.Service;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Library_Managment_System_ASP.NET_API.Controllers
{
    [Route("getMeBooks")]
    [ApiController]
    public class BookController : ControllerBase
    {
        BookService bookService;

        public BookController(BookService bookService)
        {
            this.bookService = bookService;
        }

        [HttpGet("all")]
        public List<Book> getAll() 
        {
            return bookService.GetBooks();
        }

        [HttpGet("first")]
        public Book getOneBook()
        {
            return bookService.GetBooks()[0];
        }


    }
}
