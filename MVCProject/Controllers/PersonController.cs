using Microsoft.AspNetCore.Mvc;
using MVCProject.Data;

namespace  MVCProject
{
    public class PersonController : Controller {
        
        private readonly ApplicationDbContext _context;

        public PersonController(ApplicationDbContext context) {
            _context = context;
        }

        public IActionResult Index() {
            

            return View();
        }
        public IActionResult Create() {
            return View();
        }
        public IActionResult Update() {
            return View();
        }
        public IActionResult Delete() {
            return View();
        }

    }   
}