using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationDemo.Models;

namespace WebApplicationDemo.Controllers
{
    public class NumberController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(string num1, string num2)
        {
            int result = Byte.Parse(num1)+ Byte.Parse(num2);
            ViewBag.result = result;
            return View();  
        }

        public IActionResult Add1()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add1(string num1, string num2)
        {
            int result = Byte.Parse(num1) + Byte.Parse(num2);
            ViewBag.result = result;
            return View();
        }


        public IActionResult Add2()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add2(IFormCollection f)
        {
            int num1 =  Byte.Parse(f["num1"]);
            int num2 = Byte.Parse(f["num2"]);
            ViewBag.result = num1 + num2;

            return View();


        }


        public IActionResult Add3()
        {
            Numbers numbers = new Numbers();
            return View(numbers);

        }

        [HttpPost]
        public IActionResult Add3(Numbers numbers)
        {

            int res =  numbers.Num1+ numbers.Num2;
            ViewBag.result = res;
            return View();
        }
    }
}
