using Library_Managment_System_ASP.NET_API.objects;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace Library_Managment_System_ASP.NET_API.Data 
{
    public class DatabaseContext: DbContext
    {
        
        public DatabaseContext(DbContextOptions options): base (options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
