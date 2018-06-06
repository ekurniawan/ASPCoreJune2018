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
        private List<Mahasiswa> listMahasiswa = new List<Mahasiswa>() {
            new Mahasiswa { Nim="22002321",Nama="Erick",Alamat="Wahidin 5-25" },
            new Mahasiswa {Nim="22002322",Nama="Candra",Alamat="Jambi"}
        };
        public IActionResult Index(int id,string kota,string telp)
        {
            ViewData["nama"] = "Erick Kurniawan";
            ViewBag.Alamat = "Jl Wahidin 5-25";

            ViewBag.Telp = telp;
            ViewBag.Kota = kota;
            ViewBag.Id = id;

            return View();
        }

        public IActionResult GetMahasiswa(){
            return View(listMahasiswa);
        }

        public IActionResult HitungSegitiga()
        {
            return View();
        }

        [HttpPost]
        public IActionResult HitungSegitiga(double alas,double tinggi)
        {
            double hasil = 0.5*alas*tinggi;
            ViewBag.Hasil = hasil;
            return View();
        }


    }
}