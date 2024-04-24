using Library_Managment_System_ASP.NET_API.Controllers;
using Library_Managment_System_ASP.NET_API.Data;
using Library_Managment_System_ASP.NET_API.objects;
using System.Data.Entity;

namespace Library_Managment_System_ASP.NET_API.Service
{
    public class BookService
    {
        DatabaseContext dbContext;

        public BookService(DatabaseContext dbContex)
        {
            this.dbContext = dbContext;
        }

        public List<Book> GetBooks() { return dbContext.books; }
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
