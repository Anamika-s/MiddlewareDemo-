using Microsoft.AspNetCore.Mvc;

namespace WebApplicationDemo.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            string currentyDate = DateTime.Now.ToString();
            ViewBag.Date = currentyDate;
            ViewBag.name = "Deepak Lal";
            ViewData["course"] = "C001";
            if (TempData["address"] != null)
                ViewBag.address = TempData["address"].ToString();
            return View();
        }

        public IActionResult First()
        {
            TempData["address"] = "Delhi";
            return RedirectToAction("Index");
        }
    }
}
