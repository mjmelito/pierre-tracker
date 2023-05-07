using Microsoft.AspNetCore.Mvc;
using Bakery.Models;

namespace Bakery.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      Vendor starterVendor  = new Vendor("Add first vendor to list");
      return View(starterVendor);
    }

  }
}