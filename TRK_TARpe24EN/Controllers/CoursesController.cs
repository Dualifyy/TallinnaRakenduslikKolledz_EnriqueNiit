using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TRK_TARpe24EN.Data;
using TRK_TARpe24EN.Models;

namespace TRK_TARpe24EN.Controllers
{
    public class CoursesController : Controller
    {
        private readonly SchoolContext _context;
        public CoursesController(SchoolContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var courses = _context.Courses.Include(c => c.Department)
                .AsNoTracking();
            return View(courses);

        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewData["Create"] = "Create";
            PopulateDepartmentsDropDownList();
            return View("Create");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Course course)
        {
            if (ModelState.IsValid)
            {
                _context.Courses.Add(course);
                await _context.SaveChangesAsync();
                //PopulateDepartmentsDropDownList(course.DepartmentID);
           
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Courses == null)
            {
                return NotFound();
            }
            var course = await _context.Courses
                .Include(c => c.Department)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.CourseID == id);
            if (course == null)
            {
                return NotFound();
            }
            ViewData["Delete"] = "Delete";
            return View(course);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Courses == null)
            {
                return NotFound();
            }
            var course = await _context.Courses.FindAsync(id);
            if (course == null)
            {
                _context.Courses.Remove(course);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            ViewData["Delete"] = "Details";
            var course = await _context.Courses.FirstOrDefaultAsync(c => c.CourseID == id);
            return View(nameof(Delete), course);

        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            ViewData["Create"] = "Edit";
            var course = await _context.Courses.FindAsync(id);
            return View("Create");

        }
        [HttpPost, ActionName("Edit")]
        public async Task<IActionResult> Edit([Bind("CourseID, Title, Credits, DepartmentID")] Course course)

        {
            if (ModelState.IsValid)
            {
                _context.Courses.Update(course);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(course);
        }
        private void PopulateDepartmentsDropDownList(object selectedDepartment = null)
        {
            var departmentsQuery = from d in _context.Departments
                                   orderby d.Name
                                   select d;
            ViewBag.DepartmentID = new SelectList(departmentsQuery.AsNoTracking(), "DepartmentID", "Name", selectedDepartment);

        }
    }
}
