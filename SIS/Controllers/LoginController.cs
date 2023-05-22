using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SIS.Controllers
{
    public class LoginController : Controller
    {
        // GET: LoginController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LoginController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


        public ActionResult LoginAdmin()
        {
            return View();
        }

        public ActionResult LoginAcademic()
        {
            return View();
        }
    }
}
