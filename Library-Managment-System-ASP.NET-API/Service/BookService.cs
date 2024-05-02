using System.Collections.Generic;
using System.Linq;
using Library_Managment_System_ASP.NET_API.Data;
using Library_Managment_System_ASP.NET_API.Objects;
using Microsoft.EntityFrameworkCore;

namespace Library_Managment_System_ASP.NET_API.Service
{
    public class BookService
    {
        private readonly DatabaseContext _dbContext;

        public BookService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void ResetAutoIncrement()
        {
            _dbContext.Database.ExecuteSqlRaw("ALTER TABLE Books AUTO_INCREMENT = 1;");
        }

        public List<Book> GetBooks()
        {
            return _dbContext.Books.ToList();
        }

        public Book GetBookById(int id)
        {
            return _dbContext.Books.FirstOrDefault(book => book.BookId == id);
        }

        public bool AddBook(Book book)
        {
            if (book == null) return false;
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
            return true;
        }

        public bool UpdateBook(Book updatedBook)
        {
            var book = _dbContext.Books.FirstOrDefault(b => b.BookId == updatedBook.BookId);
            if (book == null) return false;
            book.Title = updatedBook.Title;
            _dbContext.SaveChanges();
            return true;
        }

        public bool DeleteBook(int id)
        {
            var book = _dbContext.Books.FirstOrDefault(b => b.BookId == id);
            if (book == null) return false;
            _dbContext.Books.Remove(book);
            _dbContext.SaveChanges();

            ResetAutoIncrement();

            return true;
        }
    }
}
