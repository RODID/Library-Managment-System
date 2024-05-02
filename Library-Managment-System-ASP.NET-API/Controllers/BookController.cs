using Library_Managment_System_ASP.NET_API.Objects;
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

        //Fetching all the existing books from the list
        [HttpGet("getAll")]
        public List<Book> GetAll() 
        {
            return bookService.GetBooks();
        }

        //Fetching a book (singular)
        [HttpGet("getBook")]
        public Book GetABook()
        {
            return bookService.GetBooks()[0];
        }

        //Adding a book
        [HttpPost("addBook")]
        public ActionResult AddBook(Book book)
        {
            bool success = bookService.AddBook(book);
            if (success)
            {
                return Ok();
            }
            return BadRequest();
        }


        //Updates books
        [HttpPut ("updateBook")]

        public ActionResult UpdateBook(Book book)
        {
            bool success = bookService.UpdateBook(book);
            if (success)
            {
                return Ok();
            }
            return BadRequest();
        }


        public ActionResult DeleteBook(int id)
        {
            bool success = bookService.DeleteBook(id);
            if(success)
            {
                return Ok();
            }
            return BadRequest();

        }

    }
}
