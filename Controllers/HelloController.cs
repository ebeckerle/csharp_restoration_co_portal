using Microsoft.AspNetCore.Mvc;

namespace RestorationCompanyPortal.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            string html = "<h1>" + "Hello Worlds" + "</h1>";
            return Content(html, "text/html");
        }
    }
}
