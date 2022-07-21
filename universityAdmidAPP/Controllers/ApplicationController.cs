using Microsoft.AspNetCore.Mvc;

namespace universityAdmidAPP.Controllers
{
    public class ApplicationController : Controller
    {
        public IActionResult apps()
        {
            return View();
        }
        public IActionResult process()
        {
            return View();
        }
    }
}
