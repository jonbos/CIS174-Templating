using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TemplateAssignmentBos.Models;

namespace TemplateAssignmentBos.Controllers
{
    public class SixDotOneController : Controller
    {
        public SixDotOneController(StudentContext context)
        {
            _context = context;
        }

        private StudentContext _context { get; set; }

        // GET
        public IActionResult Index(int id = 3)
        {
            ViewBag.AccessLevel = id;
            var Students = _context.Students.OrderBy(c => c.LastName).ToList();
            return View(Students);
        }
    }
}