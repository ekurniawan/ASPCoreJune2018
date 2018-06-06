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
        public IActionResult Index(int id,string kota,string telp)
        {
            ViewData["nama"] = "Erick Kurniawan";
            ViewBag.Alamat = "Jl Wahidin 5-25";

            ViewBag.Telp = telp;
            ViewBag.Kota = kota;
            ViewBag.Id = id;

            return View();
        }
    }
}