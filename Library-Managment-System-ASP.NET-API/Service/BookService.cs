using Library_Managment_System_ASP.NET_API.Controllers;
using Library_Managment_System_ASP.NET_API.objects;
using System.Data.Entity;

namespace Library_Managment_System_ASP.NET_API.Service
{
    public class BookService
    {
        BookController bookController;
        DbContext dbContext;

        public List<Book> GetBooks() { return bookController.BooksDb; }
        public Book GetBookById(int id)
        {
            return bookController.BooksDb.First(book => book.BookId == id);
        }

        public bool AddBook(Book book)
        {
            if(book == null) return false;
            bookController.BooksDb.Add(book);
            return true;
        }

        public bool UpdateBook(Book book)
        {
            if(book == null) return false;
            bookController.UpdateBook(book);
            return true;
        }

        public bool DeleteBook(int id)
        {
            if(id == 0) return false;
            bookController.DeleteBook(id);
            return true;
        }

        

        internal List<Book> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        
    }
}
