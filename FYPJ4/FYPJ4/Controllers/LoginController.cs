using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FYPJ4.Models;

namespace FYPJ4.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login model)
        {
            if(model.Name=="admin"&&model.Password=="123")
            {
                return Redirect("Home/index");
            }
            else
            {
                ViewBag.Message = "Wrong username or password";
                return View();
            }
            
        }
    }
}