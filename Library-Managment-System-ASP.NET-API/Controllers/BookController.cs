using Library_Managment_System_ASP.NET_API.Data;
using Library_Managment_System_ASP.NET_API.Objects;
using Library_Managment_System_ASP.NET_API.Service;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Library_Managment_System_ASP.NET_API.Controllers
{
    [Route("getMeBooks")]
    [ApiController]
    public class BookController : ControllerBase
    {
        DatabaseContext db;
        
        public BookController(DatabaseContext databaseContext)
        private readonly BookService bookService;
        private readonly DatabaseContext _dbContext;

        public BookController(BookService bookService, DatabaseContext dBContext)
        {
            db = databaseContext;
            this.bookService = bookService;
            _dbContext = dBContext;
        }

      

        //Fetching all the existing books from the list
        [HttpGet("getAll")]
        public ActionResult <List<Book>> Get() 
        {
            return Ok(db.Books.ToList());
        }



        //Adding a book
        [HttpPost("addBook")]
        public ActionResult AddBook(Book book)
        {
            if (book != null && !string.IsNullOrEmpty(book.Title) && !string.IsNullOrEmpty(book.Author)
              && book.Published > -1 && !string.IsNullOrEmpty(book.Genre))
            {
                db.Books.Add(book);
                db.SaveChanges();
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet]
        public ActionResult<Book> GetBookById(int id)
        {
            Book book = db.Books.Find(id);
            if (book != null)
            {
                return Ok(book);
            }
            return NoContent();
        }


        //Updates books
        [HttpPut ("updateBook/{id}")]

        public ActionResult UpdateBook(int id, Book updateBook)
        {
           Book bookToEdit = db.Books.Find(book.BookId);
            if (bookToEdit != null)
            bool success = bookService.UpdateBook(id, updateBook);
            if (success)
            {
                bookToEdit.Title = book.Title;
                bookToEdit.Author = book.Author;
                bookToEdit.Published = book.Published;
                bookToEdit.Genre = book.Genre;

                db.SaveChanges();
                return Ok();

            }
            return NoContent();

        }


        [HttpDelete("deleteBook")]
        public ActionResult DeleteBook(int id)
        {
           Book book = db.Books.Find(id);
            if (book != null)
            {
                db.Books.Remove(book);
                db.SaveChanges();
                return Ok();
            } 
            return BadRequest();
        }

    }
}
