using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers
{
    public class ValuesController : Controller
    {
        public ValuesController()
        {
                //TODO

        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            // Just a test
            return "Test";
        }
    }
}