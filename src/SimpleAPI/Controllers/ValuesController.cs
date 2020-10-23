using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers
{
    public class ValuesController : Controller
    {
        public ValuesController()
        {


        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Test";
        }
    }
}