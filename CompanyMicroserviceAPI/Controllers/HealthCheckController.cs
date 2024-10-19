using Microsoft.AspNetCore.Mvc;

namespace CompanyMicroserviceAPI.Controllers
{
    public class HealthCheckController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
