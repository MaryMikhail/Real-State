using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RealEstate.Data;
using RealEstate.Models;
using System.Net.Mail;


namespace RealEstate.Controllers
{
    public class ContactsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Contact.ToList());
        }

        public IActionResult Send()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Send([Bind("Name,Email,Phone,Message,Subject")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contact);
                await _context.SaveChangesAsync();
                
           
            string email = "ebtesam.hussien@gmail.com";
            string subject = contact.Subject;
            string message = contact.Message;
            string name = contact.Name;
            string phone = contact.Phone;
            MailMessage mm = new MailMessage();
            mm.To.Add(email);
            mm.Subject = subject;
            mm.Body = message;
            mm.From = new MailAddress(contact.Email);
            mm.IsBodyHtml = false;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.UseDefaultCredentials = true;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential(contact.Email, "L123456789c");
            smtp.Send(mm);
            ViewBag.mess = "This Mail Has been sent to " + contact.Email+" Successfully";
            return RedirectToAction(nameof(Send));
            }
            return View(contact);
           
        }
     
        // GET: Contacts
        public IActionResult Contact()
        {
            return View();
        }

        // GET: Contacts/Create
        public IActionResult CreateContact()
        {
            return View();
        }

        // POST: Contacts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateContact([Bind("Name,Email,Phone,Message,Subject")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Contact));
            }
            return View(contact);
        }

        private bool ContactExists(int id)
        {
            return _context.Contact.Any(e => e.ClientId == id);
        }
    }
}
