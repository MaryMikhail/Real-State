using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RealEstate.Data;
using RealEstate.Models;
using RealEstate.Models.Repositries;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepository<Property> propertyRepo;
        private readonly ApplicationDbContext _context;


        public HomeController(ApplicationDbContext context,ILogger<HomeController> logger, IRepository<Property> PropertyRepo)
        {
            _logger = logger;
            _context = context;
            propertyRepo = PropertyRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index([Bind("PropertyType,PropertyStatus,Price,Rooms,Country,Bathrooms,YearBuilt")] Property searchModel)
        {
            var Properties = propertyRepo.Search(searchModel);
            ViewBag.Properties = Properties;
            ViewBag.Images = _context.Image.ToList();
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

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult TermsAndConditions()
        {
            return View();
        }

        public IActionResult ErrorNotFound()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            ViewBag.PropCount = _context.Property.ToList().Count();
            ViewBag.ComplaintCount = _context.Contact.ToList().Count();
            ViewBag.ReviewCount = _context.Review.ToList().Count();
            ViewBag.ReviewRateCount = _context.Review.ToList().Where(c => c.PropertyRate == 5).Count();
            return View();
        }
    }
}
