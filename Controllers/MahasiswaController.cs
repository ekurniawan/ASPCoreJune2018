using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleMVC.Models;

namespace SampleMVC.Controllers
{
    public class MahasiswaController : Controller
    {
        public IActionResult Index()
        {
            ViewData["nama"] = "Erick Kurniawan";
            return View();
        }
    }
}