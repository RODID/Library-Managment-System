using Library_Managment_System_ASP.NET_API.objects;
using System.Data.Entity;

namespace Library_Managment_System_ASP.NET_API.Objects
{
    public class Library
    {
        DbContext dbContext;
        public string Location  { get; set; }
        public Library() { }

    }
}
