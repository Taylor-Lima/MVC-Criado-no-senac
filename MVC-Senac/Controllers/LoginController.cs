using Microsoft.AspNetCore.Mvc;

namespace MVC_Senac.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
