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
        public List<Book> GetAll() 
        {
            return bookService.GetBooks();
        }

        [HttpGet("first")]
        public Book GetABook()
        {
            return bookService.GetBooks()[0];
        }

        [HttpPost]
        public ActionResult AddBook(Book book)
        {
            bool success = bookService.AddBook(book);
            if (success)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut]

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

        public List<Book> GetBookList()
        {
            return bookService.GetBookList();
        }
        


    }
}
