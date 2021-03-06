using Microsoft.AspNetCore.Mvc;
using MvcCoreDB.Models;
using System;
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
            if (ogr != null)
            {
                using (var ctx = new OkulDbContext())
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

        
        public IActionResult OgrenciDetay(int id)
        {
            using(var ctx = new OkulDbContext())
            {
                var willupdate = ctx.Ogrenciler.Find(id);
                return View(willupdate);
            }
        }

        [HttpPost]
        public IActionResult OgrenciDetay(Ogrenci ogrenci)
        {
            using (var ctx = new OkulDbContext())
            {
                ctx.Ogrenciler.Update(ogrenci);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult OgrenciSil(int id)
        {

            using (var ctx = new OkulDbContext())
            {
                try
                {
                    var deleted = ctx.Ogrenciler.Find(id);
                    ctx.Ogrenciler.Remove(deleted);
                    ctx.SaveChanges();

                }
                catch (System.Exception)
                {

                    return RedirectToAction("OgrenciListe", ctx.Ogrenciler.ToList());
                }
                return RedirectToAction("OgrenciListe", ctx.Ogrenciler.ToList());
            }


           
        }
    }
}
