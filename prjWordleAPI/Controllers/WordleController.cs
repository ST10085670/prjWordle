using Microsoft.AspNetCore.Mvc;

namespace prjWordleAPI.Controllers
{
    public class WordleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
