using Microsoft.AspNetCore.Mvc;

namespace Library_Managment_System_ASP.NET_API.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
