using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
