using Library_Managment_System_ASP.NET_API.objects;

namespace Library_Managment_System_ASP.NET_API.Service
{
    public class BookService
    {
        List<Book> BooksDb = new List<Book>();

        public BookService()
        {
            BooksDb.Add(new Book(1, "The Prince", "Niccolo Machiavelli", 1445));
            BooksDb.Add(new Book(2, "Art of War", "Sun-Tzu", 1356));
            BooksDb.Add(new Book(3, "Harry Potter", "JK Rowling", 2010));
        }

        public List<Book> GetBooks() { return BooksDb; }
        public Book GetBookById(int id)
        {
            return BooksDb.First(book => book.BookId == id);
        }

        public bool AddBook(Book book)
        {
            if(book == null) return false;
            BooksDb.Add(book);
            return true;
        }

        public void UpdateBook(Book updateBook)
        {
            Book book = GetBookById(updateBook.BookId);
            if(book == null) return;
            book.Title = updateBook.Title;
            book.Published = updateBook.Published;
        }

        public void DeleteBook(int id)
        {
            Book book = GetBookById(id);
            if(book == null) return;
            BooksDb.Remove(book);
        }

        internal List<Book> GetAllBooks()
        {
            throw new NotImplementedException();
        }
    }
}
