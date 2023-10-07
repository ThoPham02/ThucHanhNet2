using Microsoft.AspNetCore.Mvc;

namespace  MVCProject
{
    public class PersonController : Controller {
        public IActionResult Index() {
            return View();
        }
    }   
}