using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TRK_TARpe24EN.Data;
using TRK_TARpe24EN.Models;

namespace TRK_TARpe24EN.Controllers
{
   public class DelinquentsController : Controller
    {
        private readonly SchoolContext _context;
        public DelinquentsController(SchoolContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var delinquents = _context.Delinquents.ToList();
            return View(delinquents);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Delinquents delinquent)
        {
             if (ModelState.IsValid)
             {

             }
             return RedirectToAction("Index");
        }
    }
}
