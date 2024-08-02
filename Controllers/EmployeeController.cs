using Microsoft.AspNetCore.Mvc;



namespace DotNetCorePracticeApp.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {

            var myEmployees = new List<Model.Employee>
            {
                new Model.Employee { EmpId = 101, Name = "Daniyal" , Position = "Boss", Salary = 100000},
                new Model.Employee { EmpId = 102, Name = "Shamas" , Position = "Manager", Salary = 10000},
                new Model.Employee { EmpId = 103, Name = "Farzan" , Position = "Tea Boy", Salary = 1000},
                new Model.Employee { EmpId = 104, Name = "Nomi" , Position = "Peon", Salary = 100},
            };

            ViewData["myEmployee"] = myEmployees;

            return View();
        }
    }
}
