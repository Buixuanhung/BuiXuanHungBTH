using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BuiXuanHungBTH.Models;

namespace BuiXuanHungBTH.Controllers;

    public class EmployeeController : Controller 
    {
        public IActionResult Index()
    {
        return View();
    }
    }