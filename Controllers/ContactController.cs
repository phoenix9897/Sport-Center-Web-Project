using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAppProject.Models;

namespace WebAppProject.Controllers
{

    public class ContactController : Controller
    {
        private readonly DataContext _context;

        public ContactController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

         [HttpPost]
        public async Task<IActionResult> Index(Contact model)
        {
            _context.Contacts.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

      
    }
}