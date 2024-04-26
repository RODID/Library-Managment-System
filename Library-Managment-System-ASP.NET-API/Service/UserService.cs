using Microsoft.AspNetCore.Mvc;

namespace Library_Managment_System_ASP.NET_API.Service
{
    public class UserService : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
