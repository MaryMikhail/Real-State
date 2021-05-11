using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RealEstate.Data;
using RealEstate.Models;

namespace RealEstate.Areas.Test.Controllers
{
    public class PropertyController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment webHostEnvironment; 
        private readonly IHostingEnvironment hostingEnvironment;

        public PropertyController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            this.webHostEnvironment = webHostEnvironment;
        }

        // GET: Properties
        public async Task<IActionResult> Index()
        {
            ViewBag.Images = _context.Image.ToList();
            ViewBag.ApartmentProp = _context.Property.ToList().Where(c => c.PropertyType == PropertyType.Apartment).Count();
            ViewBag.BungalowProp = _context.Property.ToList().Where(c => c.PropertyType == PropertyType.Bungalow).Count();
            ViewBag.HouseProp = _context.Property.ToList().Where(c => c.PropertyType == PropertyType.House).Count();
            ViewBag.LandProp = _context.Property.ToList().Where(c => c.PropertyType == PropertyType.Land).Count();
            ViewBag.SingelFamilyProp = _context.Property.ToList().Where(c => c.PropertyType == PropertyType.SingelFamily).Count();
            ViewBag.VillaProp = _context.Property.ToList().Where(c => c.PropertyType == PropertyType.Villa).Count();
            return View(await _context.Property.ToListAsync());
        }

        // GET: Properties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review1Count = _context.Review.ToList().Where(c => c.PropertyID == id).Where(c => c.PropertyRate == 1).Count();
            var review2Count = _context.Review.ToList().Where(c => c.PropertyID == id).Where(c => c.PropertyRate == 2).Count();
            var review3Count = _context.Review.ToList().Where(c => c.PropertyID == id).Where(c => c.PropertyRate == 3).Count();
            var review4Count = _context.Review.ToList().Where(c => c.PropertyID == id).Where(c => c.PropertyRate == 4).Count();
            var review5Count = _context.Review.ToList().Where(c => c.PropertyID == id).Where(c => c.PropertyRate == 5).Count();

            if (_context.Review.ToList().Where(c => c.PropertyID == id).Count() != 0)
            {
                ViewBag.RateOfProp = Convert.ToInt32((review1Count * 1 + review2Count * 2 + review3Count * 3 + review4Count * 4 +
                review5Count * 5) / _context.Review.ToList().Where(c => c.PropertyID == id).Count());
            }

            var @property = await _context.Property.FirstOrDefaultAsync(m => m.PropertyID == id);
            if (@property == null)
            {
                return NotFound();
            }

            Property property1 = _context.Property.ToList().FirstOrDefault(c => c.PropertyID == id);
            ViewBag.SimilarPropertiesCount = _context.Property.ToList().Where(c => c.PropertyType == property1.PropertyType).Where(c => c.PropertyID != property1.PropertyID).Count();
            ViewBag.SimilarProperties = _context.Property.ToList().Where(c => c.PropertyType == property1.PropertyType).Where(c => c.PropertyID != property1.PropertyID);
            ViewBag.NumOfReview = _context.Review.ToList().Where(c => c.PropertyID == id).Count();
            ViewBag.Reviews = _context.Review.ToList().Where(c => c.PropertyID == id).ToArray();
            ViewBag.Images = _context.Image.ToList().Where(c => c.PropertyID == id);
            ViewBag.NumImages = _context.Image.ToList().Where(c => c.PropertyID == id).Count();
            ViewBag.FirstImg = _context.Image.ToList().FirstOrDefault();
            ViewBag.PropID = id;
            ViewBag.countReviews = _context.Review.ToList().Where(c => c.PropertyID == id).Count();
            ViewBag.AllImages = _context.Image.ToList();
            return View(@property);
        }

        // GET: Properties/MyProperties
        public async Task<IActionResult> AllProperties()
        {
            ViewBag.Images = _context.Image.ToList();
            return View(await _context.Property.ToListAsync());
        }
        
        // GET: Properties/Create
        public IActionResult Create()
        { 
            var user= System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            if (User.Identity.IsAuthenticated)
                    return View();
            return RedirectToRoute(new { action = "Login", controller = "Account", area = "Identity" });
          
        }

        // POST: Properties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Property model)
        {
            if (ModelState.IsValid)
            {
                _context.Add(model);
                await _context.SaveChangesAsync();
                if (model.Images != null && model.Images.Count > 0)
                {
                    foreach (IFormFile item in model.Images)
                    {
                        var LastProp = _context.Property.ToList().Last();
                        int LastPropID = LastProp.PropertyID;
                        _context.Image.Add(new Image { PropertyID = (LastPropID), ImageTitle = item.FileName + " Title", ImgData = item.FileName });
  
                    }
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: Properties/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @property = await _context.Property.FindAsync(id);
            if (@property == null)
            {
                return NotFound();
            }
            return View(@property);
        }

        // POST: Properties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PropertyID,Title,Description,PropertyType,PropertyStatus,Price,Rooms,Address,State,City,Zip,Country,Bathrooms,AreaSize,YearBuilt")] Property @property)
        {
            if (id != @property.PropertyID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@property);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PropertyExists(@property.PropertyID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(AllProperties));
            }
            return View(@property);
        }

        // GET: Properties/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @property = await _context.Property
                .FirstOrDefaultAsync(m => m.PropertyID == id);
            if (@property == null)
            {
                return NotFound();
            }

            return View(@property);
        }

        // POST: Properties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @property = await _context.Property.FindAsync(id);
            _context.Property.Remove(@property);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(AllProperties));
        }

        private bool PropertyExists(int id)
        {
            return _context.Property.Any(e => e.PropertyID == id);
        }

        public IActionResult CreateReview(int? id)
        {
            if (id == null)
                return NotFound();

            return RedirectToAction(nameof(Create), "Reviews", new { id = id });
        }

        public IActionResult LoadAllReviews(int? id)
        {
            ViewBag.reviews = _context.Review.ToList().Where(c => c.PropertyID == id);
            return View();
        }
    }
}
