using Microsoft.AspNet.Mvc;

namespace ViewDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
