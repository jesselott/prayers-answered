using PrayersAnswered.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace PrayersAnswered.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }
        
        public ActionResult Index()
        {
            var prayersList = _context.Prayers
                .Include(p => p.Poster)
                .Where(p => p.DateTime > DateTime.Now);
                
            return View(prayersList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}