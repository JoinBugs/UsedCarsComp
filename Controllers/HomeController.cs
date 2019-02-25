using Microsoft.AspNetCore.Mvc;

namespace UsedCarsComp.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public IActionResult MyIndex()
        {
            return View("Index");
        }
    }
}