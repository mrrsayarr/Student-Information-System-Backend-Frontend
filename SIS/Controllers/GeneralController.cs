using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SIS.Data;

namespace SIS.Controllers
{
    public class GeneralController : Controller
    {
        public IActionResult PersonalInformation()
        {
            return View();
        }

        // ---------------------------------------
        //public IActionResult GeneralInformation()
        //{
        //    return View();
        //}
        private readonly SISContext _context;

        public GeneralController(SISContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> GeneralInformation(string searchString)
        {
            if (_context.Students == null)
            {
                return Problem("Entity set 'SISContext.Students'  is null.");
            }
            var students = from s in _context.Students
                           select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                students = students.Where(s => s.FirstName.Contains(searchString)
                                       || s.LastName.Contains(searchString));
            }
            return View(await students.ToListAsync());
        }
        // ---------------------------------------

        public IActionResult ConsultantInfo()
        {
            return View();
        }

        public IActionResult ExamResult()
        {
            return View();
        }

        public IActionResult Charts()
        {
            return View();
        }

        public IActionResult ExamSchedule()
        {
            return View();
        }

        public IActionResult IntershipInfo()
        {
            return View();
        }

        public IActionResult LessonTaken()
        {
            return View();
        }

        public IActionResult YOKSIS()
        {
            return View();
        }

        public IActionResult AcademicCalendar()
        {
            return View();
        }
    }

}
