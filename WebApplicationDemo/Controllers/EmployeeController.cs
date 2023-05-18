using Microsoft.AspNetCore.Mvc;
using WebApplicationDemo.Models;

namespace WebApplicationDemo.Controllers
{
    public class EmployeeController : Controller
    {
       static List<Employee> employees = null;
       void InitializeEmployees()
        {
            employees = new List<Employee>()
            {
new Employee() { Id = 1,Name="Deepak", Dept="HR", Exp=9},
new Employee() { Id = 2,Name="Sagar", Dept="Accts", Exp=5}
            };
           
        }
        public EmployeeController()
        {
            if(employees == null)
            {
               InitializeEmployees();
            }
        }
        public IActionResult Index()
        {
            return View(employees);
            }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee) {
        employees.Add(employee);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
           return View(employees.FirstOrDefault(x => x.Id == id));

        }

        public IActionResult Edit(int? id)
        {
            Employee employee = employees.FirstOrDefault(x => x.Id == id);
            return View(employee);

        }
        [HttpPost]
        public IActionResult Edit(int id, Employee employee)
        { 
            foreach(Employee e in employees)
            {
                if(e.Id== id)
                {
                    e.Dept=employee.Dept;
                }
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            return View(employees.FirstOrDefault(x => x.Id == id));

        }
        [HttpPost]
        public IActionResult Delete(int id, Employee employee)
        {
            foreach (Employee e in employees)
            {
                if (e.Id == id)
                    employee = e;
                    }
            employees.Remove(employee);
            
            return RedirectToAction("Index");
        }
    }
}
