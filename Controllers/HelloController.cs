using Microsoft.AspNetCore.Mvc;

namespace RestorationCompanyPortal.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        //[HttpGet]
        //[Route("/helloworld")]
        //public IActionResult Index()
        //{
        //    string html = "<h1>" + "Hello Worlds" + "</h1>";
        //    return Content(html, "text/html");
        //}

        [HttpGet]
        //[Route("/helloworld")]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld/welcome'>" +
                "<input type='text' name='name' />" +
                "<input type='submit' value='Greet Me!' />" +
                "</form>";
            return Content(html, "text/html");
        }

        ////GET : /<controller>/welcome
        //[HttpGet]
        //[Route("/helloworld/welcome/{name?}")]
        //public IActionResult Welcome(string name = "World")
        //{
        //    return Content("<h1>Welcome to my App, " + name + "!</h1>", "text/html");
        //}


        //POST : /<controller>/welcome
        [HttpPost("welcome")]
        [HttpGet("welcome/{name?}")]
        public IActionResult Welcome(string name = "World")
        {
            return Content("<h1>Welcome to my App, " + name + "!</h1>", "text/html");
        }
    }
}
