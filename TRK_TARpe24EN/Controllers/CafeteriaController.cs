using Microsoft.AspNetCore.Mvc;
using TRK_TARpe24EN.Models;
using TRK_TARpe24EN.Data;

namespace TRK_TARpe24EN.Controllers
{
    public class CafeteriaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Cafeteria cafeteria)
        {
            if (ModelState.IsValid)
            {

            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            return View("Index");
        }
    }
}
