using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using MvcCoreDB.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MvcCoreDB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Ogrenci ogr)
        {
            ViewBag.ogrName = ogr.ogrName;
            ViewBag.ogrSurname = ogr.ogrSurname;

            using (var ctx = new OkulContext())
            {
                ctx.Ogrenciler.Add(ogr);
                ctx.SaveChanges();
            }
                return View();
        }



        public IActionResult Privacy()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }


    class OkulContext : DbContext
    {
        public DbSet<Ogrenci> Ogrenciler { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=OkulAppDbSube2;Integrated Security=true");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Ders>().ToTable("tblDersler");
        //    modelBuilder.Entity<Ders>().Property(p => p.Dersad).HasColumnType("varchar").HasMaxLength(30).IsRequired();

        //}Fluent Api
    }
}
