using Microsoft.AspNetCore.Mvc;
using WebApplicationDemo.Models;

namespace WebApplicationDemo.Controllers
{
    public class PracticeController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult Add1()
        {
            //Numbers num = new Numbers();
            return View();

        }

        [HttpPost]
        public IActionResult Add1(IFormCollection f)
        {
            int num3=Byte.Parse(f["num1"])+ Byte.Parse(f["num2"]);
            ViewBag.res = num3;
            return View();
        }
    }
}
