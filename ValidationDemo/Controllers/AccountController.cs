using Microsoft.AspNetCore.Mvc;
using ValidationDemo.Models;

namespace ValidationDemo.Controllers
{
    public class AccountController : Controller
    {
        //Get:/Account/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        //Post: /Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login (UserLogin model)
            {
            if (ModelState.IsValid)
            {
                return View(model);
            }
            return RedirectToAction("Login Success");
        }

        //Get: /Account /Login Success
        [HttpGet]
        public IActionResult LoginSuccess()
        {
            return View();
        }

    }
}
