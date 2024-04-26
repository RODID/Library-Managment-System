using Library_Managment_System_ASP.NET_API.Objects;
using Library_Managment_System_ASP.NET_API.Service;
using Microsoft.AspNetCore.Mvc;

namespace Library_Managment_System_ASP.NET_API.Controllers
{
    [Route("getMeUsers")]
    [ApiController]
    public class UserController : ControllerBase
    {

         UserService UserService;

         public UserController(UserService userService)
         {
             this.UserService = userService;
         }
    }
}
