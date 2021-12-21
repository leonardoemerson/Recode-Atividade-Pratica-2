using Microsoft.AspNetCore.Mvc;

namespace CRUDMVC.Controllers
{
    public class CatalogoController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}