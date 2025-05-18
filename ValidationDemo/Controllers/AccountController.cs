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

        //Method for remote validation
        [AcceptVerbs("Get", "Post")]
        public IActionResult ChekUserName(string userName)
        {
            //Simulte checking UserName against a database
            var takenUserName = new List<string> {"admin", "root","sytem", "modorater","user" };
            if (takenUserName.Contains(userName.ToLower()){
                return Json($"The username {userName}is already taken.");
            }
            ;
            return Json(true);
        }

        //Get: /Account /Register
        public IActionResult Register()
        {
            return View();
        }

        //Post: /Account /Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(UserRegistration model)
        {
            if (ModelState.IsValid)
            {
                return View(model);
            }
            return RedirectToAction("Registration Success");

        }
        //Get: /Account /Registration Success
        [HttpGet]
        public IActionResult RegistrationSuccess()
        {
            return View();
        }


    }
}
