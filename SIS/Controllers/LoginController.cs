using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SIS.Data;
using SIS.Models;
using System.Data;

namespace SIS.Controllers
{
    public class LoginController : Controller
    {
        // [Authorize] // Böylece bu sayfaya sadece oturumu açılmış kullanıcılar erişebilecektir
        public IActionResult Index(Login model)
        {
            using (var _connection = new SqlConnection("Data Source=.;Initial Catalog=SIS.Data;Integrated Security=True"))
            {
                _connection.Open();

                if (ModelState.IsValid)
                {
                    // Authenticate the user
                    var query = @"SELECT * FROM AuthorizedUser WHERE Username = @Username AND Password = @Password";

                    using (var cmd = _connection.CreateCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@Username", model.Username);
                        cmd.Parameters.AddWithValue("@Password", model.Password);

                        var reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            string role = reader["Authority"].ToString(); // Rol bilgisini veritabanından al

                            // return RedirectToAction("Index", "Home");

                            if (role.Equals("Student", StringComparison.OrdinalIgnoreCase))
                            {
                                // Student ise farklı bir sayfaya yönlendir
                                return RedirectToAction("Index", "Home");

                                //ModelState.AddModelError("", "Invalid username or password.");
                                //return View(model);
                            }
                            else if (role.Equals("Academist", StringComparison.OrdinalIgnoreCase))
                            {
                                // Academist ise başka bir sayfaya yönlendir
                                return RedirectToAction("Index", "Home");
                            }
                            else if (role.Equals("Student Affairs", StringComparison.OrdinalIgnoreCase))
                            {
                                // Student Affairs ise Home/Index sayfasına yönlendir
                                return RedirectToAction("Index", "Home");
                            }
                        }

                        else
                        {
                            // Geçersiz kullanıcı adı veya şifre hatası
                            ModelState.AddModelError("", "Invalid username or password.");
                            ViewBag.ErrorMessage = "Invalid username or password. Please try again.";
                        }
                    }
                }

                // Show an error message
                ModelState.AddModelError("", "Invalid username or password.");
                return View(model);
            }

        }

        public IActionResult Logout()
        {
            // Oturumu sonlandır
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Login");
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
