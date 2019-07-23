using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.hour = hour < 12 ? "Good morning " : "Good Afternoon";
            return View("MyView");
        }
        [HttpGet]
        public ViewResult RsvpForm() {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.addResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else
            {
                //there is a validation error burası valitadion hatası olunca.  
                return View();
            }
            
        }
        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(x=>x.WillAttend == true));
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
}
