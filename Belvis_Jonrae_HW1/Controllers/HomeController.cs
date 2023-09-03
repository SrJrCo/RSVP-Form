using Microsoft.AspNetCore.Mvc;
using Belvis_Jonrae_HW1.Models;

namespace Belvis_Jonrae_HW1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid == false) //response is not valid
            {
                return View();
            }
            Repository.AddResponse(guestResponse);
            return View("Thanks", guestResponse);
        }
        public IActionResult ListResponses()
        {
            IEnumerable<GuestResponse> attendeeList = Repository.Responses
            .Where(r => r.WillAttend == true);
            return View(attendeeList);
        }
    }
}