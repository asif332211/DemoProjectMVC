using DemoProjectMVC.DbCon;
using DemoProjectMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemoProjectMVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly DemoProjectMVCDbContext _context;
        public StudentController(DemoProjectMVCDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult> Edit(int id)
        {
            var student = await _context.Students.FindAsync(id);
            return View(student);
        }
        [HttpPost]
        public async Task<ActionResult> Edit(int id, Student student)
        {
            if (!ModelState.IsValid)
            {
                return View(student);
            }
            _context.Entry(student).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }


        public async Task<IActionResult> Index()
        {
            var data = await _context.Students.ToListAsync();
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (!ModelState.IsValid)
            {
                return View(student);
            }

            _context.Students.Add(student);
            _context.SaveChanges();

          

            return RedirectToAction(nameof(Index));

        }

        public IActionResult Delete(int id)
        {
            return View(_context.Students.Find(id));

        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            var student = _context.Students.Find(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
                
            }

            return View();
        }

    }
}
