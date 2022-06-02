using Microsoft.AspNetCore.Mvc;
using MvcCoreDB.Models;
using System.Collections.Generic;
using System.Linq;

namespace MvcCoreDB.Controllers
{
    public class OgretmenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OgretmenEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OgretmenEkle(Ogretmen ogr)
        {
            if (ogr != null)
            {
                using (var ctx = new OkulDbContext())
                {
                    ctx.Ogretmenler.Add(ogr);
                    ctx.SaveChanges();
                }
            }
            return View();
        }

        public IActionResult OgretmenListe()
        {
            List<Ogretmen> lst;
            using (var ctx = new OkulDbContext())
            {
                lst = ctx.Ogretmenler.ToList();
            }
            return View(lst);
        }
    }
}
