using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TRK_TARpe24EN.Data;
using TRK_TARpe24EN.Models;

namespace TRK_TARpe24EN.Controllers
{
    public class InstructorsController : Controller
    {
        private readonly SchoolContext _context;
        public InstructorsController(SchoolContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index( int? id, int? courseId)
        {
            var vm = new InstructorIndexData();
            vm.Instructors = await _context.Instructors
                .Include(i => i.OfficeAssignment)
                .Include(i => i.CourseAssignments)
                .ToListAsync();
            return View(vm);

        }
    }
}
