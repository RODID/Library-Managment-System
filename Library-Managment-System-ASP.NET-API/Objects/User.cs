namespace Library_Managment_System_ASP.NET_API.Objects
{
    public class User
    {
        public User() { }

        public int UserId { get; set; }
        public string Name { get; set; }
        public int  UserNumber  { get; set; }
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
