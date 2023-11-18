using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using MVCProject.Data;

namespace  MVCProject
{
    public class PersonController : Controller {
        
        private readonly ApplicationDbContext _context;

        public PersonController(ApplicationDbContext context) {
            _context = context;
        }

        public async Task<IActionResult> Index() {
            var model = await _context.Person.ToListAsync();

            return View(model);
        }

        public  IActionResult Create() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Person ps) {
            if (ModelState.IsValid) {
                await _context.Person.AddAsync(ps);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            } else {
                ModelState.AddModelError("", "Data error");
            }
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