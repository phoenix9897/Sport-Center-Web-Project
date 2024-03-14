using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAppProject.Models;

namespace WebAppProject.Controllers;

[AllowAnonymous]
public class HomeController : Controller
{


    public IActionResult Index()                        
    {
        return View();
    }

    public IActionResult Trainers()
    {
        return View();
    }

     public IActionResult About()
    {
        return View();
    }

     public IActionResult Fitness()
    {
        return View();
    }

     public IActionResult Kickbox()
    {
        return View();
    }

     public IActionResult Pilates()
    {
        return View();
    }

     public IActionResult Zumba()
    {
        return View();
    }

     public IActionResult Coaching()
    {
        return View();
    }


}
