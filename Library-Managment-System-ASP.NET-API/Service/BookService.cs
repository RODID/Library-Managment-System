using Library_Managment_System_ASP.NET_API.Controllers;
using Library_Managment_System_ASP.NET_API.Data;
using Library_Managment_System_ASP.NET_API.objects;
using System.Data.Entity;

namespace Library_Managment_System_ASP.NET_API.Service
{
    public class BookService
    {
        private readonly DatabaseContext dbContext;

        public BookService(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Book> GetBooks() { return dbContext.Books.ToList(); }
        public Book GetBookById(int id)
        {
            return dbContext.Books.FirstOrDefault(book => book.BookId == id);
        }

        public bool AddBook(Book book)
        {
            if(book == null) return false;
            dbContext.Books.Add(book);
            dbContext.SaveChanges();
            return true;
        }

        public bool UpdateBook(Book book)
        {
            if(book == null) return false;
            dbContext.Books.Update(book);
            dbContext.SaveChanges();
            return true;
        }

        public bool DeleteBook(int id)
        {
            var book = dbContext.Books.FirstOrDefault(book => book.BookId == id);
            if(book == null) return false;
            dbContext.Books.Remove(book);
            dbContext.SaveChanges();
            return true;
        }

    }
}
