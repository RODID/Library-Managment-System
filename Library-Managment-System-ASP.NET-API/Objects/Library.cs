using Library_Managment_System_ASP.NET_API.objects;

namespace Library_Managment_System_ASP.NET_API.Objects
{
    public class Library
    {
        public string Location  { get; set; }
        public List<Book> Books { get; set; }
        public Library() { }

    }
}
