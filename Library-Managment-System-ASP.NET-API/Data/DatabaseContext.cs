﻿using Library_Managment_System_ASP.NET_API.objects;
using Microsoft.EntityFrameworkCore;

namespace Library_Managment_System_ASP.NET_API.Data 
{
    public class DatabaseContext: DbContext
    {
        //generall synthax for establishing connection between database and program.
        public DatabaseContext(DbContextOptions options): base (options)
        {

        }

        //Creata a Table name Books with 5 columns
        public DbSet<Book> books { get; set; }
    }
}
