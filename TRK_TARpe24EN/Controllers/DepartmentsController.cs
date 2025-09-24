using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TRK_TARpe24EN.Data;

namespace TRK_TARpe24EN
{
    public class DepartmentsController : Controller
    {
        private readonly SchoolContext _context;

        public DepartmentsController(SchoolContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var schoolContext = _context.Departments.Include(d => d.Administrator);
            return View(await schoolContext.ToListAsync());
        }
    }
}