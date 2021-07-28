using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SpaDay.Models;
using SpaDay.ViewModels;

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
            AddUserViewModel newobj = new AddUserViewModel();
            
            return View(newobj);
        }



        
        [HttpPost]
        public IActionResult Add(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            {
                
                    User newUser = new User { 
                    UserName = addUserViewModel.UserName,
                    Email = addUserViewModel.Email,
                    PassWord = addUserViewModel.PassWord,
                    DateJoined = addUserViewModel.DateJoined
                    
                    };

                    return View("Index", newUser);

                
            }

            
            return View();
           
      
        }
    }
}
