using Microsoft.AspNetCore.Mvc;

namespace MVC_Senac.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
