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
                _context.Add(delinquent);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            var delinquents = await _context.Delinquents.FindAsync(id);
            return View(delinquents);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Delinquents delinquent)
        {
            if (id != delinquent.ID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _context.Delinquents.Update(delinquent);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(delinquent);
        }
        [HttpGet]
        public async Task<IActionResult> Details (int? id)
        {
            var delinquent = await _context.Delinquents.FindAsync(id);
            return View(delinquent);
        }
    }
}
