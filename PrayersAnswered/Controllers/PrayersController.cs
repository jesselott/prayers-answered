using Microsoft.AspNet.Identity;
using PrayersAnswered.Models;
using PrayersAnswered.ViewModel;
using System;
using System.Web.Mvc;

namespace PrayersAnswered.Controllers
{
    public class PrayersController : Controller
    {
        private ApplicationDbContext _context;

        public PrayersController()
        {
            _context = new ApplicationDbContext();
        }
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PrayerFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View("Create", viewModel);

            var prayer = new Prayer
            {
                PosterId = User.Identity.GetUserId(),
                Title = viewModel.Title,
                Content = viewModel.Content,
                DateTime = DateTime.Now
                
            };

            _context.Prayers.Add(prayer);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}