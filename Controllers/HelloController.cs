using Microsoft.AspNetCore.Mvc;

namespace RestorationCompanyPortal.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("/helloworld")]
        public IActionResult Index()
        {
            string html = "<h1>" + "Hello Worlds" + "</h1>";
            return Content(html, "text/html");
        }

        //GET : /<controller>/welcome
        [HttpGet]
        [Route("/helloworld/welcome/{name?}")]
        public IActionResult Welcome(string name = "World")
        {
            return Content("<h1>Welcome to my App, " + name + "!</h1>", "text/html");
        }
    }
}
