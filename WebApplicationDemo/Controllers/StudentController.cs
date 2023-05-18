using Microsoft.AspNetCore.Mvc;
using WebApplicationDemo.Models;
namespace WebApplicationDemo.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            Student student = new Student()

            {
                Id = 1,
                Name = "LAlit",
                Address = "Bombay",
                Marks = 90
            };
            ViewBag.student = student;

            return View();
        }

        public IActionResult DisplayRecord()
        {
            Student student = new Student()

            {
                Id = 1,
                Name = "LAlit",
                Address = "Bombay",
                Marks = 90
            };
            return View(student);
        }

        public IActionResult List()
        {
            List<Student> list = new List<Student>()
            {
                new Student() {Id = 1,Name="Ajay",Address="Delhi", Marks=90 },
                 new Student() {Id = 2,Name="Vijay",Address="Delhi", Marks=90 },
                  new Student() {Id = 3,Name="Jay",Address="Delhi", Marks=90 },
                   new Student() {Id = 4,Name="Raman",Address="Delhi", Marks=90 },
                    new Student() {Id = 5,Name="Aman",Address="Delhi", Marks=90 },
                     new Student() {Id = 6,Name="Ajay",Address="Delhi", Marks=90 },


            };

            ViewBag.students = list; return View();

        }

        public IActionResult List1()
        {
            List<Student> list = new List<Student>()
            {
                new Student() {Id = 1,Name="Ajay",Address="Delhi", Marks=90 },
                 new Student() {Id = 2,Name="Vijay",Address="Delhi", Marks=90 },
                  new Student() {Id = 3,Name="Jay",Address="Delhi", Marks=90 },
                   new Student() {Id = 4,Name="Raman",Address="Delhi", Marks=90 },
                    new Student() {Id = 5,Name="Aman",Address="Delhi", Marks=90 },
                     new Student() {Id = 6,Name="Ajay",Address="Delhi", Marks=90 },


            };

             return View(list);

        }
    }
}
