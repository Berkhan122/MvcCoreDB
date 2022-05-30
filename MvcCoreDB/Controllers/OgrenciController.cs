using Microsoft.AspNetCore.Mvc;
using MvcCoreDB.Models;
using System.Collections.Generic;
using System.Linq;

namespace MvcCoreDB.Controllers
{
    public class OgrenciController : Controller
    {
        public IActionResult Index()
        {
            List<Ogrenci> lst;
            using (var ctx = new OkulContext())
            {
                lst = ctx.Ogrenciler.ToList();
            }
            return View(lst);
        }

        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            using (var ctx = new OkulContext())
            {
                var ogrenci = ctx.Ogrenciler.Find(Id);
                ctx.Ogrenciler.Remove(ogrenci);
                ctx.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
