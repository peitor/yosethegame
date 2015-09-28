namespace WebApp.Controllers
{
    using Microsoft.AspNet.Mvc;

    [Route("/ping")]
    public class PingController : Controller
    {
        public JsonResult Index()
        {
            // return "{ "alive" : true }"
            return new JsonResult(new { alive = true });
        }
    }
}