using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
           
            return View();
        }

        public IActionResult Add()
        { 
            ViewBag.didNotMatch = false;
            return View();
        }

        
        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            
            
            if (newUser.PassWord == verify)
            {
                /*ViewBag.didNotMatch = false;*/
                ViewBag.userName = newUser.UserName;
                return View("Index");
            }
            else
            {
                ViewBag.userName = newUser.UserName;
                ViewBag.email = newUser.Email;
                ViewBag.didNotMatch = true;
                ViewBag.error = "Passwords must match";
                return View("add");
            }
        }
    }
}
