using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace Library_Managment_System_ASP.NET_API.Objects
{
    public class Book
    {
       

        [Key]//Sätter Primary Key på propertyn raden under
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]// + Sätter Auto Increment
        public int BookId { get; set; }
        [Required] //NOT NULL - så raden inte lämnas tom
        [MaxLength(50)]// = VARCHAR (50), maxlängden på propertyn raden under
        public string Title { get; set; }
        public string Author { get; set; }
        public int Published { get; set; }
        public string Genre { get; set; }

        public Book()
        {

        }

        public Book(int bookId, string title, string author, int published, string genre)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            Published = published;
            Genre = genre;
        }
    }

    
}
