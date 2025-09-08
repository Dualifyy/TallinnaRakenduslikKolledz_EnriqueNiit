using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TRK_TARpe24EN.Data;
using TRK_TARpe24EN.Models;
namespace TRK_TARpe24EN.Controllers
{
    public class StudentController : Controller
    {
        private readonly SchoolContext _context;
        public StudentController(SchoolContext context) 
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Students.ToListAsync());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind

            ("LastName, FirstName, Id, EnrollmentDate, GradesPerAverage")] Student student)

        {
            if (ModelState.IsValid)
            { 
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
            }
            return View(student);
        }
    }
}
