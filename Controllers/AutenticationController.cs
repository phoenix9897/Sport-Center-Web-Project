using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using WebAppProject.Models;

namespace WebAppProject.Controllers
{
    [AllowAnonymous]
 
    public class AutenticationController : Controller
    {
        private readonly DataContext _context;

        public AutenticationController(DataContext context)
        {
            _context = context;
            
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> SignUp(Users model)
        {
            if(ModelState.IsValid){
                _context.Users.Add(model);
                await _context.SaveChangesAsync();
                return RedirectToAction("LogIn", "Autentication");

            } else{
                return View(model);
            }
           
        }


        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }

         [HttpPost]
        public async Task<IActionResult> LogIn(LoginViewModel model)
        {
            if(ModelState.IsValid){
                var result = _context.Users.Where(i => (i.Email == model.Email) && (i.Password == model.Password)).FirstOrDefault();
                if(result!= null){
                 
                return RedirectToAction("Index", "Home");
                }

            }

            return View("LogIn");
            
        }


         public  IActionResult LogOut()
        {
            
            return RedirectToAction("LogIn", "Autentication");
        }
   
    }
}