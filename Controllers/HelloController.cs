using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        // GET: /helloworld
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post'action='/helloworld/welcome'>" +
                "<input type='text' name='name' />" +
                "<select name='language' id='language - select'>" +
                "< option value = ''>--Please choose an option--</ option >" +
                "<option value='english'>English</option>" +
                "<option value='french'>French</option>" +
                "<option value='spanish'>Spanish</option>" +
                "<option value='german'>German</option>" +
                "<option value='italian'>Italian</option>" +
                "<option value='farsi'>Farsi</option>" +
                "</ select > " +
                "<input type='submit' value='Greet Me!' />" +
                "</form>";
            return Content(html, "text/html");
        }

        // GET: /helloworld or /helloworld/welcome or /helloworld/welcome/name or /helloworld/welcome?name=name        
        [HttpGet("welcome/{name?}")]
        [HttpPost("welcome")]
        public IActionResult Welcome(string name = "World", string language = "english")
        {
            string message;
            //string hello;
            //hello = "Bonjour";
            //message = "<h1>" + hello + " " + name + "!</h1>";
            message = CreateMessage(name, language);
            return Content(message, "text/html");
            //return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }

        public static string CreateMessage(string name, string language)
        {
            string hello;
            string message;

            if (language == "french")
            {
                hello = "Bonjour"; 
            } else if (language == "spanish")
            {
                hello = "Hola";
            }
            else if (language == "german")
            {
                hello = "Hallo";
            }
            else if (language == "italian")
            {
                hello = "Ciao";
            }
            else if (language == "farsi")
            {
                hello = "Salaam";
            }
            else
            {
                hello = "Hello";
            }
            
            message = "<h1>" + hello + " " + name + "!</h1>";
            return message;
        }
    }
}
