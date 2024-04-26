using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Managment_System_ASP.NET_API.Objects
{
    public class User
    {
        public User() 
        {
            
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int  UserNumber  { get; set; }
        [Required]
        public int Password { get; set; }


        public User(int userId, string name, int userNumber, int password)
        {
            UserId = userId;
            Name = name;
            UserNumber = userNumber;
            Password = password;
        }
    }
}
