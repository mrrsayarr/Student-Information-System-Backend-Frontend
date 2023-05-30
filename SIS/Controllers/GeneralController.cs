using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SIS.Data;
using SIS.Models;

namespace SIS.Controllers
{
    public class GeneralController : Controller
    {
        public IActionResult PersonalInformation()
        {
            return View();
        }

        // ---------------------------------------
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


        public IActionResult ExamResult() // Working bro
        {
            List<Generals> examResults = _context.ExamResults.ToList();

            return View(examResults);
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

        public IActionResult ExamResultAdd(string? studentNo, string? lessonName)
        {
            // Veritabanından öğrenci numarasına ve ders ismine göre ilgili kaydı bulun
            var examResult = _context.ExamResults.FirstOrDefault(e => e.StudentNo == studentNo && e.LessonName == lessonName);

            if (examResult == null)
            {
                // Belirtilen öğrenci numarası ve ders ismine sahip kayıt bulunamadı
                return NotFound();
            }

            // Modeli oluştur
            var model = new Generals
            {
                StudentNo = examResult.StudentNo,
                LessonName = examResult.LessonName,
                Midterm = examResult.Midterm,
                Final = examResult.Final,
                Average = examResult.Average,
                Pass = examResult.Pass
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult SaveExamResult(Generals model)
        {
            if (ModelState.IsValid)
            {
                // Veritabanında kaydı güncelle
                var examResult = _context.ExamResults.FirstOrDefault(e => e.StudentNo == model.StudentNo && e.LessonName == model.LessonName);

                if (examResult == null)
                {
                    // Belirtilen öğrenci numarası ve ders ismine sahip kayıt bulunamadı
                    return NotFound();
                }

                // Sadece Midterm ve Final alanlarını güncelle
                examResult.Midterm = model.Midterm;
                examResult.Final = model.Final;

                _context.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }


    }

}
