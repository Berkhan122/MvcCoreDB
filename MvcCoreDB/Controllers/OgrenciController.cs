﻿using Microsoft.AspNetCore.Mvc;
using MvcCoreDB.Models;
using System.Collections.Generic;
using System.Linq;

namespace MvcCoreDB.Controllers
{
    public class OgrenciController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OgrenciEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OgrenciEkle(Ogrenci ogr)
        {
            if(ogr != null)
            {
                using(var ctx = new OkulDbContext())
                {
                    ctx.Ogrenciler.Add(ogr);
                    ctx.SaveChanges();
                }
            }
            return View();
        }

        public IActionResult OgrenciListe()
        {
            List<Ogrenci> lst;
            using (var ctx = new OkulDbContext())
            {
                lst = ctx.Ogrenciler.ToList();
            }
            return View(lst);
        }
        
    }
}
