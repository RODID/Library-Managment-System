using System.Reflection.Metadata.Ecma335;

namespace Library_Managment_System_ASP.NET_API.objects
{
    public class Book
    {
        public Book(int bookId, string title, string author, int published)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            Published = published;
        }

        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Published { get; set; }
    }

    public Book()
    {

    }
}
