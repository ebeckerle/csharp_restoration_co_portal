using Microsoft.AspNetCore.Mvc;

namespace RestorationCompanyPortal.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            List<string> Events = new List<string>();

            Events.Add("Code with Pride");
            Events.Add("Strange Loop");
            Events.Add("Women Who code");

            ViewBag.events = Events;
            return View();
        }
    }
}
