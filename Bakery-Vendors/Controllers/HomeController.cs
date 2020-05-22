using Microsoft.AspNetCore.Mvc;

namespace BakeryVendors.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}