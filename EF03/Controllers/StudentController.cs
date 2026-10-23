using EF03.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EF03.Controllers
{
    public class StudentController : Controller
    {
        private readonly TimourDbContext _context;

        public StudentController(TimourDbContext context)
        {
            _context = context;
        }

        public IActionResult ShowAll()
        {
            var students = _context.Students.Include(s => s.Department).ToList();

            return View(students);
        }
        //Student/ShowDetails?id=3
        public IActionResult ShowDetails(int id)
        {
            var student = _context.Students
                                  .Include(s => s.Department)
                                  .FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }
    }
}
