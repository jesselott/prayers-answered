using PrayersAnswered.Models;
using System.Web.Mvc;

namespace PrayersAnswered.Controllers
{
    public class PrayersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PrayersController()
        {
            _context = new ApplicationDbContext();
        }
        
        public ActionResult Create()
        {
            return View();
        }
    }
}